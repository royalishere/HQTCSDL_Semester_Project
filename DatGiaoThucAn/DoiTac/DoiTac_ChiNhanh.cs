using DatGiaoThucAn.Models;
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
    public partial class DoiTac_ChiNhanh : Form
    {
        string MaCH;
        public DoiTac_ChiNhanh()
        {
            InitializeComponent();
        }

        private void DoiTac_ChiNhanh_Load(object sender, EventArgs e)
        {
            var db1 = UserClass.dbcontext.ThongTinDoiTacs.AsNoTracking();
            var db2 = UserClass.dbcontext.CuaHangChiNhanhs.AsNoTracking();
            var tlb = from c in db1
                      join k in db2 on c.MaCuaHang equals k.CuaHang
                      where c.NgDaiDien == UserClass.Ma_actor
                      select new { MaCH = c.MaCuaHang, TenCuaHang = c.TenCuaHang, DiaChi = k.DiaChi, ChiNhanh = k.ChiNhanh };

            dgv_ChiNhanh.DataSource = tlb.ToList();
            dgv_ChiNhanh.AllowUserToAddRows = false;
            dgv_ChiNhanh.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

    }
}
