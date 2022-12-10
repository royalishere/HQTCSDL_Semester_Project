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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DatGiaoThucAn.TaiXe
{
    public partial class TaiXe_DanhSachDH : Form
    {
        DataTable table_DonHang;
        public TaiXe_DanhSachDH()
        {
            InitializeComponent();
        }

        private void TaiXe_DanhSachDH_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select dh.MaDonHang, kh.TenKH, dh.PhiSanPham + dh.PhiVanChuyen as TongPhi, kh.SDT, dh.DCGiaoHang, " +
                "dh.HinhThucTT from DonHang dh left join KhachHang kh on dh.MaKH = kh.MaKH where dh.TinhTrang != 'Chap nhan'";

            table_DonHang = UserClass.getDataTable(sqlQuery);
            dgv_DonHang.DataSource = table_DonHang;

            dgv_DonHang.Font = new Font("Time New Roman", 13);
            dgv_DonHang.Columns[0].HeaderText = "Mã Đơn hàng";
            dgv_DonHang.Columns[1].HeaderText = "Khách Hàng";
            dgv_DonHang.Columns[2].HeaderText = "Tổng chi phí";
            dgv_DonHang.Columns[3].HeaderText = "SĐT Khách hàng";
            dgv_DonHang.Columns[4].HeaderText = "Địa chỉ giao hàng";
            dgv_DonHang.Columns[5].HeaderText = "Hình thức thanh toán";

            dgv_DonHang.DefaultCellStyle.Font = new Font("Time New Roman", 12);
            dgv_DonHang.Columns[0].Width = 150;
            dgv_DonHang.Columns[1].Width = 150;
            dgv_DonHang.Columns[2].Width = 150;
            dgv_DonHang.Columns[3].Width = 150;
            dgv_DonHang.Columns[4].Width = 150;
            dgv_DonHang.Columns[5].Width = 150;

            dgv_DonHang.AllowUserToAddRows = false;
            dgv_DonHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgv_DonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_DonHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các mục            
            tb_MaDH.Text = dgv_DonHang.CurrentRow.Cells["MaDonHang"].Value.ToString();
            tb_TenKH.Text = dgv_DonHang.CurrentRow.Cells["TenKH"].Value.ToString();
            tb_TongTien.Text = dgv_DonHang.CurrentRow.Cells["TongPhi"].Value.ToString();
            tb_dcgh.Text = dgv_DonHang.CurrentRow.Cells["DCGiaoHang"].Value.ToString();
            tb_SDT.Text = dgv_DonHang.CurrentRow.Cells["SDT"].Value.ToString();
            tb_HTTT.Text = dgv_DonHang.CurrentRow.Cells["HinhThucTT"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (table_DonHang.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng");
                return;
            }

            SqlCommand cmd = new SqlCommand("chon_donhang", UserClass.sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaDonHang", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MaTX", SqlDbType.Char, 5);
            cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@MaDonHang"].Value = dgv_DonHang.CurrentRow.Cells["MaDonHang"].Value.ToString();
            cmd.Parameters["@MaTX"].Value = UserClass.Ma_actor;
            cmd.ExecuteNonQuery();

            int result = Convert.ToInt32(cmd.Parameters["@output"].Value);

            if (result == 0)
            {
                MessageBox.Show("Nhận đơn không thành công");
            }
            else MessageBox.Show("Nhận đơn thành công");
        }
    }
}
