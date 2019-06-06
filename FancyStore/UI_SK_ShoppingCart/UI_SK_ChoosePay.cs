﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Cls_Utility;
using static Cls_Utility.Cls_SK_NormalClass;


namespace UI_SK_ShoppingCart
{
    public partial class UI_SK_ChoosePay : UI_SK_MotherForm
    {
        public UI_SK_ChoosePay()
        {
            InitializeComponent();

            var resultList = from n in Cls_Utility.Cls_SK_NormalClass.ShoppingList
                             select new { SubAmount = n.UnitPrice * n.ProductOrderQTY };
            Cls_Utility.Cls_SK_NormalClass.UI_SK_CP_SmallSum_int = resultList.Sum(x => x.SubAmount);
            
        }




        FancyStoreEntities dbContext_FSE = new FancyStoreEntities();
        internal void UI_SK_ChoosePay_Load(object sender, EventArgs e)
        {
            

            //FirstOrDefault(); 取出序列的第一筆資料,若無資料則回傳 Default
            //UI_SK_CP_PM_Name1_lbl 付款方式 (從資料庫提取),
            var UI_SK_CP_PM_Name1_Var = dbContext_FSE.PayMethods
                                        .Where(pm => (pm.PayMethodID == 1))
                                        .Select(pm => pm.PayMethodName).FirstOrDefault();
            UI_SK_CP_PM_Name1_lbl.Text = UI_SK_CP_PM_Name1_Var.ToString();
            //UI_SK_CP_int1 = Convert.ToInt32(UI_SK_CP_PM_Name1_Var);

            var UI_SK_CP_PM_ShippingFee1_String = dbContext_FSE.PayMethods
                                               .Where(pm => pm.PayMethodID == 1)
                                               .Select(pm => pm.Freight).FirstOrDefault();
            UI_SK_CP_PM_ShippingFee1_lbl.Text = "運費=" + UI_SK_CP_PM_ShippingFee1_String.ToString() +"NT";

            var UI_SK_CP_SP1_Var = dbContext_FSE.Shippings
                                               .Where(pm => pm.ShippingID == 1)
                                               .Select(pm => pm.ShippingName).FirstOrDefault();
            UI_SK_CP_SP1_lbl.Text = UI_SK_CP_SP1_Var.ToString();
            //==============================================================


            //UI_SK_CP_PM_Name2_lbl 付款方式 (從資料庫提取)
            var UI_SK_CP_PM_Name2_Var = dbContext_FSE.PayMethods
                                        .Where(pm => (pm.PayMethodID == 2))
                                        .Select(pm => (pm.PayMethodName)).FirstOrDefault() + "NT";
            UI_SK_CP_PM_Name2_lbl.Text = UI_SK_CP_PM_Name2_Var.ToString();
            //UI_SK_CP_int2 = Convert.ToInt32(UI_SK_CP_PM_Name2_Var);

            var UI_SK_CP_PM_ShippingFee2_String = dbContext_FSE.PayMethods
                                              .Where(pm => pm.PayMethodID == 2)
                                              .Select(pm => pm.Freight).FirstOrDefault();
            UI_SK_CP_PM_ShippingFee2_lbl.Text = "運費=" + UI_SK_CP_PM_ShippingFee2_String.ToString() + "NT";

            var UI_SK_CP_SP2_Var = dbContext_FSE.Shippings
                                               .Where(pm => pm.ShippingID == 2)
                                               .Select(pm => pm.ShippingName).FirstOrDefault();
            UI_SK_CP_SP2_lbl.Text = UI_SK_CP_SP2_Var.ToString();
            //==============================================================


            //UI_SK_CP_PM_Name3_lbl 付款方式 (從資料庫提取)
            var UI_SK_CP_PM_Name3_Var = dbContext_FSE.PayMethods
                                        .Where(pm => pm.PayMethodID == 3)
                                        .Select(pm => pm.PayMethodName).FirstOrDefault();
            UI_SK_CP_PM_Name3_lbl.Text = UI_SK_CP_PM_Name3_Var.ToString();
            //UI_SK_CP_int3 = Convert.ToInt32(UI_SK_CP_PM_Name3_Var);

            var UI_SK_CP_PM_ShippingFee3_String = dbContext_FSE.PayMethods
                                             .Where(pm => pm.PayMethodID == 3)
                                             .Select(pm => pm.Freight).FirstOrDefault();
            UI_SK_CP_PM_ShippingFee3_lbl.Text = "運費=" + UI_SK_CP_PM_ShippingFee3_String.ToString() + "NT";

            var UI_SK_CP_SP3_Var = dbContext_FSE.Shippings
                                               .Where(pm => pm.ShippingID == 3)
                                               .Select(pm => pm.ShippingName).FirstOrDefault();
            UI_SK_CP_SP3_lbl.Text = UI_SK_CP_SP3_Var.ToString();
            //==============================================================


            //UI_SK_CP_PM_Name4_lbl 付款方式 (從資料庫提取)
            var UI_SK_CP_PM_Name4_Var = dbContext_FSE.PayMethods
                                        .Where(pm => (pm.PayMethodID == 4))
                                        .Select(pm => (pm.PayMethodName)).FirstOrDefault();
            UI_SK_CP_PM_Name4_lbl.Text = UI_SK_CP_PM_Name4_Var.ToString();
            //UI_SK_CP_int4 = Convert.ToInt32(UI_SK_CP_PM_Name4_Var);

            var UI_SK_CP_PM_ShippingFee4_String = dbContext_FSE.PayMethods
                                             .Where(pm => pm.PayMethodID == 4)
                                             .Select(pm => pm.Freight).FirstOrDefault();
            UI_SK_CP_PM_ShippingFee4_lbl.Text = "運費=" + UI_SK_CP_PM_ShippingFee4_String.ToString() + "NT";

            var UI_SK_CP_SP4_Var = dbContext_FSE.Shippings
                                               .Where(pm => pm.ShippingID == 4)
                                               .Select(pm => pm.ShippingName).FirstOrDefault();
            UI_SK_CP_SP4_lbl.Text = UI_SK_CP_SP4_Var.ToString();
            //==============================================================


        }

        RadioButton RB_PayMethon;
        private void UI_SK_CP_PM_Name1_lbl_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SK_CP_PM_Name1_lbl.Checked) RB_PayMethon = UI_SK_CP_PM_Name1_lbl;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB1 = true;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB2 = false;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB3 = false;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB4 = false;
            Cls_SK_NormalClass.UI_SK_CP_PM_SQL = dbContext_FSE.Shippings.Where(sh => sh.ShippingID == 1).Select(sh => sh.ShippingID).FirstOrDefault();
        }

        private void UI_SK_CP_PM_Name2_lbl_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SK_CP_PM_Name2_lbl.Checked) RB_PayMethon = UI_SK_CP_PM_Name2_lbl;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB1 = false;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB2 = true;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB3 = false;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB4 = false;
            Cls_SK_NormalClass.UI_SK_CP_PM_SQL = dbContext_FSE.Shippings.Where(sh => sh.ShippingID == 2).Select(sh => sh.ShippingID).FirstOrDefault();
        }

        private void UI_SK_CP_PM_Name3_lbl_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SK_CP_PM_Name3_lbl.Checked) RB_PayMethon = UI_SK_CP_PM_Name3_lbl;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB1 = false;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB2 = false;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB3 = true;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB4 = false;
            Cls_SK_NormalClass.UI_SK_CP_PM_SQL = dbContext_FSE.Shippings.Where(sh => sh.ShippingID == 3).Select(sh => sh.ShippingID).FirstOrDefault();
        }

        private void UI_SK_CP_PM_Name4_lbl_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SK_CP_PM_Name4_lbl.Checked) RB_PayMethon = UI_SK_CP_PM_Name4_lbl;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB1 = false;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB2 = false;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB3 = false;
            Cls_SK_NormalClass.UI_SK_CP_Way_Bool_RB4 = true;
            Cls_SK_NormalClass.UI_SK_CP_PM_SQL = dbContext_FSE.Shippings.Where(sh => sh.ShippingID == 4).Select(sh => sh.ShippingID).FirstOrDefault();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (UI_SK_CP_PM_Name1_lbl.Checked || UI_SK_CP_PM_Name2_lbl.Checked || 
            //    UI_SK_CP_PM_Name3_lbl.Checked || UI_SK_CP_PM_Name4_lbl.Checked)
            //RBOX_Test_lbl.Text = RB_PayMethon.Text;
            //else
            //{

            //}

           

            UI_SK_RecieptWay UISKRW = new UI_SK_RecieptWay();
            UISKRW.Show();
            this.Hide();
        }

        RadioButton RB_Shipping;

        private void UI_SK_CP_SP1_lbl_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SK_CP_SP1_lbl.Checked) RB_Shipping = UI_SK_CP_SP1_lbl;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB1 = true;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB2 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB3 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB4 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_SQL = 1;
        }

        private void UI_SK_CP_SP2_lbl_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SK_CP_SP2_lbl.Checked) RB_Shipping = UI_SK_CP_SP2_lbl;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB1 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB2 = true;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB3 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB4 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_SQL = 2;
        }

        private void UI_SK_CP_SP3_lbl_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SK_CP_SP3_lbl.Checked) RB_Shipping = UI_SK_CP_SP3_lbl;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB1 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB2 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB3 = true;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB4 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_SQL = 3;
        }

        private void UI_SK_CP_SP4_lbl_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_SK_CP_SP4_lbl.Checked) RB_Shipping = UI_SK_CP_SP4_lbl;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB1 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB2 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB3 = false;
            Cls_SK_NormalClass.UI_SK_CP_SP_Bool_RB4 = true;
            Cls_SK_NormalClass.UI_SK_CP_SP_SQL = 4;
        }
    }
}
