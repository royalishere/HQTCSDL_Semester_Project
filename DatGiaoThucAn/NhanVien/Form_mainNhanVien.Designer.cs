namespace DatGiaoThucAn.NhanVien
{
    partial class Form_mainNhanVien
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
            this.button5 = new System.Windows.Forms.Button();
            this.bt_nvTK = new System.Windows.Forms.Button();
            this.bt_hdDaDuyet = new System.Windows.Forms.Button();
            this.bt_hdChuaDuyet = new System.Windows.Forms.Button();
            this.form_hD_chuaDuyet1 = new DatGiaoThucAn.NhanVien.Form_HD_chuaDuyet();
            this.form_hD_daDuyet1 = new DatGiaoThucAn.NhanVien.Form_HD_daDuyet();
            this.form_TaiKhoan_nv1 = new DatGiaoThucAn.NhanVien.Form_TaiKhoan_NV();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.bt_nvTK);
            this.panel1.Controls.Add(this.bt_hdDaDuyet);
            this.panel1.Controls.Add(this.bt_hdChuaDuyet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 562);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(23, 354);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "ĐĂNG XUẤT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_nvTK
            // 
            this.bt_nvTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nvTK.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_nvTK.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_nvTK.Location = new System.Drawing.Point(0, 252);
            this.bt_nvTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_nvTK.Name = "bt_nvTK";
            this.bt_nvTK.Size = new System.Drawing.Size(166, 64);
            this.bt_nvTK.TabIndex = 2;
            this.bt_nvTK.Text = "Tài khoản";
            this.bt_nvTK.UseVisualStyleBackColor = true;
            this.bt_nvTK.Click += new System.EventHandler(this.bt_nvTK_Click);
            // 
            // bt_hdDaDuyet
            // 
            this.bt_hdDaDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hdDaDuyet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_hdDaDuyet.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_hdDaDuyet.Location = new System.Drawing.Point(0, 188);
            this.bt_hdDaDuyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_hdDaDuyet.Name = "bt_hdDaDuyet";
            this.bt_hdDaDuyet.Size = new System.Drawing.Size(166, 64);
            this.bt_hdDaDuyet.TabIndex = 1;
            this.bt_hdDaDuyet.Text = "Hợp đồng đã duyệt";
            this.bt_hdDaDuyet.UseVisualStyleBackColor = true;
            this.bt_hdDaDuyet.Click += new System.EventHandler(this.bt_hdDaDuyet_Click);
            // 
            // bt_hdChuaDuyet
            // 
            this.bt_hdChuaDuyet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_hdChuaDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hdChuaDuyet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_hdChuaDuyet.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_hdChuaDuyet.Location = new System.Drawing.Point(0, 124);
            this.bt_hdChuaDuyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_hdChuaDuyet.Name = "bt_hdChuaDuyet";
            this.bt_hdChuaDuyet.Size = new System.Drawing.Size(166, 64);
            this.bt_hdChuaDuyet.TabIndex = 0;
            this.bt_hdChuaDuyet.Text = "Hợp đồng chưa duyệt";
            this.bt_hdChuaDuyet.UseVisualStyleBackColor = false;
            this.bt_hdChuaDuyet.Click += new System.EventHandler(this.bt_hdChuaDuyet_Click);
            // 
            // form_hD_chuaDuyet1
            // 
            this.form_hD_chuaDuyet1.Location = new System.Drawing.Point(166, 0);
            this.form_hD_chuaDuyet1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form_hD_chuaDuyet1.Name = "form_hD_chuaDuyet1";
            this.form_hD_chuaDuyet1.Size = new System.Drawing.Size(945, 638);
            this.form_hD_chuaDuyet1.TabIndex = 1;
            this.form_hD_chuaDuyet1.Load += new System.EventHandler(this.form_hD_chuaDuyet1_Load);
            // 
            // form_hD_daDuyet1
            // 
            this.form_hD_daDuyet1.Location = new System.Drawing.Point(166, 0);
            this.form_hD_daDuyet1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form_hD_daDuyet1.Name = "form_hD_daDuyet1";
            this.form_hD_daDuyet1.Size = new System.Drawing.Size(945, 638);
            this.form_hD_daDuyet1.TabIndex = 2;
            // 
            // form_TaiKhoan_nv1
            // 
            this.form_TaiKhoan_nv1.Location = new System.Drawing.Point(166, 0);
            this.form_TaiKhoan_nv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form_TaiKhoan_nv1.Name = "form_TaiKhoan_nv1";
            this.form_TaiKhoan_nv1.Size = new System.Drawing.Size(945, 638);
            this.form_TaiKhoan_nv1.TabIndex = 3;
            // 
            // Form_mainNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 562);
            this.Controls.Add(this.form_TaiKhoan_nv1);
            this.Controls.Add(this.form_hD_daDuyet1);
            this.Controls.Add(this.form_hD_chuaDuyet1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_mainNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button bt_hdChuaDuyet;
        private Button bt_hdDaDuyet;
        private Button bt_nvTK;
        private Form_HD_chuaDuyet form_hD_chuaDuyet1;
        private Form_HD_daDuyet form_hD_daDuyet1;
        private Form_TaiKhoan_NV form_TaiKhoan_nv1;
        private Button button5;
    }
}