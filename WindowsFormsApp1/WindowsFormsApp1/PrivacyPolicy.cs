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
    public partial class PrivacyPolicy : Form
    {
        public PrivacyPolicy()
        {
            InitializeComponent();
        }

        private void PrivacyPolicy_Load(object sender, EventArgs e)
        {
            txtPolicy.Text = @"隱私政策｜危機就是轉雞蛋糕

            更新日期：2026.04.24  

            危機就是轉雞蛋糕（以下稱「我們」）重視您的隱私與個人資料保護。

            當您使用本應用程式（危機就是轉雞蛋糕）時，
            我們可能會蒐集並處理您的個人資料
            （例如基本資料、訂單資訊或您於操作過程中提供的內容）。
            當您進行瀏覽、下單或使用相關功能時，
            系統亦可能記錄必要資訊，以確保服務正常運作與安全性。

            我們重視您的個人資料，並致力於維護本應用程式的安全與穩定。
            本隱私政策將說明我們蒐集的資料類型
            和使用方式，以及您可選擇的權利。

            一、我們可能透過以下方式蒐集資料：

            - 您於應用程式中主動輸入的資訊（如會員、訂單資料）
            - 操作過程中產生的紀錄（如使用時間、功能操作）
            - 系統自動蒐集的裝置資訊（如基本環境資料）
            - 實體門市會員消費紀錄
            - Cookie與裝置資訊

            此外，若您透過社群平台（如 Facebook、Instagram）與我們互動，
            或於實體門市購買商品（如雞蛋糕）並使用會員服務，
            相關消費紀錄亦可能被整合使用。
            所有資料提供皆為自願，但若您選擇不提供，
            部分功能或服務可能無法正常使用。

            二、蒐集目的：

            - 訂單處理與客戶服務  
            - 身分驗證與交易安全  
            - 行銷通知與優惠資訊  

            三、資料使用方式：

            - 處理訂單、付款、退換貨  
            - 客服聯繫  
            - 客製化廣告  

            四、資料保護：

            我們採取適當措施保護資料，但無法保證絕對安全。
            此外，若基於相關法律規定之要求，或涉及
            公共安全、他人生命與財產安全等情況，
            我們得依法律規定提供必要之個人資料予相關主管機關或依法有權之單位。

            五、聯絡方式：

            若您對本隱私政策有任何疑問或需要協助，
            請透過以下方式與我們聯繫：
            電子郵件
            orderEggPanckes@gmail.com.tw" ;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
