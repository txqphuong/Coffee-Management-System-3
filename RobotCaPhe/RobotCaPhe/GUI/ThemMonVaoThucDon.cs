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
    public partial class ThemMonVaoThucDon : Form
    {
        public ThemMonVaoThucDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.thucdonTableAdapter1.Insert(txtMaMon.Text, txtTenMon.Text, int.Parse(txtGia.Text));
                MessageBox.Show("Thêm món thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Không thể thêm món này");
            }
        }
    }
}
