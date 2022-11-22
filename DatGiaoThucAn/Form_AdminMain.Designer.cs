namespace DatGiaoThucAn
{
    partial class Form_AdminMain
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
            this.bt_TaiKhoan = new System.Windows.Forms.Button();
            this.bt_DSTaiKhoan = new System.Windows.Forms.Button();
            this.form_TaiKhoan_Ad1 = new DatGiaoThucAn.Form_TaiKhoan_Ad();
            this.form_dsTaiKhoan1 = new DatGiaoThucAn.Form_DSTaiKhoan();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_TaiKhoan);
            this.panel1.Controls.Add(this.bt_DSTaiKhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 853);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_TaiKhoan
            // 
            this.bt_TaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_TaiKhoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_TaiKhoan.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_TaiKhoan.Location = new System.Drawing.Point(0, 251);
            this.bt_TaiKhoan.Name = "bt_TaiKhoan";
            this.bt_TaiKhoan.Size = new System.Drawing.Size(190, 85);
            this.bt_TaiKhoan.TabIndex = 1;
            this.bt_TaiKhoan.Text = "Tài khoản";
            this.bt_TaiKhoan.UseVisualStyleBackColor = true;
            this.bt_TaiKhoan.Click += new System.EventHandler(this.bt_TaiKhoan_Click);
            // 
            // bt_DSTaiKhoan
            // 
            this.bt_DSTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_DSTaiKhoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_DSTaiKhoan.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_DSTaiKhoan.Location = new System.Drawing.Point(0, 166);
            this.bt_DSTaiKhoan.Name = "bt_DSTaiKhoan";
            this.bt_DSTaiKhoan.Size = new System.Drawing.Size(190, 85);
            this.bt_DSTaiKhoan.TabIndex = 0;
            this.bt_DSTaiKhoan.Text = "Danh sách tài khoản";
            this.bt_DSTaiKhoan.UseVisualStyleBackColor = true;
            this.bt_DSTaiKhoan.Click += new System.EventHandler(this.bt_DSTaiKhoan_Click);
            // 
            // form_TaiKhoan_Ad1
            // 
            this.form_TaiKhoan_Ad1.Location = new System.Drawing.Point(186, 0);
            this.form_TaiKhoan_Ad1.Name = "form_TaiKhoan_Ad1";
            this.form_TaiKhoan_Ad1.Size = new System.Drawing.Size(1080, 850);
            this.form_TaiKhoan_Ad1.TabIndex = 1;
            this.form_TaiKhoan_Ad1.Load += new System.EventHandler(this.form_TaiKhoan_Ad1_Load);
            // 
            // form_dsTaiKhoan1
            // 
            this.form_dsTaiKhoan1.Location = new System.Drawing.Point(186, 0);
            this.form_dsTaiKhoan1.Name = "form_dsTaiKhoan1";
            this.form_dsTaiKhoan1.Size = new System.Drawing.Size(1080, 850);
            this.form_dsTaiKhoan1.TabIndex = 2;
            // 
            // Form_AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 853);
            this.Controls.Add(this.form_dsTaiKhoan1);
            this.Controls.Add(this.form_TaiKhoan_Ad1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_AdminMain";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button bt_DSTaiKhoan;
        private Button bt_TaiKhoan;
        private Form_TaiKhoan_Ad form_TaiKhoan_Ad1;
        private Form_DSTaiKhoan form_dsTaiKhoan1;
    }
}