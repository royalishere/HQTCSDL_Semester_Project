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
using System.Data.SqlTypes;

namespace DatGiaoThucAn.NhanVien
{
    public partial class Form_HD_chuaDuyet : UserControl
    {

        public Form_HD_chuaDuyet()
        {
            InitializeComponent();
        }
        private void Form_HD_chuaDuyet_Load(object sender, EventArgs e)
        {
            if (UserClass.sqlCon.State == ConnectionState.Closed)
            {
                UserClass.sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from XacNhanHopDong xn join HopDong hd on xn.MaHD = hd.MaHopDong where TinhTrang not like N'Da xac nhan'";

            sqlCmd.Connection = UserClass.sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0));
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetString(3));
                lvi.SubItems.Add((reader.GetDateTime(7)).ToString());
                lvi.SubItems.Add((reader.GetDateTime(8)).ToString());
                lvi.SubItems.Add(reader.GetString(9));
                lvi.SubItems.Add(reader.GetString(10));
                lvi.SubItems.Add((reader.GetInt32(12)).ToString());
                lvi.SubItems.Add((reader.GetInt32(13)).ToString());

                lv_HopDongCD.Items.Add(lvi);
            }

            reader.Close();
        }

        private void lv_HopDongCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_HopDongCD.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lv_HopDongCD.SelectedItems[0];
                tb_MaHD.Text = lvi.SubItems[0].Text;
                tb_maDT.Text = lvi.SubItems[1].Text;
                tb_tgBD.Text = lvi.SubItems[3].Text;
                tb_tgKT.Text = lvi.SubItems[4].Text;
                tb_soTK.Text = lvi.SubItems[5].Text;
                tb_NH.Text = lvi.SubItems[6].Text;
                tb_PhiKH.Text = lvi.SubItems[7].Text;
                tb_PhiHH.Text = lvi.SubItems[8].Text;
            }
        }

        private void bt_duyet_Click(object sender, EventArgs e)
        {
            

            if (lv_HopDongCD.SelectedItems.Count <= 0) 
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần duyệt!");
                return;
            }

            SqlCommand cmd;

            cmd = new SqlCommand("Sp_NV_DuyetHopDong", UserClass.sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaHopDong", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaNV", SqlDbType.Char, 5);
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar, 30);    
            cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@MaHopDong"].Value = lv_HopDongCD.SelectedItems[0].SubItems[0].Text;
            cmd.Parameters["@MaNV"].Value = UserClass.Ma_actor;
            cmd.Parameters["@TinhTrang"].Value = "Da xac nhan";

            cmd.ExecuteNonQuery();

            int result = Convert.ToInt32(cmd.Parameters["@output"].Value);

            if (result != 1)
            {
                MessageBox.Show("Duyệt không thành công" + Convert.ToString(result));
                return;
            }
            else MessageBox.Show("Duyệt thành công");
            // refresh listview
            lv_HopDongCD.Items.Clear();
            Form_HD_chuaDuyet_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lv_HopDongCD.Items.Clear();
            Form_HD_chuaDuyet_Load(sender, e);
        }
    }
}
