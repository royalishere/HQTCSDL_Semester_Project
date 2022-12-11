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
            sqlCmd.CommandText = "select * from HopDong where MaHopDong not in ( select MaHD from XacNhanHopDong )";

            sqlCmd.Connection = UserClass.sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0));
                lvi.SubItems.Add(reader.GetString(1));
                lvi.SubItems.Add(reader.GetString(2));
                lvi.SubItems.Add((reader.GetDateTime(3)).ToString());
                lvi.SubItems.Add((reader.GetDateTime(4)).ToString());
                lvi.SubItems.Add(reader.GetString(5));
                lvi.SubItems.Add(reader.GetString(6));
                lvi.SubItems.Add(reader.GetString(7));
                lvi.SubItems.Add((reader.GetInt32(8)).ToString());
                lvi.SubItems.Add((reader.GetInt32(9)).ToString());

                lv_HopDongCD.Items.Add(lvi);
            }

            reader.Close();
        }

        private void lv_HopDongCD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_duyet_Click(object sender, EventArgs e)
        {
            if (lv_HopDongCD.SelectedItems.Count <= 0) 
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần duyệt!");
                return;
            }

            string MaDT = lv_HopDongCD.SelectedItems[0].SubItems[2].Text;

            SqlCommand cmd = new SqlCommand("sp_get_MaCH",UserClass.sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaDT", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaCH", SqlDbType.Char, 5).Direction = ParameterDirection.Output;

            cmd.Parameters["@MaDT"].Value = lv_HopDongCD.SelectedItems[0].SubItems[0].ToString();
            string MaCH = Convert.ToString(cmd.Parameters["@MaCH"].Value);

            cmd.Dispose();

            cmd = new SqlCommand("Sp_NV_DuyetHopDong", UserClass.sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaHopDong", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaCH", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaNV", SqlDbType.Char, 5);
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar, 30);    
            cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@MaHopDong"].Value = lv_HopDongCD.SelectedItems[0].SubItems[0].Text;
            cmd.Parameters["@MaCH"].Value = MaCH;
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
        }
    }
}
