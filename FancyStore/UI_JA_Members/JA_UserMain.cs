using Cls_Utility;
using DB_Fancy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_JA_Main;

namespace UI_JA_Members
{
    public partial class JA_UserMain : Form
    {
        public JA_UserMain()
        {
            InitializeComponent();
            this.Gender.SelectedIndex = 0;
            this.jA_Input6.texboxsetting = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.jA_Input1.輸入塊字串 = "Jay";
            this.jA_Input2.輸入塊字串 = "123";
            this.jA_Input3.輸入塊字串 = "stepmania003@gmail.com";
            this.jA_Input4.輸入塊字串 = "0979325992";
            Gender.SelectedIndex = 1;
        }
        //註冊
        private void button8_Click(object sender, EventArgs e)
        {

            foreach (var item in SingUp_panel.Controls)
            {
                if (item is JA_Input)
                {
                    if (((JA_Input)item).輸入塊字串.Trim() == "")
                    {
                        MessageBox.Show("欄位不可空百");
                        return;
                    }
                }
            }
            if (!Cls_JA_IDo.IsValidEmail(this.jA_Input3.輸入塊字串))
            {
                this.jA_Input3.警告 = System.Drawing.Color.FromArgb(244, 67, 54);
                return;
            }
            if (!Cls_JA_IDo.IsValidPhone(this.jA_Input4.輸入塊字串))
            {
                this.jA_Input4.警告 = System.Drawing.Color.FromArgb(244, 67, 54);
                return;
            }
            string guid = Guid.NewGuid().ToString("N");
            User newuser = new User
            {
                UserName = this.jA_Input1.輸入塊字串,
                UserPassword = Cls_JA_IDo.HashPw(this.jA_Input2.輸入塊字串, guid),
                GUID = guid,
                Email = this.jA_Input3.輸入塊字串,
                Phone = this.jA_Input4.輸入塊字串,
                RegionID = 1,
                Address = "",
                RegistrationDate = DateTime.Now,
                Enabled = true,
                Gender = this.Gender.SelectedItem.ToString().Equals("男")
            };
            try
            {
                if (Cls_JA_Member.Register(newuser))
                {
                    MessageBox.Show("成功");
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

        }
        //登入
        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Cls_JA_Member.VaildateUser(this.jA_Input5.輸入塊字串, this.jA_Input6.輸入塊字串))
                {
                    this.Hide();
                    MessageBox.Show("成功");
                    JA_FancyMain fancyMain = new JA_FancyMain();
                    fancyMain.FormClosing += (s, ee) =>
                    {
                        this.Show();
                    };
                    fancyMain.Show();
                }
                else
                {
                    this.jA_Input5.Focus();
                    this.jA_Input5.輸入塊字串 = this.jA_Input6.輸入塊字串 = "";
                    this.jA_Input5.警告 = System.Drawing.Color.FromArgb(244, 67, 54);
                    this.jA_Input6.警告 = System.Drawing.Color.FromArgb(244, 67, 54);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;

            foreach (var item in SingUp_panel.Controls)
            {
                if (item is JA_Input)
                {
                    ((JA_Input)item).輸入塊字串 = "";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.SingUp_panel.Left < 1000)
            {
                SingUp_panel.Left += 20;
            }
            else
            {
                if (Login_panel.Left > 490)
                {
                    Login_panel.Left -= 20;
                }
                else
                {
                    this.timer1.Enabled = false;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
            this.jA_Input5.輸入塊字串 = this.jA_Input6.輸入塊字串 = "";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.SingUp_panel.Left > 490)
            {
                SingUp_panel.Left -= 20;
            }
            else
            {
                if (Login_panel.Left < 1000)
                {
                    Login_panel.Left += 20;
                }
                else { this.timer2.Enabled = false; }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.timer4.Enabled = true;
            this.jA_Input5.輸入塊字串 = this.jA_Input6.輸入塊字串 = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.timer3.Enabled = true;
            this.jA_Input7.輸入塊字串 = this.jA_Input8.輸入塊字串 = "";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.fg_panel.Left < 1000)
            {
                fg_panel.Left += 20;
            }
            else
            {
                if (Login_panel.Left > 490)
                {
                    Login_panel.Left -= 20;
                }
                else { this.timer3.Enabled = false; }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Action r = new Action(() =>
            {
                if (Login_panel.Left < 1000)
                {
                    Login_panel.Left += 20;
                }
                else
                {
                    if (this.fg_panel.Left > 490)
                    {
                        fg_panel.Left -= 20;
                    }
                    else { this.timer4.Enabled = false; }
                }
            });
            r();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Cls_JA_Member.ForgotPassword(this.jA_Input7.輸入塊字串, this.jA_Input8.輸入塊字串))
            {
                MessageBox.Show("新密碼成功寄出");
                this.timer3.Enabled = true;
                this.jA_Input7.輸入塊字串 = this.jA_Input8.輸入塊字串 = "";
            }
            else { MessageBox.Show("資料錯誤"); }
        }



        private void button9_Click(object sender, EventArgs e)
        {
            this.jA_Input5.輸入塊字串 = "Jay";
            this.jA_Input6.輸入塊字串 = "222";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
;