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
    }
}
