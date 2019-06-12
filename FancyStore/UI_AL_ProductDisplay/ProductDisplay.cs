using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;
using Ctr_Customs;
using Cls_Utility;

namespace UI_AL_ProductDisplay
{
    public partial class ProductDisplay : Form
    {
        public ProductDisplay(int categorylargeID)
        {
            InitializeComponent();
            CategoryLargeID = categorylargeID;
            LoadAll(categorylargeID);
            Bar_BtnM.Left = Flp_CategoryM.Left + 3;
        }

        int CategoryLargeID;

        void LoadAll(int CategoryLargeID)
        {
            var categoryLquery = et.Products.Where(n => n.CategorySmall.CategoryMiddle.CategoryLarge.CategoryLID == CategoryLargeID).First();
            LoadM(CategoryLargeID);
            LoadS(categoryLquery.CategorySmall.CategoryMiddle.CategoryMID);
            LoadProduct(categoryLquery.CategorySID);
            LoadKeyword();
        }

        FancyStoreEntities et = new FancyStoreEntities();

        void LoadM(int lid)//產生中分類
        {
            var categoryMquery = et.CategoryMiddles.Where(n => n.CategoryLID == lid);
            Button Btn_M;
            foreach (var n in categoryMquery)
            {
                Btn_M = new Button
                {
                    Name = n.CategoryMID.ToString(),
                    Text = n.CategoryMName,
                    Height = Flp_CategoryM.Height,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("微軟正黑體", 12F, FontStyle.Bold),
                    Tag = n.CategoryMID
                };
                Btn_M.FlatAppearance.BorderSize = 0;
                Btn_M.Click += Btn_M_Click;
                Btn_M.Visible = false;
                Flp_CategoryM.Controls.Add(Btn_M);
                Bar_BtnM.Top = Btn_M.Height + Flp_CategoryM.Top - 2;
            }
        }

        private void Btn_M_Click(object sender, EventArgs e)
        {
            Flp_CategoryS.Controls.Clear();
            Flp_Products.Controls.Clear();
            LoadS(int.Parse(((Button)sender).Name));
            LoadProduct(first);
            Bar_BtnM.Left = Flp_CategoryM.Left + ((Button)sender).Left;
        }

        int count;//紀錄次數
        int first;//紀錄預設顯示的商品
        int set;//預設按鈕顏色

        void LoadS(int mid)//產生小分類
        {
            count += 1;
            var categorySquery = et.CategorySmalls.Where(n => n.CategoryMID == mid);
            Button Btn_S;
            foreach (var n in categorySquery)
            {
                Btn_S = new Button
                {
                    Name = n.CategorySID.ToString(),
                    Text = n.CategorySName,
                    Width = Flp_CategoryS.Width,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("微軟正黑體", 10F, FontStyle.Bold),
                    Tag = n.CategorySID,
                };
                if (set == 0)
                {
                    Btn_S.BackColor = System.Drawing.Color.Orange;
                    set = 1;
                }
                if (count == 2)
                {
                    Btn_S.BackColor = System.Drawing.Color.Orange;
                    first = n.CategorySID;//第一筆小分類的ID
                    count = 1;
                }
                Btn_S.FlatAppearance.BorderSize = 0;
                Btn_S.Click += Btn_S_Click;
                Flp_CategoryS.Controls.Add(Btn_S);
            }
            count = 1;
        }

        private void Btn_S_Click(object sender, EventArgs e)
        {
            foreach (Button btn_S in Flp_CategoryS.Controls)//點擊的那項改變顏色
            {
                btn_S.BackColor = Flp_CategoryS.BackColor;
            }
            ((Button)sender).BackColor = System.Drawing.Color.Orange;
            Flp_Products.Controls.Clear();
            LoadProduct(int.Parse(((Button)sender).Name));
        }

        void LoadProduct(int sid)//產生商品
        {
            var productquery = et.Products.Where(n => n.CategorySID == sid && n.ProductInDate <= DateTime.Now && n.ProductOutDate >= DateTime.Now);
            CreateProduct(productquery);
        }

        private void flowLayoutPanel3_Resize(object sender, EventArgs e)
        {
        }

        void CreateProduct(IQueryable<Product> productquery)
        {
            AL_ProductInfo info;
            foreach (var n in productquery)
            {
                var photoquery = et.ProductPhotoes.Where(m => m.ProductID == n.ProductID);
                var favoritequery = et.MyFavorites.Any(o =>o.UserID== Cls_JA_Member.UserID && o.ProductID == n.ProductID);
                info = new AL_ProductInfo
                {
                    PName = n.ProductName,
                    PPrice = n.UnitPrice,
                    ProductID = n.ProductID,
                    Picturebyte = photoquery.First().Photo.Photo1
                };
                info.AddFav += (a, b) =>//委派加入我的最愛
                {
                    et.MyFavorites.Add(new MyFavorite { UserID = Cls_JA_Member.UserID, ProductID = n.ProductID, CreateDate = DateTime.Now });
                    et.SaveChanges();
                };
                info.RemoveFav += (a, b) =>//委派刪除我的最愛
                {
                    var q3 = et.MyFavorites.Where(p => p.UserID == Cls_JA_Member.UserID && p.ProductID == n.ProductID).First();
                    et.MyFavorites.Remove(q3);
                    et.SaveChanges();
                };
                var cartquery = Cls_Utility.Class1.CartList.Any(m => m.ProductID == n.ProductID);
                if (cartquery)
                    info.buy = true;
                else
                    info.buy = false;
                if (favoritequery)
                    info.like = true;
                else
                    info.like = false;
                Flp_Products.Controls.Add(info);
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Flp_Products.Controls.Clear();
            var q = et.Products.Where(n => n.ProductName.Contains(Tb_Searchbox.Text.Trim()) && n.ProductInDate <= DateTime.Now && n.ProductOutDate >= DateTime.Now);
            if (q.Count() > 0)
                CreateProduct(q);
            else
            {
                MessageBox.Show("查無產品");//強制跳回第一項
                var q1 = et.Products.Where(n => n.CategorySmall.CategoryMiddle.CategoryLID == CategoryLargeID).Select(n=>n.CategorySID).First();
                LoadProduct(q1);
                int first = 0;
                foreach (Button btn_S in Flp_CategoryS.Controls)
                {
                    btn_S.BackColor = Flp_CategoryS.BackColor;
                    if (first == 0)
                    {
                        btn_S.BackColor = System.Drawing.Color.Orange;
                        first = 1;
                    }
                }
            }
        }

        void LoadKeyword()
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            var keywordquery = et.KeyWords.Take(3);
            foreach (var n in keywordquery)
            {
                source.Add(n.Keyword1);
            }
            Tb_Searchbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            Tb_Searchbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Tb_Searchbox.AutoCompleteCustomSource = source;
        }

    }
}
