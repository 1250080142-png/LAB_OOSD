namespace QuanLyHoSoBenhAn.Form
{
    partial class frmThanhToanVienPhi
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
            this.txtTimKiemMaHS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.dgvChiTietChiPhi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboHinhThucThanhToan = new System.Windows.Forms.ComboBox();
            this.btnXacNhanThanhToan = new System.Windows.Forms.Button();
            this.btnPrintHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietChiPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Hồ Sơ:";
            // 
            // txtTimKiemMaHS
            // 
            this.txtTimKiemMaHS.Location = new System.Drawing.Point(130, 22);
            this.txtTimKiemMaHS.Name = "txtTimKiemMaHS";
            this.txtTimKiemMaHS.Size = new System.Drawing.Size(180, 20);
            this.txtTimKiemMaHS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Bệnh Nhân:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(130, 62);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(180, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Hồ Sơ:";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(440, 62);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(180, 20);
            this.txtMaHS.TabIndex = 5;
            // 
            // dgvChiTietChiPhi
            // 
            this.dgvChiTietChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietChiPhi.Location = new System.Drawing.Point(30, 100);
            this.dgvChiTietChiPhi.Name = "dgvChiTietChiPhi";
            this.dgvChiTietChiPhi.Size = new System.Drawing.Size(590, 140);
            this.dgvChiTietChiPhi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(440, 257);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(180, 20);
            this.txtTongTien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiền Khách Đưa:";
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Location = new System.Drawing.Point(440, 287);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(180, 20);
            this.txtTienKhachDua.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tiền Thối:";
            // 
            // txtTienThua
            // 
            this.txtTienThua.Location = new System.Drawing.Point(440, 317);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.ReadOnly = true;
            this.txtTienThua.Size = new System.Drawing.Size(180, 20);
            this.txtTienThua.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hình Thức TT:";
            // 
            // cboHinhThucThanhToan
            // 
            this.cboHinhThucThanhToan.FormattingEnabled = true;
            this.cboHinhThucThanhToan.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ ngân hàng"});
            this.cboHinhThucThanhToan.Location = new System.Drawing.Point(130, 257);
            this.cboHinhThucThanhToan.Name = "cboHinhThucThanhToan";
            this.cboHinhThucThanhToan.Size = new System.Drawing.Size(180, 21);
            this.cboHinhThucThanhToan.TabIndex = 14;
            this.cboHinhThucThanhToan.Text = "Tiền mặt";
            // 
            // btnXacNhanThanhToan
            // 
            this.btnXacNhanThanhToan.Location = new System.Drawing.Point(30, 300);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(130, 35);
            this.btnXacNhanThanhToan.TabIndex = 15;
            this.btnXacNhanThanhToan.Text = "Xác Nhận Thanh Toán";
            this.btnXacNhanThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnPrintHoaDon
            // 
            this.btnPrintHoaDon.Location = new System.Drawing.Point(180, 300);
            this.btnPrintHoaDon.Name = "btnPrintHoaDon";
            this.btnPrintHoaDon.Size = new System.Drawing.Size(130, 35);
            this.btnPrintHoaDon.TabIndex = 16;
            this.btnPrintHoaDon.Text = "In Hóa Đơn";
            this.btnPrintHoaDon.UseVisualStyleBackColor = true;
            // 
            // frmThanhToanVienPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 365);
            this.Controls.Add(this.btnPrintHoaDon);
            this.Controls.Add(this.btnXacNhanThanhToan);
            this.Controls.Add(this.cboHinhThucThanhToan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTienThua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTienKhachDua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvChiTietChiPhi);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimKiemMaHS);
            this.Controls.Add(this.label1);
            this.Name = "frmThanhToanVienPhi";
            this.Text = "Thanh Toán Viện Phí & Xuất Viện";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietChiPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiemMaHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.DataGridView dgvChiTietChiPhi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboHinhThucThanhToan;
        private System.Windows.Forms.Button btnXacNhanThanhToan;
        private System.Windows.Forms.Button btnPrintHoaDon;
    }
}