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


namespace UI_SK_ShoppingCart
{
    

    public partial class UI_SK_MainCart : UI_SK_MotherForm
    {
        UC_SK_ShoppingItem UCSKSI;
        public UI_SK_MainCart()
        {
            InitializeComponent();
            
            for (int i = 0; i <= Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                UCSKSI = new UC_SK_ShoppingItem();

                UCSKSI.UC_SK_ShoppingItem_ProductName_linklbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductName;

                UCSKSI.UC_SK_ShoppingItem_ProductSize_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductSizeName;

                UCSKSI.UC_SK_ShoppingItem_ProductColor_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductColorName;

                UCSKSI.UC_SK_ShoppingItem_ProductStockQTY_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductStockQTY.ToString();

                UCSKSI.UC_SK_ShoppingItem_ProductOrderQTY_lbl_GetSet = Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY.ToString();

                UI_SK_MC_ProductFlowPanel.Controls.Add(UCSKSI);

                //if (Cls_SK_NormalClass.ShoppingList[i].StockID == )

                
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            UI_SK_ChoosePay UISKCP = new UI_SK_ChoosePay();
            UISKCP.Show();
            this.Hide();
        }

        
        

        
        public void UI_SK_MainCart_Load(object sender, EventArgs e)
        {
            
            


        }
    }
}
