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
    public partial class TaiXe_DHDaNhan : Form
    {
        DataTable table_DonHang;
        public TaiXe_DHDaNhan()
        {
            InitializeComponent();
        }

        private void TaiXe_DHDaNhan_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select dh.MaDonHang, kh.TenKH, dh.PhiSanPham + dh.PhiVanChuyen as TongPhi, kh.SDT, dh.DCGiaoHang, " +
                "dh.HinhThucTT from DonHang dh left join KhachHang kh on dh.MaKH = kh.MaKH " + 
                "where dh.MaDonHang in (select MaDonHang from ChiTietGiaoHang where MaTX = '" + UserClass.Ma_actor + "')";

            table_DonHang = UserClass.getDataTable(sqlQuery);
            dgv_DHDaNhan.DataSource = table_DonHang;

            dgv_DHDaNhan.Font = new Font("Time New Roman", 13);
            dgv_DHDaNhan.Columns[0].HeaderText = "Mã Đơn hàng";
            dgv_DHDaNhan.Columns[1].HeaderText = "Khách Hàng";
            dgv_DHDaNhan.Columns[2].HeaderText = "Tổng chi phí";
            dgv_DHDaNhan.Columns[3].HeaderText = "SĐT Khách hàng";
            dgv_DHDaNhan.Columns[4].HeaderText = "Địa chỉ giao hàng";
            dgv_DHDaNhan.Columns[5].HeaderText = "Hình thức thanh toán";

            dgv_DHDaNhan.DefaultCellStyle.Font = new Font("Time New Roman", 12);
            dgv_DHDaNhan.Columns[0].Width = 150;
            dgv_DHDaNhan.Columns[1].Width = 150;
            dgv_DHDaNhan.Columns[2].Width = 150;
            dgv_DHDaNhan.Columns[3].Width = 150;
            dgv_DHDaNhan.Columns[4].Width = 150;
            dgv_DHDaNhan.Columns[5].Width = 150;

            dgv_DHDaNhan.AllowUserToAddRows = false;
            dgv_DHDaNhan.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
