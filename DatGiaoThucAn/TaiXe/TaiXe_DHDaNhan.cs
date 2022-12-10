using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void cb_TT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (table_DonHang.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng");
                return;
            }

            if (cb_TT.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tình trạng muốn cập nhật");
                return;
            }

            SqlCommand cmd = new SqlCommand("capnhat_tinhtrang", UserClass.sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaDonHang", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaTX", SqlDbType.Char, 5);
            cmd.Parameters.Add("@TinhTrangGiaoHang", SqlDbType.NVarChar, 30);
            cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

            string tinhTrang = "Da nhan";

            switch(cb_TT.SelectedItem.ToString())
            {
                case "Đã nhận":
                    tinhTrang = "Da nhan";
                    break;
                case "Đang giao":
                    tinhTrang = "Dang giao";
                    break;
                case "Hoàn thành":
                    tinhTrang = "Hoan thanh";
                    break;
                default: break;
            }

            cmd.Parameters["@MaDonHang"].Value = dgv_DHDaNhan.CurrentRow.Cells["MaDonHang"].Value.ToString();
            cmd.Parameters["@MaTX"].Value = UserClass.Ma_actor;
            cmd.Parameters["@TinhTrangGiaoHang"].Value = tinhTrang;
            cmd.ExecuteNonQuery();

            int result = Convert.ToInt32(cmd.Parameters["@output"].Value);

            if (result != 1)
            {
                MessageBox.Show(Convert.ToString(result));
            }
            else MessageBox.Show("Cập nhật thành công");
        }
    }
}
