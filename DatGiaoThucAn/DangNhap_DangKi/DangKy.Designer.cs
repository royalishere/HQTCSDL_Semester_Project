namespace DatGiaoThucAn
{
    partial class DangKy
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
            this.title = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_confPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_dangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(12, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(593, 41);
            this.title.TabIndex = 9;
            this.title.Text = "HỆ THỐNG ĐẶT GIAO THỨC ĂN Ú FOOD";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(218, 147);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(220, 27);
            this.tb_username.TabIndex = 10;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(218, 222);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(220, 27);
            this.tb_pass.TabIndex = 11;
            // 
            // tb_confPass
            // 
            this.tb_confPass.Location = new System.Drawing.Point(218, 291);
            this.tb_confPass.Name = "tb_confPass";
            this.tb_confPass.Size = new System.Drawing.Size(220, 27);
            this.tb_confPass.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Confirm Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bt_dangKy
            // 
            this.bt_dangKy.Location = new System.Drawing.Point(254, 377);
            this.bt_dangKy.Name = "bt_dangKy";
            this.bt_dangKy.Size = new System.Drawing.Size(122, 38);
            this.bt_dangKy.TabIndex = 16;
            this.bt_dangKy.Text = "Đăng ký";
            this.bt_dangKy.UseVisualStyleBackColor = true;
            this.bt_dangKy.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 475);
            this.Controls.Add(this.bt_dangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_confPass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.title);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private TextBox tb_username;
        private TextBox tb_pass;
        private TextBox tb_confPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bt_dangKy;
    }
}