using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatGiaoThucAn.NhanVien
{
    public partial class Form_mainNhanVien : Form
    {
        public Form_mainNhanVien()
        {
            InitializeComponent();
        }

        private void form_hD_chuaDuyet1_Load(object sender, EventArgs e)
        {
            form_hD_chuaDuyet1.Hide();
            form_hD_daDuyet1.Hide();
            form_TaiKhoan_nv1.Hide();
        }

        private void bt_hdChuaDuyet_Click(object sender, EventArgs e)
        {
            form_hD_chuaDuyet1.Show();
            form_hD_chuaDuyet1.BringToFront();
        }

        private void bt_hdDaDuyet_Click(object sender, EventArgs e)
        {
            form_hD_daDuyet1.Show();
            form_hD_daDuyet1.BringToFront();
        }

        private void bt_nvTK_Click(object sender, EventArgs e)
        {
            form_TaiKhoan_nv1.Show();
            form_TaiKhoan_nv1.BringToFront();
        }
    }
}
