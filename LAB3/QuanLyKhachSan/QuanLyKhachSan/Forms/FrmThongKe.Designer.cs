namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.lblPhieuDat = new System.Windows.Forms.Label();
            this.lblDangO = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblDoanhThuHD = new System.Windows.Forms.Label();
            this.lblTongDenBu = new System.Windows.Forms.Label();
            this.lblDV = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTu
            // 
            this.lblTu.Location = new System.Drawing.Point(20, 20);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(65, 20);
            this.lblTu.TabIndex = 11;
            this.lblTu.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(90, 18);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(120, 22);
            this.dtTu.TabIndex = 10;
            // 
            // lblDen
            // 
            this.lblDen.Location = new System.Drawing.Point(230, 20);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(70, 20);
            this.lblDen.TabIndex = 9;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(305, 18);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(120, 22);
            this.dtDen.TabIndex = 8;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(450, 15);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(110, 28);
            this.btnTK.TabIndex = 7;
            this.btnTK.Text = "Thống kê";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // lblPhieuDat
            // 
            this.lblPhieuDat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhieuDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.lblPhieuDat.Location = new System.Drawing.Point(20, 65);
            this.lblPhieuDat.Name = "lblPhieuDat";
            this.lblPhieuDat.Size = new System.Drawing.Size(250, 25);
            this.lblPhieuDat.TabIndex = 6;
            this.lblPhieuDat.Text = "Phiếu đặt: 0";
            // 
            // lblDangO
            // 
            this.lblDangO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDangO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.lblDangO.Location = new System.Drawing.Point(350, 65);
            this.lblDangO.Name = "lblDangO";
            this.lblDangO.Size = new System.Drawing.Size(250, 25);
            this.lblDangO.TabIndex = 5;
            this.lblDangO.Text = "Đang ở: 0";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.lblHoaDon.Location = new System.Drawing.Point(20, 100);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(250, 25);
            this.lblHoaDon.TabIndex = 4;
            this.lblHoaDon.Text = "Hóa đơn: 0";
            // 
            // lblDoanhThuHD
            // 
            this.lblDoanhThuHD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.lblDoanhThuHD.Location = new System.Drawing.Point(350, 100);
            this.lblDoanhThuHD.Name = "lblDoanhThuHD";
            this.lblDoanhThuHD.Size = new System.Drawing.Size(350, 25);
            this.lblDoanhThuHD.TabIndex = 3;
            this.lblDoanhThuHD.Text = "Doanh thu HĐ: 0 đ";
            // 
            // lblTongDenBu
            // 
            this.lblTongDenBu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongDenBu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.lblTongDenBu.Location = new System.Drawing.Point(20, 135);
            this.lblTongDenBu.Name = "lblTongDenBu";
            this.lblTongDenBu.Size = new System.Drawing.Size(300, 25);
            this.lblTongDenBu.TabIndex = 2;
            this.lblTongDenBu.Text = "Tổng đền bù: 0 đ";
            // 
            // lblDV
            // 
            this.lblDV.Location = new System.Drawing.Point(20, 180);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(150, 20);
            this.lblDV.TabIndex = 0;
            this.lblDV.Text = "Dịch vụ sử dụng:";
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeight = 29;
            this.dgvDV.Location = new System.Drawing.Point(20, 205);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.Size = new System.Drawing.Size(680, 200);
            this.dgvDV.TabIndex = 1;
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.ColumnHeadersHeight = 29;
            this.dgvTongHop.Location = new System.Drawing.Point(0, 0);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.RowHeadersWidth = 51;
            this.dgvTongHop.Size = new System.Drawing.Size(240, 150);
            this.dgvTongHop.TabIndex = 12;
            this.dgvTongHop.Visible = false;
            // 
            // FrmThongKe
            // 
            this.ClientSize = new System.Drawing.Size(720, 430);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.lblTongDenBu);
            this.Controls.Add(this.lblDoanhThuHD);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblDangO);
            this.Controls.Add(this.lblPhieuDat);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.dgvTongHop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê khách sạn";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTu, lblDen, lblPhieuDat, lblDangO, lblHoaDon, lblDoanhThuHD, lblTongDenBu, lblDV;
        private System.Windows.Forms.DateTimePicker dtTu, dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.DataGridView dgvDV, dgvTongHop;
    }
}