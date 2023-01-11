using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatGiaoThucAn.NhanVien
{
    public partial class Form_HD_daDuyet : UserControl
    {
        public Form_HD_daDuyet()
        {
            InitializeComponent();
        }

        private void Form_HD_daDuyet_Load(object sender, EventArgs e)
        {
            if (UserClass.sqlCon.State == ConnectionState.Closed)
            {
                UserClass.sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from HopDong hd join XacNhanHopDong xn on hd.MaHopDong = xn.MaHD where xn.TinhTrang like N'Da xac nhan'";

            sqlCmd.Connection = UserClass.sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0));
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add((reader.GetDateTime(3)).ToString());
                lvi.SubItems.Add((reader.GetDateTime(4)).ToString());
                lvi.SubItems.Add(reader.GetString(5));
                lvi.SubItems.Add(reader.GetString(6));
                lvi.SubItems.Add(reader.GetString(7));
                lvi.SubItems.Add((reader.GetInt32(8)).ToString());
                lvi.SubItems.Add((reader.GetInt32(9)).ToString());
                lvi.SubItems.Add(reader.GetString(11));
                lvi.SubItems.Add(reader.GetString(12));
                lv_HopDongDD.Items.Add(lvi);
            }

            reader.Close();
        }

        private void lv_HopDongDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_HopDongDD.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lv_HopDongDD.SelectedItems[0];
                tb_MaHD.Text = lvi.SubItems[0].Text;
                tb_maDT.Text = lvi.SubItems[9].Text;
                tb_tgBD.Text = lvi.SubItems[2].Text;
                tb_tgKT.Text = lvi.SubItems[3].Text;
                tb_soTK.Text = lvi.SubItems[4].Text;
                tb_NH.Text = lvi.SubItems[5].Text;
                tb_PhiKH.Text = lvi.SubItems[7].Text;
                tb_PhiHH.Text = lvi.SubItems[8].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserClass.sqlCon.State == ConnectionState.Closed)
            {
                UserClass.sqlCon.Open();
            }
            ListViewItem lvi = lv_HopDongDD.SelectedItems[0];
            SqlCommand cmd = new SqlCommand("GiaHanHopDong", UserClass.sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHD", tb_MaHD.Text);
            // subtract two dates to get number of month
            DateTime date1 = DateTime.Parse(lvi.SubItems[3].Text);
            DateTime date2 = DateTime.Parse(tb_tgKT.Text);
            int month = (date2.Year - date1.Year) * 12 + date2.Month - date1.Month;
            cmd.Parameters.AddWithValue("@soThang", month);
            cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            
            int result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            if (result == 1)
            {
                MessageBox.Show("Gia hạn thành công");
            }
            else
            {
                MessageBox.Show("Gia hạn thất bại");
            }
            // refresh listview
            lv_HopDongDD.Items.Clear();
            Form_HD_daDuyet_Load(sender, e);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lv_HopDongDD.Items.Clear();
            Form_HD_daDuyet_Load(sender, e);
        }
    }
}
