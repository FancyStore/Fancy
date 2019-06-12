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
            //int j;
            //int tempQTY_SearchStockQTY;
            //bool UI_SK_MC_OrderQTY_Checker = true;
            //for (int i = 0; i <= Cls_Utility.Class1.CartList.Count - 1; i++)
            //{
            //    j = Cls_Utility.Class1.CartList[i].ProductID;
            //    var q = dbContext_FSE.ProductStocks
            //        .Where(ps => ps.ProductID == j)
            //        .Select(ps => ps.StockQTY).FirstOrDefault();
            //    tempQTY_SearchStockQTY = q;

            //    Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductStockQTY = tempQTY_SearchStockQTY;
            //}

            button3.Visible = false;

            Cls_SK_NormalClass.FW = UI_SK_MC_ProductFlowPanel;

            //UC_SK_ShoppingItem UCSKSI_IC = new UC_SK_ShoppingItem(FWPAL);

            for (int index = 0; index <= Cls_Utility.Class1.CartList.Count - 1; index++)
            {
                Cls_SK_NormalClass.indexself = index;

                UCSKSI = new UC_SK_ShoppingItem(index);

                UCSKSI.UC_SK_ShoppingItem_ProductName_linklbl_GetSet = Cls_Utility.Class1.CartList[index].ProductName;

                UCSKSI.UC_SK_ShoppingItem_ProductSize_lbl_GetSet = Cls_Utility.Class1.CartList[index].ProductSizeName;

                UCSKSI.UC_SK_ShoppingItem_ProductColor_lbl_GetSet = Cls_Utility.Class1.CartList[index].ProductColorName;

                UCSKSI.UC_SK_ShoppingItem_ProductStockQTY_lbl_GetSet = CHECK(Cls_Utility.Class1.CartList[index].ProductColorID, Cls_Utility.Class1.CartList[index].ProductSizeID, Cls_Utility.Class1.CartList[index].ProductID);

                UCSKSI.UC_SK_ShoppingItem_ProductOrderQTY_lbl_GetSet = Cls_Utility.Class1.CartList[index].Qty.ToString();

                UCSKSI.tableLayoutPanel1_GetSet = Cls_SK_NormalClass.indexself;

                UCSKSI.UC_SK_ShoppingItem_RemoveRowOrder_btn_GetSet = Cls_SK_NormalClass.indexself;

                UI_SK_MC_ProductFlowPanel.Controls.Add(UCSKSI);
            }
            #endregion 初次顯示
        }

        public string CHECK(int COLOR, int SIZE, int ID)
        {
            var q = dbContext_FSE.ProductStocks.Where(N => N.ProductID == ID && N.ProductColorID == COLOR && N.ProductSizeID == SIZE).Select(N => N.StockQTY).First();
            return q.ToString();
        }

        FancyStoreEntities dbContext_FSE = new FancyStoreEntities();

        #region 第一次庫存檢查
        private void button1_Click(object sender, EventArgs e)
        {
            
            bool UI_SK_MC_OrderQTY_Checker = true;
            int j;
            for (int i = 0; i<=Cls_Utility.Class1.CartList.Count - 1; i++)
            {
                j = Cls_Utility.Class1.CartList[i].ProductID;
                var q = dbContext_FSE.ProductStocks
                    .Where(ps => ps.ProductID == j)
                    .Select(ps => ps.StockQTY).FirstOrDefault();

                if(Cls_Utility.Class1.CartList[i].Qty > q)
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
            UISKCP.ShowDialog();
            //UISKCP.TopMost = true;
            this.Close();
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

            for (int index = 0; index <= Cls_Utility.Class1.CartList.Count - 1; index++)
            {
                Cls_SK_NormalClass.indexself = index;

                UCSKSI = new UC_SK_ShoppingItem(index);

                UCSKSI.UC_SK_ShoppingItem_ProductName_linklbl_GetSet = Cls_Utility.Class1.CartList[index].ProductName;

                UCSKSI.UC_SK_ShoppingItem_ProductSize_lbl_GetSet = Cls_Utility.Class1.CartList[index].ProductSizeName;

                UCSKSI.UC_SK_ShoppingItem_ProductColor_lbl_GetSet = Cls_Utility.Class1.CartList[index].ProductColorName;

                UCSKSI.UC_SK_ShoppingItem_ProductStockQTY_lbl_GetSet = CHECK(Cls_Utility.Class1.CartList[index].ProductColorID, Cls_Utility.Class1.CartList[index].ProductSizeID, Cls_Utility.Class1.CartList[index].ProductID);

                UCSKSI.UC_SK_ShoppingItem_ProductOrderQTY_lbl_GetSet = Cls_Utility.Class1.CartList[index].Qty.ToString();

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
