using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Tools.Word;


namespace Cls_Utility
{
    public class Cls_SK_NormalClass
    {
        
        public static int UserID { get; set; }

        public static List<BuyItem> ShoppingList = new List<BuyItem>();

        public static string UI_SK_CP_SP_Phone_Str, UI_SK_CP_SP_Fax_Str, UI_SK_CP_SP_Email_Str, UI_SK_CP_SP_Address_Str,UI_SK_CP_SP_SentWay_Str;

        public static bool UI_SK_CP_Way_Bool_RB1, UI_SK_CP_Way_Bool_RB2, UI_SK_CP_Way_Bool_RB3, UI_SK_CP_Way_Bool_RB4;

        public static int UI_SK_CP_int1, UI_SK_CP_int2, UI_SK_CP_int3, UI_SK_CP_int4,UI_SK_CP_PM_SQL,UI_SK_CP_SP_SQL;

        public static bool UI_SK_CP_SP_Bool_RB1, UI_SK_CP_SP_Bool_RB2, UI_SK_CP_SP_Bool_RB3, UI_SK_CP_SP_Bool_RB4;

        public static int UI_SK_CP_SmallSum_int,UI_SK_CP_MediumPay_int1, UI_SK_CP_MediumPay_int2, UI_SK_CP_MediumPay_int3, UI_SK_CP_MediumPay_int4, UI_SK_CP_FinalPay_int;

        public class BuyItem
        {
            

            public int StockID { get; set; }

            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int UnitPrice { get; set; }

            public int ProductSizeID { get; set; }
            public string ProductSizeName { get; set; }

            public int ProductColorID { get; set; }
            public string ProductColorName { get; set; }

            public int ProductOrderQTY { get; set; }

            public int ProductStockQTY { get; set; }

            public int MinStock { get; set; }

            public ClickEventArgs UpdateQTYAdd { get; set; }
            public ClickEventArgs UpdateQTYReduce { get; set; }

            public ClickEventArgs ProductRemoveAt { get;set;}
            

        }
    }
}
