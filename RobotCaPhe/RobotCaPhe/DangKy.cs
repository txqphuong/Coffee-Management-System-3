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

namespace WindowsFormsApplication1
{
    public partial class DangKy : Form
    {
        SqlConnection connect;

        public DangKy(SqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void button_Dangky_Click(object sender, EventArgs e)
        {
            if(textBox_TenTaiKhoan.Text == string.Empty)
            {
                MessageBox.Show("Tên tài khoản không được phép để trống !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            if (textBox_Matkhau.Text == string.Empty)
            {
                MessageBox.Show("Mật khẩu không được phép để trống !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            if (textBox_Xacnhan.Text == string.Empty)
            {
                MessageBox.Show("Xác nhận mật khẩu không được phép để trống !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            if (textBox_Xacnhan.Text != textBox_Matkhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không hợp lệ !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            try
            {
                connect.Open();
                string query = string.Format("exec sp_addlogin '{0}', '{1}'; exec sp_adduser '{0}', '{0}'",
                    textBox_TenTaiKhoan.Text, textBox_Matkhau.Text);
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Tạo tài khoản thành công !", "Thông báo !", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Tạo tài khoản thất bại !", "Thông báo !", MessageBoxButtons.OK);
            }
        }
    }
}
