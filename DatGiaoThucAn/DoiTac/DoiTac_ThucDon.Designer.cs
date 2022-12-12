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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MoTa = new System.Windows.Forms.RichTextBox();
            this.bt_ThemMon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_GiaBan = new System.Windows.Forms.TextBox();
            this.tb_TenMon = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(386, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực Đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_MoTa);
            this.panel1.Controls.Add(this.bt_ThemMon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_GiaBan);
            this.panel1.Controls.Add(this.tb_TenMon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 235);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mô tả";
            // 
            // tb_MoTa
            // 
            this.tb_MoTa.Location = new System.Drawing.Point(176, 141);
            this.tb_MoTa.Name = "tb_MoTa";
            this.tb_MoTa.Size = new System.Drawing.Size(291, 57);
            this.tb_MoTa.TabIndex = 12;
            this.tb_MoTa.Text = "";
            // 
            // bt_ThemMon
            // 
            this.bt_ThemMon.AutoSize = true;
            this.bt_ThemMon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_ThemMon.Location = new System.Drawing.Point(619, 141);
            this.bt_ThemMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_ThemMon.Name = "bt_ThemMon";
            this.bt_ThemMon.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bt_ThemMon.Size = new System.Drawing.Size(123, 57);
            this.bt_ThemMon.TabIndex = 11;
            this.bt_ThemMon.Text = "Thêm món";
            this.bt_ThemMon.UseVisualStyleBackColor = true;
            this.bt_ThemMon.Click += new System.EventHandler(this.bt_ThemMon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(530, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Món";
            // 
            // tb_GiaBan
            // 
            this.tb_GiaBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_GiaBan.Location = new System.Drawing.Point(619, 85);
            this.tb_GiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_GiaBan.Name = "tb_GiaBan";
            this.tb_GiaBan.Size = new System.Drawing.Size(199, 29);
            this.tb_GiaBan.TabIndex = 7;
            // 
            // tb_TenMon
            // 
            this.tb_TenMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_TenMon.Location = new System.Drawing.Point(176, 85);
            this.tb_TenMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_TenMon.Name = "tb_TenMon";
            this.tb_TenMon.Size = new System.Drawing.Size(190, 29);
            this.tb_TenMon.TabIndex = 4;
            // 
            // dgv_ThucDon
            // 
            this.dgv_ThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThucDon.Location = new System.Drawing.Point(4, 233);
            this.dgv_ThucDon.Name = "dgv_ThucDon";
            this.dgv_ThucDon.RowHeadersWidth = 51;
            this.dgv_ThucDon.RowTemplate.Height = 29;
            this.dgv_ThucDon.Size = new System.Drawing.Size(909, 270);
            this.dgv_ThucDon.TabIndex = 14;
            // 
            // DoiTac_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 501);
            this.Controls.Add(this.dgv_ThucDon);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DoiTac_ThucDon";
            this.Text = "DoiTac_ThucDon";
            this.Load += new System.EventHandler(this.DoiTac_ThucDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox tb_GiaBan;
        private TextBox tb_TenMon;
        private Label label4;
        private Label label3;
        private Button bt_ThemMon;
        private Label label2;
        private RichTextBox tb_MoTa;
        private DataGridView dgv_ThucDon;
    }
}