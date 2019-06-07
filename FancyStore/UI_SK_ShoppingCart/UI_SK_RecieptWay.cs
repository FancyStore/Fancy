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
using Cls_Utility;

namespace UI_SK_ShoppingCart
{
    public partial class UI_SK_RecieptWay : UI_SK_MotherForm
    {
        UC_SK_RW_CheckList_Item UCSKSI;
        public UI_SK_RecieptWay()
        {
            InitializeComponent();

            if (Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB1 == true)
            {
                Cls_SK_NormalClass.UI_SK_CP_FinalPay_int = Cls_SK_NormalClass.UI_SK_CP_SmallSum_int + Cls_SK_NormalClass.UI_SK_CP_int1;
            }
            else if (Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB2 == true)
            {
                Cls_SK_NormalClass.UI_SK_CP_FinalPay_int = Cls_SK_NormalClass.UI_SK_CP_SmallSum_int + Cls_SK_NormalClass.UI_SK_CP_int2;
            }
            else if (Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB3 == true)
            {
                Cls_SK_NormalClass.UI_SK_CP_FinalPay_int = Cls_SK_NormalClass.UI_SK_CP_SmallSum_int + Cls_SK_NormalClass.UI_SK_CP_int3;
            }
            else if (Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB4 == true)
            {
                Cls_SK_NormalClass.UI_SK_CP_FinalPay_int = Cls_SK_NormalClass.UI_SK_CP_SmallSum_int + Cls_SK_NormalClass.UI_SK_CP_int4;
            }
            else
            {

            }
            
            for (int i = 0; i <= Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                UCSKSI = new UC_SK_RW_CheckList_Item();

                UCSKSI.UC_SK_RW_CheckItem_ProductName_linklbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductName;

                UCSKSI.UC_SK_RW_CheckItem_ProductSize_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductSizeName;

                UCSKSI.UC_SK_RW_CheckItem_ProductColor_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductColorName;

                

                UCSKSI.UC_SK_RW_CheckItem_OrderQTY_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY.ToString();

                UI_SK_RW_FOPanel1.Controls.Add(UCSKSI);

                //if (Cls_SK_NormalClass.ShoppingList[i].StockID == )


            }

            UI_SK_RW_SP_Phone_Dynamiclbl.Text = UI_SK_CP_SP_Phone_Str;
            UI_SK_RW_SP_Fax_Dynamiclbl.Text = UI_SK_CP_SP_Fax_Str;
            UI_SK_RW_SP_Email_Dynamiclbl.Text = UI_SK_CP_SP_Email_Str;
            UI_SK_RW_SP_Address_Dynamiclbl.Text = UI_SK_CP_SP_Address_Str;
            UI_SK_RW_SP_SentWay_Dynamiclbl.Text = UI_SK_CP_SP_SentWay_Str;


        }


        FancyStoreEntities dbContext_FSE = new FancyStoreEntities();
        //OrderDetail OD = new OrderDetail { OrderDetailID = 1, OrderID = Convert.ToInt32($"GD{DateTime.Now:yyyyMMddHHmmss}{Cls_Utility.Cls_SK_NormalClass.UserID}"), ProductID = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductID, ProductColorID = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductColorID, ProductSizeID = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductSizeID, UnitPrice = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].UnitPrice, OrderQTY = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY, CreateDate = DateTime.Now };
        //FancyStoreEntities dbContext_FSE = new FancyStoreEntities();
        private void UI_SK_RW_BornOrder_Click(object sender, EventArgs e)
        {
            int id;
               
            //for (int i=0; i<= Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            //{
            using (var dbContext_FSE = new FancyStoreEntities())
            {
                OrderHeader OH = new OrderHeader
                { /*OrderID = 1,*/
                    OrderNum = $"GD{DateTime.Now:yyyyMMddHHmmss}{Cls_Utility.Cls_SK_NormalClass.UserID}"
                    ,
                    OrderDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    ShipDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    UserID = 1,
                    PayMethodID = Cls_SK_NormalClass.UI_SK_CP_PM_SQL,
                    ShippingID = Cls_SK_NormalClass.UI_SK_CP_SP_SQL,
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

                    //Insert OrderDetail資料
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

            using (var dbContext_FSE = new FancyStoreEntities())
            {
                Shipping SH = new Shipping
                {
                    ShippingName=UI_SK_CP_SP_SentWay_Str,
                    Phone=UI_SK_CP_SP_Phone_Str,
                    Fax=UI_SK_CP_SP_Fax_Str,
                    Email= UI_SK_CP_SP_Email_Str,
                    Address= UI_SK_CP_SP_Address_Str,
                    CreateDate= DateTime.Now
                };

                dbContext_FSE.Shippings.Add(SH);
                dbContext_FSE.SaveChanges();
            }



            using (var dbContext_FSE = new FancyStoreEntities())
            {
                OrderStatusList OLS = new OrderStatusList { /*OrderStatusID = ,*/ OrderStatusName = "預設名" };
                dbContext_FSE.OrderStatusLists.Add(OLS);
                dbContext_FSE.SaveChanges();

            }

            //}
           

          
        }

        private void UI_SK_RW_SP_SentWay_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
