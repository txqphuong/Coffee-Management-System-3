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
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class DatMon : Form
    {
        SqlConnection connect;

        // select on THUCDON, HOADON, CHITIETHOADON
        // exec on themChiTietHoaDon : select, update, insert CHITIETHOADON
        public DatMon(SqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void DatMon_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "select MAMON, TENMON from THUCDON";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cbo_Mon.DataSource = table;
                cbo_Mon.DisplayMember = "TENMON";
                cbo_Mon.ValueMember = "MAMON";
                cbo_Mon.SelectedIndex = 0;

                load_cbo_HoaDon();
                load_DataGridView();
                update_TongTien();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK);
                this.Close();
            }
        }

        void update_TongTien()
        {
            string query = string.Format("select TongTien from HOADON where MAHD = '{0}'", cbo_HoaDon.SelectedItem);
            SqlCommand cmd = new SqlCommand(query, connect);
            connect.Open();
            textBox_ThanhTien.Text = cmd.ExecuteScalar().ToString();
            connect.Close();
        }

        void load_cbo_HoaDon()
        {
            string query = "select MAHD from HOADON";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
                cbo_HoaDon.Items.Add(row[0].ToString());
            cbo_HoaDon.SelectedIndex = 0;
        }

        void load_DataGridView()
        {
            string query = string.Format("select * from CHITIETHOADON where MAHD = '{0}'",
                cbo_HoaDon.SelectedItem);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void cbo_Mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_DataGridView();
        }

        private void cbo_HoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_DataGridView();
            update_TongTien();
        }

        private void btn_HD_Click(object sender, EventArgs e)
        {
            GUI.ThemHoaDon hd = new GUI.ThemHoaDon();
            hd.ShowDialog();
            load_cbo_HoaDon();
            update_TongTien();
        }

        private void btn_Mon_Click(object sender, EventArgs e)
        {
            string query = string.Format("exec themChiTietHoaDon '{0}', '{1}', {2}",
                cbo_HoaDon.SelectedItem, cbo_Mon.SelectedValue, decimal.ToInt32(numericUpDown1.Value));
            SqlCommand cmd = new SqlCommand(query, connect);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();

            load_DataGridView();
            update_TongTien();
        }
    }
}