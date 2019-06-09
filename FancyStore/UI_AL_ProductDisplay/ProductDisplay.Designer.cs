namespace UI_AL_ProductDisplay
{
    partial class ProductDisplay
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
            this.Tlp_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.Flp_CategoryM = new System.Windows.Forms.FlowLayoutPanel();
            this.Flp_CategoryS = new System.Windows.Forms.FlowLayoutPanel();
            this.Flp_Products = new System.Windows.Forms.FlowLayoutPanel();
            this.P_Search = new System.Windows.Forms.Panel();
            this.Tb_Searchbox = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Bar_BtnM = new System.Windows.Forms.Panel();
            this.Tlp_Bottom.SuspendLayout();
            this.P_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_Bottom
            // 
            this.Tlp_Bottom.BackColor = System.Drawing.Color.White;
            this.Tlp_Bottom.ColumnCount = 2;
            this.Tlp_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Tlp_Bottom.Controls.Add(this.Flp_CategoryM, 1, 0);
            this.Tlp_Bottom.Controls.Add(this.Flp_CategoryS, 0, 1);
            this.Tlp_Bottom.Controls.Add(this.Flp_Products, 1, 1);
            this.Tlp_Bottom.Controls.Add(this.P_Search, 0, 0);
            this.Tlp_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Bottom.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.Tlp_Bottom.Name = "Tlp_Bottom";
            this.Tlp_Bottom.RowCount = 2;
            this.Tlp_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Tlp_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.Tlp_Bottom.Size = new System.Drawing.Size(1401, 662);
            this.Tlp_Bottom.TabIndex = 0;
            // 
            // Flp_CategoryM
            // 
            this.Flp_CategoryM.BackColor = System.Drawing.Color.White;
            this.Flp_CategoryM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp_CategoryM.Location = new System.Drawing.Point(280, 0);
            this.Flp_CategoryM.Margin = new System.Windows.Forms.Padding(0);
            this.Flp_CategoryM.Name = "Flp_CategoryM";
            this.Flp_CategoryM.Size = new System.Drawing.Size(1121, 66);
            this.Flp_CategoryM.TabIndex = 3;
            // 
            // Flp_CategoryS
            // 
            this.Flp_CategoryS.BackColor = System.Drawing.Color.White;
            this.Flp_CategoryS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp_CategoryS.Location = new System.Drawing.Point(0, 66);
            this.Flp_CategoryS.Margin = new System.Windows.Forms.Padding(0);
            this.Flp_CategoryS.Name = "Flp_CategoryS";
            this.Flp_CategoryS.Size = new System.Drawing.Size(280, 596);
            this.Flp_CategoryS.TabIndex = 1;
            // 
            // Flp_Products
            // 
            this.Flp_Products.AutoScroll = true;
            this.Flp_Products.BackColor = System.Drawing.Color.GhostWhite;
            this.Flp_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp_Products.Location = new System.Drawing.Point(280, 66);
            this.Flp_Products.Margin = new System.Windows.Forms.Padding(0);
            this.Flp_Products.Name = "Flp_Products";
            this.Flp_Products.Size = new System.Drawing.Size(1121, 596);
            this.Flp_Products.TabIndex = 2;
            this.Flp_Products.Resize += new System.EventHandler(this.flowLayoutPanel3_Resize);
            // 
            // P_Search
            // 
            this.P_Search.Controls.Add(this.Tb_Searchbox);
            this.P_Search.Controls.Add(this.Btn_Search);
            this.P_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Search.Location = new System.Drawing.Point(3, 3);
            this.P_Search.Name = "P_Search";
            this.P_Search.Size = new System.Drawing.Size(274, 60);
            this.P_Search.TabIndex = 4;
            // 
            // Tb_Searchbox
            // 
            this.Tb_Searchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Tb_Searchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Tb_Searchbox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_Searchbox.Location = new System.Drawing.Point(3, 28);
            this.Tb_Searchbox.MaxLength = 50;
            this.Tb_Searchbox.Name = "Tb_Searchbox";
            this.Tb_Searchbox.Size = new System.Drawing.Size(174, 27);
            this.Tb_Searchbox.TabIndex = 1;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.Gold;
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Search.Location = new System.Drawing.Point(183, 27);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(88, 29);
            this.Btn_Search.TabIndex = 0;
            this.Btn_Search.Text = "搜尋";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Bar_BtnM
            // 
            this.Bar_BtnM.BackColor = System.Drawing.Color.Black;
            this.Bar_BtnM.Location = new System.Drawing.Point(11, 30);
            this.Bar_BtnM.Margin = new System.Windows.Forms.Padding(0);
            this.Bar_BtnM.Name = "Bar_BtnM";
            this.Bar_BtnM.Size = new System.Drawing.Size(100, 5);
            this.Bar_BtnM.TabIndex = 1;
            // 
            // ProductDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 662);
            this.Controls.Add(this.Bar_BtnM);
            this.Controls.Add(this.Tlp_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductDisplay";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Tlp_Bottom.ResumeLayout(false);
            this.P_Search.ResumeLayout(false);
            this.P_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp_Bottom;
        private System.Windows.Forms.FlowLayoutPanel Flp_CategoryM;
        private System.Windows.Forms.FlowLayoutPanel Flp_CategoryS;
        private System.Windows.Forms.FlowLayoutPanel Flp_Products;
        private System.Windows.Forms.Panel Bar_BtnM;
        private System.Windows.Forms.Panel P_Search;
        private System.Windows.Forms.TextBox Tb_Searchbox;
        private System.Windows.Forms.Button Btn_Search;
    }
}

