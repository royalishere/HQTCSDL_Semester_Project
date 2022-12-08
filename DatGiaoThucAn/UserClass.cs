using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatGiaoThucAn
{
    internal class UserClass
    {
        static string strCon = @"Data Source=DESKTOP-SDTBD0C\SQLEXPRESS;Initial Catalog=HTDatGiaoThucAn;Integrated Security=True";
        //static string strCon = @"Data Source=HOANGGIA\HOANGGIA;Initial Catalog=HTDatGiaoThucAn;Integrated Security=True";
        public static SqlConnection sqlCon = new SqlConnection(strCon);
        public string Ma_actor = "";
    }
}
