using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.GUI;

namespace WindowsFormsApplication1.GUI
{
    public partial class ThucDon : Form
    {
        public ThucDon()
        {
            InitializeComponent();
        }

        private void ThucDon_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dB_QLCAPHEDataSet.CHITIETHOADON' table. You can move, or remove it, as needed.
                this.cHITIETHOADONTableAdapter.Fill(this.dB_QLCAPHEDataSet.CHITIETHOADON);
                // TODO: This line of code loads data into the 'dB_QLCAPHEDataSet.THUCDON' table. You can move, or remove it, as needed.
                this.tHUCDONTableAdapter.Fill(this.dB_QLCAPHEDataSet.THUCDON);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.tHUCDONBindingSource.EndEdit();
                this.tHUCDONTableAdapter.Update(dB_QLCAPHEDataSet.THUCDON);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.cHITIETHOADONBindingSource.EndEdit();
                this.cHITIETHOADONTableAdapter.Update(dB_QLCAPHEDataSet.CHITIETHOADON);
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemKhachHang kh = new ThemKhachHang();
            kh.Show();
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tHUCDONTableAdapter.Fill(dB_QLCAPHEDataSet.THUCDON);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemMonVaoThucDon mon = new ThemMonVaoThucDon();
            mon.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa món này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes == r)
                {
                    this.tHUCDONTableAdapter.xoaMonKhoiThucDon(txtMaMon.Text);
                    MessageBox.Show("Xóa món thành công");
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa món này");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tHUCDONTableAdapter.capNhatMonTrenThucDon(txtTenMon.Text, int.Parse(txtGia.Text), txtMaMon.Text);
                MessageBox.Show("Chỉnh sửa món thành công");
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa món này");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog(); // mở dialog
            op.ShowDialog();
            if (!op.CheckFileExists)
            {
                return;
            }
            string path = op.FileName;
            string query = "BULK INSERT ThucDon FROM '" + path + "' WITH (FIRSTROW = 1, FIELDTERMINATOR = ',', ROWTERMINATOR = ' ' )";
            string _cnn = @"Data Source=DESKTOP-KNIJTEG\SQLEXPRESS;Initial Catalog=DB_QLCAPHE;Integrated Security=True";
            SqlConnection conn = new SqlConnection(_cnn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ec)
            {
                if(ec.Number != 4864)
                    MessageBox.Show(ec.Message);
            }
            MessageBox.Show("Thêm thành công");
        }
    }
}
