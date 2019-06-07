using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;
using Cls_Utility;
using static Cls_Utility.Cls_SK_NormalClass;
using Ctr_Customs;

namespace UI_SK_ShoppingCart
{
    public partial class UI_SK_RecieptWay : UI_SK_MotherForm
    {
        UC_SK_RW_CheckList_Item UCSKSI;
        public UI_SK_RecieptWay()
        {
            InitializeComponent();

            #region 應付總價
            int tempSum;
            var q = Cls_SK_NormalClass.ShoppingList.Sum(temppay => temppay.SmallSum);
            tempSum = q;

            if (Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB1 == true)
            {
                Cls_SK_NormalClass.UI_SK_CP_FinalPay_int = tempSum + Cls_SK_NormalClass.UI_SK_CP_int1 + Cls_SK_NormalClass.UI_SK_RW_SPfee1_int;
            }
            else if (Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB2 == true)
            {
                Cls_SK_NormalClass.UI_SK_CP_FinalPay_int = tempSum + Cls_SK_NormalClass.UI_SK_CP_int2 + Cls_SK_NormalClass.UI_SK_RW_SPfee2_int;
            }
            else if (Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB3 == true)
            {
                Cls_SK_NormalClass.UI_SK_CP_FinalPay_int = tempSum + Cls_SK_NormalClass.UI_SK_CP_int3 + Cls_SK_NormalClass.UI_SK_RW_SPfee3_int;
            }
            else if (Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB4 == true)
            {
                Cls_SK_NormalClass.UI_SK_CP_FinalPay_int = tempSum + Cls_SK_NormalClass.UI_SK_CP_int4 + Cls_SK_NormalClass.UI_SK_RW_SPfee4_int;
            }
            else
            {

            }
            #endregion 應付總價

            #region 確認購物內容
            for (int i = 0; i <= Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                UCSKSI = new UC_SK_RW_CheckList_Item();

                UCSKSI.UC_SK_RW_CheckItem_ProductName_linklbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductName;

                UCSKSI.UC_SK_RW_CheckItem_ProductSize_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductSizeName;

                UCSKSI.UC_SK_RW_CheckItem_ProductColor_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductColorName;

                UCSKSI.UC_SK_RW_CheckItem_OrderQTY_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY.ToString();

                UI_SK_RW_FOPanel1.Controls.Add(UCSKSI);
                
            }
            #endregion 確認購物內容
            //UI_SK_RW_SP_Phone_Dynamiclbl.Text = UI_SK_CP_SP_Phone_Str;
            //UI_SK_RW_SP_Fax_Dynamiclbl.Text = UI_SK_CP_SP_Fax_Str;
            //UI_SK_RW_SP_Email_Dynamiclbl.Text = UI_SK_CP_SP_Email_Str;
            //UI_SK_RW_SP_Address_Dynamiclbl.Text = UI_SK_CP_SP_Address_Str;
            //UI_SK_RW_SP_SentWay_Dynamiclbl.Text = UI_SK_CP_SP_SentWay_Str;


        }


        FancyStoreEntities dbContext_FSE = new FancyStoreEntities();
        #region 參數寫入 OrderDetail, OrderHeader, 庫存檢查

        int tempQTY_SearchStockQTY;
        int tempQTY_WriteToSQL;
        int j;
        private void UI_SK_RW_BornOrder_Click(object sender, EventArgs e)
        {
            bool UI_SK_MC_OrderQTY_Checker = true;
            for (int i = 0; i <= Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                j = Cls_SK_NormalClass.ShoppingList[i].ProductID;
                var q = dbContext_FSE.ProductStocks
                    .Where(ps => ps.ProductID == j)
                    .Select(ps => ps.StockQTY).FirstOrDefault();
                tempQTY_SearchStockQTY = q;

                if (Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY > q)
                {
                    MessageBox.Show("庫存不足，請降低數量", "System Alarm");
                    UI_SK_MC_OrderQTY_Checker = false;
                    return;
                }
                else
                {
                    
                }
            }

            for (int i = 0; i <= Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                tempQTY_WriteToSQL = 
                    tempQTY_SearchStockQTY - Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY;
            }


            

            using (var dbContext_FSE = new FancyStoreEntities())
            {
                var q = (from ps in dbContext_FSE.ProductStocks
                        where ps.ProductID == j
                        select ps).FirstOrDefault();

                q.StockQTY = tempQTY_WriteToSQL;

                dbContext_FSE.SaveChanges();
            }

            int id;
            using (var dbContext_FSE = new FancyStoreEntities())
            {
                OrderHeader OH = new OrderHeader
                { 
                    OrderNum = $"GD{DateTime.Now:yyyyMMddHHmmss}{Cls_Utility.Cls_SK_NormalClass.UserID}"
                    ,
                    OrderDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    ShipDate = Convert.ToDateTime(DateTime.Now.AddDays(15).ToShortDateString()),
                    UserID = 1,
                    PayMethodID = Cls_SK_NormalClass.UI_SK_CP_PM_SQL,
                    ShippingID = 1 /*Cls_SK_NormalClass.UI_SK_CP_SP_SQL*/,
                    DiscountID = 3,
                    OrderStatusID = 1,
                    OrderAmount = Cls_SK_NormalClass.UI_SK_CP_FinalPay_int,
                    CreateDate = DateTime.Now
                };
                dbContext_FSE.OrderHeaders.Add(OH);
                dbContext_FSE.SaveChanges();
                id = OH.OrderID;
                MessageBox.Show($"OrderID={id}");


               
            }


            for (int i = 0; i <= Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                using (var dbContext_FSE = new FancyStoreEntities())
                {
                    OrderDetail OD = new OrderDetail
                    { /*OrderDetailID = 1,*/
                        OrderID = id,
                        ProductID = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductID,
                        ProductColorID = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductColorID,
                        ProductSizeID = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductSizeID,
                        UnitPrice = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].UnitPrice,
                        OrderQTY = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY,
                        CreateDate = DateTime.Now
                    };

                    dbContext_FSE.OrderDetails.Add(OD);
                    dbContext_FSE.SaveChanges();

                }
            }
            #endregion 參數寫入 OrderDetail, OrderHeader, 庫存檢查

            #region 寫入shipping
            //using (var dbContext_FSE = new FancyStoreEntities())
            //{
            //    Shipping SH = new Shipping
            //    {
            //        ShippingName=UI_SK_CP_SP_SentWay_Str,
            //        Phone=UI_SK_CP_SP_Phone_Str,
            //        Fax=UI_SK_CP_SP_Fax_Str,
            //        Email= UI_SK_CP_SP_Email_Str,
            //        Address= UI_SK_CP_SP_Address_Str,
            //        CreateDate= DateTime.Now
            //    };

            //    dbContext_FSE.Shippings.Add(SH);
            //    dbContext_FSE.SaveChanges();
            //}
            #endregion 寫入shipping


        }





    }
}
