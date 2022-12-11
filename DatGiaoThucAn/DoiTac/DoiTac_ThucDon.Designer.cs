namespace DatGiaoThucAn.DoiTac
{
    partial class DoiTac_ThucDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_GiaBan = new System.Windows.Forms.TextBox();
            this.tb_TenMon = new System.Windows.Forms.TextBox();
            this.cb_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.dgv_ThucDon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực Đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_GiaBan);
            this.panel1.Controls.Add(this.tb_TenMon);
            this.panel1.Controls.Add(this.cb_ChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 176);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(616, 106);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(494, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chi Nhánh";
            // 
            // tb_GiaBan
            // 
            this.tb_GiaBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_GiaBan.Location = new System.Drawing.Point(572, 64);
            this.tb_GiaBan.Name = "tb_GiaBan";
            this.tb_GiaBan.PlaceholderText = "Lọc món theo giá";
            this.tb_GiaBan.Size = new System.Drawing.Size(175, 25);
            this.tb_GiaBan.TabIndex = 7;
            // 
            // tb_TenMon
            // 
            this.tb_TenMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_TenMon.Location = new System.Drawing.Point(152, 112);
            this.tb_TenMon.Name = "tb_TenMon";
            this.tb_TenMon.PlaceholderText = "Nhập tên món cần tìm";
            this.tb_TenMon.Size = new System.Drawing.Size(167, 25);
            this.tb_TenMon.TabIndex = 4;
            // 
            // cb_ChiNhanh
            // 
            this.cb_ChiNhanh.FormattingEnabled = true;
            this.cb_ChiNhanh.Location = new System.Drawing.Point(152, 64);
            this.cb_ChiNhanh.Name = "cb_ChiNhanh";
            this.cb_ChiNhanh.Size = new System.Drawing.Size(167, 23);
            this.cb_ChiNhanh.TabIndex = 2;
            // 
            // dgv_ThucDon
            // 
            this.dgv_ThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThucDon.Location = new System.Drawing.Point(0, 0);
            this.dgv_ThucDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_ThucDon.Name = "dgv_ThucDon";
            this.dgv_ThucDon.RowHeadersWidth = 51;
            this.dgv_ThucDon.RowTemplate.Height = 25;
            this.dgv_ThucDon.Size = new System.Drawing.Size(800, 376);
            this.dgv_ThucDon.TabIndex = 1;
            this.dgv_ThucDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThucDon_CellContentClick);
            // 
            // DoiTac_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_ThucDon);
            this.Name = "DoiTac_ThucDon";
            this.Text = "DoiTac_ThucDon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dgv_ThucDon;
        private TextBox tb_GiaBan;
        private TextBox tb_TenMon;
        private ComboBox cb_ChiNhanh;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button button2;
    }
}