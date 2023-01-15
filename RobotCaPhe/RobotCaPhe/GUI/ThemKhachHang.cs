using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.khachhangTableAdapter1.Insert(txtMaKH.Text, txtTenKH.Text, txtGioiTinh.Text, txtSDT.Text);
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
