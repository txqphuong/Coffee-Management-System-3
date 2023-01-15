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
    public partial class PhanQuyen : Form
    {
        SqlConnection connect;

        public PhanQuyen(SqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            try
            {
                load_cbo_Users();
                load_cbo_Role();

                // Load comboBox Bảng
                object[] list_table = new object[] { "KHACHHANG", "NHANVIEN", "THUCDON", "HOADON", "CHITIETHOADON" };
                cbo_Bang.Items.AddRange(list_table);
                cbo_Bang.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
                this.Close();
            }
        }

        void load_cbo_Users()
        {
            // Tải lên comboBox các User
            string query = "SELECT pri.name As Username FROM sys.database_principals pri LEFT JOIN sys.database_permissions permit ON permit.grantee_principal_id = pri.principal_id where permit.permission_name = 'CONNECT' and pri.name != 'dbo'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable table = new DataTable();
            adapter.Fill(table);

            cbo_Users.Items.Clear();
            foreach (DataRow row in table.Rows)
                cbo_Users.Items.Add(row[0]);
            try
            {
                cbo_Users.SelectedIndex = 0;
            }
            catch { }
        }

        void load_cbo_Role()
        {
            // Load comboBox Role
            string query = "Select name From sys.database_principals Where type = 'R' and is_fixed_role = 0 and name <> 'public'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable table = new DataTable();
            adapter.Fill(table);

            cbo_Role.Items.Clear();
            foreach (DataRow row in table.Rows)
                cbo_Role.Items.Add(row[0]);
            try
            {
                cbo_Role.SelectedIndex = 0;
            }
            catch{}
        }

        private void btn_XoaUser_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không !", "Thông báo !", MessageBoxButtons.YesNo);

            if (r == DialogResult.No)
                return;

            // Chọn xóa tài khoản
            connect.Open();
            string username = (string)cbo_Users.SelectedItem;
            string query = string.Format("exec sp_dropuser {0}; exec sp_droplogin {0}", username);
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();

            // Load lại comboBox
            load_cbo_Users();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Thêm User vào Role
            string query = string.Format("sp_addrolemember {0}, {1}",
                cbo_Role.SelectedItem, cbo_Users.SelectedItem);
            SqlCommand cmd = new SqlCommand(query, connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Xóa User khỏi Role
            string query = string.Format("sp_droprolemember {0}, {1}",
                cbo_Role.SelectedItem, cbo_Users.SelectedItem);
            SqlCommand cmd = new SqlCommand(query, connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        private void btn_XoaQuyen_Click(object sender, EventArgs e)
        {
            CheckBox[] list_cb = new CheckBox[] { checkBox_Select, checkBox_Insert, checkBox_Update, checkBox_Delete };
            string[] list_quyen = new string[] { "SELECT", "INSERT", "UPDATE", "DELETE" };
            int length = 4;

            string user = (string)cbo_Users.SelectedItem;
            string table = (string)cbo_Bang.SelectedItem;

            connect.Open();
            for (int i = 0; i < length; ++i)
                if(list_cb[i].Checked)
                {
                    string query = string.Format("revoke {0} on {1} from {2}",
                        list_quyen[i], table, user);
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();

                    list_cb[i].Checked = false;
                }
            connect.Close();
        }

        private void btn_ThemQuyen_Click(object sender, EventArgs e)
        {
            CheckBox[] list_cb = new CheckBox[] { checkBox_Select, checkBox_Insert, checkBox_Update, checkBox_Delete };
            string[] list_quyen = new string[] { "SELECT", "INSERT", "UPDATE", "DELETE" };
            int length = 4;

            string user = (string)cbo_Users.SelectedItem;
            string table = (string)cbo_Bang.SelectedItem;

            connect.Open();
            for (int i = 0; i < length; ++i)
                if (list_cb[i].Checked)
                {
                    string query = string.Format("grant {0} on {1} to {2}",
                        list_quyen[i], table, user);
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();

                    list_cb[i].Checked = false;
                }
            connect.Close();
        }

        private void btn_ThemQuyenRole_Click(object sender, EventArgs e)
        {
            CheckBox[] list_cb = new CheckBox[] { checkBox_Select, checkBox_Insert, checkBox_Update, checkBox_Delete };
            string[] list_quyen = new string[] { "SELECT", "INSERT", "UPDATE", "DELETE" };
            int length = 4;

            string role = (string)cbo_Role.SelectedItem;
            string table = (string)cbo_Bang.SelectedItem;

            connect.Open();
            for (int i = 0; i < length; ++i)
                if (list_cb[i].Checked)
                {
                    string query = string.Format("grant {0} on {1} to {2}",
                        list_quyen[i], table, role);
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();

                    list_cb[i].Checked = false;
                }
            connect.Close();
        }

        private void btn_ThemRole_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string role = textBox_Role.Text;
                string query = string.Format("sp_addrole {0}", role);
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                MessageBox.Show("Role đã tồn tại !", "Thông báo !", MessageBoxButtons.OK);
            }

            load_cbo_Role();
        }
    }
}
