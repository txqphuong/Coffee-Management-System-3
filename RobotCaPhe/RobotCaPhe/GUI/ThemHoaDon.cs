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
    public partial class ThemHoaDon : Form
    {
        public ThemHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.hoadonTableAdapter1.Insert(textBox1.Text, textBox2.Text, textBox3.Text, DateTime.Parse(textBox4.Text), int.Parse(textBox5.Text));
                MessageBox.Show("Thêm hóa đơn thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Không thể thêm hóa đơn");
            }
        }
    }
}
