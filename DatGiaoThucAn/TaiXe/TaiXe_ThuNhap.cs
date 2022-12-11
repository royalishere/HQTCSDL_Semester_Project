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
    public partial class TaiXe_ThuNhap : Form
    {
        DataTable table_DonHang;
        public TaiXe_ThuNhap()
        {
            InitializeComponent();
        }

        private void TaiXe_ThuNhap_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select dh.MaDonHang, kh.TenKH, dh.PhiSanPham + dh.PhiVanChuyen as TongPhi," + 
                " kh.SDT, dh.DCGiaoHang,dh.HinhThucTT from DonHang dh left join KhachHang kh on dh.MaKH =" + 
                " kh.MaKH where dh.MaDonHang in (select MaDonHang from ChiTietGiaoHang where MaTX = '" + UserClass.Ma_actor + "'" + 
                " and TinhTrangGiaoHang = 'Hoan Thanh')";

            table_DonHang = UserClass.getDataTable(sqlQuery);
            dgv_DonHangDN.DataSource = table_DonHang;

            dgv_DonHangDN.Font = new Font("Time New Roman", 13);
            dgv_DonHangDN.Columns[0].HeaderText = "Mã Đơn hàng";
            dgv_DonHangDN.Columns[1].HeaderText = "Khách Hàng";
            dgv_DonHangDN.Columns[2].HeaderText = "Tổng chi phí";
            dgv_DonHangDN.Columns[3].HeaderText = "SĐT Khách hàng";
            dgv_DonHangDN.Columns[4].HeaderText = "Địa chỉ giao hàng";
            dgv_DonHangDN.Columns[5].HeaderText = "Hình thức thanh toán";

            dgv_DonHangDN.DefaultCellStyle.Font = new Font("Time New Roman", 12);
            dgv_DonHangDN.Columns[0].Width = 150;
            dgv_DonHangDN.Columns[1].Width = 150;
            dgv_DonHangDN.Columns[2].Width = 150;
            dgv_DonHangDN.Columns[3].Width = 150;
            dgv_DonHangDN.Columns[4].Width = 150;
            dgv_DonHangDN.Columns[5].Width = 150;

            dgv_DonHangDN.AllowUserToAddRows = false;
            dgv_DonHangDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
    
}
