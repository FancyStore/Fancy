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
            // UI_SK_RecieptWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 1000);
            this.Controls.Add(this.UI_SK_RW_BornOrder);
            this.Name = "UI_SK_RecieptWay";
            this.Text = "UI_SK_RecieptWay";
            this.Controls.SetChildIndex(this.UI_SK_RW_BornOrder, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_SK_RW_BornOrder_btn;
        private System.Windows.Forms.Button UI_SK_RW_BornOrder;
    }
}