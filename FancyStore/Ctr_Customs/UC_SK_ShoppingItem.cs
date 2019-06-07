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
using Cls_Utility;
using static Cls_Utility.Cls_SK_NormalClass;

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

        //public EventArgs UC_SK_ShoppingItem_OrderQTYIncrease_btn_GetSet
        //{
        //    set { UC_SK_ShoppingItem_OrderQTYIncrease_btn.Text = value.ToString(); }
        //}

        public string UC_SK_ShoppingItem_ProductOrderQTY_lbl_GetSet
        {
            set { UC_SK_ShoppingItem_OrderQTY_lbl.Text = value.ToString(); }
        }

        //public EventArgs UC_SK_ShoppingItem_OrderQTYReduce_btn_GetSet
        //{
        //    set { UC_SK_ShoppingItem_OrderQTYReduce_btn.Text = value.ToString(); }
        //}

        public int UC_SK_ShoppingItem_RemoveRowOrder_btn_GetSet
        {
            //set { Removei = value; }
            set { SK_UC_ShoppingItem_RemoveRowOrder_btn.Tag = value.ToString(); }
        }
        #endregion //===============================================================

        public void UC_SK_ShoppingItem_OrderQTYIncrease_btn_Click(object sender, EventArgs e)
        {
            Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Increase = true;
            if (Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Remove == true)
            {
                MessageBox.Show("請先點選更新數量", "System Alarm");
                return;
            }
            for (int i = 0 ; i<=Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count -1; i++)
            {
                Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY + 1;
               }
        }

        public void UC_SK_ShoppingItem_OrderQTYReduce_btn_Click(object sender, EventArgs e)
        {
            Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Reduce = true;
            if (Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Remove == true)
            {
                MessageBox.Show("請先點選更新數量", "System Alarm");
                return;
            }
            for (int i=0;i<= Cls_Utility.Cls_SK_NormalClass.ShoppingList.Count - 1; i++)
            {
                Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY = Cls_Utility.Cls_SK_NormalClass.ShoppingList[i].ProductOrderQTY - 1;
            }
        }

        UC_SK_ShoppingItem UCSKSIItem;
        private void SK_UC_ShoppingItem_RemoveRowOrder_btn_Click_1(object sender, EventArgs e)
        {
            if(Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Increase == true ||
                Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Reduce == true ||
                Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Remove == true)
            {
                MessageBox.Show("請先點選更新數量","System Alarm");
                return;
            }
            Cls_SK_NormalClass.UI_SK_MC_QtyANDRemove_InterLock_Remove = true;

            Cls_SK_NormalClass.ShoppingList.RemoveAt(Convert.ToInt32(SK_UC_ShoppingItem_RemoveRowOrder_btn.Tag));
            return;
        }
    }
}
               
