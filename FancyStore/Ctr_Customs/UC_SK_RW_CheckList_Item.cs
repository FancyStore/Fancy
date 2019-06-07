using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctr_Customs
{
    public partial class UC_SK_RW_CheckList_Item : UserControl
    {
        public UC_SK_RW_CheckList_Item()
        {
            InitializeComponent();
        }

        public string UC_SK_RW_CheckItem_ProductName_linklbl_GetSet
        {
            set { UC_SK_RW_CheckItem_ProductName_linklbl.Text = value.ToString(); }
        }

        public string UC_SK_RW_CheckItem_ProductSize_lbl_GetSet
        {
            set { UC_SK_RW_CheckItem_ProductSize_lbl.Text = value.ToString(); }
        }

        public string UC_SK_RW_CheckItem_ProductColor_lbl_GetSet
        {
            set { UC_SK_RW_CheckItem_ProductColor_lbl.Text = value.ToString(); }
        }

        public string UC_SK_RW_CheckItem_OrderQTY_lbl_GetSet
        {
            set { UC_SK_RW_CheckItem_OrderQTY_lbl.Text = value.ToString(); }
        }
    }
}
