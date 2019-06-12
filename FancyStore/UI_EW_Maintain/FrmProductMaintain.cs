using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;
using Cls_Utility;

namespace UI_EW_Maintain
{
    public partial class FrmProductMaintain : Form
    {
        public FrmProductMaintain()
        {
            InitializeComponent();
        }

        public FrmProductMaintain(string status, Product prod)
        {
            InitializeComponent();
            FormStatus = status;
            cProd = prod;  //由上一個Form傳過來Product類別的值

            //將cbCategory給DataSource
            var q = dbContext.VW_EW_CategorySML;
            vWEWCategorySMLBindingSource.DataSource = q.ToList();
            this.cbCategoryS.SelectedValue = _clsProd._CategorySID = cProd.CategorySID;

            //將cbSupplier給DataSource
            var s = dbContext.Suppliers.OrderBy(x=>x.SupplierID).ToList();
            vWEWSupplierBindingSource.DataSource = s.ToList();

            switch (FormStatus)    //顯示狀態
            {
                case "C":
                    this.lblStatus.Text = " 新增 ";
                    this.txtProductID.Text = "";
                    this.cbSupplier.SelectedValue = cProd.SupplierID = 2;
                    break;
                case "U":
                    this.lblStatus.Text = " 修改 ";
                    this.txtProductID.Text = cProd.ProductID.ToString();
                    this.txtDescription.Text = cProd.Desctiption;
                    this.txtProductName.Text = cProd.ProductName;
                    this.txtUnitPrice.Text = cProd.UnitPrice.ToString();
                    this.cbSupplier.SelectedValue = (Object)cProd.SupplierID;
                    this.dateTimePicker1.Text = cProd.ProductInDate.ToString();
                    this.dateTimePicker2.Text = cProd.ProductOutDate.ToString();
                    break;
            }
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        string FormStatus;  //狀態 : C 新增 / U 修改
        Product cProd = new Product(); //接收前一個Form傳來的product資料


        private void FrmProductMaintain_Load(object sender, EventArgs e)
        {

            //檢查是否有空白的欄位
            //this.btnInsert.Enabled = false;

            foreach (Control x in this.Controls)
            {
                if (x is TextBox && x.Name != "txtProductID")  //不包含ProductID欄位
                {
                    x.TextChanged += X_TextChanged;
                }
            }
        }

        //檢查是否有空白的欄位
        private void X_TextChanged(object sender, EventArgs e)
        {
            this.btnInsert.Enabled = true;

            foreach (Control x in this.Controls)
            {
                if (x is TextBox && x.Name != "txtProductID")   //不包含ProductID欄位
                {
                    if (x.Text.Trim() == "")
                    {
                        this.btnInsert.Enabled = false;
                        return;   //跳離方法
                    }
                }
            }
        }

        //存檔
        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (!ValidationFields())  //欄位驗證不通過則離開, 不做任何處理
            { return; }

            if (FormStatus == "C")   //新增
            { cProd = new Product(); }

            cProd.Desctiption = this.txtDescription.Text;
            cProd.ProductName = this.txtProductName.Text;
            cProd.UnitPrice = int.Parse(this.txtUnitPrice.Text);
            cProd.CategorySID = _clsProd._CategorySID = int.Parse(this.cbCategoryS.SelectedValue.ToString());
            cProd.SupplierID = (int)cbSupplier.SelectedValue;
            cProd.ProductInDate = DateTime.Parse(this.dateTimePicker1.Text);
            cProd.ProductOutDate = DateTime.Parse(this.dateTimePicker2.Text);
            cProd.CreateDate = DateTime.Now;

            if (FormStatus == "C")   //新增
            {
                if (cProd.ProductID > 0)
                {
                    MessageBox.Show("資料已 [新增] , 若要修改欄位資料, 請使用 [更改] !");
                    return;
                }

                try
                {
                    dbContext.Products.Add(cProd);
               
                    this.dbContext.SaveChanges();

                    int i = cProd.ProductID;  //取得資料庫自增ID
                    MessageBox.Show($"產品 [新增] 資料成功 => ID: {i} ");
                    txtProductID.Text = cProd.ProductID.ToString();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    MessageBox.Show("產品 [新增] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !");
                    txtProductID.Text = "";
                }
                return;
            }

            if (FormStatus == "U")  //修改
            {
                try
                {
                    var q = dbContext.Products.Find(cProd.ProductID);

                    q.ProductName = cProd.ProductName;
                    q.Desctiption = cProd.Desctiption;
                    q.CategorySID = _clsProd._CategorySID = cProd.CategorySID;
                    q.SupplierID = cProd.SupplierID;
                    q.UnitPrice = cProd.UnitPrice;
                    q.ProductInDate = cProd.ProductInDate;
                    q.ProductOutDate = cProd.ProductOutDate;

                    this.dbContext.SaveChanges();
                    MessageBox.Show($"產品: {cProd.ProductID}  [修改] 資料成功 !");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    { MessageBox.Show($"產品: {cProd.ProductID} [修改] 資料失敗, 請檢查欄位資料後再試一下, 或找系統管理員協助處理 !"); }
                }
                return;
            }
        }

        //驗證欄位
        bool ValidationFields()
        {
            //驗證產品單價
            decimal unitPirce;
            if (decimal.TryParse(txtUnitPrice.Text, out unitPirce))
            { this.errorProvider1.SetError(txtUnitPrice, ""); }
            else
            {
                this.errorProvider1.SetError(txtUnitPrice, "[單價] 必須為數字 !");
                txtUnitPrice.Text = "";
                txtUnitPrice.Focus();
                return false;
            }

            if (DateTime.Parse(dateTimePicker1.Text) > DateTime.Parse(dateTimePicker2.Text))
            {
                this.errorProvider1.SetError(dateTimePicker2, "[下架日期] 不可小於 [上架日期] !");
                dateTimePicker2.Text = dateTimePicker1.Text;
                dateTimePicker2.Focus();
                return false;
            }
            else
            { this.errorProvider1.SetError(dateTimePicker2, ""); }

            return true;
        }

        private void FrmProductMaintain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbContext.Dispose();
        }

        //圖片
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (cProd.ProductID == 0)
            {
                MessageBox.Show($"請先將產品資料 [存檔] 後再執行本作業 !");
                return;
            }
            FrmProductPhoto f = new FrmProductPhoto(cProd);
            f.ShowDialog();
        }

        //顏色
        private void btnColot_Click(object sender, EventArgs e)
        {
            if (cProd.ProductID == 0)
            {
                MessageBox.Show($"請先將產品資料 [存檔] 後再執行本作業 !");
                return;
            }
            FrmProductColor f = new FrmProductColor(cProd);
            f.ShowDialog();
        }

        //尺吋大小
        private void btnSize_Click(object sender, EventArgs e)
        {
            if (cProd.ProductID == 0)
            {
                MessageBox.Show($"請先將產品資料 [存檔] 後再執行本作業 !");
                return;
            }
            FrmProductSize f = new FrmProductSize(cProd);
            f.ShowDialog();
        }

        //洗滌方式
        private void btnWashing_Click(object sender, EventArgs e)
        {
            if (cProd.ProductID == 0)
            {
                MessageBox.Show($"請先將產品資料 [存檔] 後再執行本作業 !");
                return;
            }
            FrmProductWashing f = new FrmProductWashing(cProd);
            f.ShowDialog();
        }

        //庫存量
        private void btnStock_Click(object sender, EventArgs e)
        {
            if (cProd.ProductID == 0)
            {
                MessageBox.Show($"請先將產品資料 [存檔] 後再執行本作業 !");
                return;
            }
            FrmProductStock f = new FrmProductStock(cProd);
            f.ShowDialog();
        }
    }
}
