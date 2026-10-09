namespace QuanLyTourDuLich.Frm
{
    partial class FrmPhanCongVaLuong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpPhanCong = new System.Windows.Forms.GroupBox();
            this.lblHDV = new System.Windows.Forms.Label();
            this.cboHDV = new System.Windows.Forms.ComboBox();
            this.lblChuyenDi = new System.Windows.Forms.Label();
            this.cboChuyenDi = new System.Windows.Forms.ComboBox();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.btnPhanCong = new System.Windows.Forms.Button();

            this.grpLuong = new System.Windows.Forms.GroupBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnTinhLuong = new System.Windows.Forms.Button();

            this.dgvBangLuong = new System.Windows.Forms.DataGridView();

            this.grpPhanCong.SuspendLayout();
            this.grpLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();

            // grpPhanCong
            this.grpPhanCong.Controls.Add(this.lblHDV);
            this.grpPhanCong.Controls.Add(this.cboHDV);
            this.grpPhanCong.Controls.Add(this.lblChuyenDi);
            this.grpPhanCong.Controls.Add(this.cboChuyenDi);
            this.grpPhanCong.Controls.Add(this.lblNgayBD);
            this.grpPhanCong.Controls.Add(this.dtpNgayBD);
            this.grpPhanCong.Controls.Add(this.lblNgayKT);
            this.grpPhanCong.Controls.Add(this.dtpNgayKT);
            this.grpPhanCong.Controls.Add(this.lblPhuCap);
            this.grpPhanCong.Controls.Add(this.txtPhuCap);
            this.grpPhanCong.Controls.Add(this.btnPhanCong);
            this.grpPhanCong.Location = new System.Drawing.Point(15, 12);
            this.grpPhanCong.Name = "grpPhanCong";
            this.grpPhanCong.Size = new System.Drawing.Size(930, 130);
            this.grpPhanCong.TabIndex = 0;
            this.grpPhanCong.TabStop = false;
            this.grpPhanCong.Text = "Phân Công Hướng Dẫn Viên";

            this.lblHDV.AutoSize = true;
            this.lblHDV.Location = new System.Drawing.Point(15, 30);
            this.lblHDV.Text = "Chọn HDV:";
            this.cboHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDV.Location = new System.Drawing.Point(110, 26);
            this.cboHDV.Size = new System.Drawing.Size(200, 23);

            this.lblChuyenDi.AutoSize = true;
            this.lblChuyenDi.Location = new System.Drawing.Point(340, 30);
            this.lblChuyenDi.Text = "Chuyến / Đoàn:";
            this.cboChuyenDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenDi.Location = new System.Drawing.Point(440, 26);
            this.cboChuyenDi.Size = new System.Drawing.Size(200, 23);

            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(15, 65);
            this.lblNgayBD.Text = "Ngày Bắt Đầu:";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Location = new System.Drawing.Point(110, 61);
            this.dtpNgayBD.Size = new System.Drawing.Size(120, 23);

            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(340, 65);
            this.lblNgayKT.Text = "Ngày Kết Thúc:";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Location = new System.Drawing.Point(440, 61);
            this.dtpNgayKT.Size = new System.Drawing.Size(120, 23);

            this.lblPhuCap.AutoSize = true;
            this.lblPhuCap.Location = new System.Drawing.Point(15, 98);
            this.lblPhuCap.Text = "Phụ Cấp Tour:";
            this.txtPhuCap.Location = new System.Drawing.Point(110, 95);
            this.txtPhuCap.Size = new System.Drawing.Size(120, 23);
            this.txtPhuCap.Text = "500000";

            this.btnPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPhanCong.Location = new System.Drawing.Point(700, 26);
            this.btnPhanCong.Size = new System.Drawing.Size(200, 92);
            this.btnPhanCong.Text = "Kiểm Tra && Phân Công";
            this.btnPhanCong.UseVisualStyleBackColor = false;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);

            // grpLuong
            this.grpLuong.Controls.Add(this.lblThang);
            this.grpLuong.Controls.Add(this.cboThang);
            this.grpLuong.Controls.Add(this.lblNam);
            this.grpLuong.Controls.Add(this.txtNam);
            this.grpLuong.Controls.Add(this.btnTinhLuong);
            this.grpLuong.Location = new System.Drawing.Point(15, 150);
            this.grpLuong.Name = "grpLuong";
            this.grpLuong.Size = new System.Drawing.Size(930, 60);
            this.grpLuong.TabIndex = 1;
            this.grpLuong.TabStop = false;
            this.grpLuong.Text = "Thống Kê Lương Hướng Dẫn Viên";

            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(15, 25);
            this.lblThang.Text = "Tháng:";
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            this.cboThang.Location = new System.Drawing.Point(65, 21);
            this.cboThang.Size = new System.Drawing.Size(70, 23);
            this.cboThang.SelectedIndex = 9;

            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(160, 25);
            this.lblNam.Text = "Năm:";
            this.txtNam.Location = new System.Drawing.Point(200, 21);
            this.txtNam.Size = new System.Drawing.Size(80, 23);
            this.txtNam.Text = "2026";

            this.btnTinhLuong.Location = new System.Drawing.Point(310, 19);
            this.btnTinhLuong.Size = new System.Drawing.Size(150, 28);
            this.btnTinhLuong.Text = "Tính Lương Tháng";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);

            // dgvBangLuong
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Location = new System.Drawing.Point(15, 220);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.Size = new System.Drawing.Size(930, 365);
            this.dgvBangLuong.TabIndex = 2;

            // FrmPhanCongVaLuong
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.dgvBangLuong);
            this.Controls.Add(this.grpLuong);
            this.Controls.Add(this.grpPhanCong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmPhanCongVaLuong";
            this.Text = "Phân Công & Bảng Lương HDV";
            this.grpPhanCong.ResumeLayout(false);
            this.grpPhanCong.PerformLayout();
            this.grpLuong.ResumeLayout(false);
            this.grpLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpPhanCong;
        private System.Windows.Forms.Label lblHDV;
        private System.Windows.Forms.ComboBox cboHDV;
        private System.Windows.Forms.Label lblChuyenDi;
        private System.Windows.Forms.ComboBox cboChuyenDi;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.Button btnPhanCong;

        private System.Windows.Forms.GroupBox grpLuong;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnTinhLuong;

        private System.Windows.Forms.DataGridView dgvBangLuong;
    }
}