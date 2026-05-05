using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // 登入方法
        void SetLoginUser(string name, string email, int permission)
        {
            GlobalVar.isLogin = true;
            GlobalVar.UserName = name;
            GlobalVar.UserEmail = email;
            GlobalVar.permission = permission;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "my_Project";
            scsb.IntegratedSecurity = true;
            GlobalVar.DBconnectionString = scsb.ConnectionString.ToString();
            txtPassword.UseSystemPasswordChar = true; // 密碼預設隱藏
        }

        // 訪客登入
        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            GuestLogin();
        }

        // 一般會員和管理者登入
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MemberLogin();
        }

        private void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pictureBoxRegister_Click(object sender, EventArgs e)
        {
            using (FormSignUp formRegister = new FormSignUp())
            {
                formRegister.ShowDialog(); 
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVar.isLogin == false)
            {
                e.Cancel = true; // 取消關閉的事件
            }
        }

        // 訪客登入邏輯
        void GuestLogin()
        {
            SetLoginUser("訪客", "", 0);
            MessageBox.Show(
                text: "您以訪客身分登入",
                caption: "訪客登入",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information
            );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // 一般會員/管理者登入邏輯
        void MemberLogin()
        {
            string strLoginField1 = txtEmail.Text.Trim();
            string strLoginField2 = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(strLoginField1) || string.IsNullOrEmpty(strLoginField2))
            {
                MessageBox.Show(
                    text: "登入時所有欄位為必填",
                    caption: "登入提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information
                );
                return;
            }
            using (SqlConnection con = new SqlConnection(GlobalVar.DBconnectionString))
            {
                con.Open();

                string strSQL = "select TOP(1) * from Members " +
                    "where email = @SearchEmail and " +
                    "password COLLATE Latin1_General_CS_AS = @Password;";

                using (SqlCommand cmd = new SqlCommand(strSQL, con))
                {
                    cmd.Parameters.AddWithValue("@SearchEmail", strLoginField1);
                    cmd.Parameters.AddWithValue("@Password", strLoginField2);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            SetLoginUser(
                                reader["name"].ToString(),
                                reader["email"].ToString(),
                                (int)reader["permissions"]
                            );

                            MessageBox.Show(
                                text: $"親愛的 {GlobalVar.UserName} 您好，已登入成功。",
                                caption: "登入提示",
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Information
                            );

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                text: "電子郵件或密碼錯誤，請再次確認或用訪客身分繼續",
                                caption: "登入失敗",
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
        }
    }
}