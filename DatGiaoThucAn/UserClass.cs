using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace DatGiaoThucAn
{
    internal class UserClass
    {
        public static SqlConnection sqlCon = new SqlConnection();
        public static string Ma_actor = "";
        //private static string server_name = "DESKTOP-SDTBD0C\\SQLEXPRESS";
        private static string server_name = "HOANGGIA\\HOANGGIA";


        public static void Disconnect()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                //Đóng kết nối
                sqlCon.Close();

                //Giải phóng tài nguyên
                sqlCon.Dispose();
                sqlCon = new SqlConnection();

                //Kiểm tra kết nối
                //MessageBox.Show("Đóng Kết nối DB thành công");
            }
        }
        public static void Connection (int type)
        {
            string s = "";
            switch(type)
            {
                    // vo danh
                    case -2:
                    {
                        s = @"Data Source=" + server_name + ";Initial Catalog=HTDatGiaoThucAn;Persist Security Info=True;User ID=anonimus;Password=";
                        break;
                    }
                    //admin
                    case 0:
                    {
                        s = @"Data Source=" + server_name + ";Initial Catalog=HTDatGiaoThucAn;Persist Security Info=True;User ID=HT_AD;Password=admin";
                        break;
                    }
                    //doi tac
                    case 1:
                    {
                        s = @"Data Source=" + server_name + ";Initial Catalog=HTDatGiaoThucAn;Persist Security Info=True;User ID=HT_DT;Password=123456";
                        break;
                    }
                    //khach hang
                    case 2:
                    {
                        s = @"Data Source=" + server_name + ";Initial Catalog=HTDatGiaoThucAn;Persist Security Info=True;User ID=HT_KH;Password=123456";
                        break;
                    }
                    //nhan vien
                    case 3:
                    {
                        s = @"Data Source=" + server_name + ";Initial Catalog=HTDatGiaoThucAn;Persist Security Info=True;User ID=HT_NV;Password=123456";
                        break;
                    }
                    //tai xe
                    case 4:
                    {
                        s = @"Data Source=" + server_name + ";Initial Catalog=HTDatGiaoThucAn;Persist Security Info=True;User ID=HT_TX;Password=123456";
                        break;
                    }
            }

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection();
            }
            sqlCon.ConnectionString = s;
            sqlCon.Open();

            if (sqlCon.State != ConnectionState.Open) {
                MessageBox.Show("connection fails!");
                Application.Exit();
            }
        }
    }
}
