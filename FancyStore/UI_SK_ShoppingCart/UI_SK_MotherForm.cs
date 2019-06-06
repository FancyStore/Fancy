using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_Utility;
using static Cls_Utility.Cls_SK_NormalClass;

namespace UI_SK_ShoppingCart
{
    public partial class UI_SK_MotherForm : Form
    {
        public UI_SK_MotherForm()
        {
            InitializeComponent();
        }

        private void MyClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MyMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uC_SK_CartTitle1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UI_SK_MainCart UISKMC = new UI_SK_MainCart();
            UI_SK_ChoosePay UISKCP = new UI_SK_ChoosePay();
            UISKCP.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cls_SK_NormalClass.ShoppingList.Add(new BuyItem
            {
                ProductID = 1,
                ProductName = "鹿皮襯裙",
                ProductSizeName = "XL",
                ProductSizeID = 1,
                ProductColorName = "一般色",
                ProductColorID = 1,
                ProductStockQTY = 20,//Linq First Of Default();
                ProductOrderQTY = 3
            }
            );

            Cls_SK_NormalClass.ShoppingList.Add(new BuyItem
            {
                ProductID = 5,
                ProductName = "英國貴族の文藝復興裙裝",
                ProductSizeName = "3L",
                ProductSizeID =4,
                ProductColorName = "鄉村麥",
                ProductColorID =7,
                ProductStockQTY = 30,//Linq First Of Default();
                ProductOrderQTY = 1
            }
            );

            Cls_SK_NormalClass.ShoppingList.Add(new BuyItem
            {
                ProductID = 8,
                ProductName = "黑喬其紗裙裝",
                ProductSizeName = "L",
                ProductSizeID =5,
                ProductColorName = "黑色",
                ProductColorID = 8,
                ProductStockQTY = 50,//Linq First Of Default();
                ProductOrderQTY = 5
            }
            );
        }
    }
}
