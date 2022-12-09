using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatGiaoThucAn.DangNhap_DangKi;

namespace DatGiaoThucAn
{
    public partial class DangKy : Form
    {
        public int bt_type = -1;

        Thread t;
        public DangKy()
        {
            InitializeComponent();
        }

        public void open_signUp (object obj)
        {
            switch (bt_type)
            {
                 case 0:
                    break;

                 case 1:
                    break;

                 case 2:
                    Application.Run(new DangKy_TaIXe());
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bt_type = 2;
            this.Close();
            t = new Thread(open_signUp);

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
