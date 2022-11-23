using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatGiaoThucAn.Admin
{
    public partial class Form_addUser : Form
    {
        public Form_addUser()
        {
            InitializeComponent();
        }

        private void Form_addUser_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_nv_Click(object sender, EventArgs e)
        {
            cb_ad.Checked = false;
        }

        private void cb_ad_Click(object sender, EventArgs e)
        {
            cb_nv.Checked = false;
        }

        private void bt_addUser_Click(object sender, EventArgs e)
        {
            if (cb_ad.Checked == false && cb_nv.Checked == false)
                MessageBox.Show("Vui lòng chọn nhân viên hoặc admin");
        }
    }
}
