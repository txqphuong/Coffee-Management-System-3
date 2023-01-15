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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                            // TODO: This line of code loads data into the 'dB_QLCAPHEDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dB_QLCAPHEDataSet.KHACHHANG);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
                this.Close();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKhachHang kh = new ThemKhachHang();
            kh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                kHACHHANGTableAdapter.UpdateKhachHang(txtTenKH.Text,txtGioiTinh.Text,txtSDT.Text,txtMaKH.Text);
                MessageBox.Show("Chỉnh sửa khách hàng thành công");
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa khách hàng này");
            }
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.Fill(dB_QLCAPHEDataSet.KHACHHANG);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (DialogResult.Yes == r)
                {
                    this.kHACHHANGTableAdapter.DeleteKhachHang(txtMaKH.Text);
                    MessageBox.Show("Xóa khách hàng thành công");
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa khách hàng này");
            }
        }
    }
}
