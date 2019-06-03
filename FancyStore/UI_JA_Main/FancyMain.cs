﻿using Cls_Utility;
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

namespace UI_JA_Main
{
    public partial class FancyMain : Form
    {
        public FancyMain()
        {
            User data = Cls_JA_Member.UserDetail();
            Thread t = new Thread(new ThreadStart(delegate
           {
               Loading loading = new Loading();

               Application.Run(loading);

           }));
            t.Start();
           
            Thread.Sleep(3000);
            InitializeComponent();

            if (data.Admin) { button10.Visible = true; }
            MessageBox.Show(Cls_JA_Member.UserID.ToString());
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        private void FancyMain_Load(object sender, EventArgs e)
        {
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Left = ((Button)sender).Left;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool df = true;
        private void button8_Click(object sender, EventArgs e)
        {
            if (df)
            {
                UserDetail detail = new UserDetail();
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
                detail.Show();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ChangPW changPW = new ChangPW();
            changPW.密碼更改成功 += delegate
            {
                this.Close();
            };
            this.TopMost = false;
            changPW.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AllMemberList allMemberList = new AllMemberList();
            allMemberList.TopMost = true;
            allMemberList.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Favorite favorite = new Favorite();
            favorite.ShowDialog();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            IfMdown = false;
        }
    }
}

