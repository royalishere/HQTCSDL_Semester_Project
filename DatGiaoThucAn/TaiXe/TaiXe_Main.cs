using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatGiaoThucAn.TaiXe
{
    public partial class TaiXe_Main : Form
    {
        Thread t;
        // mo 1 form con trong form cha
        private void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public TaiXe_Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiXe_TaiKhoan());
        }

        private void TaiXe_Main_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiXe_ThuNhap());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiXe_DanhSachDH());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiXe_DHDaNhan());
        }

        public void open_DangNhap()
        {
            Application.Run(new DangNhap());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_DangNhap);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
