namespace WindowsFormsApplication1
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLCAPHEDataSet = new WindowsFormsApplication1.DB_QLCAPHEDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kHACHHANGTableAdapter = new WindowsFormsApplication1.DB_QLCAPHEDataSetTableAdapters.KHACHHANGTableAdapter();
            this.Mon_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCAPHEDataSet)).BeginInit();
            this.Mon_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHDataGridViewTextBoxColumn,
            this.tENKHDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kHACHHANGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 233);
            this.dataGridView1.TabIndex = 1;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
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
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.dB_QLCAPHEDataSet;
            // 
            // dB_QLCAPHEDataSet
            // 
            this.dB_QLCAPHEDataSet.DataSetName = "DB_QLCAPHEDataSet";
            this.dB_QLCAPHEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số điên thoại";
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MAKH", true));
            this.txtMaKH.Location = new System.Drawing.Point(176, 132);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 22);
            this.txtMaKH.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.txtTenKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "TENKH", true));
            this.txtTenKH.Location = new System.Drawing.Point(176, 186);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 22);
            this.txtTenKH.TabIndex = 7;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "GIOITINH", true));
            this.txtGioiTinh.Location = new System.Drawing.Point(425, 127);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 22);
            this.txtGioiTinh.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(425, 183);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 22);
            this.txtSDT.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(71, 549);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
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
            this.Mon_menuStrip.Size = new System.Drawing.Size(629, 28);
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
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 675);
            this.Controls.Add(this.Mon_menuStrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private DB_QLCAPHEDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip Mon_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Text_toolStripTextBox;
    }
}