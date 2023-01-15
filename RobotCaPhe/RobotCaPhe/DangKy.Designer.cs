namespace WindowsFormsApplication1
{
    partial class DangKy
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_Matkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Xacnhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Dangky = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(37, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(180, 286);
            this.textBox_TenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TenTaiKhoan.Multiline = true;
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(344, 42);
            this.textBox_TenTaiKhoan.TabIndex = 7;
            // 
            // textBox_Matkhau
            // 
            this.textBox_Matkhau.Location = new System.Drawing.Point(180, 350);
            this.textBox_Matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Matkhau.Multiline = true;
            this.textBox_Matkhau.Name = "textBox_Matkhau";
            this.textBox_Matkhau.PasswordChar = '*';
            this.textBox_Matkhau.Size = new System.Drawing.Size(344, 42);
            this.textBox_Matkhau.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(37, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Xacnhan
            // 
            this.textBox_Xacnhan.Location = new System.Drawing.Point(180, 418);
            this.textBox_Xacnhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Xacnhan.Multiline = true;
            this.textBox_Xacnhan.Name = "textBox_Xacnhan";
            this.textBox_Xacnhan.PasswordChar = '*';
            this.textBox_Xacnhan.Size = new System.Drawing.Size(344, 42);
            this.textBox_Xacnhan.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(11, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Xác nhận mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Dangky
            // 
            this.button_Dangky.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dangky.Location = new System.Drawing.Point(180, 512);
            this.button_Dangky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Dangky.Name = "button_Dangky";
            this.button_Dangky.Size = new System.Drawing.Size(344, 43);
            this.button_Dangky.TabIndex = 14;
            this.button_Dangky.Text = "ĐĂNG KÝ";
            this.button_Dangky.UseVisualStyleBackColor = true;
            this.button_Dangky.Click += new System.EventHandler(this.button_Dangky_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(71, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 654);
            this.Controls.Add(this.button_Dangky);
            this.Controls.Add(this.textBox_Xacnhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Matkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng_Ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoan;
        private System.Windows.Forms.TextBox textBox_Matkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Xacnhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Dangky;
    }
}