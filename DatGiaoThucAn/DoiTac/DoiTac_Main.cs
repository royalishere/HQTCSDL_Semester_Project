using DatGiaoThucAn.TaiXe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatGiaoThucAn.DoiTac
{
    public partial class DoiTac_Main : Form
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
        public DoiTac_Main()
        {
            InitializeComponent();
        }

        private void TaiXe_Main_Load(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new DoiTac_ThucDon());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new DoiTac_ChiNhanh());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new DoiTac_DSHopDong());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void DangXuat()
        {
            UserClass.Disconnect();
            Application.Run(new DangNhap());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(DangXuat);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
