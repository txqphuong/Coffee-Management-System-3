namespace WindowsFormsApplication1.GUI
{
    partial class ThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThucDon));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAMONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHUCDONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLCAPHEDataSet = new WindowsFormsApplication1.DB_QLCAPHEDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Mon_menuStrip = new System.Windows.Forms.MenuStrip();
            this.Tai_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tHUCDONTableAdapter = new WindowsFormsApplication1.DB_QLCAPHEDataSetTableAdapters.THUCDONTableAdapter();
            this.cHITIETHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETHOADONTableAdapter = new WindowsFormsApplication1.DB_QLCAPHEDataSetTableAdapters.CHITIETHOADONTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUCDONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCAPHEDataSet)).BeginInit();
            this.Mon_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAMONDataGridViewTextBoxColumn,
            this.tENMONDataGridViewTextBoxColumn,
            this.gIADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tHUCDONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(282, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(349, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // mAMONDataGridViewTextBoxColumn
            // 
            this.mAMONDataGridViewTextBoxColumn.DataPropertyName = "MAMON";
            this.mAMONDataGridViewTextBoxColumn.HeaderText = "Mã món";
            this.mAMONDataGridViewTextBoxColumn.Name = "mAMONDataGridViewTextBoxColumn";
            // 
            // tENMONDataGridViewTextBoxColumn
            // 
            this.tENMONDataGridViewTextBoxColumn.DataPropertyName = "TENMON";
            this.tENMONDataGridViewTextBoxColumn.HeaderText = "Tên món";
            this.tENMONDataGridViewTextBoxColumn.Name = "tENMONDataGridViewTextBoxColumn";
            // 
            // gIADataGridViewTextBoxColumn
            // 
            this.gIADataGridViewTextBoxColumn.DataPropertyName = "GIA";
            this.gIADataGridViewTextBoxColumn.HeaderText = "Giá";
            this.gIADataGridViewTextBoxColumn.Name = "gIADataGridViewTextBoxColumn";
            // 
            // tHUCDONBindingSource
            // 
            this.tHUCDONBindingSource.DataMember = "THUCDON";
            this.tHUCDONBindingSource.DataSource = this.dB_QLCAPHEDataSet;
            // 
            // dB_QLCAPHEDataSet
            // 
            this.dB_QLCAPHEDataSet.DataSetName = "DB_QLCAPHEDataSet";
            this.dB_QLCAPHEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỰC ĐƠN";
            // 
            // txtGia
            // 
            this.txtGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHUCDONBindingSource, "GIA", true));
            this.txtGia.Location = new System.Drawing.Point(163, 240);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 15;
            // 
            // txtTenMon
            // 
            this.txtTenMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHUCDONBindingSource, "TENMON", true));
            this.txtTenMon.Location = new System.Drawing.Point(163, 190);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(100, 22);
            this.txtTenMon.TabIndex = 14;
            // 
            // txtMaMon
            // 
            this.txtMaMon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tHUCDONBindingSource, "MAMON", true));
            this.txtMaMon.Location = new System.Drawing.Point(163, 140);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(100, 22);
            this.txtMaMon.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gía";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã món";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Xóa ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
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
            // tHUCDONTableAdapter
            // 
            this.tHUCDONTableAdapter.ClearBeforeFill = true;
            // 
            // cHITIETHOADONBindingSource
            // 
            this.cHITIETHOADONBindingSource.DataMember = "CHITIETHOADON";
            this.cHITIETHOADONBindingSource.DataSource = this.dB_QLCAPHEDataSet;
            // 
            // cHITIETHOADONTableAdapter
            // 
            this.cHITIETHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 111;
            this.button4.Text = "Thêm từ file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 529);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Mon_menuStrip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThucDon";
            this.Text = "ThucDon";
            this.Load += new System.EventHandler(this.ThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUCDONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCAPHEDataSet)).EndInit();
            this.Mon_menuStrip.ResumeLayout(false);
            this.Mon_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_QLCAPHEDataSet dB_QLCAPHEDataSet;
        private System.Windows.Forms.BindingSource tHUCDONBindingSource;
        private DB_QLCAPHEDataSetTableAdapters.THUCDONTableAdapter tHUCDONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cHITIETHOADONBindingSource;
        private DB_QLCAPHEDataSetTableAdapters.CHITIETHOADONTableAdapter cHITIETHOADONTableAdapter;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip Mon_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Tai_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox Text_toolStripTextBox;
        private System.Windows.Forms.Button button4;
    }
}