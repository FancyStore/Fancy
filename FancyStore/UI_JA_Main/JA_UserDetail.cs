using Cls_Utility;
using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_JA_Main
{

    public partial class JA_UserDetail : Form
    {
        public event Action 關閉了;
        DbSet<DB_Fancy.Region> allregion = Cls_JA_Member.db.Regions;
        User data = Cls_JA_Member.UserDetail();
        public JA_UserDetail()
        {

            InitializeComponent();

            this.City.DataSource = Cls_JA_Member.db.Cities.Select(n => n.CityName).ToList();
            this.City.SelectedItem = data.Region.City.CityName;
            this.MYRegion.DataSource = allregion
                .Where(n => n.City.CityName == data.Region.City.CityName)
                .Select(n => n.RegionName).ToList();
            this.MYRegion.SelectedItem = data.Region.RegionName;
            this.Email.Text = data.Email;
            this.label1.Text = data.UserName;
            this.Phone.Text = data.Phone;
            this.Address.Text = data.Address;
            this.日期.Text = data.RegistrationDate.ToShortDateString();
            if (Cls_JA_Member.db.OrderDetails.Any(n => n.OrderHeader.UserID == Cls_JA_Member.UserID))
            {
                var sum = Cls_JA_Member.db.OrderDetails.Where(n => n.OrderHeader.UserID == Cls_JA_Member.UserID)
                .Sum(n => n.UnitPrice * n.OrderQTY);
                this.金額.Text = $"{sum:c0}";
            }
            else { this.金額.Text = $"0:c0"; }
            byte[] q;
            if (data.PhotoID == null)
            { q = Cls_JA_Member.db.Photos.Where(n => n.PhotoID == 1).Select(n => n.Photo1).First(); }
            else
            { q = data.Photo.Photo1; }
            using (MemoryStream ms = new MemoryStream(q))
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox1.Width = 100;
                this.pictureBox1.Height = 100;
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (關閉了 != null)
            {
                關閉了();
            }
            this.TopMost = false;
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            int dl = 0;
            t.Tick += delegate
            {
                if (dl < this.Width + 10)
                {
                    this.Left -= 25;
                    dl += 25;
                }
                else { t.Stop(); dl = this.Left; this.Close(); }
            };

        }
        private void City_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MYRegion.DataSource = allregion
                .Where(n => n.City.CityName == ((ComboBox)sender).SelectedItem
                .ToString()).Select(n => n.RegionName).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User data = Cls_JA_Member.UserDetail();

            if (FileName != null)
            {
                if (data.PhotoID != 1)
                {
                    if (Cls_JA_Member.UserUppic(FileName))
                    { MessageBox.Show("上傳成功"); FileName = ""; }
                    else
                    { MessageBox.Show("上傳失敗"); }
                }
                else
                {
                    if (Cls_JA_Member.UpLoadPic(FileName))
                    { MessageBox.Show("新增成功"); }
                    else
                    { MessageBox.Show("上傳失敗"); }
                }

            }
        }
        string FileName;
        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = this.openFileDialog1.FileName;
                FileName = this.openFileDialog1.FileName;
            }
        }

        private void 修改信箱_Click(object sender, EventArgs e)
        {
            if (!this.Email.Enabled)
            {
                this.修改信箱.Text = "確認修改";
                this.Email.Enabled = true;
            }
            else
            {
                if (Cls_JA_Member.UpdateEmail(this.Email.Text))
                {
                    MessageBox.Show("修改成功");
                    this.修改信箱.Text = "修改";
                    this.Email.Enabled = false;
                }
                else
                {
                    MessageBox.Show("修改失敗");
                }
            }
        }

        private void 修改手機_Click(object sender, EventArgs e)
        {
            if (!this.Phone.Enabled)
            {
                this.修改手機.Text = "確認修改";
                this.Phone.Enabled = true;
            }
            else
            {
                if (Cls_JA_Member.UpdatePhone(this.Phone.Text))
                {
                    MessageBox.Show("修改成功");
                    this.修改手機.Text = "修改";
                    this.Phone.Enabled = false;
                }
                else
                { MessageBox.Show("修改失敗"); }
            }
        }

        private void 修改地址_Click(object sender, EventArgs e)
        {
            if (!this.City.Enabled)
            {
                this.修改地址.Text = "確認修改";
                this.City.Enabled = true;
                this.MYRegion.Enabled = true;
                this.Address.Enabled = true;
            }
            else
            {
                string R = this.MYRegion.SelectedValue.ToString();
                string A = this.Address.Text;
                if (Cls_JA_Member.UpdateAddress(R, A))
                {
                    MessageBox.Show("修改成功");
                    this.修改地址.Text = "修改";
                    this.Address.Enabled = false;
                    this.City.Enabled = false;
                    this.MYRegion.Enabled = false;
                }
                else
                {
                    MessageBox.Show("修改失敗");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FileName != null) { this.button3.Visible = true; }
        }
    }
}
