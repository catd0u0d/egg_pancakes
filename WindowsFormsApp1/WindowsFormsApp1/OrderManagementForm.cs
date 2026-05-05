using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class OrderManagementForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string DBConnString = "";
        List<int> SearchID = new List<int>(); // 搜尋結果找尋訂單編號
        int intOrderdetailStatus = 0; // 0全部 1已出貨 2待出貨 3審核中 4已取消
        int DGVorderRecords = 0; // 訂單資料筆數

        private const int ORDER_LOAD_MIN = 51;
        private const int ORDER_LOAD_MAX = 150;

        // 集中管理 Status 對應 RadioButton 的 Dictionary
        private Dictionary<string, RadioButton> GetStatusRadioMap() => new Dictionary<string, RadioButton>()
        {
            { "已出貨", radioDone },
            { "待出貨", radioWait },
            { "審核中", radioCheck },
            { "已取消", radioCancel }
        };

        // RadioButton 取得目前選取的狀態文字
        private string GetSelectedStatus()
        {
            if (radioDone.Checked) return "已出貨";
            if (radioWait.Checked) return "待出貨";
            if (radioCheck.Checked) return "審核中";
            if (radioCancel.Checked) return "已取消";
            return "";
        }

        // 將狀態文字對應到 RadioButton
        private void SetStatusRadio(string status)
        {
            radioDone.Checked = false;
            radioWait.Checked = false;
            radioCheck.Checked = false;
            radioCancel.Checked = false;

            var statusMap = GetStatusRadioMap();
            if (statusMap.ContainsKey(status))
            {
                statusMap[status].Checked = true;
            }
            else
            {
                MessageBox.Show("未知的訂單狀態");
            }
        }

        public OrderManagementForm()
        {
            InitializeComponent();
        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            // 資料庫連線
            scsb.DataSource = @".";
            scsb.InitialCatalog = "my_Project";
            scsb.IntegratedSecurity = true;
            DBConnString = scsb.ConnectionString.ToString();
            // UI 預設值
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtOrderInfo.Text = "";
            txtTotal.Text = "";
            txtNote.Text = "";
            DTPOrder.Value = DateTime.Now;

            comboSearchbyKeyword.Items.Add("訂購姓名");
            comboSearchbyKeyword.Items.Add("訂單電話");
            comboSearchbyKeyword.SelectedIndex = 0;
            radioDone.Checked = false;
            radioWait.Checked = false;
            radioCheck.Checked = false;
            radioCancel.Checked = false;
            radioAllStatus.Checked = true;
            radioDone2.Checked = false;
            radioWait2.Checked = false;
            radioCheck2.Checked = false;
            radioCancel2.Checked = false;
            intOrderdetailStatus = 0;

            LoadDraftIfExists();
        }

        // 載入草稿的方法
        private void LoadDraftIfExists()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DBConnString))
                {
                    con.Open();
                    string strSQL = "select TOP(1) * from temp_orders;";
                    using (SqlCommand cmd = new SqlCommand(strSQL, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 先詢問使用者是否要載入草稿
                            DialogResult result = MessageBox.Show(
                                text: "偵測到上次未完成的草稿，是否要載入？",
                                caption: "草稿提示",
                                buttons: MessageBoxButtons.YesNo,
                                icon: MessageBoxIcon.Question
                            );

                            if (result == DialogResult.No)
                                return; // 使用者選擇不載入 → 維持空白預設值

                            if (reader["purchaser"] != DBNull.Value) // 姓名
                            {
                                txtName.Text = reader["purchaser"].ToString();
                            }
                            if (reader["phone"] != DBNull.Value) // 電話
                            {
                                txtPhone.Text = reader["phone"].ToString();
                            }
                            if (reader["orderinfo"] != DBNull.Value) // 訂單資訊
                            {
                                txtOrderInfo.Text = reader["orderinfo"].ToString();
                            }
                            if (reader["orderdate"] != DBNull.Value) // 訂購時間
                            {
                                DTPOrder.Value = (DateTime)reader["orderdate"];
                            }
                            if (reader["total"] != DBNull.Value) // 訂單總價
                            {
                                txtTotal.Text = reader["total"].ToString();
                            }
                            if (reader["note"] != DBNull.Value) // 備註
                            {
                                txtNote.Text = reader["note"].ToString();
                            }
                            if (reader["status"] != DBNull.Value) // 訂單狀態
                            {
                                string status = reader["status"].ToString();
                                if (status != "")
                                {
                                    SetStatusRadio(status);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"草稿讀取失敗: {ex.Message}");
            }
        }

        // 連線測試
        private void BtnConTest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DBConnString);
            con.Open();
            string strSQL = "select TOP(5) * from OrderDetails;"; // 指定 5 筆資料先測試
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader(); // SQL 資料讀取器

            string strMessage = "";
            int count = 0;

            while (reader.Read())
            {
                // 取得資料
                int id = (int)reader["order_id"];
                string name = (string)reader["purchaser"];
                string phone = (string)reader["phone"];
                string information = (string)reader["orderinfo"];
                DateTime date = (DateTime)reader["orderdate"];
                int totalamount = (int)reader["total"];
                string orderstatus = (string)reader["status"];
                string ordernote = (string)reader["note"];
                strMessage += $"\n{id} {name} {phone}\n商品明細:{information}\n{date:yyyy/MM/dd} 總額:{totalamount} 狀態:{orderstatus} 備註:{ordernote}";
                count++;
            }
            strMessage += "\n*********************************************\n";
            strMessage += $"測試用資料筆數: {count}";
            reader.Close();
            con.Close();
            MessageBox.Show(strMessage);
        }

        // 訂單修改
        private void BtnDataMod_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPhone.Text != "") && (txtTotal.Text != "") && (txtOrderInfo.Text != "") && (txtNote.Text != ""))
            {
                // 避免訂單總價格式錯誤
                if (!int.TryParse(txtTotal.Text, out int total))
                {
                    MessageBox.Show("金額格式錯誤");
                    return;
                }

                int intID = 0;
                Int32.TryParse(txtID.Text, out intID);
                if (intID > 0)
                {
                    // 取得狀態
                    string status = GetSelectedStatus();

                    SqlConnection con = new SqlConnection(DBConnString);
                    con.Open();
                    string strSQL =
                        "UPdate OrderDetails\r\n" +
                        "Set purchaser = @NewName,\r\n" +
                        "phone = @NewPhone,\r\n" +
                        "orderinfo = @NewOrderinfo,\r\n" +
                        "orderdate = @NewOrderdate,\r\n" +
                        "total = @NewTotal,\r\n" +
                        "status = @NewStatus,\r\n" +
                        "note = @NewNote\r\n" +
                        "where order_id = @SearchID;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    cmd.Parameters.AddWithValue("@NewName", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@NewOrderinfo", txtOrderInfo.Text.Trim());
                    cmd.Parameters.AddWithValue("@NewOrderdate", DTPOrder.Value);
                    cmd.Parameters.Add("@NewTotal", SqlDbType.Int).Value = int.Parse(txtTotal.Text); // 因為 Total 是 int
                    cmd.Parameters.AddWithValue("@NewNote", txtNote.Text.Trim());
                    cmd.Parameters.AddWithValue("@NewStatus", status);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(
                        text: $"訂單修改成功\n {rows}筆資料受影響",
                        caption: "修改提示",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    text: "訂單欄位必須填寫完整",
                    caption: "修改提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
        }

        // 訂單新增
        private void BtnDataAdded_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPhone.Text != "") && (txtTotal.Text != "") && (txtOrderInfo.Text != "") && (txtNote.Text != ""))
            {
                // 避免訂單總價格式錯誤
                if (!int.TryParse(txtTotal.Text, out int total))
                {
                    MessageBox.Show("金額格式錯誤");
                    return;
                }

                // 取得狀態
                string status = GetSelectedStatus();

                SqlConnection con = new SqlConnection(DBConnString);
                con.Open();
                string strSQL = "insert into OrderDetails\r\n" +
                    "(purchaser, phone, orderinfo, orderdate, total, status, note)\r\n" +
                    "values (@NewName, @NewPhone, @NewOrderinfo, @NewOrderdate, @NewTotal, @NewStatus, @NewNote);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@NewOrderinfo", txtOrderInfo.Text.Trim());
                cmd.Parameters.AddWithValue("@NewOrderdate", DTPOrder.Value);
                cmd.Parameters.Add("@NewTotal", SqlDbType.Int).Value = int.Parse(txtTotal.Text);
                cmd.Parameters.AddWithValue("@NewStatus", status);
                cmd.Parameters.AddWithValue("@NewNote", txtNote.Text.Trim());
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) // 如果新增資料成功清空草稿
                {
                    string clearDraftSQL = "DELETE FROM temp_orders;";
                    SqlCommand clearcmd = new SqlCommand(clearDraftSQL, con);
                    clearcmd.ExecuteNonQuery();

                    MessageBox.Show(
                        text: $"訂單新增成功\n {rows}筆資料受影響",
                        caption: "新增提示",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Information
                    );

                    ClearAllFields();
                }

                con.Close();    
            }
            else
            {
                MessageBox.Show(
                    text: "訂單欄位必須填寫完整",
                    caption: "新增提示",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
        }

        // 清空資料欄位的所有欄位
        void ClearAllFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtTotal.Clear();
            DTPOrder.Value = DateTime.Now;
            txtNote.Clear();
            txtOrderInfo.Clear();
            radioDone.Checked = false;
            radioWait.Checked = false;
            radioCheck.Checked = false;
            radioCancel.Checked = false;
        }

        // 清空進階搜尋欄位資料
        void ClearSearchFields()
        {
            DTPStart.Value = new DateTime(2000, 1, 1);
            DTPEnd.Value = DateTime.Now;
            comboSearchbyKeyword.SelectedIndex = 0;
            txtSearchbyKeyword.Clear();
            radioAllStatus.Checked = true;
            intOrderdetailStatus = 0;
        }

        // 清空資料
        private void BtnClearData_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            ClearSearchFields();
        }

        // 訂單顯示
        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            PrintAllOrders(ORDER_LOAD_MIN, ORDER_LOAD_MAX); // 用具名常數調整顯示的資料筆數
        }

        // 顯示資料筆數
        void PrintRecord()
        {
            int TotalCount = DGVOrder1.Rows.Count;

            // 如果有新增空白列就扣掉
            if (DGVOrder1.AllowUserToAddRows)
            {
                TotalCount = TotalCount - 1;
            }

            if (DGVOrder1.CurrentCell != null)
            {
                int CurrentIndex = DGVOrder1.CurrentCell.RowIndex + 1; // RowIndex 從0開始

                lblRecord.Text = $"第 {CurrentIndex} 筆/共 {TotalCount} 筆";
            }
            else
            {
                lblRecord.Text = "第 0 筆/共 0 筆";
            }
        }

        // 顯示訂單詳細資訊
        void AllOrdersInfo(int myId)
        {
            if (myId > 0)
            {
                SqlConnection con = new SqlConnection(DBConnString);
                con.Open();
                string strSQL = "select * from OrderDetails where order_id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", myId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtID.Text = reader["order_id"].ToString();
                    txtName.Text = reader["purchaser"].ToString();
                    txtPhone.Text = reader["phone"].ToString();
                    txtOrderInfo.Text = reader["orderinfo"].ToString();
                    DTPOrder.Value = (DateTime)reader["orderdate"];
                    txtTotal.Text = reader["total"].ToString();
                    txtNote.Text = reader["note"].ToString();

                    // 用方法設定 RadioButton
                    string status = reader["status"].ToString();
                    SetStatusRadio(status);
                }
                else
                {
                    MessageBox.Show(
                        text: "查無此人",
                        caption: "提示",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error
                    );
                }
                reader.Close();
                con.Close();
            }
        }

        // 顯示全部訂購單
        void PrintAllOrders(int minID, int maxID)
        {
            SqlConnection con = new SqlConnection(DBConnString);
            con.Open();
            string strSQL = "select order_id as '訂單No.',\r\n" +
                " purchaser, phone, orderinfo, orderdate, total, status, note\r\n" +
                "from OrderDetails where order_id between @minID and @maxID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@minID", minID);
            cmd.Parameters.AddWithValue("@maxID", maxID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGVOrder1.DataSource = dt;
                DGVorderRecords = dt.Rows.Count;
                Console.WriteLine($"\nDGV 筆數資料: {DGVorderRecords}");
            }
            reader.Close();
            con.Close();
        }

        private void DGVOrder1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // 限制 DGV 合法的點擊範圍
            if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0) && (e.RowIndex < DGVorderRecords))
            {
                int selID = (int)DGVOrder1.Rows[e.RowIndex].Cells[0].Value;
                //Console.WriteLine(selID);
                AllOrdersInfo(selID);
                PrintRecord();
            }
        }

        // 處理筆數邏輯
        void MoveToRow(int index)
        {
            int TotalCount = 0;

            if (DGVOrder1.AllowUserToAddRows)
            {
                TotalCount = DGVOrder1.Rows.Count - 1;
            }
            else
            {
                TotalCount = DGVOrder1.Rows.Count;
            }

            // 讓 index 在合法範圍
            if (index >= 0 && index < TotalCount)
            {
                DGVOrder1.ClearSelection();
                DGVOrder1.Rows[index].Selected = true;
                DGVOrder1.CurrentCell = DGVOrder1.Rows[index].Cells[0];

                int selID = (int)DGVOrder1.Rows[index].Cells[0].Value;
                AllOrdersInfo(selID);
                PrintRecord();
            }
        }

        // 上一筆
        private void BtnLeftArrow_Click(object sender, EventArgs e)
        {
            if (DGVOrder1.CurrentCell != null)
            {
                int CurrentIndex = DGVOrder1.CurrentCell.RowIndex;
                MoveToRow(CurrentIndex - 1);
            }
        }

        // 下一筆
        private void BtnRightArrow_Click(object sender, EventArgs e)
        {
            if (DGVOrder1.CurrentCell != null)
            {
                int CurrentIndex = DGVOrder1.CurrentCell.RowIndex;
                int TotalCount = DGVOrder1.Rows.Count;

                if (DGVOrder1.AllowUserToAddRows)
                {
                    TotalCount = TotalCount - 1;
                }

                // 防止超出範圍
                if (CurrentIndex < TotalCount - 1)
                {
                    MoveToRow(CurrentIndex + 1);
                }
            }
        }

        // 第一筆
        private void pictureBoxFP_Click(object sender, EventArgs e)
        {
            MoveToRow(0);
        }

        // 最後筆
        private void pictureBoxLP_Click(object sender, EventArgs e)
        {
            int TotalCount = DGVOrder1.Rows.Count;
            if (DGVOrder1.AllowUserToAddRows)
            {
                TotalCount = TotalCount - 1;
            }
            MoveToRow(TotalCount - 1); // index 範圍從 0 開始
        }

        // 進階搜尋
        private void BtnAdvancedSearch_Click(object sender, EventArgs e)
        {
            string strSQL = "select * from OrderDetails where 1=1"; // 初始化 SQL 查詢語法 1=1 方便用於加上 and 條件

            using (SqlConnection con = new SqlConnection(DBConnString))
            using (SqlCommand cmd = new SqlCommand(strSQL, con))
            {
                // 條件A 關鍵字搜尋
                if (string.IsNullOrWhiteSpace(txtSearchbyKeyword.Text) == false)
                {
                    string SearchType = comboSearchbyKeyword.SelectedItem.ToString();
                    string dbColumnName = "";

                    if (SearchType == "訂購姓名") dbColumnName = "purchaser";
                    else if (SearchType == "訂單電話") dbColumnName = "phone";

                    if (dbColumnName != "")
                    {
                        cmd.CommandText += $" and {dbColumnName} like @SearchKeyword";
                        cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txtSearchbyKeyword.Text.Trim()}%");
                    }
                }

                // 條件B 日期區間處理
                cmd.CommandText += $" and orderdate >= @StartDate and orderdate <= @EndDate";
                cmd.Parameters.AddWithValue("@StartDate", DTPStart.Value.Date); // 開始時間取開始日的 00:00:00
                cmd.Parameters.AddWithValue("@EndDate", DTPEnd.Value.Date.AddDays(1).AddSeconds(-1)); // 結束時間取結束日的 23:59:59(+1變隔天再-1秒)

                // 條件C 訂單狀態處理
                if (intOrderdetailStatus != 0) // 0 代表全部
                {
                    string statusText = "";
                    switch (intOrderdetailStatus)
                    {
                        case 1:
                            statusText = "已出貨";
                            break;
                        case 2:
                            statusText = "待出貨";
                            break;
                        case 3:
                            statusText = "審核中";
                            break;
                        case 4:
                            statusText = "已取消";
                            break;
                    }
                    if (statusText != "")
                    {
                        cmd.CommandText += $" and status = @Status";
                        cmd.Parameters.AddWithValue("@Status", statusText);
                    }
                }

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            DGVOrder1.DataSource = dt;
                            DGVorderRecords = dt.Rows.Count;
                            PrintRecord(); // 更新筆數顯示
                        }
                        else
                        {
                            DGVorderRecords = 0;
                            DGVOrder1.DataSource= null;
                            PrintRecord();
                            MessageBox.Show(
                                text: "查無符合條件的訂單",
                                caption: "搜尋提示",
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Information
                            );
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        text: $"查詢發生錯誤: {ex.Message}",
                        caption: "錯誤",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error
                    );
                }
            } // using 區塊結束 會自動呼叫 reader.Close() con.Close() 釋放資源
        }

        private void radioAllStatus_CheckedChanged(object sender, EventArgs e)
        {
            intOrderdetailStatus = 0;
        }

        private void radioDone2_CheckedChanged(object sender, EventArgs e)
        {
            intOrderdetailStatus = 1;
        }

        private void radioWait2_CheckedChanged(object sender, EventArgs e)
        {
            intOrderdetailStatus = 2;
        }

        private void radioCheck2_CheckedChanged(object sender, EventArgs e)
        {
            intOrderdetailStatus = 3;
        }

        private void radioCancel2_CheckedChanged(object sender, EventArgs e)
        {
            intOrderdetailStatus = 4;
        }

        // 意外關閉時儲存草稿
        private void OrderManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) || !string.IsNullOrWhiteSpace(txtPhone.Text) || !string.IsNullOrWhiteSpace(txtNote.Text))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(DBConnString))
                    {
                        con.Open();

                        // 保持只有一筆最新的草稿
                        SqlCommand deletcmd = new SqlCommand("delete from temp_orders;", con);
                        deletcmd.ExecuteNonQuery();

                        // 存入目前資訊
                        string strSQL = "insert into temp_orders (purchaser, phone, orderinfo, orderdate, total, status, note)\r\n" +
                                "values (@Name, @Phone, @Orderinfo, @Orderdate, @Total, @Status, @Note);";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Orderinfo", txtOrderInfo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Orderdate", DTPOrder.Value);
                                                
                        int totalVal = 0; // total 的處理未輸入和可能輸入錯誤
                        Int32.TryParse(txtTotal.Text, out totalVal);
                        cmd.Parameters.AddWithValue("@Total", totalVal);
                        cmd.Parameters.AddWithValue("@Status", GetSelectedStatus() == "" ? "審核中" : GetSelectedStatus());
                        cmd.Parameters.AddWithValue("@Note", txtNote.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"草稿儲存失敗: {ex.Message}",
                        "系統提示",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}