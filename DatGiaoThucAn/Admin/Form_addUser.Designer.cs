namespace DatGiaoThucAn.Admin
{
    partial class Form_addUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_confPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_nv = new System.Windows.Forms.CheckBox();
            this.cb_ad = new System.Windows.Forms.CheckBox();
            this.bt_addUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(210, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm tài khoản";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(188, 166);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(257, 27);
            this.tb_user.TabIndex = 1;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(188, 249);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(257, 27);
            this.tb_pass.TabIndex = 2;
            // 
            // tb_confPass
            // 
            this.tb_confPass.Location = new System.Drawing.Point(188, 334);
            this.tb_confPass.Name = "tb_confPass";
            this.tb_confPass.Size = new System.Drawing.Size(257, 27);
            this.tb_confPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên tài khoản";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // cb_nv
            // 
            this.cb_nv.AutoSize = true;
            this.cb_nv.Location = new System.Drawing.Point(188, 416);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(97, 24);
            this.cb_nv.TabIndex = 7;
            this.cb_nv.Text = "Nhân viên";
            this.cb_nv.UseVisualStyleBackColor = true;
            this.cb_nv.Click += new System.EventHandler(this.cb_nv_Click);
            // 
            // cb_ad
            // 
            this.cb_ad.AutoSize = true;
            this.cb_ad.Location = new System.Drawing.Point(359, 416);
            this.cb_ad.Name = "cb_ad";
            this.cb_ad.Size = new System.Drawing.Size(75, 24);
            this.cb_ad.TabIndex = 8;
            this.cb_ad.Text = "Admin";
            this.cb_ad.UseVisualStyleBackColor = true;
            this.cb_ad.Click += new System.EventHandler(this.cb_ad_Click);
            // 
            // bt_addUser
            // 
            this.bt_addUser.Location = new System.Drawing.Point(222, 480);
            this.bt_addUser.Name = "bt_addUser";
            this.bt_addUser.Size = new System.Drawing.Size(160, 51);
            this.bt_addUser.TabIndex = 9;
            this.bt_addUser.Text = "Thêm tài khoản";
            this.bt_addUser.UseVisualStyleBackColor = true;
            this.bt_addUser.Click += new System.EventHandler(this.bt_addUser_Click);
            // 
            // Form_addUser
            // 
            this.ClientSize = new System.Drawing.Size(637, 577);
            this.Controls.Add(this.bt_addUser);
            this.Controls.Add(this.cb_ad);
            this.Controls.Add(this.cb_nv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_confPass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label1);
            this.Name = "Form_addUser";
            this.Load += new System.EventHandler(this.Form_addUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_user;
        private TextBox tb_pass;
        private TextBox tb_confPass;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox cb_nv;
        private CheckBox cb_ad;
        private Button bt_addUser;
    }
}