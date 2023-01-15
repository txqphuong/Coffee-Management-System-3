namespace WindowsFormsApplication1
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.TB_TK = new System.Windows.Forms.TextBox();
            this.TB_MK = new System.Windows.Forms.TextBox();
            this.linkLabel1_QuenMK = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DK = new System.Windows.Forms.LinkLabel();
            this.button_Dangnhap = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_Database = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_TK
            // 
            this.TB_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TB_TK.Location = new System.Drawing.Point(168, 286);
            this.TB_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_TK.Name = "TB_TK";
            this.TB_TK.Size = new System.Drawing.Size(352, 28);
            this.TB_TK.TabIndex = 1;
            this.TB_TK.Tag = "";
            // 
            // TB_MK
            // 
            this.TB_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TB_MK.Location = new System.Drawing.Point(168, 366);
            this.TB_MK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_MK.Name = "TB_MK";
            this.TB_MK.PasswordChar = '*';
            this.TB_MK.Size = new System.Drawing.Size(352, 26);
            this.TB_MK.TabIndex = 2;
            this.TB_MK.Tag = "";
            // 
            // linkLabel1_QuenMK
            // 
            this.linkLabel1_QuenMK.AutoSize = true;
            this.linkLabel1_QuenMK.Location = new System.Drawing.Point(62, 552);
            this.linkLabel1_QuenMK.Name = "linkLabel1_QuenMK";
            this.linkLabel1_QuenMK.Size = new System.Drawing.Size(117, 17);
            this.linkLabel1_QuenMK.TabIndex = 4;
            this.linkLabel1_QuenMK.TabStop = true;
            this.linkLabel1_QuenMK.Tag = "";
            this.linkLabel1_QuenMK.Text = "Quên mật khẩu ?";
            this.linkLabel1_QuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_QuenMK_LinkClicked);
            // 
            // linkLabel_DK
            // 
            this.linkLabel_DK.AutoSize = true;
            this.linkLabel_DK.Location = new System.Drawing.Point(565, 552);
            this.linkLabel_DK.Name = "linkLabel_DK";
            this.linkLabel_DK.Size = new System.Drawing.Size(60, 17);
            this.linkLabel_DK.TabIndex = 5;
            this.linkLabel_DK.TabStop = true;
            this.linkLabel_DK.Tag = "";
            this.linkLabel_DK.Text = "Đăng ký";
            this.linkLabel_DK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DK_LinkClicked);
            // 
            // button_Dangnhap
            // 
            this.button_Dangnhap.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dangnhap.Location = new System.Drawing.Point(168, 494);
            this.button_Dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Dangnhap.Name = "button_Dangnhap";
            this.button_Dangnhap.Size = new System.Drawing.Size(352, 43);
            this.button_Dangnhap.TabIndex = 3;
            this.button_Dangnhap.Tag = "";
            this.button_Dangnhap.Text = "ĐĂNG NHẬP";
            this.button_Dangnhap.UseVisualStyleBackColor = true;
            this.button_Dangnhap.Click += new System.EventHandler(this.button_Dangnhap_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(66, 366);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 286);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(66, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cb_Database
            // 
            this.cb_Database.FormattingEnabled = true;
            this.cb_Database.Location = new System.Drawing.Point(168, 435);
            this.cb_Database.Name = "cb_Database";
            this.cb_Database.Size = new System.Drawing.Size(352, 24);
            this.cb_Database.TabIndex = 6;
            // 
            // DangNhap
            // 
            this.AcceptButton = this.button_Dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 594);
            this.Controls.Add(this.cb_Database);
            this.Controls.Add(this.button_Dangnhap);
            this.Controls.Add(this.linkLabel_DK);
            this.Controls.Add(this.linkLabel1_QuenMK);
            this.Controls.Add(this.TB_MK);
            this.Controls.Add(this.TB_TK);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TB_TK;
        private System.Windows.Forms.TextBox TB_MK;
        private System.Windows.Forms.LinkLabel linkLabel1_QuenMK;
        private System.Windows.Forms.LinkLabel linkLabel_DK;
        private System.Windows.Forms.Button button_Dangnhap;
        private System.Windows.Forms.ComboBox cb_Database;
    }
}

