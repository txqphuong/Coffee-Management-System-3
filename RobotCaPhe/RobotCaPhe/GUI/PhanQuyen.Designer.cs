namespace WindowsFormsApplication1.GUI
{
    partial class PhanQuyen
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Users = new System.Windows.Forms.ComboBox();
            this.btn_XoaUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ThemQuyen = new System.Windows.Forms.Button();
            this.checkBox_Delete = new System.Windows.Forms.CheckBox();
            this.checkBox_Update = new System.Windows.Forms.CheckBox();
            this.checkBox_Insert = new System.Windows.Forms.CheckBox();
            this.checkBox_Select = new System.Windows.Forms.CheckBox();
            this.cbo_Bang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cbo_Role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_XoaQuyen = new System.Windows.Forms.Button();
            this.btn_ThemQuyenRole = new System.Windows.Forms.Button();
            this.btn_XoaQuyenRole = new System.Windows.Forms.Button();
            this.textBox_Role = new System.Windows.Forms.TextBox();
            this.btn_ThemRole = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN QUYỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // cbo_Users
            // 
            this.cbo_Users.FormattingEnabled = true;
            this.cbo_Users.Location = new System.Drawing.Point(111, 90);
            this.cbo_Users.Name = "cbo_Users";
            this.cbo_Users.Size = new System.Drawing.Size(222, 24);
            this.cbo_Users.TabIndex = 2;
            // 
            // btn_XoaUser
            // 
            this.btn_XoaUser.Location = new System.Drawing.Point(364, 90);
            this.btn_XoaUser.Name = "btn_XoaUser";
            this.btn_XoaUser.Size = new System.Drawing.Size(109, 43);
            this.btn_XoaUser.TabIndex = 3;
            this.btn_XoaUser.Text = "Xóa";
            this.btn_XoaUser.UseVisualStyleBackColor = true;
            this.btn_XoaUser.Click += new System.EventHandler(this.btn_XoaUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_XoaQuyen);
            this.panel1.Controls.Add(this.btn_ThemQuyen);
            this.panel1.Controls.Add(this.checkBox_Delete);
            this.panel1.Controls.Add(this.checkBox_Update);
            this.panel1.Controls.Add(this.checkBox_Insert);
            this.panel1.Controls.Add(this.checkBox_Select);
            this.panel1.Controls.Add(this.cbo_Bang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 162);
            this.panel1.TabIndex = 4;
            // 
            // btn_ThemQuyen
            // 
            this.btn_ThemQuyen.Location = new System.Drawing.Point(180, 52);
            this.btn_ThemQuyen.Name = "btn_ThemQuyen";
            this.btn_ThemQuyen.Size = new System.Drawing.Size(117, 24);
            this.btn_ThemQuyen.TabIndex = 6;
            this.btn_ThemQuyen.Text = "Thêm quyền";
            this.btn_ThemQuyen.UseVisualStyleBackColor = true;
            this.btn_ThemQuyen.Click += new System.EventHandler(this.btn_ThemQuyen_Click);
            // 
            // checkBox_Delete
            // 
            this.checkBox_Delete.AutoSize = true;
            this.checkBox_Delete.Location = new System.Drawing.Point(109, 103);
            this.checkBox_Delete.Name = "checkBox_Delete";
            this.checkBox_Delete.Size = new System.Drawing.Size(69, 21);
            this.checkBox_Delete.TabIndex = 9;
            this.checkBox_Delete.Text = "delete";
            this.checkBox_Delete.UseVisualStyleBackColor = true;
            // 
            // checkBox_Update
            // 
            this.checkBox_Update.AutoSize = true;
            this.checkBox_Update.Location = new System.Drawing.Point(21, 103);
            this.checkBox_Update.Name = "checkBox_Update";
            this.checkBox_Update.Size = new System.Drawing.Size(74, 21);
            this.checkBox_Update.TabIndex = 9;
            this.checkBox_Update.Text = "update";
            this.checkBox_Update.UseVisualStyleBackColor = true;
            // 
            // checkBox_Insert
            // 
            this.checkBox_Insert.AutoSize = true;
            this.checkBox_Insert.Location = new System.Drawing.Point(109, 55);
            this.checkBox_Insert.Name = "checkBox_Insert";
            this.checkBox_Insert.Size = new System.Drawing.Size(65, 21);
            this.checkBox_Insert.TabIndex = 8;
            this.checkBox_Insert.Text = "insert";
            this.checkBox_Insert.UseVisualStyleBackColor = true;
            // 
            // checkBox_Select
            // 
            this.checkBox_Select.AutoSize = true;
            this.checkBox_Select.Location = new System.Drawing.Point(21, 55);
            this.checkBox_Select.Name = "checkBox_Select";
            this.checkBox_Select.Size = new System.Drawing.Size(67, 21);
            this.checkBox_Select.TabIndex = 7;
            this.checkBox_Select.Text = "select";
            this.checkBox_Select.UseVisualStyleBackColor = true;
            // 
            // cbo_Bang
            // 
            this.cbo_Bang.FormattingEnabled = true;
            this.cbo_Bang.Location = new System.Drawing.Point(70, 14);
            this.cbo_Bang.Name = "cbo_Bang";
            this.cbo_Bang.Size = new System.Drawing.Size(220, 24);
            this.cbo_Bang.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bảng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_XoaQuyenRole);
            this.panel2.Controls.Add(this.btn_ThemQuyenRole);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.cbo_Role);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 150);
            this.panel2.TabIndex = 5;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(201, 50);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 40);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(17, 50);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 40);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm vào";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbo_Role
            // 
            this.cbo_Role.FormattingEnabled = true;
            this.cbo_Role.Location = new System.Drawing.Point(112, 14);
            this.cbo_Role.Name = "cbo_Role";
            this.cbo_Role.Size = new System.Drawing.Size(178, 24);
            this.cbo_Role.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhóm quyền";
            // 
            // btn_XoaQuyen
            // 
            this.btn_XoaQuyen.Location = new System.Drawing.Point(180, 100);
            this.btn_XoaQuyen.Name = "btn_XoaQuyen";
            this.btn_XoaQuyen.Size = new System.Drawing.Size(117, 24);
            this.btn_XoaQuyen.TabIndex = 10;
            this.btn_XoaQuyen.Text = "Xóa quyền";
            this.btn_XoaQuyen.UseVisualStyleBackColor = true;
            this.btn_XoaQuyen.Click += new System.EventHandler(this.btn_XoaQuyen_Click);
            // 
            // btn_ThemQuyenRole
            // 
            this.btn_ThemQuyenRole.Location = new System.Drawing.Point(17, 96);
            this.btn_ThemQuyenRole.Name = "btn_ThemQuyenRole";
            this.btn_ThemQuyenRole.Size = new System.Drawing.Size(127, 40);
            this.btn_ThemQuyenRole.TabIndex = 9;
            this.btn_ThemQuyenRole.Text = "Thêm quyền";
            this.btn_ThemQuyenRole.UseVisualStyleBackColor = true;
            this.btn_ThemQuyenRole.Click += new System.EventHandler(this.btn_ThemQuyenRole_Click);
            // 
            // btn_XoaQuyenRole
            // 
            this.btn_XoaQuyenRole.Location = new System.Drawing.Point(163, 96);
            this.btn_XoaQuyenRole.Name = "btn_XoaQuyenRole";
            this.btn_XoaQuyenRole.Size = new System.Drawing.Size(127, 40);
            this.btn_XoaQuyenRole.TabIndex = 10;
            this.btn_XoaQuyenRole.Text = "Xóa quyền";
            this.btn_XoaQuyenRole.UseVisualStyleBackColor = true;
            // 
            // textBox_Role
            // 
            this.textBox_Role.Location = new System.Drawing.Point(340, 299);
            this.textBox_Role.Name = "textBox_Role";
            this.textBox_Role.Size = new System.Drawing.Size(133, 22);
            this.textBox_Role.TabIndex = 6;
            // 
            // btn_ThemRole
            // 
            this.btn_ThemRole.Location = new System.Drawing.Point(340, 328);
            this.btn_ThemRole.Name = "btn_ThemRole";
            this.btn_ThemRole.Size = new System.Drawing.Size(133, 32);
            this.btn_ThemRole.TabIndex = 7;
            this.btn_ThemRole.Text = "Thêm role";
            this.btn_ThemRole.UseVisualStyleBackColor = true;
            this.btn_ThemRole.Click += new System.EventHandler(this.btn_ThemRole_Click);
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 461);
            this.Controls.Add(this.btn_ThemRole);
            this.Controls.Add(this.textBox_Role);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_XoaUser);
            this.Controls.Add(this.cbo_Users);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Users;
        private System.Windows.Forms.Button btn_XoaUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_Bang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Delete;
        private System.Windows.Forms.CheckBox checkBox_Update;
        private System.Windows.Forms.CheckBox checkBox_Insert;
        private System.Windows.Forms.CheckBox checkBox_Select;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbo_Role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_ThemQuyen;
        private System.Windows.Forms.Button btn_XoaQuyen;
        private System.Windows.Forms.Button btn_XoaQuyenRole;
        private System.Windows.Forms.Button btn_ThemQuyenRole;
        private System.Windows.Forms.TextBox textBox_Role;
        private System.Windows.Forms.Button btn_ThemRole;
    }
}