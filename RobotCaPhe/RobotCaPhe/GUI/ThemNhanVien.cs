using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.nhanvienTableAdapter1.Insert(txtMaNV.Text, txtTenNV.Text, txtGioiTinh.Text, txtSDT.Text, txtDiaChi.Text);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Không thể thêm");
            }
        }
    }
}
