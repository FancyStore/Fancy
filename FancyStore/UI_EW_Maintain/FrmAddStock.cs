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

namespace UI_EW_Maintain
{
    public partial class FrmAddStock : Form
    {
        public FrmAddStock()
        {
            InitializeComponent();
        }

        FancyStoreEntities dbContext = new FancyStoreEntities();
        ProductStock prodStock = new ProductStock();

        private void FrmAddStock_Load(object sender, EventArgs e)
        {
            ResetData();
        }

        void ResetData()
        {
            dbContext = new FancyStoreEntities();

            var p = dbContext.Products;
            productBindingSource.DataSource = p.ToList();

            var c = dbContext.VW_EW_ProductColor;
            vWEWProductColorBindingSource.DataSource = c.ToList();

            var s = dbContext.VW_EW_ProductSize;
            vWEWProductSizeBindingSource.DataSource = s.ToList();

            var q = dbContext.ProductStocks.Where(x => x.StockQTY < x.MinStock).OrderBy(x=>x.StockQTY);
            productStockBindingSource.DataSource = q.ToList();
            productStockDataGridView.DataSource = productStockBindingSource;
        }

        private void productStockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductStock ps = new ProductStock();

            switch (e.ColumnIndex)
            {
                case 1:  //存檔
                    try
                    {
                        ps.StockID = ((ProductStock)productStockBindingSource.Current).StockID;

                        int addQty;

                        if (!int.TryParse(productStockDataGridView[5, e.RowIndex].Value.ToString(), out addQty))
                        {
                            addQty = 0;
                        }
                        //MessageBox.Show($"cell={productStockDataGridView[5, e.RowIndex].Value} => addQty= {addQty}");
                        var q = dbContext.ProductStocks.Find(ps.StockID);

                        q.StockQTY = ((ProductStock)productStockBindingSource.Current).StockQTY + addQty;

                        this.dbContext.SaveChanges();

                        ResetData();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    break;
            }
        }
    }
}
