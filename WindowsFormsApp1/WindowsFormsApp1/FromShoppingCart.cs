using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FromShoppingCart : Form
    {
        public FromShoppingCart()
        {
            InitializeComponent();
        }

        private void FromShoppingCart_Load(object sender, EventArgs e)
        {
            lblOrdererInfo.Text = $"訂購人:{GlobalVar.OrdererInfo}  電話:{GlobalVar.OrdererPhone}\n備註:{GlobalVar.OrdererNote}";
            InitShoppingCartListView();
        }

        // 設定 ListView 與載入資料
        private void InitShoppingCartListView()
        {
            listViewOrderedItems.Clear();
            listViewOrderedItems.View = View.Details; // 顯示為詳細表格模式
            listViewOrderedItems.FullRowSelect = true; // 點擊時反白
            listViewOrderedItems.GridLines = true; // 顯示格線
            listViewOrderedItems.Font = new Font("微軟正黑體", 18, FontStyle.Regular);
            listViewOrderedItems.Columns.Add("商品明細", 450);
            listViewOrderedItems.Columns.Add("單價", 100);
            listViewOrderedItems.Columns.Add("數量", 80);
            listViewOrderedItems.Columns.Add("總額", 120);

            // 讀取全域變數
            foreach (ArrayList ProductInfo in GlobalVar.listOrderedItems)
            {
                int ProductId = (int)ProductInfo[0];         // id
                string ProductName = (string)ProductInfo[1]; // 商品名稱
                string Form1Size = (string)ProductInfo[2];   // 份量
                string Form1Shape = (string)ProductInfo[3];  // 造型
                int Bags = (int)ProductInfo[4];              // 數量
                int UnitPrice = (int)ProductInfo[5];         // 單價
                int UnitTotal = (int)ProductInfo[6];         // 單品總價

                ListViewItem item = 
                    new ListViewItem($"{ProductName} {Form1Shape} 雞蛋糕  {Form1Size}"); // 第一欄主項目
                item.SubItems.Add($"{UnitPrice}元");                                    // 第二欄單價
                item.SubItems.Add($"{Bags}包");                                         // 第三欄數量

                // 將總額上色
                ListViewItem.ListViewSubItem totalSubItem = new ListViewItem.ListViewSubItem(item, $"{UnitTotal}元");
                totalSubItem.ForeColor = Color.FromArgb(224, 114, 164);
                totalSubItem.Font = new Font("微軟正黑體", 18, FontStyle.Bold);
                item.SubItems.Add(totalSubItem); // 第四欄總額
                item.UseItemStyleForSubItems = false; // false 自訂顏色與字體才能生效
                listViewOrderedItems.Items.Add(item);
            }
            OrderTotal();
        }

        // 購物車總額
        void OrderTotal()
        {
            int OrderTotal = 0;
            foreach (ArrayList Order in GlobalVar.listOrderedItems)
            {
                int UnitTotal = (int) Order[6];
                OrderTotal += UnitTotal;
            }

            if ((GlobalVar.isShoppingBag) && (GlobalVar.listOrderedItems.Count > 0))
            {
                OrderTotal += 3;
                lblShoppingBag.Visible = true;
            }
            else
            {
                lblShoppingBag.Visible = false;
            }
            if ( (GlobalVar.isToothpick) && (GlobalVar.listOrderedItems.Count > 0) )
            {
                lblToothpick.Visible = true;
            }
            else
            {
                lblToothpick.Visible = false;
            }
            lblTotal.Text = $"訂單總價: {OrderTotal} 元";
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listViewOrderedItems.SelectedIndices.Count > 0)
            {
                int delIdx = listViewOrderedItems.SelectedIndices[0]; // 取得目前項目的索引
                GlobalVar.listOrderedItems.RemoveAt(delIdx);
                InitShoppingCartListView(); // 重新呼叫初始化方法 UI 根據最新的 List 重新繪製
                OrderTotal();

                MessageBox.Show(
                    text: "已成功移除該口味雞蛋糕",
                    caption: "移除提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    text: "請先從清單中選擇您要移除的品項",
                    caption: "錯誤提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            if (listViewOrderedItems.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    text: "確定要清空購物車內所有商品嗎?",
                    caption: "清空確認",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    GlobalVar.listOrderedItems.Clear();
                    listViewOrderedItems.Items.Clear();
                    lblOrdererInfo.Text = "";
                    lblShoppingBag.Visible = false;
                    lblToothpick.Visible = false;
                    OrderTotal();

                    MessageBox.Show(
                        text: "購物車已清空",
                        caption: "提示",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    text: "購物車內目前已無任何商品",
                    caption: "錯誤提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
        }

        // 純文字收據
        private void BtnPrintOrder_Click(object sender, EventArgs e)
        {
            string strDefaultURL = @"C:\Users\iSpan\Desktop\deng_work\個人專題\素材\txt"; // txt 存檔目錄

            Random MyRnd = new Random();
            int numRnd = MyRnd.Next(1000, 10000); // 隨機4位數
            string strFileName = $"{DateTime.Now.ToString("yyyyMMdd")}{numRnd.ToString()}{"訂購單.txt"}";
            string strFullFileRoad = $"{strDefaultURL}\\{strFileName}";
            Console.WriteLine(strFullFileRoad);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = strDefaultURL;
            sfd.FileName = strFileName;
            sfd.Filter = "文字檔|*.txt"; // 限制只存.txt 檔案
            DialogResult result = sfd.ShowDialog();

            // 另存新檔視窗
            if (result == DialogResult.OK)
            {
                strFullFileRoad = sfd.FileName;
                Console.WriteLine(strFullFileRoad);
            }
            else
            {
                return;
            }

            List<string> listOrderDetails = new List<string>();
            listOrderDetails.Add("************** 危機就是轉雞蛋糕 訂購單 **************");
            listOrderDetails.Add($"訂單編號: {GlobalVar.OrderCounter.ToString()}");
            listOrderDetails.Add($"訂購時間: {DateTime.Now}");
            listOrderDetails.Add($"訂購人: {GlobalVar.OrdererInfo}");
            listOrderDetails.Add($"電話: {GlobalVar.OrdererPhone}");
            listOrderDetails.Add($"備註: {GlobalVar.OrdererNote}");
            listOrderDetails.Add($"-------------------------------------------------");
            foreach (ArrayList ProductInfo in GlobalVar.listOrderedItems)
            {
                int ProductId = (int)ProductInfo[0]; // id（若不需要可略過）
                string ProductName = (string)ProductInfo[1]; // 商品名稱
                string Form1Size = (string)ProductInfo[2]; // 份量
                string Form1Shape = (string)ProductInfo[3]; // 造型
                int Bags = (int)ProductInfo[4]; // 數量
                int UnitPrice = (int)ProductInfo[5]; // 單價
                int UnitTotal = (int)ProductInfo[6]; // 單品總價
                string Orderline = $"商品明細: {ProductName}    ({Form1Shape}{Form1Size})";
                string Priceline = $"   單價: {UnitPrice}元 x {Bags}包 = {UnitTotal}元";
                listOrderDetails.Add(Orderline);
                listOrderDetails.Add(Priceline);
            }
            if (GlobalVar.isShoppingBag == true)
            {
                listOrderDetails.Add($"{lblShoppingBag.Text}");
            }
            if (GlobalVar.isToothpick == true)
            {
                listOrderDetails.Add($"{lblToothpick.Text}");
            }
            listOrderDetails.Add($"-------------------------------------------------");
            listOrderDetails.Add($"訂單總金額: {lblTotal.Text}");
            listOrderDetails.Add("");
            listOrderDetails.Add("******************  謝謝您的惠顧  ******************");
            try
            {
                File.WriteAllLines(strFullFileRoad, listOrderDetails, Encoding.UTF8);
                MessageBox.Show(
                    text: $"訂購單儲存成功！",
                    caption: "列印提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information
                );
                GlobalVar.OrderCounter += 1; // 若成功存檔 訂單編號 +1
            }
            catch (Exception ex) 
            {
                MessageBox.Show(
                    text: $"存檔時發生錯誤: {ex.Message}",
                    caption: "錯誤",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error                    
                );
            }
        }

        private void BtnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            // 檢查購物車是否有東西
            if (GlobalVar.listOrderedItems.Count == 0)
            {
                MessageBox.Show(
                    "購物車內無商品，無法結帳。",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            int currentOrderCount = GlobalVar.OrderCounter;
            
            BtnPrintOrder_Click(sender, e); // 呼叫文字收據

            // 判斷存檔成功
            if (GlobalVar.OrderCounter == currentOrderCount)
            {
                MessageBox.Show(
                    "偵測到未完成收據存檔，結帳程序已暫停。\n若不需收據請直接點選結帳或手動關閉。",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
                       
            string finalPriceText = lblTotal.Text; // 取得最終結帳總額

            // 跳出成功視窗
            string strMsg = $"感謝您的訂購！\n\n訂購人：{GlobalVar.OrdererInfo}\n結帳總金額：{finalPriceText}";
            MessageBox.Show(
                text: strMsg,
                caption: "結帳成功",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information
            );

            GlobalVar.listOrderedItems.Clear(); // 清空全域資料                      
            this.Close(); // 關閉目前的購物車視窗 回訂購單主選單
        }
    }
}