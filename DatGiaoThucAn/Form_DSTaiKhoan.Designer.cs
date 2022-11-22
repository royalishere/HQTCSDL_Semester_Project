namespace DatGiaoThucAn
{
    partial class Form_DSTaiKhoan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.UserType = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_AddUser = new System.Windows.Forms.Button();
            this.lv_DSTaiKhoan = new System.Windows.Forms.ListView();
            this.MaTK = new System.Windows.Forms.ColumnHeader();
            this.TenDangNhap = new System.Windows.Forms.ColumnHeader();
            this.MatKhau = new System.Windows.Forms.ColumnHeader();
            this.LoaiTK = new System.Windows.Forms.ColumnHeader();
            this.TrangThai = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(387, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(217, 208);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(184, 27);
            this.Username.TabIndex = 2;
            // 
            // UserType
            // 
            this.UserType.Location = new System.Drawing.Point(730, 208);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(184, 27);
            this.UserType.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(474, 208);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(184, 27);
            this.Password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(217, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(730, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(474, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật khẩu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bt_AddUser
            // 
            this.bt_AddUser.Location = new System.Drawing.Point(474, 291);
            this.bt_AddUser.Name = "bt_AddUser";
            this.bt_AddUser.Size = new System.Drawing.Size(184, 39);
            this.bt_AddUser.TabIndex = 8;
            this.bt_AddUser.Text = "Thêm tài khoản";
            this.bt_AddUser.UseVisualStyleBackColor = true;
            this.bt_AddUser.Click += new System.EventHandler(this.bt_AddUser_Click);
            // 
            // lv_DSTaiKhoan
            // 
            this.lv_DSTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaTK,
            this.TenDangNhap,
            this.MatKhau,
            this.LoaiTK,
            this.TrangThai});
            this.lv_DSTaiKhoan.FullRowSelect = true;
            this.lv_DSTaiKhoan.GridLines = true;
            this.lv_DSTaiKhoan.Location = new System.Drawing.Point(20, 414);
            this.lv_DSTaiKhoan.Name = "lv_DSTaiKhoan";
            this.lv_DSTaiKhoan.Size = new System.Drawing.Size(1037, 388);
            this.lv_DSTaiKhoan.TabIndex = 9;
            this.lv_DSTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lv_DSTaiKhoan.View = System.Windows.Forms.View.Details;
            this.lv_DSTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.lv_DSTaiKhoan_SelectedIndexChanged);
            // 
            // MaTK
            // 
            this.MaTK.Text = " MaTK";
            this.MaTK.Width = 100;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.Text = "TenDangNhap";
            this.TenDangNhap.Width = 150;
            // 
            // MatKhau
            // 
            this.MatKhau.Text = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // LoaiTK
            // 
            this.LoaiTK.Text = "LoaiTK";
            this.LoaiTK.Width = 100;
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "TrangThai";
            this.TrangThai.Width = 150;
            // 
            // Form_DSTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lv_DSTaiKhoan);
            this.Controls.Add(this.bt_AddUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Name = "Form_DSTaiKhoan";
            this.Size = new System.Drawing.Size(1080, 850);
            this.Load += new System.EventHandler(this.Form_DSTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox Username;
        private TextBox UserType;
        private TextBox Password;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_AddUser;
        private ListView lv_DSTaiKhoan;
        private ColumnHeader MaTK;
        private ColumnHeader TenDangNhap;
        private ColumnHeader MatKhau;
        private ColumnHeader LoaiTK;
        private ColumnHeader TrangThai;
    }
}
