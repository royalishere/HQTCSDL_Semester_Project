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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DatGiaoThucAn.DangNhap_DangKi
{
    public partial class DangKy_TaIXe : Form
    {
        public DangKy_TaIXe()
        {
            InitializeComponent();
        }

        private void DangKy_TaIXe_Load(object sender, EventArgs e)
        {

        }

        private void bt_DangKy_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcmd = new SqlCommand("dangky_taixe", UserClass.sqlCon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

            sqlcmd.Parameters.Add("@matx", SqlDbType.Char, 5);
            sqlcmd.Parameters.Add("@tentx", SqlDbType.NVarChar, 50);
            sqlcmd.Parameters.Add("@ngaysinh", SqlDbType.Date);
            sqlcmd.Parameters.Add("@cccd", SqlDbType.VarChar, 12);
            sqlcmd.Parameters.Add("@sdt", SqlDbType.VarChar, 11);
            sqlcmd.Parameters.Add("@diachi", SqlDbType.VarChar, 100);
            sqlcmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
            sqlcmd.Parameters.Add("@biensoxe", SqlDbType.VarChar, 10);
            sqlcmd.Parameters.Add("@khuvuc", SqlDbType.NVarChar, 50);
            sqlcmd.Parameters.Add("@sotk", SqlDbType.VarChar, 20);
            sqlcmd.Parameters.Add("@phithue", SqlDbType.Int);
            sqlcmd.Parameters.Add("@output", SqlDbType.Int);

            sqlcmd.Parameters["@matx"].Value = tb_matx.Text.Trim().ToString();
            sqlcmd.Parameters["@tentx"].Value = tb_tentx.Text.Trim().ToString();
            sqlcmd.Parameters["@ngaysinh"].Value = DateOnly.Parse(tb_ngaysinh.Text.Trim().ToString());
            sqlcmd.Parameters["@cccd"].Value = tb_CCCD.Text.Trim().ToString();
            sqlcmd.Parameters["@sdt"].Value = tb_sdt.Text.Trim().ToString();
            sqlcmd.Parameters["@diachi"].Value = tb_dc.Text.Trim().ToString();
            sqlcmd.Parameters["@email"].Value = tb_email.Text.Trim().ToString();
            sqlcmd.Parameters["@biensoxe"].Value = tb_bsx.Text.Trim().ToString();
            sqlcmd.Parameters["@khuvuc"].Value = tb_khuvuc.Text.Trim().ToString();
            sqlcmd.Parameters["@sotk"].Value = tb_sotk.Text.Trim().ToString();
            sqlcmd.Parameters["@phithue"].Value = 10000;

            sqlcmd.ExecuteNonQuery();

            int result = Convert.ToInt32(sqlcmd.Parameters["@output"].Value);

            if (result != 1)
            {
                MessageBox.Show("Tao tai khoan khong thanh cong");
                return;
            }
            else MessageBox.Show("Tao tai khoan thanh cong");

            sqlcmd.Dispose();

            sqlcmd = new SqlCommand("sp_dangky");
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

            sqlcmd.Parameters.Add("@matk", SqlDbType.Char, 5);
            sqlcmd.Parameters.Add("@tentk", SqlDbType.VarChar, 30);
            sqlcmd.Parameters.Add("@pass", SqlDbType.VarChar, 30);
            sqlcmd.Parameters.Add("@loaitk", SqlDbType.VarChar, 30);

            sqlcmd.Parameters["@matk"].Value = tb_matx.Text.Trim().ToString();
            sqlcmd.Parameters["@tentk"].Value = tb_username.Text.Trim().ToString();
            sqlcmd.Parameters["@pass"].Value = tb_pass.Text.Trim().ToString();
            sqlcmd.Parameters["@loaitk"].Value = "TX";

            sqlcmd.ExecuteNonQuery();
        }
    }
}
