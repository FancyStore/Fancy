using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UI_AL_ProductDetail;

namespace Ctr_Customs
{
    public partial class AL_ProductInfo : UserControl
    {

        public AL_ProductInfo()
        {
            InitializeComponent();
        }

        public EventHandler AddFav;
        public EventHandler RemoveFav;
        //public EventHandler Incart;
        //public EventHandler Offcart;

        public string PName { set { Lbl_Name.Text = value; } }
        public int PPrice { set { Lbl_Price.Text = value.ToString("C0"); } }
        public int ProductID { get; set; }
        public byte[] Picturebyte//set圖片的二進位資料
        {
            set
            {
                MemoryStream ms = new MemoryStream(value);
                Pb_Productimage.Image = Image.FromStream(ms);
                ms.Dispose();
            }
        }
        public bool like;
        public bool buy;

        private void AL_ProductInfo_Load(object sender, EventArgs e)
        {
            if (like)
                Btn_Favorite.Image = imageList1.Images[1];
            else
                Btn_Favorite.Image = imageList1.Images[0];
            if (buy)
                Pb_Cartstatus.Image = imageList1.Images[3];
            else
                Pb_Cartstatus.Image = imageList1.Images[2];

            foreach (Control c in P_Buttom.Controls)//設定元件的enter&leave
            {
                c.MouseEnter += AL_ProductInfo_MouseEnter;
                c.MouseLeave += AL_ProductInfo_MouseLeave;
                if (!(c is Button))//設定非按鈕的元件點擊觸發new form
                    c.Click += C_Click;
            }
        }

        private void Btn_Favorite_Click(object sender, EventArgs e)
        {
            if (like)
            {
                Btn_Favorite.Image = imageList1.Images[0];
                RemoveFav(sender, e);
            }
            else
            {
                Btn_Favorite.Image = imageList1.Images[1];
                AddFav(sender, e);
            }
            like = !like;
        }

        private void C_Click(object sender, EventArgs e)
        {
            ProductDetail a = new ProductDetail(ProductID,InCart);
            a.ShowDialog();
        }

        private void AL_ProductInfo_MouseLeave(object sender, EventArgs e)
        {
            P_Buttom.BackColor = Color.White;
        }

        private void AL_ProductInfo_MouseEnter(object sender, EventArgs e)
        {
            P_Buttom.BackColor = Color.AliceBlue;
        }

        void InCart()
        {
            Pb_Cartstatus.Image = imageList1.Images[3];
        }
    }
}
