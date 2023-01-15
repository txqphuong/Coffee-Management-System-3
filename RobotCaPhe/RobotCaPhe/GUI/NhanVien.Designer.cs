namespace WindowsFormsApplication1
{
    partial class NhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLCAPHEDataSet = new WindowsFormsApplication1.DB_QLCAPHEDataSet();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nHANVIENTableAdapter = new WindowsFormsApplication1.DB_QLCAPHEDataSetTableAdapters.NHANVIENTableAdapter();
            this.Mon_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCAPHEDataSet)).BeginInit();
            this.Mon_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(942, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nguyễn Văn B";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.tENNVDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nHANVIENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            // 
            // tENNVDataGridViewTextBoxColumn
            // 
            this.tENNVDataGridViewTextBoxColumn.DataPropertyName = "TENNV";
            this.tENNVDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.tENNVDataGridViewTextBoxColumn.Name = "tENNVDataGridViewTextBoxColumn";
            // 
            // gIOITINHDataGridViewTextBoxColumn
            // 
            this.gIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gIOITINHDataGridViewTextBoxColumn.Name = "gIOITINHDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dB_QLCAPHEDataSet;
            // 
            // dB_QLCAPHEDataSet
            // 
            this.dB_QLCAPHEDataSet.DataSetName = "DB_QLCAPHEDataSet";
            this.dB_QLCAPHEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(463, 203);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 22;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(463, 158);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 22);
            this.txtSDT.TabIndex = 21;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "GIOITINH", true));
            this.txtGioiTinh.Location = new System.Drawing.Point(191, 262);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 22);
            this.txtGioiTinh.TabIndex = 20;
            // 
            // txtTenNV
            // 
            this.txtTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "TENNV", true));
            this.txtTenNV.Location = new System.Drawing.Point(191, 208);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 22);
            this.txtTenNV.TabIndex = 19;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(191, 161);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giới tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 687);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 687);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 687);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Mon_menuStrip
            // 
            this.Mon_menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.Mon_menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mon_menuStrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Mon_menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Mon_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mon_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tai_toolStripMenuItem,
            this.TimKiem_toolStripMenuItem,
            this.Text_toolStripTextBox});
            this.Mon_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Mon_menuStrip.Name = "Mon_menuStrip";
            this.Mon_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Mon_menuStrip.Size = new System.Drawing.Size(643, 28);
            this.Mon_menuStrip.TabIndex = 110;
            this.Mon_menuStrip.Text = "MenuMon";
            // 
            // Tai_toolStripMenuItem
            // 
            this.Tai_toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Tai_toolStripMenuItem.Image")));
            this.Tai_toolStripMenuItem.Name = "Tai_toolStripMenuItem";
            this.Tai_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.Tai_toolStripMenuItem.Click += new System.EventHandler(this.Tai_toolStripMenuItem_Click);
            // 
            // TimKiem_toolStripMenuItem
            // 
            this.TimKiem_toolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TimKiem_toolStripMenuItem.Name = "TimKiem_toolStripMenuItem";
            this.TimKiem_toolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            // 
            // Text_toolStripTextBox
            // 
            this.Text_toolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Text_toolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_toolStripTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.Text_toolStripTextBox.Name = "Text_toolStripTextBox";
            this.Text_toolStripTextBox.Size = new System.Drawing.Size(149, 24);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 741);
            this.Controls.Add(this.Mon_menuStrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCAPHEDataSet)).EndInit();
            this.Mon_menuStrip.ResumeLayout(false);
            this.Mon_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_QLCAPHEDataSet dB_QLCAPHEDataSet;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DB_QLCAPHEDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip Mon_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Text_toolStripTextBox;
    }
}