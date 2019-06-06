using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Office.Tools.Word;

namespace Ctr_Customs
{
    public partial class UC_SK_ShoppingItem : UserControl
    {
        public UC_SK_ShoppingItem()
        {
            InitializeComponent();
        }


        #region 設定SK_UC_ShoppingItem GetSet屬性
        public string UC_SK_ShoppingItem_ProductName_linklbl_GetSet
        {
            set { UC_SK_ShoppingItem_ProductName_linklbl.Text = value.ToString(); }
        }

        public string UC_SK_ShoppingItem_ProductSize_lbl_GetSet
        {
            set { UC_SK_ShoppingItem_ProductSize_lbl.Text = value.ToString(); }
        }

        public string UC_SK_ShoppingItem_ProductColor_lbl_GetSet
        {
            set { UC_SK_ShoppingItem_ProductColor_lbl.Text = value.ToString(); }
        }

        public string UC_SK_ShoppingItem_ProductStockQTY_lbl_GetSet
        {
            set { UC_SK_ShoppingItem_ProductStockQTY_lbl.Text = value.ToString(); }
        }

        public EventArgs UC_SK_ShoppingItem_OrderQTYIncrease_btn_GetSet
        {
            set { UC_SK_ShoppingItem_OrderQTYIncrease_btn.Text = value.ToString(); }
        }

        public string UC_SK_ShoppingItem_ProductOrderQTY_lbl_GetSet
        {
            set { UC_SK_ShoppingItem_OrderQTY_lbl.Text = value.ToString(); }
        }

        public EventArgs UC_SK_ShoppingItem_OrderQTYReduce_btn_GetSet
        {
            set { UC_SK_ShoppingItem_OrderQTYReduce_btn.Text = value.ToString(); }
        }

        public EventArgs UC_SK_ShoppingItem_RemoveRowOrder_btn_GetSet
        {
            set { SK_UC_ShoppingItem_RemoveRowOrder_btn.Text = value.ToString(); }
        }
        #endregion //===============================================================

        public static void RemoveAt(int index)
        {
            for (int i = 0; i <= Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                RemoveAt(i);
            }
        }
        

        

        public void UC_SK_ShoppingItem_OrderQTYIncrease_btn_Click(object sender, EventArgs e)
        {
            for (int i=0;i<=Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count -1; i++)
            {
                Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY + 1;

            }


        }

        public void UC_SK_ShoppingItem_OrderQTYReduce_btn_Click(object sender, EventArgs e)
        {
            for (int i=0;i<= Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY - 1;
            }
        }

        public void SK_UC_ShoppingItem_RemoveRowOrder_btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                RemoveAt(i);
            }
        }
    }
}
