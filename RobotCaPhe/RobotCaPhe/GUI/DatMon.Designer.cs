namespace WindowsFormsApplication1
{
    partial class DatMon
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
            this.dB_QLCAPHEDataSet = new WindowsFormsApplication1.DB_QLCAPHEDataSet();
            this.btn_Mon = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Mon = new System.Windows.Forms.ComboBox();
            this.cbo_HoaDon = new System.Windows.Forms.ComboBox();
            this.btn_HD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ThanhTien = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chitiethoadonTableAdapter1 = new WindowsFormsApplication1.DB_QLCAPHEDataSetTableAdapters.CHITIETHOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCAPHEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_QLCAPHEDataSet
            // 
            this.dB_QLCAPHEDataSet.DataSetName = "DB_QLCAPHEDataSet";
            this.dB_QLCAPHEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Mon
            // 
            this.btn_Mon.Location = new System.Drawing.Point(259, 208);
            this.btn_Mon.Name = "btn_Mon";
            this.btn_Mon.Size = new System.Drawing.Size(117, 31);
            this.btn_Mon.TabIndex = 1;
            this.btn_Mon.Text = "Thêm CTHD";
            this.btn_Mon.UseVisualStyleBackColor = true;
            this.btn_Mon.Click += new System.EventHandler(this.btn_Mon_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(425, 159);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(421, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "THỰC ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chi tiết hóa đơn";
            // 
            // cbo_Mon
            // 
            this.cbo_Mon.FormattingEnabled = true;
            this.cbo_Mon.Location = new System.Drawing.Point(58, 212);
            this.cbo_Mon.Name = "cbo_Mon";
            this.cbo_Mon.Size = new System.Drawing.Size(182, 24);
            this.cbo_Mon.TabIndex = 6;
            this.cbo_Mon.SelectedIndexChanged += new System.EventHandler(this.cbo_Mon_SelectedIndexChanged);
            // 
            // cbo_HoaDon
            // 
            this.cbo_HoaDon.FormattingEnabled = true;
            this.cbo_HoaDon.Location = new System.Drawing.Point(58, 163);
            this.cbo_HoaDon.Name = "cbo_HoaDon";
            this.cbo_HoaDon.Size = new System.Drawing.Size(182, 24);
            this.cbo_HoaDon.TabIndex = 8;
            this.cbo_HoaDon.SelectedIndexChanged += new System.EventHandler(this.cbo_HoaDon_SelectedIndexChanged);
            // 
            // btn_HD
            // 
            this.btn_HD.Location = new System.Drawing.Point(259, 159);
            this.btn_HD.Name = "btn_HD";
            this.btn_HD.Size = new System.Drawing.Size(117, 31);
            this.btn_HD.TabIndex = 7;
            this.btn_HD.Text = "Thêm hóa đơn";
            this.btn_HD.UseVisualStyleBackColor = true;
            this.btn_HD.Click += new System.EventHandler(this.btn_HD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng tiền";
            // 
            // textBox_ThanhTien
            // 
            this.textBox_ThanhTien.Location = new System.Drawing.Point(512, 336);
            this.textBox_ThanhTien.Name = "textBox_ThanhTien";
            this.textBox_ThanhTien.Size = new System.Drawing.Size(129, 22);
            this.textBox_ThanhTien.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(58, 265);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(182, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chitiethoadonTableAdapter1
            // 
            this.chitiethoadonTableAdapter1.ClearBeforeFill = true;
            // 
            // DatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 439);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox_ThanhTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_HoaDon);
            this.Controls.Add(this.btn_HD);
            this.Controls.Add(this.cbo_Mon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_Mon);
            this.Name = "DatMon";
            this.Text = "DatMon";
            this.Load += new System.EventHandler(this.DatMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCAPHEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Mon;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private DB_QLCAPHEDataSet dB_QLCAPHEDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Mon;
        private System.Windows.Forms.ComboBox cbo_HoaDon;
        private System.Windows.Forms.Button btn_HD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ThanhTien;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private DB_QLCAPHEDataSetTableAdapters.CHITIETHOADONTableAdapter chitiethoadonTableAdapter1;
    }
}