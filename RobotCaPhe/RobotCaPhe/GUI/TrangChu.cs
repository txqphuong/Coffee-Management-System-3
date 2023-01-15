using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.GUI
{
    public partial class TrangChu : Form
    {
        SqlConnection connect;
        public string dbname = string.Empty;

        public TrangChu(SqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            DatMon dm = new DatMon(connect);
            dm.TopLevel = false;
            this.panel2.Controls.Add(dm);
            dm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dm.Dock = DockStyle.Fill;

            try
            {
                dm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            HoaDon hd = new HoaDon(connect);
            hd.TopLevel = false;
            this.panel2.Controls.Add(hd);
            hd.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            hd.Dock = DockStyle.Fill;

            try
            {
                hd.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            ThucDon td = new ThucDon();
            td.TopLevel = false;
            this.panel2.Controls.Add(td);
            td.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            td.Dock = DockStyle.Fill;

            try
            {
                td.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            KhachHang kh = new KhachHang();
            kh.TopLevel = false;
            this.panel2.Controls.Add(kh);
            kh.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kh.Dock = DockStyle.Fill;

            try
            {
                kh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            NhanVien nv = new NhanVien();
            nv.TopLevel = false;
            this.panel2.Controls.Add(nv);
            nv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            nv.Dock = DockStyle.Fill;

            try
            {
                nv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            PhanQuyen form = new PhanQuyen(connect);
            form.TopLevel = false;
            this.panel2.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            try
            {
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            SaoLuuPhucHoi form = new SaoLuuPhucHoi(connect); 
            form.TopLevel = false;
            this.panel2.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            try
            {
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
            }
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (dbname.Equals("master"))
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
    }
}
