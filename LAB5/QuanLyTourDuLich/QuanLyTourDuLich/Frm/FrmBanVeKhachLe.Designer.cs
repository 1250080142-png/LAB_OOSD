namespace QuanLyTourDuLich.Frm
{
    partial class FrmBanVeKhachLe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTinVe = new System.Windows.Forms.GroupBox();
            this.lblChuyenDi = new System.Windows.Forms.Label();
            this.cboChuyenDi = new System.Windows.Forms.ComboBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.btnXuatVe = new System.Windows.Forms.Button();

            this.dgvDanhSachVe = new System.Windows.Forms.DataGridView();

            this.grpThongTinVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachVe)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTinVe
            // 
            this.grpThongTinVe.Controls.Add(this.lblChuyenDi);
            this.grpThongTinVe.Controls.Add(this.cboChuyenDi);
            this.grpThongTinVe.Controls.Add(this.lblTenKhach);
            this.grpThongTinVe.Controls.Add(this.txtTenKhach);
            this.grpThongTinVe.Controls.Add(this.lblSDT);
            this.grpThongTinVe.Controls.Add(this.txtSDT);
            this.grpThongTinVe.Controls.Add(this.lblGiaVe);
            this.grpThongTinVe.Controls.Add(this.txtGiaVe);
            this.grpThongTinVe.Controls.Add(this.btnXuatVe);
            this.grpThongTinVe.Location = new System.Drawing.Point(15, 12);
            this.grpThongTinVe.Name = "grpThongTinVe";
            this.grpThongTinVe.Size = new System.Drawing.Size(930, 110);
            this.grpThongTinVe.TabIndex = 0;
            this.grpThongTinVe.TabStop = false;
            this.grpThongTinVe.Text = "Bán Vé Tour Khách Lẻ";

            // lblChuyenDi & cboChuyenDi
            this.lblChuyenDi.AutoSize = true;
            this.lblChuyenDi.Location = new System.Drawing.Point(15, 30);
            this.lblChuyenDi.Text = "Chọn Chuyến:";
            this.cboChuyenDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenDi.Location = new System.Drawing.Point(110, 26);
            this.cboChuyenDi.Size = new System.Drawing.Size(180, 23);

            // lblTenKhach & txtTenKhach
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Location = new System.Drawing.Point(310, 30);
            this.lblTenKhach.Text = "Họ Tên Khách:";
            this.txtTenKhach.Location = new System.Drawing.Point(400, 26);
            this.txtTenKhach.Size = new System.Drawing.Size(200, 23);

            // lblSDT & txtSDT
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(15, 68);
            this.lblSDT.Text = "Số Điện Thoại:";
            this.txtSDT.Location = new System.Drawing.Point(110, 65);
            this.txtSDT.Size = new System.Drawing.Size(180, 23);

            // lblGiaVe & txtGiaVe
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Location = new System.Drawing.Point(310, 68);
            this.lblGiaVe.Text = "Giá Vé (VNĐ):";
            this.txtGiaVe.Location = new System.Drawing.Point(400, 65);
            this.txtGiaVe.Size = new System.Drawing.Size(200, 23);
            this.txtGiaVe.Text = "1500000";

            // btnXuatVe
            this.btnXuatVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnXuatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatVe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXuatVe.ForeColor = System.Drawing.Color.White;
            this.btnXuatVe.Location = new System.Drawing.Point(630, 26);
            this.btnXuatVe.Size = new System.Drawing.Size(180, 62);
            this.btnXuatVe.Text = "Lập & Xuất Vé";
            this.btnXuatVe.UseVisualStyleBackColor = false;
            this.btnXuatVe.Click += new System.EventHandler(this.btnXuatVe_Click);

            // 
            // dgvDanhSachVe
            // 
            this.dgvDanhSachVe.AllowUserToAddRows = false;
            this.dgvDanhSachVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachVe.Location = new System.Drawing.Point(15, 135);
            this.dgvDanhSachVe.Name = "dgvDanhSachVe";
            this.dgvDanhSachVe.ReadOnly = true;
            this.dgvDanhSachVe.Size = new System.Drawing.Size(930, 450);
            this.dgvDanhSachVe.TabIndex = 1;

            // 
            // FrmBanVeKhachLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.dgvDanhSachVe);
            this.Controls.Add(this.grpThongTinVe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmBanVeKhachLe";
            this.Text = "Bán Vé & Đặt Chỗ Khách Lẻ";
            this.grpThongTinVe.ResumeLayout(false);
            this.grpThongTinVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachVe)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpThongTinVe;
        private System.Windows.Forms.Label lblChuyenDi;
        private System.Windows.Forms.ComboBox cboChuyenDi;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblGiaVe;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Button btnXuatVe;

        private System.Windows.Forms.DataGridView dgvDanhSachVe;
    }
}