namespace UI_AL_ProductDetail
{
    partial class ProductDetail
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pb_Productimage = new System.Windows.Forms.PictureBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Description = new System.Windows.Forms.Label();
            this.Flp_Washing = new System.Windows.Forms.FlowLayoutPanel();
            this.Flp_Color = new System.Windows.Forms.FlowLayoutPanel();
            this.Flp_Size = new System.Windows.Forms.FlowLayoutPanel();
            this.Flp_Images = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_Price = new System.Windows.Forms.Label();
            this.Btn_Addcart = new System.Windows.Forms.Button();
            this.Lbl_Qty = new System.Windows.Forms.Label();
            this.Nud_QTY = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Bar_Color = new System.Windows.Forms.Panel();
            this.Bar_Size = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Productimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_QTY)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_Productimage
            // 
            this.Pb_Productimage.Location = new System.Drawing.Point(92, 41);
            this.Pb_Productimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pb_Productimage.Name = "Pb_Productimage";
            this.Pb_Productimage.Size = new System.Drawing.Size(379, 379);
            this.Pb_Productimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Productimage.TabIndex = 0;
            this.Pb_Productimage.TabStop = false;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Name.Location = new System.Drawing.Point(529, 54);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(78, 22);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "商品名稱";
            // 
            // Lbl_Description
            // 
            this.Lbl_Description.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Description.Location = new System.Drawing.Point(529, 100);
            this.Lbl_Description.Name = "Lbl_Description";
            this.Lbl_Description.Size = new System.Drawing.Size(504, 380);
            this.Lbl_Description.TabIndex = 2;
            this.Lbl_Description.Text = "說明";
            // 
            // Flp_Washing
            // 
            this.Flp_Washing.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flp_Washing.Location = new System.Drawing.Point(525, 480);
            this.Flp_Washing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Flp_Washing.Name = "Flp_Washing";
            this.Flp_Washing.Size = new System.Drawing.Size(508, 195);
            this.Flp_Washing.TabIndex = 4;
            // 
            // Flp_Color
            // 
            this.Flp_Color.Location = new System.Drawing.Point(92, 615);
            this.Flp_Color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Flp_Color.Name = "Flp_Color";
            this.Flp_Color.Size = new System.Drawing.Size(379, 77);
            this.Flp_Color.TabIndex = 5;
            // 
            // Flp_Size
            // 
            this.Flp_Size.Location = new System.Drawing.Point(92, 696);
            this.Flp_Size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Flp_Size.Name = "Flp_Size";
            this.Flp_Size.Size = new System.Drawing.Size(379, 56);
            this.Flp_Size.TabIndex = 6;
            // 
            // Flp_Images
            // 
            this.Flp_Images.AutoScroll = true;
            this.Flp_Images.Location = new System.Drawing.Point(92, 465);
            this.Flp_Images.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Flp_Images.Name = "Flp_Images";
            this.Flp_Images.Size = new System.Drawing.Size(379, 130);
            this.Flp_Images.TabIndex = 7;
            this.Flp_Images.WrapContents = false;
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.AutoSize = true;
            this.Lbl_Price.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl_Price.ForeColor = System.Drawing.Color.Crimson;
            this.Lbl_Price.Location = new System.Drawing.Point(851, 55);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(52, 25);
            this.Lbl_Price.TabIndex = 8;
            this.Lbl_Price.Text = "價錢";
            // 
            // Btn_Addcart
            // 
            this.Btn_Addcart.BackColor = System.Drawing.Color.Orange;
            this.Btn_Addcart.FlatAppearance.BorderSize = 0;
            this.Btn_Addcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Addcart.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Addcart.Location = new System.Drawing.Point(854, 694);
            this.Btn_Addcart.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Addcart.Name = "Btn_Addcart";
            this.Btn_Addcart.Size = new System.Drawing.Size(179, 46);
            this.Btn_Addcart.TabIndex = 9;
            this.Btn_Addcart.Text = "加入購物車";
            this.Btn_Addcart.UseVisualStyleBackColor = false;
            this.Btn_Addcart.Click += new System.EventHandler(this.Btn_Addcart_Click);
            // 
            // Lbl_Qty
            // 
            this.Lbl_Qty.AutoSize = true;
            this.Lbl_Qty.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Lbl_Qty.Location = new System.Drawing.Point(529, 706);
            this.Lbl_Qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Qty.Name = "Lbl_Qty";
            this.Lbl_Qty.Size = new System.Drawing.Size(44, 22);
            this.Lbl_Qty.TabIndex = 10;
            this.Lbl_Qty.Text = "數量";
            // 
            // Nud_QTY
            // 
            this.Nud_QTY.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Nud_QTY.Location = new System.Drawing.Point(593, 704);
            this.Nud_QTY.Margin = new System.Windows.Forms.Padding(4);
            this.Nud_QTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_QTY.Name = "Nud_QTY";
            this.Nud_QTY.Size = new System.Drawing.Size(72, 30);
            this.Nud_QTY.TabIndex = 11;
            this.Nud_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nud_QTY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bar_Color
            // 
            this.Bar_Color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bar_Color.Location = new System.Drawing.Point(537, 41);
            this.Bar_Color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bar_Color.Name = "Bar_Color";
            this.Bar_Color.Size = new System.Drawing.Size(100, 5);
            this.Bar_Color.TabIndex = 12;
            // 
            // Bar_Size
            // 
            this.Bar_Size.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Bar_Size.Location = new System.Drawing.Point(681, 41);
            this.Bar_Size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bar_Size.Name = "Bar_Size";
            this.Bar_Size.Size = new System.Drawing.Size(100, 5);
            this.Bar_Size.TabIndex = 13;
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1109, 853);
            this.Controls.Add(this.Lbl_Description);
            this.Controls.Add(this.Bar_Size);
            this.Controls.Add(this.Bar_Color);
            this.Controls.Add(this.Nud_QTY);
            this.Controls.Add(this.Lbl_Qty);
            this.Controls.Add(this.Btn_Addcart);
            this.Controls.Add(this.Lbl_Price);
            this.Controls.Add(this.Flp_Images);
            this.Controls.Add(this.Flp_Size);
            this.Controls.Add(this.Flp_Color);
            this.Controls.Add(this.Flp_Washing);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Pb_Productimage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductDetail";
            this.Text = "商品詳細資訊";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Productimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_QTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Productimage;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Description;
        private System.Windows.Forms.FlowLayoutPanel Flp_Washing;
        private System.Windows.Forms.FlowLayoutPanel Flp_Color;
        private System.Windows.Forms.FlowLayoutPanel Flp_Size;
        private System.Windows.Forms.FlowLayoutPanel Flp_Images;
        private System.Windows.Forms.Label Lbl_Price;
        private System.Windows.Forms.Button Btn_Addcart;
        private System.Windows.Forms.Label Lbl_Qty;
        private System.Windows.Forms.NumericUpDown Nud_QTY;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel Bar_Color;
        private System.Windows.Forms.Panel Bar_Size;
    }
}

