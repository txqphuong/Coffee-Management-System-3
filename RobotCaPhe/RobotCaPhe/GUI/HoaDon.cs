using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.GUI;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class HoaDon : Form
    {
        SqlConnection connect;

        public HoaDon(SqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dB_QLCAPHEDataSet.CHITIETHOADON' table. You can move, or remove it, as needed.
                this.cHITIETHOADONTableAdapter.Fill(this.dB_QLCAPHEDataSet.CHITIETHOADON);
                // TODO: This line of code loads data into the 'dB_QLCAPHEDataSet.HOADON' table. You can move, or remove it, as needed.
                this.hOADONTableAdapter.Fill(this.dB_QLCAPHEDataSet.HOADON);

                string query = "declare @slhd int; exec soLuongHoaDon @slhd output; select @slhd";
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                textBox_SL.Text = cmd.ExecuteScalar().ToString();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemHoaDon hd = new ThemHoaDon();
            hd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes == r)
                {
                    this.hOADONTableAdapter.DeleteHD(txtMaHD.Text);
                    MessageBox.Show("Xóa hóa đơn thành công");
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa hóa đơn này");
            }
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hOADONTableAdapter.Fill(dB_QLCAPHEDataSet.HOADON);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.hOADONTableAdapter.UpdateHD(txtMaKH.Text, txtMaNV.Text, DateTime.Parse(dateNgayLap.Text), txtMaHD.Text);
                MessageBox.Show("Chỉnh sửa hóa đơn thành công");
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa hóa đơn này");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataSource = this.cHITIETHOADONTableAdapter.GetDataBy1(txtMaHD.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.hOADONTableAdapter.GetDataBy2(DateTime.Parse(dateTimePicker1.Text),DateTime.Parse(dateTimePicker2.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.ShowDialog();
        }
    }
}
