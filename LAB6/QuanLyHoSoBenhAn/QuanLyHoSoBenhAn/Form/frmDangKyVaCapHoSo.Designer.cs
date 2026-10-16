namespace QuanLyHoSoBenhAn.Form
{
    partial class frmDangKyVaCapHoSo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLePhi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.btnLuuVaCapHoSo = new System.Windows.Forms.Button();
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.txtMaPDK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bệnh Nhân:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(130, 27);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(200, 20);
            this.txtMaBN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(130, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(130, 107);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(130, 147);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Điện Thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(130, 187);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtDienThoai.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lệ Phí Hằng Năm:";
            // 
            // txtLePhi
            // 
            this.txtLePhi.Location = new System.Drawing.Point(460, 27);
            this.txtLePhi.Name = "txtLePhi";
            this.txtLePhi.Size = new System.Drawing.Size(200, 20);
            this.txtLePhi.TabIndex = 11;
            this.txtLePhi.Text = "500000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã Hồ Sơ:";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(460, 67);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(200, 20);
            this.txtMaHS.TabIndex = 13;
            // 
            // btnLuuVaCapHoSo
            // 
            this.btnLuuVaCapHoSo.Location = new System.Drawing.Point(460, 115);
            this.btnLuuVaCapHoSo.Name = "btnLuuVaCapHoSo";
            this.btnLuuVaCapHoSo.Size = new System.Drawing.Size(200, 35);
            this.btnLuuVaCapHoSo.TabIndex = 14;
            this.btnLuuVaCapHoSo.Text = "Đăng Ký & Cấp Hồ Sơ";
            this.btnLuuVaCapHoSo.UseVisualStyleBackColor = true;
            this.btnLuuVaCapHoSo.Click += new System.EventHandler(this.btnLuuVaCapHoSo_Click);
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(33, 230);
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(627, 180);
            this.dgvDanhSachBenhNhan.TabIndex = 15;
            // 
            // txtMaPDK
            // 
            this.txtMaPDK.Location = new System.Drawing.Point(130, 215);
            this.txtMaPDK.Name = "txtMaPDK";
            this.txtMaPDK.Size = new System.Drawing.Size(100, 20);
            this.txtMaPDK.TabIndex = 16;
            this.txtMaPDK.Visible = false;
            // 
            // frmDangKyVaCapHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.txtMaPDK);
            this.Controls.Add(this.dgvDanhSachBenhNhan);
            this.Controls.Add(this.btnLuuVaCapHoSo);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLePhi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.label1);
            this.Name = "frmDangKyVaCapHoSo";
            this.Text = "Đăng Ký & Cấp Hồ Sơ Bệnh Án";
            this.Load += new System.EventHandler(this.frmDangKyVaCapHoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLePhi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Button btnLuuVaCapHoSo;
        private System.Windows.Forms.DataGridView dgvDanhSachBenhNhan;
        private System.Windows.Forms.TextBox txtMaPDK;
    }
}