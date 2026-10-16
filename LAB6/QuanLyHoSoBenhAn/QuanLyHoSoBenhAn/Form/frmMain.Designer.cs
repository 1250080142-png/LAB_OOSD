namespace QuanLyHoSoBenhAn.Form
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangKyKham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuuHoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhamBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhamVaKeToa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThanhToanVienPhi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichHen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatLichHen = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.grpStat3 = new System.Windows.Forms.GroupBox();
            this.lblLichHenHomNay = new System.Windows.Forms.Label();
            this.grpStat2 = new System.Windows.Forms.GroupBox();
            this.lblSoBenhNhanChoKham = new System.Windows.Forms.Label();
            this.grpStat1 = new System.Windows.Forms.GroupBox();
            this.lblTongBenhNhan = new System.Windows.Forms.Label();
            this.dgvBenhNhanMoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.grpStat3.SuspendLayout();
            this.grpStat2.SuspendLayout();
            this.grpStat1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhanMoi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLyBenhNhan,
            this.mnuKhamBenh,
            this.mnuThanhToan,
            this.mnuLichHen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(71, 20);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(129, 22);
            this.mnuDangXuat.Text = "Đăng Xuất";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(129, 22);
            this.mnuThoat.Text = "Thoát";
            // 
            // mnuQuanLyBenhNhan
            // 
            this.mnuQuanLyBenhNhan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangKyKham,
            this.mnuTraCuuHoSo});
            this.mnuQuanLyBenhNhan.Name = "mnuQuanLyBenhNhan";
            this.mnuQuanLyBenhNhan.Size = new System.Drawing.Size(123, 20);
            this.mnuQuanLyBenhNhan.Text = "Quản Lý Bệnh Nhân";
            // 
            // mnuDangKyKham
            // 
            this.mnuDangKyKham.Name = "mnuDangKyKham";
            this.mnuDangKyKham.Size = new System.Drawing.Size(193, 22);
            this.mnuDangKyKham.Text = "Đăng Ký & Cấp Hồ Sơ";
            // 
            // mnuTraCuuHoSo
            // 
            this.mnuTraCuuHoSo.Name = "mnuTraCuuHoSo";
            this.mnuTraCuuHoSo.Size = new System.Drawing.Size(193, 22);
            this.mnuTraCuuHoSo.Text = "Tra Cứu Hồ Sơ Bệnh Án";
            // 
            // mnuKhamBenh
            // 
            this.mnuKhamBenh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhamVaKeToa});
            this.mnuKhamBenh.Name = "mnuKhamBenh";
            this.mnuKhamBenh.Size = new System.Drawing.Size(80, 20);
            this.mnuKhamBenh.Text = "Khám Bệnh";
            // 
            // mnuKhamVaKeToa
            // 
            this.mnuKhamVaKeToa.Name = "mnuKhamVaKeToa";
            this.mnuKhamVaKeToa.Size = new System.Drawing.Size(192, 22);
            this.mnuKhamVaKeToa.Text = "Khám Bệnh & Kê Toa";
            // 
            // mnuThanhToan
            // 
            this.mnuThanhToan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThanhToanVienPhi});
            this.mnuThanhToan.Name = "mnuThanhToan";
            this.mnuThanhToan.Size = new System.Drawing.Size(82, 20);
            this.mnuThanhToan.Text = "Thanh Toán";
            // 
            // mnuThanhToanVienPhi
            // 
            this.mnuThanhToanVienPhi.Name = "mnuThanhToanVienPhi";
            this.mnuThanhToanVienPhi.Size = new System.Drawing.Size(182, 22);
            this.mnuThanhToanVienPhi.Text = "Thanh Toán Viện Phí";
            // 
            // mnuLichHen
            // 
            this.mnuLichHen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatLichHen});
            this.mnuLichHen.Name = "mnuLichHen";
            this.mnuLichHen.Size = new System.Drawing.Size(66, 20);
            this.mnuLichHen.Text = "Lịch Hẹn";
            // 
            // mnuDatLichHen
            // 
            this.mnuDatLichHen.Name = "mnuDatLichHen";
            this.mnuDatLichHen.Size = new System.Drawing.Size(167, 22);
            this.mnuDatLichHen.Text = "Đặt Lịch Khám";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.grpStat3);
            this.pnlDashboard.Controls.Add(this.grpStat2);
            this.pnlDashboard.Controls.Add(this.grpStat1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle::Top;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 24);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(900, 110);
            this.pnlDashboard.TabIndex = 1;
            // 
            // grpStat3
            // 
            this.grpStat3.Controls.Add(this.lblLichHenHomNay);
            this.grpStat3.Location = new System.Drawing.Point(600, 15);
            this.grpStat3.Name = "grpStat3";
            this.grpStat3.Size = new System.Drawing.Size(260, 80);
            this.grpStat3.TabIndex = 2;
            this.grpStat3.TabStop = false;
            this.grpStat3.Text = "Lịch Hẹn Khám Hôm Nay";
            // 
            // lblLichHenHomNay
            // 
            this.lblLichHenHomNay.AutoSize = true;
            this.lblLichHenHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichHenHomNay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLichHenHomNay.Location = new System.Drawing.Point(110, 30);
            this.lblLichHenHomNay.Name = "lblLichHenHomNay";
            this.lblLichHenHomNay.Size = new System.Drawing.Size(30, 31);
            this.lblLichHenHomNay.TabIndex = 0;
            this.lblLichHenHomNay.Text = "0";
            // 
            // grpStat2
            // 
            this.grpStat2.Controls.Add(this.lblSoBenhNhanChoKham);
            this.grpStat2.Location = new System.Drawing.Point(310, 15);
            this.grpStat2.Name = "grpStat2";
            this.grpStat2.Size = new System.Drawing.Size(260, 80);
            this.grpStat2.TabIndex = 1;
            this.grpStat2.TabStop = false;
            this.grpStat2.Text = "Bệnh Nhân Chờ Khám";
            // 
            // lblSoBenhNhanChoKham
            // 
            this.lblSoBenhNhanChoKham.AutoSize = true;
            this.lblSoBenhNhanChoKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBenhNhanChoKham.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSoBenhNhanChoKham.Location = new System.Drawing.Point(110, 30);
            this.lblSoBenhNhanChoKham.Name = "lblSoBenhNhanChoKham";
            this.lblSoBenhNhanChoKham.Size = new System.Drawing.Size(30, 31);
            this.lblSoBenhNhanChoKham.TabIndex = 0;
            this.lblSoBenhNhanChoKham.Text = "0";
            // 
            // grpStat1
            // 
            this.grpStat1.Controls.Add(this.lblTongBenhNhan);
            this.grpStat1.Location = new System.Drawing.Point(20, 15);
            this.grpStat1.Name = "grpStat1";
            this.grpStat1.Size = new System.Drawing.Size(260, 80);
            this.grpStat1.TabIndex = 0;
            this.grpStat1.TabStop = false;
            this.grpStat1.Text = "Tổng Số Bệnh Nhân";
            // 
            // lblTongBenhNhan
            // 
            this.lblTongBenhNhan.AutoSize = true;
            this.lblTongBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongBenhNhan.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTongBenhNhan.Location = new System.Drawing.Point(110, 30);
            this.lblTongBenhNhan.Name = "lblTongBenhNhan";
            this.lblTongBenhNhan.Size = new System.Drawing.Size(30, 31);
            this.lblTongBenhNhan.TabIndex = 0;
            this.lblTongBenhNhan.Text = "0";
            // 
            // dgvBenhNhanMoi
            // 
            this.dgvBenhNhanMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhanMoi.Location = new System.Drawing.Point(20, 180);
            this.dgvBenhNhanMoi.Name = "dgvBenhNhanMoi";
            this.dgvBenhNhanMoi.Size = new System.Drawing.Size(860, 290);
            this.dgvBenhNhanMoi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Bệnh Nhân Đăng Ký Mới";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBenhNhanMoi);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Trang Chủ - Hệ Thống Quản Lý Hồ Sơ Bệnh Án";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.grpStat3.ResumeLayout(false);
            this.grpStat3.PerformLayout();
            this.grpStat2.ResumeLayout(false);
            this.grpStat2.PerformLayout();
            this.grpStat1.ResumeLayout(false);
            this.grpStat1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhanMoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDangKyKham;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuuHoSo;
        private System.Windows.Forms.ToolStripMenuItem mnuKhamBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuKhamVaKeToa;
        private System.Windows.Forms.ToolStripMenuItem mnuThanhToan;
        private System.Windows.Forms.ToolStripMenuItem mnuThanhToanVienPhi;
        private System.Windows.Forms.ToolStripMenuItem mnuLichHen;
        private System.Windows.Forms.ToolStripMenuItem mnuDatLichHen;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.GroupBox grpStat1;
        private System.Windows.Forms.Label lblTongBenhNhan;
        private System.Windows.Forms.GroupBox grpStat2;
        private System.Windows.Forms.Label lblSoBenhNhanChoKham;
        private System.Windows.Forms.GroupBox grpStat3;
        private System.Windows.Forms.Label lblLichHenHomNay;
        private System.Windows.Forms.DataGridView dgvBenhNhanMoi;
        private System.Windows.Forms.Label label1;
    }
}