using System.Collections.Specialized;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading;
using System.Data.SqlClient;
using DatGiaoThucAn.NhanVien;
using DatGiaoThucAn.KhachHang;
using DatGiaoThucAn.TaiXe;

namespace DatGiaoThucAn
{
    public partial class DangNhap : Form
    {
        int user_type = -2;
        string username = "";
        string password = "";
        string Ma_user = "";
        string Loai_tk = "";
        string trang_thai = "";

        Thread t;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserClass.Connection(user_type);
        }

        private void Run_SP_DangNhap()
        {
            SqlCommand cmd = new SqlCommand("sp_DangNhap", UserClass.sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@MAACC", SqlDbType.VarChar, 15).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@LOAIACC", SqlDbType.VarChar, 15).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@TRANGTHAI",SqlDbType.VarChar, 15).Direction = ParameterDirection.Output;

            // set giá trị
            cmd.Parameters["@TENDANGNHAP"].Value = username;
            cmd.Parameters["@MATKHAU"].Value = password;
            cmd.ExecuteNonQuery();

            Ma_user = Convert.ToString(cmd.Parameters["@MAACC"].Value);
            Loai_tk = Convert.ToString(cmd.Parameters["@LOAIACC"].Value);
            trang_thai = Convert.ToString(cmd.Parameters["@TRANGTHAI"].Value);
        }

        public void open_Form ( object obj)
        {
            switch (user_type)
            {
                case 0:
                    {
                        Application.Run(new Form_AdminMain());
                        break;
                    }
                case 1:
                    {

                        break;
                    }
                case 2:
                    {
                        Application.Run(new KhachHang_Main());
                        break;
                    }
                case 3:
                    {
                        Application.Run(new Form_mainNhanVien());
                        break;
                    }
                case 4:
                    {
                        Application.Run(new TaiXe_Main());
                        break;
                    }
                case 5:
                    {
                        Application.Run(new DangKy());
                        break;
                    }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

            user_type = 5;
            t = new Thread(open_Form);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.pass_textbox.UseSystemPasswordChar)
            {
                this.pass_textbox.UseSystemPasswordChar = false;
                this.show_btn.BackgroundImage = new Bitmap(@".\Resources\eye_2.png");
            }
            else
            {
                this.pass_textbox.UseSystemPasswordChar = true;
                this.show_btn.BackgroundImage = new Bitmap(@".\Resources\eye.png");
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            username = acc_textbox.Text.Trim().ToString();
            password = pass_textbox.Text.Trim().ToString();

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Vui long nhap thong tin dang nhap!!");
                return;
            }

            Run_SP_DangNhap();

            if (Loai_tk.Length == 0)
            {
                MessageBox.Show("ten dang nhap hoac mat khau khong chinh xac");
                return;
            }

            if (trang_thai != "Kich hoat")
            {
                MessageBox.Show("tai khoan nay da bi khoa!!");
                return;
            }

            user_type = Int32.Parse(Loai_tk);
            UserClass.Ma_actor = Ma_user;
            UserClass.Disconnect();

            UserClass.Connection(user_type);
            this.Close();

            t = new Thread(open_Form);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}