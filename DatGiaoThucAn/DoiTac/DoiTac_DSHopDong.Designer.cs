namespace DatGiaoThucAn.DoiTac
{
    partial class DoiTac_DSHopDong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_CNNH = new System.Windows.Forms.TextBox();
            this.dt_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NganHang = new System.Windows.Forms.TextBox();
            this.tb_SoTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MST = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_HopDong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_CNNH);
            this.panel1.Controls.Add(this.dt_NgayLap);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dt_NgayKetThuc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_NganHang);
            this.panel1.Controls.Add(this.tb_SoTK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_MST);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_MHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 305);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(491, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày lập";
            // 
            // tb_CNNH
            // 
            this.tb_CNNH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_CNNH.Location = new System.Drawing.Point(420, 245);
            this.tb_CNNH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CNNH.Name = "tb_CNNH";
            this.tb_CNNH.ReadOnly = true;
            this.tb_CNNH.Size = new System.Drawing.Size(226, 29);
            this.tb_CNNH.TabIndex = 8;
            // 
            // dt_NgayLap
            // 
            this.dt_NgayLap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgayLap.Location = new System.Drawing.Point(462, 143);
            this.dt_NgayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_NgayLap.Name = "dt_NgayLap";
            this.dt_NgayLap.Size = new System.Drawing.Size(153, 29);
            this.dt_NgayLap.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(677, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(647, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày kết thúc";
            // 
            // dt_NgayKetThuc
            // 
            this.dt_NgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgayKetThuc.Location = new System.Drawing.Point(632, 143);
            this.dt_NgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_NgayKetThuc.Name = "dt_NgayKetThuc";
            this.dt_NgayKetThuc.Size = new System.Drawing.Size(175, 29);
            this.dt_NgayKetThuc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(236, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngân hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(433, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Chi nhánh ngân hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số tài khoản";
            // 
            // tb_NganHang
            // 
            this.tb_NganHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_NganHang.Location = new System.Drawing.Point(221, 245);
            this.tb_NganHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_NganHang.Name = "tb_NganHang";
            this.tb_NganHang.ReadOnly = true;
            this.tb_NganHang.Size = new System.Drawing.Size(161, 29);
            this.tb_NganHang.TabIndex = 3;
            // 
            // tb_SoTK
            // 
            this.tb_SoTK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_SoTK.Location = new System.Drawing.Point(18, 245);
            this.tb_SoTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_SoTK.Name = "tb_SoTK";
            this.tb_SoTK.ReadOnly = true;
            this.tb_SoTK.Size = new System.Drawing.Size(185, 29);
            this.tb_SoTK.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã hơp đồng";
            // 
            // tb_MST
            // 
            this.tb_MST.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_MST.Location = new System.Drawing.Point(221, 143);
            this.tb_MST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MST.Name = "tb_MST";
            this.tb_MST.ReadOnly = true;
            this.tb_MST.Size = new System.Drawing.Size(223, 29);
            this.tb_MST.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(258, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Số Thuế";
            // 
            // tb_MHD
            // 
            this.tb_MHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_MHD.Location = new System.Drawing.Point(18, 143);
            this.tb_MHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MHD.Name = "tb_MHD";
            this.tb_MHD.ReadOnly = true;
            this.tb_MHD.Size = new System.Drawing.Size(185, 29);
            this.tb_MHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(233, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // dgv_HopDong
            // 
            this.dgv_HopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HopDong.Location = new System.Drawing.Point(0, 305);
            this.dgv_HopDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_HopDong.Name = "dgv_HopDong";
            this.dgv_HopDong.RowHeadersWidth = 51;
            this.dgv_HopDong.RowTemplate.Height = 25;
            this.dgv_HopDong.Size = new System.Drawing.Size(833, 290);
            this.dgv_HopDong.TabIndex = 1;
            this.dgv_HopDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DoiTac_CellContentClick);
            // 
            // DoiTac_DSHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 595);
            this.Controls.Add(this.dgv_HopDong);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoiTac_DSHopDong";
            this.Text = "DSHopDong";
            this.Load += new System.EventHandler(this.DoiTac_DanhSachHopDong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox tb_MHD;
        private Label label1;
        private DataGridView dgv_HopDong;
        private Label label5;
        private Label label3;
        private TextBox tb_NganHang;
        private TextBox tb_SoTK;
        private Label label4;
        private TextBox tb_MST;
        private Label label7;
        private DateTimePicker dt_NgayLap;
        private Button button1;
        private Label label6;
        private DateTimePicker dt_NgayKetThuc;
        private TextBox tb_CNNH;
        private Label label8;
    }
}