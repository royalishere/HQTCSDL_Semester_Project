using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatGiaoThucAn
{
    public partial class Form_AdminMain : Form
    {
        public Form_AdminMain()
        {
            InitializeComponent();
            form_dsTaiKhoan1.Hide();
            form_TaiKhoan_Ad1.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_dsTaiKhoan2_Load(object sender, EventArgs e)
        {

        }

        private void bt_DSTaiKhoan_Click(object sender, EventArgs e)
        {
            form_TaiKhoan_Ad1.Hide();
            form_dsTaiKhoan1.Show();
            form_dsTaiKhoan1.BringToFront();
        }

        private void bt_TaiKhoan_Click(object sender, EventArgs e)
        {
            form_dsTaiKhoan1.Hide();
            form_TaiKhoan_Ad1.Show();
            form_TaiKhoan_Ad1.BringToFront();
        }

        private void form_TaiKhoan_Ad_Load(object sender, EventArgs e)
        {

        }

        private void form_TaiKhoan_Ad1_Load(object sender, EventArgs e)
        {

        }
    }
}
