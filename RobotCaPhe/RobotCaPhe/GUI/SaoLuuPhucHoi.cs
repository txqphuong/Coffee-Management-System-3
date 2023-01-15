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
    public partial class SaoLuuPhucHoi : Form
    {
        SqlConnection connect;

        public SaoLuuPhucHoi(SqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("exec backUPFull",connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Sao lưu thành công");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KNIJTEG\\SQLEXPRESS;Initial Catalog=master;User ID=sa;Password=123"))
                {
                    SqlCommand cmd = new SqlCommand("exec restoreFull",conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Khôi phục thành công");
                } 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
