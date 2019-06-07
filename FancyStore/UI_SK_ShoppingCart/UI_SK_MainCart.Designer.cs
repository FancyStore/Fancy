namespace UI_SK_ShoppingCart
{
    partial class UI_SK_MainCart
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_SK_MC_ProductFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UI_SK_MC_GoToChoosePay_Btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.uC_SK_ShoppingCartTitle1 = new Ctr_Customs.UC_SK_ShoppingCartTitle();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 60);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "購物清單";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_SK_MC_ProductFlowPanel
            // 
            this.UI_SK_MC_ProductFlowPanel.Location = new System.Drawing.Point(17, 204);
            this.UI_SK_MC_ProductFlowPanel.Name = "UI_SK_MC_ProductFlowPanel";
            this.UI_SK_MC_ProductFlowPanel.Size = new System.Drawing.Size(917, 576);
            this.UI_SK_MC_ProductFlowPanel.TabIndex = 4;
            // 
            // UI_SK_MC_GoToChoosePay_Btn
            // 
            this.UI_SK_MC_GoToChoosePay_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(184)))), ((int)(((byte)(162)))));
            this.UI_SK_MC_GoToChoosePay_Btn.Location = new System.Drawing.Point(510, 850);
            this.UI_SK_MC_GoToChoosePay_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.UI_SK_MC_GoToChoosePay_Btn.Name = "UI_SK_MC_GoToChoosePay_Btn";
            this.UI_SK_MC_GoToChoosePay_Btn.Size = new System.Drawing.Size(100, 100);
            this.UI_SK_MC_GoToChoosePay_Btn.TabIndex = 5;
            this.UI_SK_MC_GoToChoosePay_Btn.Text = "下一步            選擇付款方式";
            this.UI_SK_MC_GoToChoosePay_Btn.UseCompatibleTextRendering = true;
            this.UI_SK_MC_GoToChoosePay_Btn.UseVisualStyleBackColor = false;
            this.UI_SK_MC_GoToChoosePay_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(184)))), ((int)(((byte)(162)))));
            this.button3.Location = new System.Drawing.Point(340, 850);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 7;
            this.button3.Text = "更新數量";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uC_SK_ShoppingCartTitle1
            // 
            this.uC_SK_ShoppingCartTitle1.Location = new System.Drawing.Point(17, 120);
            this.uC_SK_ShoppingCartTitle1.Name = "uC_SK_ShoppingCartTitle1";
            this.uC_SK_ShoppingCartTitle1.Size = new System.Drawing.Size(917, 78);
            this.uC_SK_ShoppingCartTitle1.TabIndex = 6;
            // 
            // UI_SK_MainCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 1000);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.uC_SK_ShoppingCartTitle1);
            this.Controls.Add(this.UI_SK_MC_GoToChoosePay_Btn);
            this.Controls.Add(this.UI_SK_MC_ProductFlowPanel);
            this.Controls.Add(this.panel2);
            this.Name = "UI_SK_MainCart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UI_SK_MainCart_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.UI_SK_MC_ProductFlowPanel, 0);
            this.Controls.SetChildIndex(this.UI_SK_MC_GoToChoosePay_Btn, 0);
            this.Controls.SetChildIndex(this.uC_SK_ShoppingCartTitle1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel UI_SK_MC_ProductFlowPanel;
        private System.Windows.Forms.Button UI_SK_MC_GoToChoosePay_Btn;
        private Ctr_Customs.UC_SK_ShoppingCartTitle uC_SK_ShoppingCartTitle1;
        private System.Windows.Forms.Button button3;
    }
}