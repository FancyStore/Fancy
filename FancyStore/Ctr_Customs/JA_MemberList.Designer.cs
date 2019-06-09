namespace Ctr_Customs
{
    partial class JA_MemberList
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.刪除_B = new System.Windows.Forms.Button();
            this.展開 = new System.Windows.Forms.Button();
            this.RegisterTIme = new System.Windows.Forms.Label();
            this.MYRegion = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.UserImg = new System.Windows.Forms.PictureBox();
            this.權限 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.開通用驗證碼 = new UI_JA_Members.JA_Input();
            this.使用者密碼 = new UI_JA_Members.JA_Input();
            this.SEmail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.刪除_B);
            this.panel1.Controls.Add(this.SEmail);
            this.panel1.Controls.Add(this.展開);
            this.panel1.Controls.Add(this.RegisterTIme);
            this.panel1.Controls.Add(this.MYRegion);
            this.panel1.Controls.Add(this.City);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.UserID);
            this.panel1.Controls.Add(this.UserImg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 60);
            this.panel1.TabIndex = 0;
            // 
            // 刪除_B
            // 
            this.刪除_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.刪除_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.刪除_B.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.刪除_B.Image = global::Ctr_Customs.img.icons8_trash_16;
            this.刪除_B.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.刪除_B.Location = new System.Drawing.Point(926, 20);
            this.刪除_B.Name = "刪除_B";
            this.刪除_B.Size = new System.Drawing.Size(65, 25);
            this.刪除_B.TabIndex = 0;
            this.刪除_B.Text = "刪除";
            this.刪除_B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.刪除_B.UseVisualStyleBackColor = false;
            this.刪除_B.Click += new System.EventHandler(this.刪除_B_Click);
            // 
            // 展開
            // 
            this.展開.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(166)))), ((int)(((byte)(121)))));
            this.展開.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.展開.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.展開.Image = global::Ctr_Customs.img.icons8_expand_arrow_24;
            this.展開.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.展開.Location = new System.Drawing.Point(783, 20);
            this.展開.Name = "展開";
            this.展開.Size = new System.Drawing.Size(65, 25);
            this.展開.TabIndex = 6;
            this.展開.Text = "展開";
            this.展開.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.展開.UseVisualStyleBackColor = false;
            this.展開.Click += new System.EventHandler(this.展開_Click);
            // 
            // RegisterTIme
            // 
            this.RegisterTIme.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.RegisterTIme.Location = new System.Drawing.Point(632, 10);
            this.RegisterTIme.Name = "RegisterTIme";
            this.RegisterTIme.Size = new System.Drawing.Size(120, 39);
            this.RegisterTIme.TabIndex = 5;
            this.RegisterTIme.Text = "2019-05-14 18:28:24.933";
            this.RegisterTIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MYRegion
            // 
            this.MYRegion.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MYRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.MYRegion.Location = new System.Drawing.Point(512, 0);
            this.MYRegion.Name = "MYRegion";
            this.MYRegion.Size = new System.Drawing.Size(120, 60);
            this.MYRegion.TabIndex = 4;
            this.MYRegion.Text = "南港區";
            this.MYRegion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.City.Location = new System.Drawing.Point(392, 0);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(120, 60);
            this.City.TabIndex = 3;
            this.City.Text = "台北市";
            this.City.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.UserName.Location = new System.Drawing.Point(152, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(120, 60);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "陳志堅";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserID
            // 
            this.UserID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(99)))), ((int)(((byte)(103)))));
            this.UserID.Location = new System.Drawing.Point(32, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(120, 60);
            this.UserID.TabIndex = 1;
            this.UserID.Text = "1";
            this.UserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserImg
            // 
            this.UserImg.Location = new System.Drawing.Point(272, 0);
            this.UserImg.Name = "UserImg";
            this.UserImg.Size = new System.Drawing.Size(120, 60);
            this.UserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserImg.TabIndex = 0;
            this.UserImg.TabStop = false;
            // 
            // 權限
            // 
            this.權限.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.權限.FormattingEnabled = true;
            this.權限.Items.AddRange(new object[] {
            "一般會員",
            "管理員"});
            this.權限.Location = new System.Drawing.Point(732, 81);
            this.權限.Name = "權限";
            this.權限.Size = new System.Drawing.Size(92, 20);
            this.權限.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(342, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "更改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(622, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "更改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(850, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "更改權限";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 開通用驗證碼
            // 
            this.開通用驗證碼.BackColor = System.Drawing.Color.Transparent;
            this.開通用驗證碼.Location = new System.Drawing.Point(472, 69);
            this.開通用驗證碼.Margin = new System.Windows.Forms.Padding(4);
            this.開通用驗證碼.Name = "開通用驗證碼";
            this.開通用驗證碼.Size = new System.Drawing.Size(100, 50);
            this.開通用驗證碼.TabIndex = 4;
            this.開通用驗證碼.Text = "開通驗證碼";
            this.開通用驗證碼.輸入塊字串 = "";
            // 
            // 使用者密碼
            // 
            this.使用者密碼.BackColor = System.Drawing.Color.Transparent;
            this.使用者密碼.Location = new System.Drawing.Point(83, 69);
            this.使用者密碼.Margin = new System.Windows.Forms.Padding(4);
            this.使用者密碼.Name = "使用者密碼";
            this.使用者密碼.Size = new System.Drawing.Size(200, 50);
            this.使用者密碼.TabIndex = 2;
            this.使用者密碼.Text = "使用者密碼";
            this.使用者密碼.輸入塊字串 = "";
            // 
            // SEmail
            // 
            this.SEmail.BackColor = System.Drawing.Color.Turquoise;
            this.SEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SEmail.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SEmail.Image = global::Ctr_Customs.img.icons8_expand_arrow_24;
            this.SEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SEmail.Location = new System.Drawing.Point(855, 20);
            this.SEmail.Name = "SEmail";
            this.SEmail.Size = new System.Drawing.Size(65, 25);
            this.SEmail.TabIndex = 6;
            this.SEmail.Text = "Email";
            this.SEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SEmail.UseVisualStyleBackColor = false;
            this.SEmail.Click += new System.EventHandler(this.SEmail_Click);
            // 
            // JA_MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(203)))));
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.權限);
            this.Controls.Add(this.開通用驗證碼);
            this.Controls.Add(this.使用者密碼);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "JA_MemberList";
            this.Size = new System.Drawing.Size(1006, 130);
            this.Load += new System.EventHandler(this.JA_MemberList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox UserImg;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label RegisterTIme;
        private System.Windows.Forms.Label MYRegion;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Button 展開;
        private System.Windows.Forms.Button 刪除_B;
        private UI_JA_Members.JA_Input 使用者密碼;
        private UI_JA_Members.JA_Input 開通用驗證碼;
        private System.Windows.Forms.ComboBox 權限;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SEmail;
    }
}
