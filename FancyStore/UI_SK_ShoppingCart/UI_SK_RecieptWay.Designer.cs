namespace UI_SK_ShoppingCart
{
    partial class UI_SK_RecieptWay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_SK_RW_BornOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SK_RW_CheckList_Title1 = new Ctr_Customs.UC_SK_RW_CheckList_Title();
            this.UI_SK_RW_FOPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_SK_RW_BornOrder
            // 
            this.UI_SK_RW_BornOrder.Location = new System.Drawing.Point(30, 870);
            this.UI_SK_RW_BornOrder.Name = "UI_SK_RW_BornOrder";
            this.UI_SK_RW_BornOrder.Size = new System.Drawing.Size(100, 100);
            this.UI_SK_RW_BornOrder.TabIndex = 3;
            this.UI_SK_RW_BornOrder.Text = "生成訂單";
            this.UI_SK_RW_BornOrder.UseVisualStyleBackColor = true;
            this.UI_SK_RW_BornOrder.Click += new System.EventHandler(this.UI_SK_RW_BornOrder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_SK_RW_CheckList_Title1);
            this.panel2.Location = new System.Drawing.Point(88, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 82);
            this.panel2.TabIndex = 4;
            // 
            // uC_SK_RW_CheckList_Title1
            // 
            this.uC_SK_RW_CheckList_Title1.BackColor = System.Drawing.Color.Transparent;
            this.uC_SK_RW_CheckList_Title1.Location = new System.Drawing.Point(0, 0);
            this.uC_SK_RW_CheckList_Title1.Name = "uC_SK_RW_CheckList_Title1";
            this.uC_SK_RW_CheckList_Title1.Size = new System.Drawing.Size(791, 82);
            this.uC_SK_RW_CheckList_Title1.TabIndex = 0;
            // 
            // UI_SK_RW_FOPanel1
            // 
            this.UI_SK_RW_FOPanel1.Location = new System.Drawing.Point(84, 150);
            this.UI_SK_RW_FOPanel1.Name = "UI_SK_RW_FOPanel1";
            this.UI_SK_RW_FOPanel1.Size = new System.Drawing.Size(798, 475);
            this.UI_SK_RW_FOPanel1.TabIndex = 5;
            // 
            // UI_SK_RecieptWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 1000);
            this.Controls.Add(this.UI_SK_RW_FOPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UI_SK_RW_BornOrder);
            this.Name = "UI_SK_RecieptWay";
            this.Text = "UI_SK_RecieptWay";
            this.Controls.SetChildIndex(this.UI_SK_RW_BornOrder, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.UI_SK_RW_FOPanel1, 0);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_SK_RW_BornOrder_btn;
        private System.Windows.Forms.Button UI_SK_RW_BornOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel UI_SK_RW_FOPanel1;
        private Ctr_Customs.UC_SK_RW_CheckList_Title uC_SK_RW_CheckList_Title1;
    }
}