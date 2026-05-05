using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GlobalVar
    {
        public static string OrdererInfo = "";  // 訂購人資訊
        public static string OrdererPhone = ""; // 訂購人電話
        public static string OrdererNote = "";  // 訂購人備註
        public static string UserName = "";     // 使用者姓名
        public static string UserEmail = "";    // 使用者電子郵件

        public static bool isLogin = false;       // 登入成功
        public static bool isShoppingBag = false; // 加購物袋
        public static bool isToothpick = false;   // 加餐具

        public static int OrderCounter = 1; // 紀錄訂單編號 從 1 開始
        public static int permission = 0;   // 使用者權限

        public static List<ArrayList> listOrderedItems = new List<ArrayList>();
        // 紀錄訂購的餐點資訊，以下是該 ArrayList 的索引項目
        // 0: 商品 id
        // 1: 商品名稱
        // 2: 份量
        // 3: 造型
        // 4: 數量
        // 5: 單價
        // 6: 單品總價

        // 資料庫連線
        public static string DBconnectionString = ""; // 連線字串
        // public static string imageDir = @"C:\Users\iSpan\Desktop\deng_work\個人專題\素材\image"; // 圖檔目錄 教室電腦
        public static string imageDir = @"E:\00全端工程師課程\專題\ver1.0\素材\image"; // 圖檔目錄 桌電
    }
}
