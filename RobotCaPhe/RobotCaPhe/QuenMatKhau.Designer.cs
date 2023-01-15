namespace WindowsFormsApplication1
{
    partial class QuenMatKhau
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
            this.textBox_TK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.textBox_MK = new System.Windows.Forms.TextBox();
            this.textBox_XacNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Gui = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_TK
            // 
            this.textBox_TK.Location = new System.Drawing.Point(224, 282);
            this.textBox_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TK.Multiline = true;
            this.textBox_TK.Name = "textBox_TK";
            this.textBox_TK.Size = new System.Drawing.Size(344, 42);
            this.textBox_TK.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(64, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(62, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(64, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu mới";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.Location = new System.Drawing.Point(157, 470);
            this.btn_XacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(344, 43);
            this.btn_XacNhan.TabIndex = 15;
            this.btn_XacNhan.Text = "Thay đổi mật khẩu";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // textBox_MK
            // 
            this.textBox_MK.Location = new System.Drawing.Point(224, 423);
            this.textBox_MK.Multiline = true;
            this.textBox_MK.Name = "textBox_MK";
            this.textBox_MK.PasswordChar = '*';
            this.textBox_MK.Size = new System.Drawing.Size(344, 42);
            this.textBox_MK.TabIndex = 16;
            // 
            // textBox_XacNhan
            // 
            this.textBox_XacNhan.Location = new System.Drawing.Point(224, 375);
            this.textBox_XacNhan.Multiline = true;
            this.textBox_XacNhan.Name = "textBox_XacNhan";
            this.textBox_XacNhan.Size = new System.Drawing.Size(216, 42);
            this.textBox_XacNhan.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(64, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã xác nhận";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Gui
            // 
            this.btn_Gui.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gui.Location = new System.Drawing.Point(446, 375);
            this.btn_Gui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.Size = new System.Drawing.Size(122, 43);
            this.btn_Gui.TabIndex = 19;
            this.btn_Gui.Text = "Gửi OTP";
            this.btn_Gui.UseVisualStyleBackColor = true;
            this.btn_Gui.Click += new System.EventHandler(this.btn_Gui_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(224, 329);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Multiline = true;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(344, 42);
            this.textBox_Email.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(64, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 42);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tài khoản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 545);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Gui);
            this.Controls.Add(this.textBox_XacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_MK);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuenMatKhau";
            this.Text = "Quên mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_TK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.TextBox textBox_MK;
        private System.Windows.Forms.TextBox textBox_XacNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Gui;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label4;
    }
}