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
        public KhachHang_DH()
        {
            InitializeComponent();
            Load_DatHang();
        }

        public void Load_DatHang()
        {
            var db = UserClass.dbcontext.ThongTinDoiTacs.AsNoTracking();
            var tlb = from c in db select new { ID = c.MaCuaHang, Name = c.TenCuaHang };
            foreach (var item in tlb)
            {
                clb_CuaHang.Items.Add(item);
                clb_CuaHang.DisplayMember = "Name";
            }
        }

        public void Load_Mon(string MaCH)
        {
            var db = UserClass.dbcontext.ThucDons.AsNoTracking();
            var tlb = from c in db where c.MaCh == MaCH select new { ID = c.MaMon, Name = c.TenMon };
            foreach (var item in tlb)
            {
                clb_ThucDon.Items.Add(item);
                clb_ThucDon.DisplayMember = "Name";
            }
        }

        private void clb_CuaHang_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                clb_ThucDon.Items.Clear();
                var item = clb_CuaHang.Items[e.Index] as dynamic;
                Load_Mon(item.ID);
            }
            else
            {
                clb_ThucDon.Items.Clear();
            }

            if (e.NewValue == CheckState.Checked && clb_CuaHang.CheckedItems.Count > 0)
            {
                clb_CuaHang.ItemCheck -= clb_CuaHang_ItemCheck;
                clb_CuaHang.SetItemChecked(clb_CuaHang.CheckedIndices[0], false);
                clb_CuaHang.ItemCheck += clb_CuaHang_ItemCheck;
            }
        }

        
        private void clb_ThucDon_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && clb_ThucDon.CheckedItems.Count > 0)
            {
                clb_ThucDon.ItemCheck -= clb_ThucDon_ItemCheck;
                clb_ThucDon.SetItemChecked(clb_ThucDon.CheckedIndices[0], false);
                tb_SoLuong.Clear();
                clb_ThucDon.ItemCheck += clb_ThucDon_ItemCheck;
            }
            
            if(e.NewValue == CheckState.Checked)
            {
                var db = UserClass.dbcontext.ThucDons.AsNoTracking();
                var MonAn = clb_ThucDon.Items[e.Index] as dynamic;
                string MaMon = MonAn.ID;
                var Mon = from c in db where c.MaMon == MaMon select new { Desc = c.MieuTaMon, Price = c.Gia, Status = c.TinhTrang};

                foreach (var item in Mon)
                {
                    tb_MoTaMon.Text = item.Desc.ToString();
                    tb_Gia.Text = item.Price.ToString();
                    tb_TinhTrang.Text = item.Status.ToString();
                }
            }

            if(e.NewValue == CheckState.Unchecked)
            {
                tb_SoLuong.Clear();
                tb_MoTaMon.Clear();
                tb_Gia.Clear();
                tb_TinhTrang.Clear();
            }
        }

        private void tb_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (tb_SoLuong.Text.Length == 0)
            {
                tb_ChiPhi.Clear();
                return;
            }

            int price = Convert.ToInt32(tb_Gia.Text);
            int SoLuong = Convert.ToInt32(tb_SoLuong.Text);
            tb_ChiPhi.Text = Convert.ToString(price * SoLuong);
        }
    }
}
