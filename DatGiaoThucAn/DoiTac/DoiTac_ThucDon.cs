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
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatGiaoThucAn.DoiTac
{
    public partial class DoiTac_ThucDon : Form
    {
        string MaCH;
        int slMon;
        public DoiTac_ThucDon()
        {
            InitializeComponent();
        }
        private void DoiTac_ThucDon_Load(object sender, EventArgs e)
        {
            var db1 = UserClass.dbcontext.ThucDons.AsNoTracking();
            var db2 = UserClass.dbcontext.ThongTinDoiTacs.AsNoTracking();

            var tlb = from c in db1 join k in db2 on c.MaCh equals k.MaCuaHang
                      where k.NgDaiDien == UserClass.Ma_actor
                      select c;
            var count = UserClass.dbcontext.ThucDons.AsNoTracking().Count();

            dgv_ThucDon.DataSource = tlb.ToList();
            dgv_ThucDon.AllowUserToAddRows = false;
            //dgv_ThucDon.EditMode = DataGridViewEditMode.EditProgrammatically;
            
            var item = tlb.FirstOrDefault();
            MaCH = item.MaCh;

            slMon = Convert.ToInt32(count.ToString());


        }

        private void bt_ThemMon_Click(object sender, EventArgs e)
        {
            if(dgv_ThucDon.SelectedRows.Count != 0)
            {
                MessageBox.Show("Không thể thêm món đã có");
                return;
            }

            if(tb_TenMon.Text.Length == 0 || tb_MoTa.Text.Length == 0 || tb_GiaBan.Text.Length == 0)
            {
                MessageBox.Show("Vui long nhap thong tin mon an can them!!");
                return;
            }

            int i;
            if (!int.TryParse(tb_GiaBan.Text, out i))
            {
                MessageBox.Show("Giá bán phải là số!!");
                return;
            }

            slMon++;
            string MaMon;
            if (slMon > 9)
            {
                MaMon = "MA0" + Convert.ToString(slMon);
            }
            else MaMon = "MA00" + Convert.ToString(slMon);
            SqlCommand cmd = new SqlCommand("them_thucdon", UserClass.sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaMon", SqlDbType.Char, 5);
            cmd.Parameters.Add("@TenMon", SqlDbType.NVarChar, 80);
            cmd.Parameters.Add("@MaCH", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MieuTaMon", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@Gia", SqlDbType.Int);
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar, 30);
            cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@MaMon"].Value = MaMon;
            cmd.Parameters["@TenMon"].Value = tb_TenMon.Text.ToString();
            cmd.Parameters["@MaCH"].Value = MaCH;
            cmd.Parameters["@MieuTaMon"].Value = tb_MoTa.Text.ToString();
            cmd.Parameters["@Gia"].Value = Convert.ToInt32(tb_GiaBan.Text.ToString());
            cmd.Parameters["@TinhTrang"].Value = "Co ban";
            cmd.ExecuteNonQuery();

            int result = Convert.ToInt32(cmd.Parameters["@output"].Value);

            if (result != 1)
            {
                MessageBox.Show("Khong the them mon an");
                return;
            }
            MessageBox.Show("Them mon thanh cong");
            tb_TenMon.Clear();
            tb_GiaBan.Clear();
            tb_MoTa.Clear();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (dgv_ThucDon.SelectedRows.Count != 0 )
            {
                MessageBox.Show("Chưa chọn món cần cập nhật");
                return;
            }

            SqlCommand cmd = new SqlCommand("capnhat_mon", UserClass.sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaMon", SqlDbType.Char, 5);
            cmd.Parameters.Add("@MieuTa", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@Gia", SqlDbType.Int);
            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar, 30);
            cmd.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@MaMon"].Value = dgv_ThucDon.CurrentRow.Cells[0].Value.ToString();
            cmd.Parameters["@MieuTa"].Value = tb_MoTa.Text.ToString();
            cmd.Parameters["@Gia"].Value = Convert.ToInt32(tb_GiaBan.Text.ToString());
            cmd.Parameters["@TinhTrang"].Value = "Co ban";
            cmd.ExecuteNonQuery();

            int result = Convert.ToInt32(cmd.Parameters["@output"].Value);
            if (result != 1)
            {
                MessageBox.Show(Convert.ToString(result));
                return;
            }
            else MessageBox.Show("Cap nhat thanh cong");
            tb_TenMon.Clear();
            tb_GiaBan.Clear();
            tb_MoTa.Clear();
        }

        private void dgv_ThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_TenMon.Text = dgv_ThucDon.CurrentRow.Cells[1].Value.ToString();
            tb_GiaBan.Text = dgv_ThucDon.CurrentRow.Cells[4].Value.ToString();
            tb_MoTa.Text = dgv_ThucDon.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
