using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class HomePageForm : Form
    {
        List<string> listHomePageMenu = new List<string>();
        string HomePageMenu = "";

        // 動畫相關
        int alpha = 0;
        Image originalImage = null;
        Timer fadeTimer = new Timer();

        bool IsGuest => GlobalVar.permission == 0;
        bool IsAdmin => GlobalVar.permission >= 1 && GlobalVar.permission <= 20;
        bool IsMember => GlobalVar.permission >= 21 && GlobalVar.permission <= 30;

        private string CurrentRole
        {
            get
            {
                if (IsGuest) return "訪客";                
                else if (IsAdmin) return "管理者";
                else if (IsMember) return "會員";
                else return "未知的身份";
            }
        }

        public HomePageForm()
        {
            InitializeComponent();
            DoubleBuffered = true; // 防止動畫閃爍
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            // FormLogin myformLogin = new FormLogin();
            // myformLogin.ShowDialog();
            LoadMenuByPermission();
            UpdateLoginUI();
            SetupShopPictureBox();
            StartFadeInAnimation();
        }

        // 當表單關閉，釋放資源
        private void HomePageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fadeTimer.Stop();
            fadeTimer.Dispose();
            if (originalImage != null)
            {
                originalImage.Dispose();
            }
        }

        // 更新登入顯示
        void UpdateLoginUI()
        {
            string roleName = CurrentRole;

            // 根據權限設定顯示的角色名稱
            if (IsGuest)
            {
                lblLogin.Text = $"歡迎 【{roleName}】";
            }
            else
            {
                lblLogin.Text = $"歡迎【{roleName}】\r\n{GlobalVar.UserName}";
            }
        }

        // 根據權限建立選單
        private void LoadMenuByPermission()
        {
            listHomePageMenu.Clear();
            comboBoxMenu.Items.Clear();

            listHomePageMenu.Add("雞蛋糕訂購單");

            // 根據身份追加不同選單功能
            if (IsAdmin)
            {
                listHomePageMenu.Add("會員專區");
                listHomePageMenu.Add("雞蛋糕訂單管理");
            }
            else if (IsMember)
            {
                listHomePageMenu.Add("會員專區");
            }

            // 遍歷選單列表並加入 comboBox
            foreach (string item in listHomePageMenu)
            {
                comboBoxMenu.Items.Add(item);
            }
            // 預設載入
            if (comboBoxMenu.Items.Count > 0)
            {
                comboBoxMenu.SelectedIndex = 0;
                HomePageMenu = comboBoxMenu.SelectedItem.ToString();
            }
        }

        // 載入首頁圖片
        private void SetupShopPictureBox()
        {
            try
            {
                string FullPath = Path.Combine(GlobalVar.imageDir, "Logo2.png");
                pictureBoxShop.SizeMode = PictureBoxSizeMode.Zoom;

                if (File.Exists(FullPath))
                {
                    using (var temp = Image.FromFile(FullPath))
                    {
                        originalImage = (Image)temp.Clone();
                    }

                    // 一開始照片的透明度
                    pictureBoxShop.Image = SetImageOpacity(originalImage, 0);
                }
                else
                {
                    pictureBoxShop.BackColor = Color.Gray;
                    Console.WriteLine("警告：找不到圖檔 " + FullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("圖片載入發生錯誤: " + ex.Message);
            }
        }

        // 動畫開始
        void StartFadeInAnimation()
        {
            this.Enabled = false; // 動畫期間禁止操作

            alpha = 0;
            fadeTimer.Stop();
            fadeTimer.Tick -= fadetimer_Tick;
            fadeTimer.Interval = 30;
            fadeTimer.Tick += fadetimer_Tick;
            fadeTimer.Start();
        }

        // 動畫更新的計時器事件
        private void fadetimer_Tick(object sender, EventArgs e)
        {
            alpha += 5;

            if (alpha >= 255)
            {
                alpha = 255;
                fadeTimer.Stop();
                this.Enabled = true; // 動畫結束後恢復操作
            }

            if (originalImage != null)
            {
                pictureBoxShop.Image.Dispose(); // 釋放舊的圖片資源
            }
            pictureBoxShop.Image = SetImageOpacity(originalImage, alpha); // 更新圖片透明度
        }

        // 透明度方法
        public Image SetImageOpacity(Image image, int alpha)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height); // 建立新的 Bitmap 以套用透明度

            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix(); // 建立顏色矩陣
                matrix.Matrix33 = alpha / 255f; // 設定 alpha 通道的值（0-1）

                ImageAttributes attributes = new ImageAttributes(); // 建立圖像屬性
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap); // 套用顏色矩陣

                // 繪製圖片並套用透明度
                g.DrawImage(image,
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, image.Width, image.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );
            } // 釋放原始圖片資源

            return bmp; // 回傳新的 Bitmap 圖片
        }

        // comboBox 改變時同步更新
        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedItem != null)
            {
                HomePageMenu = comboBoxMenu.SelectedItem.ToString();
            }
        }

        // 按鈕連線到不同的選單功能
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            switch (HomePageMenu)
            {
                case "雞蛋糕訂購單":
                    new Form1().ShowDialog();
                    break;
                case "會員專區":
                    new FormMemberCenter().ShowDialog();
                    break;
                case "雞蛋糕訂單管理":
                    new OrderManagementForm().ShowDialog();
                    break;
                default:
                    MessageBox.Show("請選擇要連線的功能");
                    break;
            }
        }

        // 登出
        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            GlobalVar.isLogin = false;      
            MessageBox.Show(
                "您已登出。",
                "登出提示",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            using (FormLogin formLogin = new FormLogin())
            {
                formLogin.ShowDialog();
            }

            LoadMenuByPermission();
            UpdateLoginUI();
        }
    }
}