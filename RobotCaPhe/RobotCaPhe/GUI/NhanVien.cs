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

namespace WindowsFormsApplication1
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dB_QLCAPHEDataSet.NHANVIEN' table. You can move, or remove it, as needed.
                this.nHANVIENTableAdapter.Fill(this.dB_QLCAPHEDataSet.NHANVIEN);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemNhanVien nv = new ThemNhanVien();
            nv.Show();
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nHANVIENTableAdapter.Fill(dB_QLCAPHEDataSet.NHANVIEN);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.nHANVIENTableAdapter.UpdateNhanVien(txtTenNV.Text, txtGioiTinh.Text, txtSDT.Text, txtDiaChi.Text, txtMaNV.Text);
                MessageBox.Show("Chỉnh sửa thành công");
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes == r)
                {
                    this.nHANVIENTableAdapter.DeleteNhanVien(txtMaNV.Text);
                    MessageBox.Show("Xóa nhân viên thành công");
                }

            }
            catch
            {
                MessageBox.Show("Không thể xóa nhân viên này");
            }
        }
    }
}
