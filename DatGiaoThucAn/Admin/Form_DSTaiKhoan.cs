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
using DatGiaoThucAn.Admin;

namespace DatGiaoThucAn
{
    public partial class Form_DSTaiKhoan : UserControl
    {
        string strCon = @"Data Source=DESKTOP-SDTBD0C\SQLEXPRESS;Initial Catalog=HTDatGiaoThucAn;Integrated Security=True";
        SqlConnection sqlCon = null;

        public Form_DSTaiKhoan()
        {
            InitializeComponent();  
        }

        private void Form_DSTaiKhoan_Load(object sender, EventArgs e)
        {
            //lấy dữ liệu bảng tài khoản
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from TaiKhoan";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string MaTK = reader.GetString(0);
                string TenDN = reader.GetString(1);
                string MK = reader.GetString(2);
                string LoaiTK = reader.GetString(3);
                string trangThai = reader.GetString(4);

                ListViewItem lvi = new ListViewItem(MaTK);
                lvi.SubItems.Add(TenDN);
                lvi.SubItems.Add(MK);
                lvi.SubItems.Add(LoaiTK);
                lvi.SubItems.Add(trangThai);

                lv_DSTaiKhoan.Items.Add(lvi);
            }

            reader.Close();
        }

        private void lv_DSTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_DSTaiKhoan.SelectedItems.Count > 0)
            {

                string strUser = lv_DSTaiKhoan.SelectedItems[0].SubItems[0].Text;
                string strPass = lv_DSTaiKhoan.SelectedItems[0].SubItems[1].Text;
                string strUType = lv_DSTaiKhoan.SelectedItems[0].SubItems[4].Text;

                Username.Text = strUser;
                Password.Text = strPass;
                UserType.Text = strUType;
            }
        }

        private void bt_AddUser_Click(object sender, EventArgs e)
        {
            Form_addUser subForm = new Form_addUser();
            subForm.StartPosition = FormStartPosition.CenterParent;
            subForm.ShowDialog();

        }

        private void bt_updateData_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            lv_DSTaiKhoan.Items.Clear();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from TaiKhoan";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string MaTK = reader.GetString(0);
                string TenDN = reader.GetString(1);
                string MK = reader.GetString(2);
                string LoaiTK = reader.GetString(3);
                string trangThai = reader.GetString(4);

                ListViewItem lvi = new ListViewItem(MaTK);
                lvi.SubItems.Add(TenDN);
                lvi.SubItems.Add(MK);
                lvi.SubItems.Add(LoaiTK);
                lvi.SubItems.Add(trangThai);

                lv_DSTaiKhoan.Items.Add(lvi);
            }

            reader.Close();
        }
    }
}
