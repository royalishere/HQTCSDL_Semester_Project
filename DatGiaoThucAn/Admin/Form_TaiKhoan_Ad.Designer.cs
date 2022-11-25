namespace DatGiaoThucAn
{
    partial class Form_TaiKhoan_Ad
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.bt_udPass = new System.Windows.Forms.Button();
            this.ad_username = new System.Windows.Forms.Label();
            this.ad_pass = new System.Windows.Forms.Label();
            this.update_pass = new System.Windows.Forms.Label();
            this.ad_name = new System.Windows.Forms.Label();
            this.ad_address = new System.Windows.Forms.Label();
            this.ad_phone = new System.Windows.Forms.Label();
            this.ad_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(373, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 27);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(609, 270);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 27);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(609, 371);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 27);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(609, 480);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 27);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(609, 583);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(190, 27);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(262, 480);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(190, 27);
            this.textBox7.TabIndex = 9;
            // 
            // bt_udPass
            // 
            this.bt_udPass.Location = new System.Drawing.Point(262, 581);
            this.bt_udPass.Name = "bt_udPass";
            this.bt_udPass.Size = new System.Drawing.Size(190, 29);
            this.bt_udPass.TabIndex = 10;
            this.bt_udPass.Text = "cập nhật mật khẩu";
            this.bt_udPass.UseVisualStyleBackColor = true;
            // 
            // ad_username
            // 
            this.ad_username.AutoSize = true;
            this.ad_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ad_username.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_username.Location = new System.Drawing.Point(262, 244);
            this.ad_username.Name = "ad_username";
            this.ad_username.Size = new System.Drawing.Size(140, 23);
            this.ad_username.TabIndex = 11;
            this.ad_username.Text = "Tên đăng nhập";
            this.ad_username.Click += new System.EventHandler(this.label2_Click);
            // 
            // ad_pass
            // 
            this.ad_pass.AutoSize = true;
            this.ad_pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ad_pass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_pass.Location = new System.Drawing.Point(262, 345);
            this.ad_pass.Name = "ad_pass";
            this.ad_pass.Size = new System.Drawing.Size(91, 23);
            this.ad_pass.TabIndex = 12;
            this.ad_pass.Text = "Mật khẩu";
            this.ad_pass.Click += new System.EventHandler(this.label3_Click);
            // 
            // update_pass
            // 
            this.update_pass.AutoSize = true;
            this.update_pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update_pass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.update_pass.Location = new System.Drawing.Point(262, 454);
            this.update_pass.Name = "update_pass";
            this.update_pass.Size = new System.Drawing.Size(175, 23);
            this.update_pass.TabIndex = 13;
            this.update_pass.Text = "Cập nhật mật khẩu";
            // 
            // ad_name
            // 
            this.ad_name.AutoSize = true;
            this.ad_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ad_name.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_name.Location = new System.Drawing.Point(609, 244);
            this.ad_name.Name = "ad_name";
            this.ad_name.Size = new System.Drawing.Size(67, 23);
            this.ad_name.TabIndex = 14;
            this.ad_name.Text = "Họ tên";
            // 
            // ad_address
            // 
            this.ad_address.AutoSize = true;
            this.ad_address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ad_address.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_address.Location = new System.Drawing.Point(609, 345);
            this.ad_address.Name = "ad_address";
            this.ad_address.Size = new System.Drawing.Size(69, 23);
            this.ad_address.TabIndex = 15;
            this.ad_address.Text = "Địa chỉ";
            // 
            // ad_phone
            // 
            this.ad_phone.AutoSize = true;
            this.ad_phone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ad_phone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_phone.Location = new System.Drawing.Point(609, 454);
            this.ad_phone.Name = "ad_phone";
            this.ad_phone.Size = new System.Drawing.Size(124, 23);
            this.ad_phone.TabIndex = 16;
            this.ad_phone.Text = "Số điện thoại";
            // 
            // ad_email
            // 
            this.ad_email.AutoSize = true;
            this.ad_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ad_email.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ad_email.Location = new System.Drawing.Point(609, 557);
            this.ad_email.Name = "ad_email";
            this.ad_email.Size = new System.Drawing.Size(58, 23);
            this.ad_email.TabIndex = 17;
            this.ad_email.Text = "Email";
            // 
            // Form_TaiKhoan_Ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ad_email);
            this.Controls.Add(this.ad_phone);
            this.Controls.Add(this.ad_address);
            this.Controls.Add(this.ad_name);
            this.Controls.Add(this.update_pass);
            this.Controls.Add(this.ad_pass);
            this.Controls.Add(this.ad_username);
            this.Controls.Add(this.bt_udPass);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_TaiKhoan_Ad";
            this.Size = new System.Drawing.Size(1080, 850);
            this.Load += new System.EventHandler(this.Form_TaiKhoan_Ad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button bt_udPass;
        private Label ad_username;
        private Label ad_pass;
        private Label update_pass;
        private Label ad_name;
        private Label ad_address;
        private Label ad_phone;
        private Label ad_email;
    }
}
