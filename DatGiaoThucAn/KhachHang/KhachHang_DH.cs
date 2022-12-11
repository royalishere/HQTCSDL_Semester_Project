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
    }
}
