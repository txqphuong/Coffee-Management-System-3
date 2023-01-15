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
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class QuenMatKhau : Form
    {
        SqlConnection connect;
        string randomCode;

        public QuenMatKhau(SqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            // Gửi OTP
            string from, pass, messageBody, to;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = textBox_Email.Text;
            from = "tanphanduy8@gmail.com";
            pass = "yoqttyqctdwajklp";
            messageBody = "Mã OTP của bạn là: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting Code";
            SmtpClient smtp = new SmtpClient("Smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);


            try
            {
                smtp.Send(message);
                MessageBox.Show("Mã OTP đã được gởi tới Gmail của bạn :3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (randomCode != (textBox_XacNhan.Text).ToString())
            {
                MessageBox.Show("Mã xác nhận không đúng !", "Thông báo !", MessageBoxButtons.OK);
                return;
            }

            try
            {
                // Đổi mật khẩu
                string query = string.Format("ALTER LOGIN {0} WITH PASSWORD = '{1}'", textBox_TK.Text, textBox_MK.Text);
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Thay đổi mật khẩu thành công !", "Thông báo !", MessageBoxButtons.OK);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Thay đổi mật khẩu thất bại !", "Thông báo !", MessageBoxButtons.OK);
            }
        }
    }
}
