using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Fancy;

namespace UI_AL_Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Addnews();
            Wait();
        }
        FancyStoreEntities et = new FancyStoreEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        void Addnews()
        {
            var q = et.NewsLists.ToList();
            for(int i=0;i<=q.Count-1;i++)
            {
                PictureBox b = new PictureBox { Width = 300, Height = 300, BackColor = System.Drawing.Color.Blue, Margin = new Padding(0), BorderStyle = BorderStyle.Fixed3D,Image=imageList1.Images[i] };
                flowLayoutPanel1.Controls.Add(b);
            }
        }

        void Wait()
        {
            Thread.Sleep(1000);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = 0;
            foreach (PictureBox p in flowLayoutPanel1.Controls)
            {
                p.MouseHover += P_MouseHover;
                p.MouseLeave += P_MouseLeave;
                if (count == 0)
                {
                    if (p.Width <= 0)
                    {
                        //Thread.Sleep(1000);
                        flowLayoutPanel1.Controls.Remove(p);
                        if (flowLayoutPanel1.Controls.Count <= 3)
                            Addnews();
                        //flowLayoutPanel1.Controls.Add(new PictureBox { BackColor = System.Drawing.Color.Green, Width = 300, Height = 300, Margin = new Padding(0), BorderStyle = BorderStyle.Fixed3D });
                        //MessageBox.Show(p.Location.X + "" + p.Location.Y);
                        //timer1.Enabled = false;
                    }
                    else
                    p.Width -= 5;
                }
                count = 1;
            }
        }

        private void P_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void P_MouseHover(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
