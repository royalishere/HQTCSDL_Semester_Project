namespace DatGiaoThucAn
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_btn = new System.Windows.Forms.Button();
            this.signup_btn = new System.Windows.Forms.Button();
            this.acc_textbox = new System.Windows.Forms.TextBox();
            this.acc_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_btn.Location = new System.Drawing.Point(218, 296);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(127, 44);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Đăng nhập";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signup_btn.Location = new System.Drawing.Point(218, 403);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(127, 44);
            this.signup_btn.TabIndex = 1;
            this.signup_btn.Text = "Đăng kí";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // acc_textbox
            // 
            this.acc_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.acc_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acc_textbox.Location = new System.Drawing.Point(192, 127);
            this.acc_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acc_textbox.Name = "acc_textbox";
            this.acc_textbox.Size = new System.Drawing.Size(183, 29);
            this.acc_textbox.TabIndex = 2;
            // 
            // acc_label
            // 
            this.acc_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.acc_label.AutoSize = true;
            this.acc_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.acc_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.acc_label.Location = new System.Drawing.Point(14, 127);
            this.acc_label.Name = "acc_label";
            this.acc_label.Size = new System.Drawing.Size(167, 32);
            this.acc_label.TabIndex = 3;
            this.acc_label.Text = "Tên tài khoản";
            // 
            // pass_label
            // 
            this.pass_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pass_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pass_label.Location = new System.Drawing.Point(54, 213);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(121, 32);
            this.pass_label.TabIndex = 4;
            this.pass_label.Text = "Mật khẩu";
            // 
            // pass_textbox
            // 
            this.pass_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pass_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_textbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pass_textbox.Location = new System.Drawing.Point(192, 213);
            this.pass_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.Size = new System.Drawing.Size(183, 29);
            this.pass_textbox.TabIndex = 2;
            this.pass_textbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(250, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hoặc";
            // 
            // show_btn
            // 
            this.show_btn.BackgroundImage = global::DatGiaoThucAn.Properties.Resources.eye;
            this.show_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_btn.Location = new System.Drawing.Point(383, 215);
            this.show_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(27, 32);
            this.show_btn.TabIndex = 7;
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(14, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(593, 41);
            this.title.TabIndex = 8;
            this.title.Text = "HỆ THỐNG ĐẶT GIAO THỨC ĂN Ú FOOD";
            // 
            // DangNhap
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 475);
            this.Controls.Add(this.title);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.acc_label);
            this.Controls.Add(this.acc_textbox);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.login_btn);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login_btn;
        private Button signup_btn;
        private TextBox acc_textbox;
        private Label acc_label;
        private Label pass_label;
        private TextBox pass_textbox;
        private Label label3;
        private Button show_btn;
        private Label title;
    }
}