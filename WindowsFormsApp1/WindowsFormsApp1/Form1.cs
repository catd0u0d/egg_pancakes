using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        // 建立集合
        List<int> listId = new List<int>();                 // key
        List<string> listEggCakes = new List<string>();     // value
        List<int> listEggCakePrices = new List<int>();      // value
        List<string> listEggCakeNotes = new List<string>(); // value
        List<string> listEggCakeDesc = new List<string>();  // value

        List<string> listSize = new List<string>();  // 份量
        List<int> listSizePrices = new List<int>();  // 份量價格
        List<string> listShape = new List<string>(); // 造型

        int Bags = 0;
        int UnitPrice = 0;          // 雞蛋糕 + 份量
        int UnitTotalPrice = 0;     // 單價 * 包數
        int previousTabIndex = 0;   // 用於記錄上一次選擇的 Tab 索引
        string Form1Size = "";
        string Form1Shape = "";
        string CurrentProduct = ""; // 目前商品分類
        bool isShoppingBag = false; // 不需要購物袋
        bool isToothpick = false;   // 不需要餐具

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDatabase();               // 初始化資料庫連線字串
            SqlConnQuery(CurrentProduct); // 預設載入全部商品
            ListMode();                   // 預設文字列表模式
            PhotoMode();                  // 預設圖片展示模式
            InitialUI();                  // 初始化 UI 元件

            // form 其餘預設值
            comboShape.SelectedIndex = 0;
            Form1Shape = listShape[0];
            comboSize.SelectedIndex = 0;
            Form1Size = listSize[0];

            Bags = 1;
            txtNumberofBags.Text = $"{Bags}";
            UnitTotalPrice = UnitPrice * Bags;
            lblUnitTotal.Text = $"{UnitTotalPrice}";
            lblTotalAmount.Text = $"🛒 0筆";
            txtShopAddress.Text = "高雄市前金區中正四路211號";
                       
            txtPurchaser.Text = GlobalVar.UserName; // 自動帶入會員名稱
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged; // TabControl 的事件處理器
        }

        // 資料存取 SQL
        void InitDatabase()
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "my_Project";
            scsb.IntegratedSecurity = true;

            GlobalVar.DBconnectionString = scsb.ConnectionString.ToString();
        }

        // 讀取商品資料庫
        void SqlConnQuery(string strClass)
        {
            string strSQL = "select * from Products where 1 = 1";
            if (!string.IsNullOrEmpty(strClass))
            {
                strSQL += " and pclass = @pclass"; 
            }

            using (SqlConnection con = new SqlConnection(GlobalVar.DBconnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(strSQL, con))
                {
                    if (!string.IsNullOrEmpty(strClass))
                    {
                        cmd.Parameters.AddWithValue("@pclass", strClass);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            listId.Add((int)reader["id"]);
                            listEggCakes.Add((string)reader["pname"]);
                            listEggCakePrices.Add((int)reader["price"]);
                            listEggCakeNotes.Add((string)reader["pnote"]);
                            listEggCakeDesc.Add((string)reader["pdesc"]);
                            string imageName = (string)reader["pimage"];
                            string FullimageDir = $"{GlobalVar.imageDir}{@"\"}{imageName}";

                            using (FileStream fs = File.OpenRead(FullimageDir))
                            {
                                Image imgProductImage = Image.FromStream(fs);
                                imageListPimage.Images.Add(imgProductImage);
                            } // 離開時自動關閉 fs 會呼叫 Dispose()

                            count++;
                        }
                        Console.WriteLine($"共有 {count} 筆資料");
                    } // 離開時自動 reader.Close()
                } // 離開時自動釋放 Command 資源
            } // 離開時自動釋放 Connection 資源
        }

        // 回到 Form 即時更新購物車內數量
        private void Form1_Activated(object sender, EventArgs e)
        {
            lblTotalAmount.Text = $"🛒 {GlobalVar.listOrderedItems.Count}筆";
        }

        // ===== UI 事件 =====
        private void txtNumberofBags_TextChanged(object sender, EventArgs e)
        {
            // 如果輸入框被清空（例如使用者按 Backspace 刪除重新輸入）我們先不處理
            if (string.IsNullOrEmpty(txtNumberofBags.Text))
                return;
            bool isBagValid = Int32.TryParse(txtNumberofBags.Text, out Bags);

            // 處理不合法的情況
            if (!isBagValid || (Bags <= 0) || (Bags > 20))
            {
                MessageBox.Show(
                    text: "數量輸入錯誤，請重新輸入(1-20)包\n如需大量訂購，請洽詢店員幫您服務。",
                    caption: "輸入提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
                Bags = 1; // 強制改寫為預設值
                txtNumberofBags.Text = $"{Bags}";
            }
            CalculateUnitPrice();
        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            if (Bags < 20) // 最大限制 20 包
            {
                Bags = Bags + 1;
                txtNumberofBags.Text = Bags.ToString();
            }
        }

        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            if (Bags > 1)
            {
                Bags = Bags - 1;
                txtNumberofBags.Text = Bags.ToString();
            }
        }

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1Size = listSize[comboSize.SelectedIndex];
            CalculateUnitPrice();
        }

        private void comboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1Shape = listShape[comboShape.SelectedIndex];
        }

        private void listViewEggCakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateUnitPrice();
        }

        private void txtFlavorSearch_TextChanged(object sender, EventArgs e)
        {
            FilterFlavorShowcase(txtFlavorSearch.Text.Trim());
        }

        private void pictureBoxFlavorSearch_Click(object sender, EventArgs e)
        {
            FilterFlavorShowcase(txtFlavorSearch.Text.Trim());
        }

        private void BtnAddtoCart_Click(object sender, EventArgs e)
        {
            AddtoCart();
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            Checkout();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentTabIndex = tabControl1.SelectedIndex;

            // 以「離開的頁面」為基準來重置對應的 Tab 狀態
            switch (previousTabIndex)
            {
                case 0:
                    ResetListTab();
                    break;
                case 1:
                    ResetPhotoTab();
                    break;
            }

            previousTabIndex = currentTabIndex;
        }

        // ===== 商業邏輯 =====
        // 單價
        private void CalculateUnitPrice()
        {
            // 確保下拉式選單 ComboBox 有選取項目
            if (comboSize.SelectedIndex < 0)
                return; 
            // 檢查 ListView 是否有選取的項目
            if (listViewEggCakes.SelectedIndices.Count > 0)
            {
                int Index = listViewEggCakes.SelectedIndices[0];
                // 計算單價：對應的雞蛋糕價格 + 選擇的份量價格
                UnitPrice = listEggCakePrices[Index] + listSizePrices[comboSize.SelectedIndex];
            }
            else
            {
                UnitPrice = 0; // 尚未選擇任何雞蛋糕預設為 0
            }
            lblUnitPrice.Text = $"{UnitPrice}";
            CalculateUnitTotal();
        }

        // 單品總價
        private void CalculateUnitTotal()
        {
            UnitTotalPrice = UnitPrice * Bags;
            lblUnitTotal.Text = $"{UnitTotalPrice}";
        }

        // 加入購物車
        private void AddtoCart()
        {
            if (listViewEggCakes.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    text: "請先選擇商品",
                    caption: "提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning
                );
                return;
            }
            int Index = listViewEggCakes.SelectedIndices[0]; // 取得選取的商品索引

            ArrayList order = new ArrayList 
            {
                listId[Index],       // 商品 id
                listEggCakes[Index], // 商品名稱
                Form1Size,           // 份量
                Form1Shape,          // 造型
                Bags,                // 數量幾包
                UnitPrice,           // 單價
                UnitTotalPrice       // 單品總價
            };

            GlobalVar.listOrderedItems.Add(order);
            MessageBox.Show(
                text: "已成功加入購物車",
                caption: "提示",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information
            );
            lblTotalAmount.Text = $"🛒 {GlobalVar.listOrderedItems.Count}筆";
        }

        // 結帳並帶入訂購資訊到購物車頁面
        private void Checkout()
        {
            if (GlobalVar.listOrderedItems.Count == 0)
            {
                MessageBox.Show(
                    text: "購物車內沒有商品，請先加入商品",
                    caption: "提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning
                ); 
                return;
            }
            GlobalVar.OrdererInfo = txtPurchaser.Text.Trim();
            GlobalVar.OrdererPhone = txtPurchaserPhone.Text.Trim();
            GlobalVar.OrdererNote = txtNote.Text.Trim();
            GlobalVar.isShoppingBag = isShoppingBag; 
            GlobalVar.isToothpick = isToothpick;     

            FromShoppingCart myShoppingCart = new FromShoppingCart();
            myShoppingCart.ShowDialog();
        }

        // 文字列表模式
        void ListMode()
        {
            listViewEggCakes.Clear();
            listViewEggCakes.LargeImageList = null;
            listViewEggCakes.SmallImageList = null;
            listViewEggCakes.View = View.Details;
            listViewEggCakes.Columns.Add("商品id", 90);
            listViewEggCakes.Columns.Add("商品名稱", 240);
            listViewEggCakes.Columns.Add("價格", 75);
            listViewEggCakes.Columns.Add("備註", 250);
            listViewEggCakes.GridLines = true;
            listViewEggCakes.FullRowSelect = true;

            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = listId[i].ToString();
                item.SubItems.Add(listEggCakes[i]);
                item.SubItems.Add(listEggCakePrices[i].ToString());
                item.SubItems.Add(listEggCakeNotes[i]);
                item.Tag = listId[i];
                item.Font = new Font("微軟正黑體", 18, FontStyle.Regular);
                item.ForeColor = Color.FromArgb(0, 110, 144);
                listViewEggCakes.Items.Add(item);
            }
        }

        // 圖片模式
        void PhotoMode()
        {
            listViewProductShowcase.Clear();
            listViewProductShowcase.View = View.LargeIcon;
            imageListPimage.ImageSize = new Size(250, 220);
            listViewProductShowcase.LargeImageList = imageListPimage;

            for (int i = 0; i < listId.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i; // 索引值對應到 imageList 圖檔
                item.Text = $"{listEggCakes[i]} {listEggCakePrices[i]}元";
                item.Font = new Font("微軟正黑體", 20, FontStyle.Bold);
                item.ForeColor = Color.FromArgb(0, 110, 144);
                item.Tag = listId[i];
                listViewProductShowcase.Items.Add(item);
            }
        }

        // 文字列表頁 Reset
        void ResetListTab()
        {
            listViewEggCakes.SelectedItems.Clear(); // 取消選取任何商品
            Bags = 1;
            txtNumberofBags.Text = $"{Bags}";
            UnitPrice = 0;
            UnitTotalPrice = 0;
            lblUnitPrice.Text = "0 元";
            lblUnitTotal.Text = "0 元";

            comboSize.SelectedIndex = 0;
            comboShape.SelectedIndex = 0;
        }

        // 圖片瀏覽頁 Reset
        void ResetPhotoTab()
        {
            txtFlavorSearch.Text = "口味搜尋...";
            FilterFlavorShowcase(""); // 清空搜尋條件以重置展示
            txtFlavorDescription.Text = "請點選上方商品圖片，以查看詳細口味描述喔。";
            listViewProductShowcase.SelectedItems.Clear(); // 取消選取任何商品
        }

        private void txtNumberofBags_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumberofBags.Text))
            {
                MessageBox.Show(
                    text: "請先填寫完成數量",
                    caption: "提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning
                );
                Bags = 1; // 防呆機制:預設數量 1
                txtNumberofBags.Text = $"{Bags}";
                txtNumberofBags.Focus(); // 游標拉回文字方塊
            }
        }

        private void pictureBoxOrderingInfo_Click(object sender, EventArgs e)
        {
            OrderingInfo MyOderInfo = new OrderingInfo();
            MyOderInfo.ShowDialog();
        }

        // 是否需要購物袋
        private void chkShoppingBag_CheckedChanged(object sender, EventArgs e)
        {
            isShoppingBag = chkShoppingBag.Checked;
        }

        // 是否需要餐具
        private void chkToothpick_CheckedChanged(object sender, EventArgs e)
        {
            isToothpick = chkToothpick.Checked;
        }

        // 重新載入資料庫資料
        void RefreshProducts()
        {
            listId.Clear();
            listEggCakes.Clear();
            listEggCakePrices.Clear();
            listEggCakeNotes.Clear();     
            listEggCakeDesc.Clear();
            // 修正在 Clear 之前先明確 Dispose 每一張圖片
            foreach (Image img in imageListPimage.Images)
            {
                img.Dispose();
            }
            imageListPimage.Images.Clear();
            SqlConnQuery(CurrentProduct);
            PhotoMode();
        }

        // 處理口味描述:
        private void listViewProductShowcase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProductShowcase.SelectedIndices.Count > 0)
            {
                // 從 Tag 取得原始商品 id，再找回對應的 List 索引
                int originalId = (int)listViewProductShowcase.SelectedItems[0].Tag;
                int originalIndex = listId.IndexOf(originalId);

                string ProductName = listEggCakes[originalIndex];
                string ProductDesc = listEggCakeDesc[originalIndex];
                txtFlavorDescription.Text = $"【 {ProductName} 】\r\n{ProductDesc}";
            }
            else
            {
                txtFlavorDescription.Text = "請點選上方商品圖片，以查看詳細口味描述喔。";
            }
        }

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            CurrentProduct = "";
            RefreshProducts();
            txtFlavorDescription.Text = "請點選上方商品圖片，以查看詳細口味描述喔。";
        }

        private void BtnSpecific_Click(object sender, EventArgs e)
        {
            CurrentProduct = "special";
            RefreshProducts();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 新增商品圖片點擊事件，並且快速下單
        private void listViewProductShowcase_ItemActivate(object sender, EventArgs e)
        {
            if (listViewProductShowcase.SelectedItems.Count == 0)
                return;

            // 點擊時取得選取項目
            ListViewItem selectedItem = listViewProductShowcase.SelectedItems[0];
            // 從 Tag 找回原始商品 id
            int originalId = (int)selectedItem.Tag;
            int originalIndex = listId.IndexOf(originalId);

            string ProductName = listEggCakes[originalIndex];
            // 快速下單邏輯：選取商品、預設小份、預設標準造型、數量 1 包，然後直接加入購物車
            string size = "小份 4入";
            string shape = "標準";
            int bags = 1;
            int price = listEggCakePrices[originalIndex];
            int UnitTotalPrice = price * bags;

            // 提示訊息
            DialogResult result = MessageBox.Show(
                text: $"您選擇了【{ProductName}】\r\n是否幫您快速添加{bags}包到購物車中？\n預設選項：份量{size}、造型{shape}",
                caption: "快速下單",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                ArrayList order = new ArrayList
                {
                    listId[originalIndex],
                    ProductName,
                    size,
                    shape,
                    bags,
                    price,
                    UnitTotalPrice
                };

                GlobalVar.listOrderedItems.Add(order);
                lblTotalAmount.Text = $"🛒 {GlobalVar.listOrderedItems.Count}筆";
                MessageBox.Show(
                    text: "已快速加入1包至購物車",
                    caption: "成功提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information
                );
            }
        }

        // 初始化 UI 元件
        void InitialUI()
        {
            listSize.Add("小份 4入");
            listSize.Add("大份 9入");

            listSizePrices.Add(0);
            listSizePrices.Add(60);

            listShape.Add("標準");
            listShape.Add("星型");
            listShape.Add("愛心");

            foreach (var size in listSize)
            {
                comboSize.Items.Add(size);
            }
            foreach (var shape in listShape)
            {
                comboShape.Items.Add(shape);
            }

            comboSize.SelectedIndex = 0;
            comboShape.SelectedIndex = 0;
            Bags = 1;
            txtNumberofBags.Text = "1";
        }

        // 口味搜尋方法
        private void FilterFlavorShowcase(string keyword)
        {
            listViewProductShowcase.Items.Clear(); // 先清空現有的展示項目

            for (int i = 0; i < listEggCakes.Count; i++)
            {
                bool isMatch = string.IsNullOrWhiteSpace(keyword) || listEggCakes[i].Contains(keyword) || listEggCakeNotes[i].Contains(keyword);

                if (isMatch)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i; // 索引值對應到 imageList 圖檔
                    item.Text = $"{listEggCakes[i]} {listEggCakePrices[i]}元";
                    item.Font = new Font("微軟正黑體", 20, FontStyle.Bold);
                    item.ForeColor = Color.FromArgb(0, 110, 144);
                    item.Tag = listId[i];
                    listViewProductShowcase.Items.Add(item);
                }
            }
            // 如果沒有符合搜尋條件的商品，顯示提示訊息
            if (listViewProductShowcase.Items.Count == 0)
            {
                txtFlavorDescription.Text = $"沒找到符合 {keyword} 的商品喔！";
            }
            else
            {
                txtFlavorDescription.Text = "請點選上方商品圖片，以查看詳細口味描述喔。";
            }
        }
    }
}