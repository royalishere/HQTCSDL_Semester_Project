namespace DatGiaoThucAn.TaiXe
{
    partial class TaiXe_ThuNhap
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DonHangDN = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonHangDN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 241);
            this.panel1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(651, 181);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(149, 29);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(494, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng doanh thu";
            // 
            // 
            
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(254, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "THU NHẬP CÁ NHÂN";
            // 
            // dgv_DonHangDN
            // 
            this.dgv_DonHangDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonHangDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DonHangDN.Location = new System.Drawing.Point(0, 0);
            this.dgv_DonHangDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_DonHangDN.Name = "dgv_DonHangDN";
            this.dgv_DonHangDN.RowHeadersWidth = 51;
            this.dgv_DonHangDN.RowTemplate.Height = 25;
            this.dgv_DonHangDN.Size = new System.Drawing.Size(833, 595);
            this.dgv_DonHangDN.TabIndex = 1;
            // 
            // TaiXe_ThuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_DonHangDN);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaiXe_ThuNhap";
            this.Text = "TaiXe_ThuNhap";
            this.Load += new System.EventHandler(this.TaiXe_ThuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonHangDN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private DataGridView dgv_DonHangDN;
    }
}