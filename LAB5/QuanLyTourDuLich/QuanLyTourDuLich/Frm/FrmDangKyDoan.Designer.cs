namespace QuanLyTourDuLich.Frm
{
    partial class FrmDangKyDoan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTinDoan = new System.Windows.Forms.GroupBox();
            this.lblTenDoan = new System.Windows.Forms.Label();
            this.txtTenDoan = new System.Windows.Forms.TextBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblNguoiDuyet = new System.Windows.Forms.Label();
            this.txtNguoiDuyet = new System.Windows.Forms.TextBox();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();

            this.dgvDanhSachDoan = new System.Windows.Forms.DataGridView();

            this.grpThongTinDoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoan)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTinDoan
            // 
            this.grpThongTinDoan.Controls.Add(this.lblTenDoan);
            this.grpThongTinDoan.Controls.Add(this.txtTenDoan);
            this.grpThongTinDoan.Controls.Add(this.lblTour);
            this.grpThongTinDoan.Controls.Add(this.cboTour);
            this.grpThongTinDoan.Controls.Add(this.lblNguoiDuyet);
            this.grpThongTinDoan.Controls.Add(this.txtNguoiDuyet);
            this.grpThongTinDoan.Controls.Add(this.lblSoNguoi);
            this.grpThongTinDoan.Controls.Add(this.txtSoNguoi);
            this.grpThongTinDoan.Controls.Add(this.lblSDT);
            this.grpThongTinDoan.Controls.Add(this.txtSDT);
            this.grpThongTinDoan.Controls.Add(this.lblDiaChi);
            this.grpThongTinDoan.Controls.Add(this.txtDiaChi);
            this.grpThongTinDoan.Controls.Add(this.btnDangKy);
            this.grpThongTinDoan.Location = new System.Drawing.Point(15, 12);
            this.grpThongTinDoan.Name = "grpThongTinDoan";
            this.grpThongTinDoan.Size = new System.Drawing.Size(930, 160);
            this.grpThongTinDoan.TabIndex = 0;
            this.grpThongTinDoan.TabStop = false;
            this.grpThongTinDoan.Text = "Thông Tin Đăng Ký Tour Khách Đoàn";

            // lblTenDoan & txtTenDoan
            this.lblTenDoan.AutoSize = true;
            this.lblTenDoan.Location = new System.Drawing.Point(15, 30);
            this.lblTenDoan.Text = "Tên Đoàn / Cty:";
            this.txtTenDoan.Location = new System.Drawing.Point(110, 26);
            this.txtTenDoan.Size = new System.Drawing.Size(200, 23);

            // lblTour & cboTour
            this.lblTour.AutoSize = true;
            this.lblTour.Location = new System.Drawing.Point(330, 30);
            this.lblTour.Text = "Chọn Tour:";
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.Location = new System.Drawing.Point(420, 26);
            this.cboTour.Size = new System.Drawing.Size(220, 23);

            // lblNguoiDuyet & txtNguoiDuyet
            this.lblNguoiDuyet.AutoSize = true;
            this.lblNguoiDuyet.Location = new System.Drawing.Point(15, 68);
            this.lblNguoiDuyet.Text = "Người Đại Diện:";
            this.txtNguoiDuyet.Location = new System.Drawing.Point(110, 65);
            this.txtNguoiDuyet.Size = new System.Drawing.Size(200, 23);

            // lblSoNguoi & txtSoNguoi
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(330, 68);
            this.lblSoNguoi.Text = "Số Khách:";
            this.txtSoNguoi.Location = new System.Drawing.Point(420, 65);
            this.txtSoNguoi.Size = new System.Drawing.Size(80, 23);
            this.txtSoNguoi.Text = "20";

            // lblSDT & txtSDT
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(15, 108);
            this.lblSDT.Text = "Số Điện Thoại:";
            this.txtSDT.Location = new System.Drawing.Point(110, 105);
            this.txtSDT.Size = new System.Drawing.Size(200, 23);

            // lblDiaChi & txtDiaChi
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(330, 108);
            this.lblDiaChi.Text = "Địa Chỉ Liên Hệ:";
            this.txtDiaChi.Location = new System.Drawing.Point(420, 105);
            this.txtDiaChi.Size = new System.Drawing.Size(220, 23);

            // btnDangKy
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(670, 26);
            this.btnDangKy.Size = new System.Drawing.Size(220, 102);
            this.btnDangKy.Text = "Lập PhIếu Đăng Ký Đoàn";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            // 
            // dgvDanhSachDoan
            // 
            this.dgvDanhSachDoan.AllowUserToAddRows = false;
            this.dgvDanhSachDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDoan.Location = new System.Drawing.Point(15, 185);
            this.dgvDanhSachDoan.Name = "dgvDanhSachDoan";
            this.dgvDanhSachDoan.ReadOnly = true;
            this.dgvDanhSachDoan.Size = new System.Drawing.Size(930, 400);
            this.dgvDanhSachDoan.TabIndex = 1;

            // 
            // FrmDangKyDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.dgvDanhSachDoan);
            this.Controls.Add(this.grpThongTinDoan);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmDangKyDoan";
            this.Text = "Quản Lý Đăng Ký Tour Theo Đoàn";
            this.grpThongTinDoan.ResumeLayout(false);
            this.grpThongTinDoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDoan)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpThongTinDoan;
        private System.Windows.Forms.Label lblTenDoan;
        private System.Windows.Forms.TextBox txtTenDoan;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblNguoiDuyet;
        private System.Windows.Forms.TextBox txtNguoiDuyet;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnDangKy;

        private System.Windows.Forms.DataGridView dgvDanhSachDoan;
    }
}