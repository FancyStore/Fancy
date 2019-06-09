using Cls_Utility;
using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UI_AL_ProductDetail
{
    public partial class ProductDetail : Form
    {
        public ProductDetail(int ProductID,Action func)
        {
            InitializeComponent();
            LoadDetail(ProductID);
            LoadWash(ProductID);
            LoadColor(ProductID);
            LoadSize(ProductID);
            LoadImage(ProductID);
            Checkqty();
            Bar_Color.Left = Flp_Color.Left + 3;
            Bar_Size.Left = Flp_Size.Left + 3;
            add = func;
        }

        Action add;
        int colordefault;//記預設點選顏色
        int sizedefault;//記預設點選尺寸
        int itemID;//記購買產品ID
        string itemName;
        int itemCategorySID;//記購買產品S分類
        int itemSizeID;//記購買產品尺寸
        string itemSizeName;
        int itemColorID;//記購買產品顏色
        string itemColorName;
        decimal itemUnitPrice;

        FancyStoreEntities et = new FancyStoreEntities();
        int count;

        void LoadDetail(int ProductID)
        {
            var productquery = et.Products.Where(n => n.ProductID == ProductID).First();
            Lbl_Name.Text = productquery.ProductName;//商品名
            Lbl_Description.Text = productquery.Desctiption;//商品敘述
            Lbl_Price.Text = productquery.UnitPrice.ToString("C0");//商品價錢

            itemID = productquery.ProductID;
            itemName = productquery.ProductName;
            itemCategorySID = productquery.CategorySID;
            itemUnitPrice = productquery.UnitPrice;
        }

        void LoadWash(int ProductID)
        {
            var washingquery = et.ProductWashings.Where(m => m.ProductID == ProductID);
            foreach (var n in washingquery)//產生洗滌資訊
            {
                Label Lbl_Washing = new Label();
                Lbl_Washing.AutoSize = false;
                Lbl_Washing.Width = Flp_Washing.Width;
                Lbl_Washing.Height=40;
                Lbl_Washing.Font = new Font("微軟正黑體", 10F);
                Lbl_Washing.Text = n.Washing.WashingName;
                Flp_Washing.Controls.Add(Lbl_Washing);
            }
        }

        void LoadColor(int ProductID)
        {
            var colorquery = et.ProductColors.Where(m => m.ProductID == ProductID);
            foreach (var n in colorquery)//產生商品顏色
            {
                Button Btn_Color = new Button();
                Btn_Color.Name = n.Color.ColorName;
                Btn_Color.BackColor = System.Drawing.Color.FromArgb((int)n.Color.R, (int)n.Color.G, (int)n.Color.B);
                Btn_Color.Tag = n.ProductColorID;
                Btn_Color.FlatStyle = FlatStyle.Flat;
                Btn_Color.FlatAppearance.BorderSize = 0;
                toolTip1.SetToolTip(Btn_Color, n.Color.ColorName);
                Btn_Color.MouseEnter += Btn_Color_Enter;
                Btn_Color.Click += Btn_Color_Click;
                Flp_Color.Controls.Add(Btn_Color);
                Bar_Color.Top = Flp_Color.Top + Btn_Color.Height + Btn_Color.Top - 4;
                if (colordefault == 0)//預設顏色
                {
                    itemColorID = n.ProductColorID;
                    itemColorName = Btn_Color.Name;
                    colordefault = 1;
                }
            }
        }

        private void Btn_Color_Click(object sender, EventArgs e)
        {
            Bar_Color.Left = ((Button)sender).Left + Flp_Color.Left;
            Bar_Color.Top = ((Button)sender).Top + ((Button)sender).Height + Flp_Color.Top - 4;
            itemColorID = (int)((Button)sender).Tag;
            itemColorName = ((Button)sender).Name;
            Checkqty();
        }

        private void Btn_Color_Enter(object sender, EventArgs e)//觸碰顏色改照片
        {
            var photoidquery = et.ProductColors.Where(n => n.ProductColorID == (int)((Button)sender).Tag).Select(n => n.PhotoID).First();
            var photoquery = et.Photos.Where(n => n.PhotoID == photoidquery).Select(n => n.Photo1);
            GetPicture(Pb_Productimage, photoquery.First());
        }

        void LoadSize(int ProductID)
        {
            var sizequery = et.ProductSizes.Where(m => m.ProductID == ProductID);
            foreach (var n in sizequery)//產生商品尺寸
            {
                Button Btn_Size = new Button();
                Btn_Size.Name = n.Size.SizeName;
                Btn_Size.BackColor = System.Drawing.Color.GhostWhite;
                Btn_Size.Text = n.Size.SizeName;
                Btn_Size.Font = new Font("微軟正黑體", 10F, FontStyle.Bold);
                Btn_Size.Tag = n.ProductSizeID;
                Btn_Size.FlatStyle = FlatStyle.Flat;
                Btn_Size.FlatAppearance.BorderSize = 0;
                Btn_Size.Click += Btn_Size_Click;
                Flp_Size.Controls.Add(Btn_Size);
                Bar_Size.Top = Flp_Size.Top + Btn_Size.Height + Btn_Size.Top - 4;
                if (sizedefault == 0)//預設尺寸
                {
                    itemSizeID = n.ProductSizeID;
                    itemSizeName = Btn_Size.Name;
                    sizedefault = 1;
                }
            }
        }

        private void Btn_Size_Click(object sender, EventArgs e)
        {
            Bar_Size.Left = ((Button)sender).Left + Flp_Size.Left;
            itemSizeID = (int)((Button)sender).Tag;
            itemSizeName = ((Button)sender).Name;
            Checkqty();
        }

        void LoadImage(int ProductID)
        {
            var photoquery = et.ProductPhotoes.Where(m => m.ProductID == ProductID);
            foreach (var n in photoquery)//產生商品照片
            {
                PictureBox Pb_Image = new PictureBox();
                Pb_Image.Height = 70;
                Pb_Image.Width = 70;
                Pb_Image.SizeMode = PictureBoxSizeMode.StretchImage;
                Pb_Image.Tag = n.Photo.Photo1;
                GetPicture(Pb_Image, n.Photo.Photo1);
                Pb_Image.MouseEnter += Pb_Image_MouseEnter;
                Flp_Images.Controls.Add(Pb_Image);
                if (count == 0)
                {
                    GetPicture(Pb_Productimage, n.Photo.Photo1);
                    count = 1;
                }
            }
        }

        private void Pb_Image_MouseEnter(object sender, EventArgs e)//觸碰圖片改照片
        {
            GetPicture(Pb_Productimage, (byte[])((PictureBox)sender).Tag);
        }


        void GetPicture(PictureBox p, byte[] photo)//讀取圖片
        {
            MemoryStream ms = new MemoryStream(photo);
            p.Image = Image.FromStream(ms);
            ms.Dispose();
        }

        private void Btn_Addcart_Click(object sender, EventArgs e)
        {
            CartItem item = new CartItem();
            item.UserID = Cls_JA_Member.UserID;
            item.ProductID = itemID;
            item.ProductName = itemName;
            item.CategorySID = itemCategorySID;
            item.ProductSizeID = itemSizeID;
            item.ProductSizeName = itemSizeName;
            item.ProductColorID = itemColorID;
            item.ProductColorName = itemColorName;
            item.Qty = (int)Nud_QTY.Value;
            item.UnitPrice = itemUnitPrice;
            Cls_Utility.Class1.CartList.Add(item);
            MessageBox.Show("加入成功");
            Checkqty();
            add();
        }

        void Checkqty()
        {
            try
            {
                var q = et.ProductStocks.Where(n => n.ProductID == itemID && n.ProductColorID == itemColorID && n.ProductSizeID == itemSizeID).First();
                if (q.StockQTY != 0)
                {
                    Btn_Addcart.Enabled = true;
                    Btn_Addcart.Text = "加入購物車";
                    Nud_QTY.Enabled = true;
                    Nud_QTY.Maximum = q.StockQTY;
                }
                else
                {
                    Btn_Addcart.Enabled = false;
                    Btn_Addcart.Text = "庫存不足";
                    Nud_QTY.Enabled = false;
                }
                Nud_QTY.Value = 1;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("庫存沒資料");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = Cls_Utility.Class1.CartList;
        }
    }
}
