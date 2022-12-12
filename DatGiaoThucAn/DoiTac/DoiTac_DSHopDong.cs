using Microsoft.EntityFrameworkCore;
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
    public partial class DoiTac_DSHopDong : Form
    {
        DataTable table_HopDong;

        public DoiTac_DSHopDong()
        {
            InitializeComponent();
        }

        private void DoiTac_DanhSachHopDong_Load(object sender, EventArgs e)
        {
            var db = UserClass.dbcontext.HopDongs.AsNoTracking();
            var tlb = from c in db where c.NgDaiDien == UserClass.Ma_actor select c;

            dgv_HopDong.DataSource = tlb.ToList();
            dgv_HopDong.AllowUserToAddRows = false;
            dgv_HopDong.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgv_HopDong.Columns[0].Width = 60;
            dgv_HopDong.Columns[1].Width = 100;
            dgv_HopDong.Columns[2].Width = 60;
            dgv_HopDong.Columns[3].Width = 100;
            dgv_HopDong.Columns[4].Width = 100;
            dgv_HopDong.Columns[6].Width = 100;
            dgv_HopDong.Columns[7].Width = 100;
            dgv_HopDong.Columns[8].Width = 80;
            dgv_HopDong.Columns[9].Width = 80;
        }

        private void dgv_DoiTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_HopDong.Rows.Count == 0) {
                return;
            }

            tb_MHD.Text = dgv_HopDong.CurrentRow.Cells[0].Value.ToString();
            tb_MST.Text = dgv_HopDong.CurrentRow.Cells[1].Value.ToString();
            tb_NganHang.Text = dgv_HopDong.CurrentRow.Cells[6].Value.ToString();
            tb_SoTK.Text = dgv_HopDong.CurrentRow.Cells[5].Value.ToString();
            tb_CNNH.Text = dgv_HopDong.CurrentRow.Cells[7].Value.ToString();
            dt_NgayLap.Text = dgv_HopDong.CurrentRow.Cells[3].Value.ToString();
            dt_NgayKetThuc.Text = dgv_HopDong.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

    }
}
