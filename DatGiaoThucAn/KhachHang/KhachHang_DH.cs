using DatGiaoThucAn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatGiaoThucAn.KhachHang
{
    public partial class KhachHang_DH : Form
    {
        ThucDon Mon;
        public KhachHang_DH()
        {
            InitializeComponent();
            Load_DatHang();
        }

        public void Load_DatHang()
        {
            var db = UserClass.dbcontext.ThongTinDoiTacs.AsNoTracking();
            var tlb = from c in db select new { ID = c.MaCuaHang, Name = c.MaCuaHang };
            foreach (var item in tlb)
            {
                clb_CuaHang.Items.Add(item.Name);
            }
        }

        public void Load_MonAn()
        {
            
        }

        private void clb_CuaHang_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked && clb_CuaHang.CheckedItems.Count > 0)
            {
                clb_CuaHang.ItemCheck -= clb_CuaHang_ItemCheck;
                clb_CuaHang.SetItemChecked(clb_CuaHang.CheckedIndices[0], false);
                clb_CuaHang.ItemCheck += clb_CuaHang_ItemCheck;
            }
        }

        private void clb_CuaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

            clb_ThucDon.Items.Clear();

            if (clb_CuaHang.SelectedItem == null)
            {
                return;
            }

            string MaCH = "CH001";
            MaCH = clb_CuaHang.SelectedItem.ToString();

            var db = UserClass.dbcontext.ThucDons.AsNoTracking();
            var tlb = from c in db where c.MaCh == MaCH select new { Name = c.TenMon };
            foreach (var item in tlb)
            {
                clb_ThucDon.Items.Add(item.Name);
            }
        }
        private void clb_ThucDon_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && clb_ThucDon.CheckedItems.Count > 0)
            {
                clb_ThucDon.ItemCheck -= clb_ThucDon_ItemCheck;
                clb_ThucDon.SetItemChecked(clb_ThucDon.CheckedIndices[0], false);
                clb_ThucDon.ItemCheck += clb_ThucDon_ItemCheck;
            }
        }

        private void clb_ThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clb_ThucDon.SelectedItem == null) { return; }

            var db = UserClass.dbcontext.ThucDons.AsNoTracking();
            Mon = db.Where(p => p.TenMon == clb_ThucDon.SelectedItem.ToString() && p.MaCh == clb_CuaHang.SelectedItem.ToString()).SingleOrDefault();

            tb_MoTaMon.Text = Mon.MieuTaMon.ToString();
            tb_Gia.Text = Mon.Gia.ToString();
            tb_TinhTrang.Text = Mon.TinhTrang.ToString();
        }

        private void tb_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if ( tb_SoLuong.Text.Length == 0 ) {
                tb_ChiPhi.Clear();
                return;
            }

            int price = Convert.ToInt32(Mon.Gia);
            int SoLuong = Convert.ToInt32(tb_SoLuong.Text);
            tb_ChiPhi.Text = Convert.ToString(price * SoLuong);
        }
    }
}
