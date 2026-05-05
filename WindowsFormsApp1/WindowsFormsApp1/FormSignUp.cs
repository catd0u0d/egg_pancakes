using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormSignUp : Form
    {
        private HashSet<string> _blacklist = new HashSet<string>();

        public FormSignUp()
        {
            InitializeComponent();
            LoadBlacklist();
            UpdateRegisterButtonState(); // 初始狀態下註冊按鈕不可用
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        // 載入黑名單檔案
        private void LoadBlacklist()
        {
            try
            {
                string path = "blacklist.txt"; // 指向執行檔目錄下的檔案
                if (File.Exists(path))
                {
                    // 讀取所有行，轉小寫並去除空白後存入清單
                    var lines = File.ReadAllLines(path);
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line)) // 忽略空白行
                            _blacklist.Add(line.Trim().ToLower());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取黑名單檔案失敗: " + ex.Message);
            }
        }

        // 即時更新檢查
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            UpdateRegisterButtonState();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string currentPassword = txtPassword.Text;

            UpdateRegisterButtonState();
            CheckPasswordStrength(currentPassword);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateRegisterButtonState();
        }

        // 密碼顯示/隱藏功能
        private void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        // 開啟隱私權政策
        private void pictureBoxPrivacyPolicy_Click(object sender, EventArgs e)
        {
            PrivacyPolicy MyPolicyInfo = new PrivacyPolicy();
            MyPolicyInfo.ShowDialog();
        }
        // 註冊按鈕事件
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        // 註冊邏輯
        private void Register()
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string name = txtName.Text.Trim();

            // 1.基本檢查
            if (email == "" || password == "" || name == "")
            {
                MessageBox.Show(
                    "所有欄位皆為必填",
                    "填寫提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show(
                    "Email 格式不正確",
                    "填寫提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (!IsValidPassword(password))
            {
                MessageBox.Show(
                    "密碼格式不正確，特殊字元只能\r\n包含 @ # $ _ & - + : ! ?",
                    "填寫提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2.整合強度評估與警告邏輯
            int types = 0;
            if (Regex.IsMatch(password, "[a-z]")) types++;
            if (Regex.IsMatch(password, "[A-Z]")) types++;
            if (Regex.IsMatch(password, "[0-9]")) types++;
            if (Regex.IsMatch(password, @"[@#$_&\-\+:!?]")) types++;

            string hitWord = GetHitBlacklistWord(password);
            // 觸發條件：命中黑名單，或字元種類少於 2 種 (例如全數字 12348765)
            if (hitWord != null || types < 2)
            {
                // 根據不同情況給予更精準的提示文字
                string warningReason;
                if (hitWord != null)
                {
                    warningReason = $"常見或連續字元 ({hitWord})";
                }
                else
                {
                    warningReason = "字元種類過少";
                }
                // 第一層警告
                DialogResult firstRes = MessageBox.Show(
                    $"偵測到{warningReason}，建議使用更高強度密碼，不然將為您存入弱密碼。\n\n是否重新輸入？",
                    "安全性建議",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (firstRes == DialogResult.Yes)
                    return;
                // 第二層警告
                DialogResult secondRes = MessageBox.Show(
                    "再次按下「否」確定為您存入弱密碼？",
                    "最終確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error
                );

                if (secondRes == DialogResult.Yes)
                    return;
            }
            // 3.存入資料庫
            SaveMemberData(name, email, password);
        }

        // 儲存資料庫邏輯
        private void SaveMemberData(string name, string email, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.DBconnectionString))
                {
                    con.Open();
                    // 檢查重複
                    string checkSQL = "SELECT COUNT(*) FROM Members WHERE email = @Email";
                    using (SqlCommand cmdCheck = new SqlCommand(checkSQL, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@Email", email);
                        if ((int)cmdCheck.ExecuteScalar() > 0) // 如果回傳的數字大於0，表示已存在
                        {
                            MessageBox.Show(
                                "此 Email 已被註冊，若您忘記密碼，請使用忘記密碼功能。",
                                "註冊提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    // 執行新增
                    string insertSQL =
                        "INSERT INTO Members (name, email, password, permissions, phone, address) " +
                        "VALUES (@Name, @Email, @Password, 30, '0', '0')";
                    using (SqlCommand cmd = new SqlCommand(insertSQL, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show(
                        $"親愛的 {name} 註冊成功\r\n可以登入了！",
                        "註冊提示", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                    );
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫存取錯誤: " + ex.Message);
            }
        }

        // 檢查email格式
        bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // 符合的例子: example@example.com 在@前後都不能有空白且必須有一個點
            return Regex.IsMatch(email, pattern); // email格式檢查
        }

        // 檢查密碼使用的範圍 (數字、英文大小寫、特定符號字元)
        bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^[a-zA-Z0-9@#$_&\-\+:!?]+$"); // 允許的符號字元為 @#$_&-+:!?
        }

        // 檢查是否命中黑名單並回傳該字眼
        private string GetHitBlacklistWord(string password)
        {
            string lower = password.ToLower();
            return _blacklist.FirstOrDefault(word => lower.Contains(word));
        }

        // 三個欄位都有值才啟用註冊按鈕
        private void UpdateRegisterButtonState()
        {
            BtnRegister.Enabled =
                !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                !string.IsNullOrWhiteSpace(txtName.Text);
        }

        // 根據密碼強度更新 UI
        private void CheckPasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                SetStrength(0, "None", Color.Gray);
                return;
            }
            // 如果包含黑名單，強度直接顯示 Weak
            if (GetHitBlacklistWord(password) != null)
            {
                SetStrength(20, "Weak", Color.Red);
                return;
            }

            int types = 0;

            if (Regex.IsMatch(password, "[a-z]")) types++;
            if (Regex.IsMatch(password, "[A-Z]")) types++;
            if (Regex.IsMatch(password, "[0-9]")) types++;
            if (Regex.IsMatch(password, @"[@#$_&\-\+:!?]")) types++;

            if (types == 4 && password.Length >= 10)
                SetStrength(100, "Strong", Color.Green);
            else if (types >= 2 && password.Length >= 6)
                SetStrength(60, "Medium", Color.Orange);
            else
                SetStrength(25, "Weak", Color.Red);
        }

        // UI 的細節更新方法，根據密碼強度調整進度條和標籤
        private void SetStrength(int value, string text, Color color)
        {
            progressBarPasswordStrength.Value = value; // 1. 更新進度條長度         
            lblPasswordStrength.Text = text;           // 2. 更新標籤文字            
            lblPasswordStrength.ForeColor = color;     // 3. 更新標籤文字顏色
        }
    }
}