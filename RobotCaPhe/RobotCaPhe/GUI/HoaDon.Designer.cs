namespace WindowsFormsApplication1
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYLAPHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tONGTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLCAPHEDataSet = new WindowsFormsApplication1.DB_QLCAPHEDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Mon_menuStrip = new System.Windows.Forms.MenuStrip();
            this.TimKiem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dateNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mAHDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAMONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHITIETHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_SL = new System.Windows.Forms.TextBox();
            this.hOADONTableAdapter = new WindowsFormsApplication1.DB_QLCAPHEDataSetTableAdapters.HOADONTableAdapter();
            this.cHITIETHOADONTableAdapter = new WindowsFormsApplication1.DB_QLCAPHEDataSetTableAdapters.CHITIETHOADONTableAdapter();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCAPHEDataSet)).BeginInit();
            this.Mon_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHDDataGridViewTextBoxColumn,
            this.mAKHDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn,
            this.nGAYLAPHDDataGridViewTextBoxColumn,
            this.tONGTIENDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hOADONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 371);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.mAHDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.mAKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            this.mAKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.mANVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            // 
            // nGAYLAPHDDataGridViewTextBoxColumn
            // 
            this.nGAYLAPHDDataGridViewTextBoxColumn.DataPropertyName = "NGAYLAPHD";
            this.nGAYLAPHDDataGridViewTextBoxColumn.HeaderText = "Ngày lập hóa đơn";
            this.nGAYLAPHDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nGAYLAPHDDataGridViewTextBoxColumn.Name = "nGAYLAPHDDataGridViewTextBoxColumn";
            // 
            // tONGTIENDataGridViewTextBoxColumn
            // 
            this.tONGTIENDataGridViewTextBoxColumn.DataPropertyName = "TONGTIEN";
            this.tONGTIENDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tONGTIENDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tONGTIENDataGridViewTextBoxColumn.Name = "tONGTIENDataGridViewTextBoxColumn";
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.dB_QLCAPHEDataSet;
            // 
            // dB_QLCAPHEDataSet
            // 
            this.dB_QLCAPHEDataSet.DataSetName = "DB_QLCAPHEDataSet";
            this.dB_QLCAPHEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã nhân viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(813, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày lập ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(813, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng tiền";
            // 
            // txtMaHD
            // 
            this.txtMaHD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAHD", true));
            this.txtMaHD.Location = new System.Drawing.Point(653, 220);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 22);
            this.txtMaHD.TabIndex = 7;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.txtMaKH.Location = new System.Drawing.Point(653, 267);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 22);
            this.txtMaKH.TabIndex = 8;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(653, 321);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 9;
            // 
            // txtTongTien
            // 
            this.txtTongTien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "TONGTIEN", true));
            this.txtTongTien.Location = new System.Drawing.Point(925, 262);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 22);
            this.txtTongTien.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(907, 623);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Mon_menuStrip.Size = new System.Drawing.Size(1058, 28);
            this.Mon_menuStrip.TabIndex = 109;
            this.Mon_menuStrip.Text = "MenuMon";
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
            // dateNgayLap
            // 
            this.dateNgayLap.Location = new System.Drawing.Point(925, 214);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(100, 22);
            this.dateNgayLap.TabIndex = 110;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHDDataGridViewTextBoxColumn1,
            this.mAMONDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.tHANHTIENDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cHITIETHOADONBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(552, 387);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(473, 178);
            this.dataGridView2.TabIndex = 111;
            // 
            // mAHDDataGridViewTextBoxColumn1
            // 
            this.mAHDDataGridViewTextBoxColumn1.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn";
            this.mAHDDataGridViewTextBoxColumn1.Name = "mAHDDataGridViewTextBoxColumn1";
            // 
            // mAMONDataGridViewTextBoxColumn
            // 
            this.mAMONDataGridViewTextBoxColumn.DataPropertyName = "MAMON";
            this.mAMONDataGridViewTextBoxColumn.HeaderText = "Mã món";
            this.mAMONDataGridViewTextBoxColumn.Name = "mAMONDataGridViewTextBoxColumn";
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            // 
            // tHANHTIENDataGridViewTextBoxColumn
            // 
            this.tHANHTIENDataGridViewTextBoxColumn.DataPropertyName = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.tHANHTIENDataGridViewTextBoxColumn.Name = "tHANHTIENDataGridViewTextBoxColumn";
            // 
            // cHITIETHOADONBindingSource
            // 
            this.cHITIETHOADONBindingSource.DataMember = "CHITIETHOADON";
            this.cHITIETHOADONBindingSource.DataSource = this.dB_QLCAPHEDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 17);
            this.label7.TabIndex = 112;
            this.label7.Text = "Hiển thị hóa đơn từ ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 114;
            this.label8.Text = "Đến ngày";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(586, 137);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 115;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(816, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 116;
            this.button4.Text = "Hiển thị";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 629);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 117;
            this.label9.Text = "Tổng số hóa đơn";
            // 
            // textBox_SL
            // 
            this.textBox_SL.Enabled = false;
            this.textBox_SL.Location = new System.Drawing.Point(169, 629);
            this.textBox_SL.Name = "textBox_SL";
            this.textBox_SL.Size = new System.Drawing.Size(100, 22);
            this.textBox_SL.TabIndex = 118;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // cHITIETHOADONTableAdapter
            // 
            this.cHITIETHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // Tai_toolStripMenuItem
            // 
            this.Tai_toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("Tai_toolStripMenuItem.Image")));
            this.Tai_toolStripMenuItem.Name = "Tai_toolStripMenuItem";
            this.Tai_toolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.Tai_toolStripMenuItem.Click += new System.EventHandler(this.Tai_toolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(431, 623);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 23);
            this.button5.TabIndex = 119;
            this.button5.Text = "Report";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 714);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox_SL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateNgayLap);
            this.Controls.Add(this.Mon_menuStrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCAPHEDataSet)).EndInit();
            this.Mon_menuStrip.ResumeLayout(false);
            this.Mon_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_QLCAPHEDataSet dB_QLCAPHEDataSet;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private DB_QLCAPHEDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYLAPHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip Mon_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Text_toolStripTextBox;
        private System.Windows.Forms.DateTimePicker dateNgayLap;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource cHITIETHOADONBindingSource;
        private DB_QLCAPHEDataSetTableAdapters.CHITIETHOADONTableAdapter cHITIETHOADONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_SL;
        private System.Windows.Forms.Button button5;
    }
}