using Cls_Utility;
using DB_Fancy;
using Microsoft.SqlServer.Server;
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
using static System.Windows.Forms.DataFormats;
using Timer = System.Windows.Forms.Timer;
using UI_AL_ProductDisplay;
using UI_EW_Maintain;
using UI_AL_Home;
using UI_AL_AboutUs;
using UI_SK_ShoppingCart;

namespace UI_JA_Main
{
    public partial class JA_FancyMain : Form
    {
        public JA_FancyMain()
        {
            Cls_JA_Member.IsAdmin = Cls_JA_Member.UserDetail().Admin;
            Thread t = new Thread(new ThreadStart(delegate
           {
               JA_Loading loading = new JA_Loading();

               Application.Run(loading);

           }));
            t.Start();
           
            Thread.Sleep(2000);
            InitializeComponent();

            if (Cls_JA_Member.IsAdmin)
            {
                button10.Visible = true;
            }          
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
        }


        private void FancyMain_Load(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            Home p = new Home();
            p.TopLevel = false;
            panel6.Controls.Add(p);
            p.Dock = DockStyle.Fill;
            p.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        bool userCheck = true;
        private void button1_Click(object sender, EventArgs e)
        {
            userCheck = !userCheck;
            Timer tim = new Timer();
            tim.Interval = 10;
            tim.Start();
            tim.Tick += delegate
            {
                if (userCheck)
                {
                    if (this.panel1.Width != 200) { this.panel1.Width += 10; }
                    else { tim.Stop(); tim.Dispose(); }
                }
                else
                {
                    if (this.panel1.Width != 0) { this.panel1.Width -= 10; }
                    else { tim.Stop(); tim.Dispose(); }
                }
            };
        }
        bool IfMdown = false;
        int NowX, NowY;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (IfMdown)
            {
                this.Location = new Point(this.Left += e.X - NowX, this.Top += e.Y - NowY);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            IfMdown = true;
            NowX = e.X;
            NowY = e.Y;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
            panel6.Controls.Clear();
            Home p = new Home();
            p.TopLevel = false;
            panel6.Controls.Add(p);
            p.Dock = DockStyle.Fill;
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
            panel6.Controls.Clear();
            AboutUs p = new AboutUs();
            p.TopLevel = false;
            panel6.Controls.Add(p);
            p.Dock = DockStyle.Fill;
            p.Show();
        }
        //衣料品
        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
            panel6.Controls.Clear();
            ProductDisplay p = new ProductDisplay(1);
            p.TopLevel = false;
            panel6.Controls.Add(p);
            p.Dock = DockStyle.Fill;
            p.Show();
        }
        //下半身
        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
            panel6.Controls.Clear();
            ProductDisplay p = new ProductDisplay(2);
            p.TopLevel = false;
            panel6.Controls.Add(p);
            p.Dock = DockStyle.Fill;
            p.Show();
        }

        //配件
        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
            panel6.Controls.Clear();
            ProductDisplay p = new ProductDisplay(5);
            p.TopLevel = false;
            panel6.Controls.Add(p);
            p.Dock = DockStyle.Fill;
            p.Show();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool df = true;
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (df)
                {
                    JA_UserDetail detail = new JA_UserDetail();
                    detail.Show();
                    detail.Shown += (s, ee) =>
                    {
                        detail.Left = (this.Left + this.Width) - detail.Width;
                        detail.Top = this.Top;
                        TopMost = false;
                        Timer t = new Timer();
                        t.Interval = 10;
                        t.Start();
                        int dl = 0;
                        t.Tick += delegate
                        {
                            if (dl <= 450)
                            {
                                detail.Left += 25;
                                dl += 25;
                            }
                            else { t.Stop(); dl = detail.Left; df = false; }
                        };
                    };
                    detail.關閉了 += delegate
                    {
                        df = true;
                        this.TopMost = true;
                    };

                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            JA_ChangPW changPW = new JA_ChangPW();
            changPW.密碼更改成功 += delegate
            {
                this.Close();
            };
            this.TopMost = false;
            changPW.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            JA_AllMemberList allMemberList = new JA_AllMemberList();
            this.TopMost = false;
            allMemberList.ShowDialog();
        }

       private void button11_Click(object sender, EventArgs e)
        {
            JA_OrdersSearch ordersSearch = new JA_OrdersSearch();
            this.TopMost = false;
            ordersSearch.ShowDialog();

        }

        //我的最愛
        private void button9_Click(object sender, EventArgs e)
        {
            JA_Favorite favorite = new JA_Favorite();
            this.TopMost = false;
            favorite.ShowDialog();
            button5_Click(button5, e);
        }

        //購物車
        private void button2_Click(object sender, EventArgs e)
        {
            //FrmCart f = new FrmCart();
            //this.TopMost = false;
            //f.ShowDialog();
            UI_SK_MainCart UISKMC = new UI_SK_MainCart();
            //UI_SK_ChoosePay UISKCP = new UI_SK_ChoosePay();
            UISKMC.ShowDialog();
            button5_Click(button5, e);

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            IfMdown = false;
        }
    }
}

