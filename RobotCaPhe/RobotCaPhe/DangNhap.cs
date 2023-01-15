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
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class DangNhap : Form
    {
        public SqlConnection connect;

        public DangNhap()
        {
            InitializeComponent();

            SqlConnectionStringBuilder connect_string = new SqlConnectionStringBuilder();
            connect_string.DataSource = "DESKTOP-KNIJTEG\\SQLEXPRESS";
            connect_string.InitialCatalog = "DB_QLCAPHE";
            connect_string.UserID = "sa";
            connect_string.Password = "123";
            connect = new SqlConnection(connect_string.ConnectionString);
        }

        private void button_Dangnhap_Click(object sender, EventArgs e)
        {
            if(TB_TK.Text == string.Empty)
            {
                MessageBox.Show("Tài khoản không được phép để trống !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            if (TB_MK.Text == string.Empty)
            {
                MessageBox.Show("Mật khẩu không được phép để trống !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            // Tạo kết nối
            SqlConnectionStringBuilder connect_string = new SqlConnectionStringBuilder();
            connect_string.DataSource = "DESKTOP-KNIJTEG\\SQLEXPRESS";
            connect_string.InitialCatalog = cb_Database.SelectedItem.ToString();
            connect_string.UserID = TB_TK.Text;
            connect_string.Password = TB_MK.Text;
            SqlConnection try_connect = new SqlConnection(connect_string.ConnectionString);

            try
            {
                // Thử kết nối
                try_connect.Open();
                try_connect.Close();

                // Đổi chuỗi kết nối trong App.config
                string path = "../../App.config";
                XDocument xwebconfig = XDocument.Load(path);
                XElement xElement = xwebconfig.Elements("configuration").Elements("connectionStrings").Elements("add").FirstOrDefault();
                xElement.SetAttributeValue("connectionString", connect_string.ConnectionString);
                xwebconfig.Save(path);
            }

            catch
            {
                MessageBox.Show("Đăng nhập không thành công !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            GUI.TrangChu form = new GUI.TrangChu(try_connect);
            form.dbname = cb_Database.SelectedItem.ToString();
            form.ShowDialog();
        }

        private void linkLabel_DK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy form = new DangKy(connect);

            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void linkLabel1_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau form = new QuenMatKhau(connect);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cb_Database.Items.Add("master");
            cb_Database.Items.Add("DB_QLCAPHE");

            cb_Database.SelectedIndex = 1;
        }
    }
}