using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ctr_Customs;
using Cls_Utility;
using DB_Fancy;


namespace UI_SK_ShoppingCart
{
    

    public partial class UI_SK_MainCart : UI_SK_MotherForm
    {
        UC_SK_ShoppingItem UCSKSI;
        
        public UI_SK_MainCart()
        {
            InitializeComponent();
            #region 初次顯示
            Cls_SK_NormalClass.FW = UI_SK_MC_ProductFlowPanel;
            for (int index = 0; index <= Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count - 1; index++)
            {
                Cls_SK_NormalClass.indexself = index;

                UCSKSI = new UC_SK_ShoppingItem();

                UCSKSI.UC_SK_ShoppingItem_ProductName_linklbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductName;

                UCSKSI.UC_SK_ShoppingItem_ProductSize_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductSizeName;

                UCSKSI.UC_SK_ShoppingItem_ProductColor_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductColorName;

                UCSKSI.UC_SK_ShoppingItem_ProductStockQTY_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductStockQTY.ToString();

                UCSKSI.UC_SK_ShoppingItem_ProductOrderQTY_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductOrderQTY.ToString();

                UCSKSI.UC_SK_ShoppingItem_RemoveRowOrder_btn_GetSet = Cls_SK_NormalClass.indexself;

                UI_SK_MC_ProductFlowPanel.Controls.Add(UCSKSI);
            }
            #endregion 初次顯示
        }



        FancyStoreEntities dbContext_FSE = new FancyStoreEntities();

        #region 第一次庫存檢查
        private void button1_Click(object sender, EventArgs e)
        {
            
            bool UI_SK_MC_OrderQTY_Checker = true;
            int j;
            for (int i = 0; i<=Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                j = Cls_SK_NormalClass.ShoppingList[i].ProductID;
                var q = dbContext_FSE.ProductStocks
                    .Where(ps => ps.ProductID == j)
                    .Select(ps => ps.StockQTY).FirstOrDefault();

                if(Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY > q)
                {
                    MessageBox.Show("庫存不足，請降低數量","System Alarm");
                    UI_SK_MC_OrderQTY_Checker = false;
                    return;
                }
                else
                {
                    
                }
            }
            UI_SK_ChoosePay UISKCP = new UI_SK_ChoosePay();
            UISKCP.Show();
            this.Hide();
        }
        #endregion 第一次庫存檢查




        public void UI_SK_MainCart_Load(object sender, EventArgs e)
        {
            
            


        }

        #region 重刷FlowlayoutPanel

        private void button3_Click(object sender, EventArgs e)
        {
            Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Reduce = false;
            Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Increase = false;
            Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Remove = false;

            UI_SK_MC_ProductFlowPanel.Controls.Clear();

            for (int index = 0; index <= Cls_SK_NormalClass.ShoppingList.Count - 1; index++)
            {
                Cls_SK_NormalClass.indexself = index;

                UCSKSI = new UC_SK_ShoppingItem();

                UCSKSI.UC_SK_ShoppingItem_ProductName_linklbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductName;

                UCSKSI.UC_SK_ShoppingItem_ProductSize_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductSizeName;

                UCSKSI.UC_SK_ShoppingItem_ProductColor_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductColorName;

                UCSKSI.UC_SK_ShoppingItem_ProductStockQTY_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductStockQTY.ToString();

                UCSKSI.UC_SK_ShoppingItem_ProductOrderQTY_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[index].ProductOrderQTY.ToString();

                UCSKSI.UC_SK_ShoppingItem_RemoveRowOrder_btn_GetSet = Cls_SK_NormalClass.indexself;

                UI_SK_MC_ProductFlowPanel.Controls.Add(UCSKSI);
            }
        }

        #endregion 重刷FlowlayoutPanel

        //private void button4_Click(object sender, EventArgs e)
        //{

        //    for (int i = 0; i <= Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
        //    {
        //        Cls_SK_NormalClass.ShoppingList.RemoveAt(i);
        //        return;
        //    }
        //}
    }
}
