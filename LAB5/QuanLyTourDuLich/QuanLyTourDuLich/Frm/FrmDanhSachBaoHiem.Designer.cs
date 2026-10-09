namespace QuanLyTourDuLich.Frm
{
    partial class FrmDanhSachBaoHiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.cboMaPhieuDoan = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThemNguoi = new System.Windows.Forms.Button();

            this.dgvDanhSachBaoHiem = new System.Windows.Forms.DataGridView();

            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBaoHiem)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaPhieu);
            this.grpThongTin.Controls.Add(this.cboMaPhieuDoan);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblCCCD);
            this.grpThongTin.Controls.Add(this.txtCCCD);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.btnThemNguoi);
            this.grpThongTin.Location = new System.Drawing.Point(15, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(930, 110);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Lập Danh Sách Bảo Hiểm Đoàn Du Lịch";

            // lblMaPhieu & cboMaPhieuDoan
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Location = new System.Drawing.Point(15, 30);
            this.lblMaPhieu.Text = "Chọn Phiếu Đoàn:";
            this.cboMaPhieuDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaPhieuDoan.Location = new System.Drawing.Point(120, 26);
            this.cboMaPhieuDoan.Size = new System.Drawing.Size(180, 23);

            // lblHoTen & txtHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(320, 30);
            this.lblHoTen.Text = "Họ và Tên:";
            this.txtHoTen.Location = new System.Drawing.Point(390, 26);
            this.txtHoTen.Size = new System.Drawing.Size(180, 23);

            // lblCCCD & txtCCCD
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(15, 68);
            this.lblCCCD.Text = "Số CCCD / Passport:";
            this.txtCCCD.Location = new System.Drawing.Point(120, 65);
            this.txtCCCD.Size = new System.Drawing.Size(180, 23);

            // lblNgaySinh & dtpNgaySinh
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(320, 68);
            this.lblNgaySinh.Text = "Ngày Sinh:";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Location = new System.Drawing.Point(390, 65);
            this.dtpNgaySinh.Size = new System.Drawing.Size(120, 23);

            // btnThemNguoi
            this.btnThemNguoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnThemNguoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNguoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThemNguoi.ForeColor = System.Drawing.Color.White;
            this.btnThemNguoi.Location = new System.Drawing.Point(600, 26);
            this.btnThemNguoi.Size = new System.Drawing.Size(180, 62);
            this.btnThemNguoi.Text = "Thêm Vào Danh Sách";
            this.btnThemNguoi.UseVisualStyleBackColor = false;
            this.btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);

            // 
            // dgvDanhSachBaoHiem
            // 
            this.dgvDanhSachBaoHiem.AllowUserToAddRows = false;
            this.dgvDanhSachBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBaoHiem.Location = new System.Drawing.Point(15, 135);
            this.dgvDanhSachBaoHiem.Name = "dgvDanhSachBaoHiem";
            this.dgvDanhSachBaoHiem.ReadOnly = true;
            this.dgvDanhSachBaoHiem.Size = new System.Drawing.Size(930, 450);
            this.dgvDanhSachBaoHiem.TabIndex = 1;

            // 
            // FrmDanhSachBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.dgvDanhSachBaoHiem);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmDanhSachBaoHiem";
            this.Text = "Quản Lý Danh Sách Bảo Hiểm Tour Đoàn";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBaoHiem)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.ComboBox cboMaPhieuDoan;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThemNguoi;

        private System.Windows.Forms.DataGridView dgvDanhSachBaoHiem;
    }
}