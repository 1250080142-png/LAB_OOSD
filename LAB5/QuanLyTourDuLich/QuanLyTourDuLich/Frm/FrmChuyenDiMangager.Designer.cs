namespace QuanLyTourDuLich.Frm
{
    partial class FrmChuyenDiMangager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTinChuyen = new System.Windows.Forms.GroupBox();
            this.lblMaChuyen = new System.Windows.Forms.Label();
            this.txtMaChuyen = new System.Windows.Forms.TextBox();
            this.lblTour = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblNgayKhoiHanh = new System.Windows.Forms.Label();
            this.dtpNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.lblSoCho = new System.Windows.Forms.Label();
            this.txtSoCho = new System.Windows.Forms.TextBox();
            this.btnTaoChuyen = new System.Windows.Forms.Button();

            this.dgvDanhSachChuyen = new System.Windows.Forms.DataGridView();

            this.grpThongTinChuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChuyen)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTinChuyen
            // 
            this.grpThongTinChuyen.Controls.Add(this.lblMaChuyen);
            this.grpThongTinChuyen.Controls.Add(this.txtMaChuyen);
            this.grpThongTinChuyen.Controls.Add(this.lblTour);
            this.grpThongTinChuyen.Controls.Add(this.cboTour);
            this.grpThongTinChuyen.Controls.Add(this.lblNgayKhoiHanh);
            this.grpThongTinChuyen.Controls.Add(this.dtpNgayKhoiHanh);
            this.grpThongTinChuyen.Controls.Add(this.lblSoCho);
            this.grpThongTinChuyen.Controls.Add(this.txtSoCho);
            this.grpThongTinChuyen.Controls.Add(this.btnTaoChuyen);
            this.grpThongTinChuyen.Location = new System.Drawing.Point(15, 12);
            this.grpThongTinChuyen.Name = "grpThongTinChuyen";
            this.grpThongTinChuyen.Size = new System.Drawing.Size(930, 110);
            this.grpThongTinChuyen.TabIndex = 0;
            this.grpThongTinChuyen.TabStop = false;
            this.grpThongTinChuyen.Text = "Lập Lịch Chuyến Đi Tour Du Lịch";

            // lblMaChuyen & txtMaChuyen
            this.lblMaChuyen.AutoSize = true;
            this.lblMaChuyen.Location = new System.Drawing.Point(15, 30);
            this.lblMaChuyen.Text = "Mã Chuyến:";
            this.txtMaChuyen.Location = new System.Drawing.Point(110, 26);
            this.txtMaChuyen.Size = new System.Drawing.Size(180, 23);

            // lblTour & cboTour
            this.lblTour.AutoSize = true;
            this.lblTour.Location = new System.Drawing.Point(310, 30);
            this.lblTour.Text = "Chọn Tour:";
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.Location = new System.Drawing.Point(400, 26);
            this.cboTour.Size = new System.Drawing.Size(220, 23);

            // lblNgayKhoiHanh & dtpNgayKhoiHanh
            this.lblNgayKhoiHanh.AutoSize = true;
            this.lblNgayKhoiHanh.Location = new System.Drawing.Point(15, 68);
            this.lblNgayKhoiHanh.Text = "Ngày Khởi Hành:";
            this.dtpNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKhoiHanh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKhoiHanh.Location = new System.Drawing.Point(110, 65);
            this.dtpNgayKhoiHanh.Size = new System.Drawing.Size(180, 23);

            // lblSoCho & txtSoCho
            this.lblSoCho.AutoSize = true;
            this.lblSoCho.Location = new System.Drawing.Point(310, 68);
            this.lblSoCho.Text = "Số Cho Tối Đa:";
            this.txtSoCho.Location = new System.Drawing.Point(400, 65);
            this.txtSoCho.Size = new System.Drawing.Size(100, 23);
            this.txtSoCho.Text = "40";

            // btnTaoChuyen
            this.btnTaoChuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnTaoChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoChuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTaoChuyen.ForeColor = System.Drawing.Color.White;
            this.btnTaoChuyen.Location = new System.Drawing.Point(650, 26);
            this.btnTaoChuyen.Size = new System.Drawing.Size(180, 62);
            this.btnTaoChuyen.Text = "Mở Chuyến Đi";
            this.btnTaoChuyen.UseVisualStyleBackColor = false;
            this.btnTaoChuyen.Click += new System.EventHandler(this.btnTaoChuyen_Click);

            // 
            // dgvDanhSachChuyen
            // 
            this.dgvDanhSachChuyen.AllowUserToAddRows = false;
            this.dgvDanhSachChuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChuyen.Location = new System.Drawing.Point(15, 135);
            this.dgvDanhSachChuyen.Name = "dgvDanhSachChuyen";
            this.dgvDanhSachChuyen.ReadOnly = true;
            this.dgvDanhSachChuyen.Size = new System.Drawing.Size(930, 450);
            this.dgvDanhSachChuyen.TabIndex = 1;

            // 
            // FrmChuyenDiMangager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.dgvDanhSachChuyen);
            this.Controls.Add(this.grpThongTinChuyen);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmChuyenDiMangager";
            this.Text = "Quản Lý Chuyến Đi Tour Du Lịch";
            this.grpThongTinChuyen.ResumeLayout(false);
            this.grpThongTinChuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChuyen)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpThongTinChuyen;
        private System.Windows.Forms.Label lblMaChuyen;
        private System.Windows.Forms.TextBox txtMaChuyen;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblNgayKhoiHanh;
        private System.Windows.Forms.DateTimePicker dtpNgayKhoiHanh;
        private System.Windows.Forms.Label lblSoCho;
        private System.Windows.Forms.TextBox txtSoCho;
        private System.Windows.Forms.Button btnTaoChuyen;

        private System.Windows.Forms.DataGridView dgvDanhSachChuyen;
    }
}