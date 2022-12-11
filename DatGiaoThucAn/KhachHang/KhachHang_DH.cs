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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatGiaoThucAn.KhachHang
{
    public partial class KhachHang_DH : Form
    {
        public KhachHang_DH()
        {
            InitializeComponent();
            Load_CuaHang();
        }

        public void Load_CuaHang()
        {
            var db = UserClass.dbcontext.ThongTinDoiTacs.AsNoTracking();
            var tbl = from c in db select new { ID = c.MaCuaHang, Name = c.TenCuaHang };
            foreach (var item in tbl)
            {
                clb_CuaHang.Items.Add(item);
                clb_CuaHang.DisplayMember = "Name";
            }
        }

        public void Load_MonAn(string MaCH)
        {
            var db = UserClass.dbcontext.ThucDons.AsNoTracking();
            var tbl = from c in db where c.MaCh == MaCH select new { Name = c.TenMon, Price = c.Gia, Status = c.TinhTrang };
            foreach (var item in tbl)
            {
                clb_MonAn.Items.Add(item);
                clb_MonAn.DisplayMember = "Name";
            }
        }

        private void clb_CuaHang_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                clb_MonAn.Items.Clear();
                var item = clb_CuaHang.Items[e.Index] as dynamic;
                Load_MonAn(item.ID);
            }
            else
            {
                clb_MonAn.Items.Clear();
            }
            if (e.NewValue == CheckState.Checked && clb_CuaHang.CheckedItems.Count > 0)
            {
                clb_CuaHang.ItemCheck -= clb_CuaHang_ItemCheck;
                clb_CuaHang.SetItemChecked(clb_CuaHang.CheckedIndices[0], false);
                clb_CuaHang.ItemCheck += clb_CuaHang_ItemCheck;
                string MaCH = ((dynamic)clb_CuaHang.Items[e.Index]).ID;
            }
        }
    }
}
