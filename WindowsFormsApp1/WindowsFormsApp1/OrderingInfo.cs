using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrderingInfo : Form
    {
        public OrderingInfo()
        {
            InitializeComponent();
        }

        private void OrderingInfo_Load(object sender, EventArgs e)
        {
            txtFAQ.Text = @"【常見問題 FAQ】

            Q1：雞蛋糕可以保存多久？
                A：建議現場食用風味最佳，常溫可保存約2～4小時，
            冷藏可保存1天，食用前可回烤加熱。

            Q2：雞蛋糕可以加熱嗎？
                A：可以，建議使用烤箱或氣炸鍋回烤3～5分鐘，
            可恢復外酥內軟口感。

            Q3：有哪些口味可以選擇？
                A：目前提供多種經典口味，並會不定期推出每週
            限定口味，未來也可能推出品牌合作款。

            Q4：可以客製口味或造型嗎？
                A：目前暫不提供客製化口味，造型固定為
            圓形、星型與愛心三種。

            Q5：可以提前預訂嗎？
                A：可以，能使用電話或社群平台提前預訂避免現場久候，
            實際供應狀況依當日現場為準。";
        }

        private void BtnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
