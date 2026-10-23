namespace QuanLyNhanSu
{
    partial class FrmKhenThuongKyLuat
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSoQuyetDinh = new System.Windows.Forms.TextBox();
            this.cboLoaiQD = new System.Windows.Forms.ComboBox();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtHinhThuc = new System.Windows.Forms.TextBox();
            this.dtpNgayKy = new System.Windows.Forms.DateTimePicker();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170); this.dataGridView1.Name = "dataGridView1"; this.dataGridView1.Size = new System.Drawing.Size(760, 220); this.dataGridView1.TabIndex = 0;
            this.txtSoQuyetDinh.Location = new System.Drawing.Point(20, 20); this.txtSoQuyetDinh.Name = "txtSoQuyetDinh"; this.txtSoQuyetDinh.Size = new System.Drawing.Size(150, 20); this.txtSoQuyetDinh.TabIndex = 1;
            this.cboLoaiQD.Items.AddRange(new object[] { "Khen thưởng", "Kỷ luật" }); this.cboLoaiQD.Location = new System.Drawing.Point(20, 60); this.cboLoaiQD.Name = "cboLoaiQD"; this.cboLoaiQD.Size = new System.Drawing.Size(150, 21); this.cboLoaiQD.TabIndex = 2;
            this.cboDoiTuong.Items.AddRange(new object[] { "Cá nhân", "Tập thể" }); this.cboDoiTuong.Location = new System.Drawing.Point(20, 100); this.cboDoiTuong.Name = "cboDoiTuong"; this.cboDoiTuong.Size = new System.Drawing.Size(150, 21); this.cboDoiTuong.TabIndex = 3;
            this.cboMaNV.Location = new System.Drawing.Point(190, 20); this.cboMaNV.Name = "cboMaNV"; this.cboMaNV.Size = new System.Drawing.Size(150, 21); this.cboMaNV.TabIndex = 4;
            this.txtSoTien.Location = new System.Drawing.Point(190, 60); this.txtSoTien.Name = "txtSoTien"; this.txtSoTien.Size = new System.Drawing.Size(150, 20); this.txtSoTien.TabIndex = 5;
            this.txtHinhThuc.Location = new System.Drawing.Point(190, 100); this.txtHinhThuc.Name = "txtHinhThuc"; this.txtHinhThuc.Size = new System.Drawing.Size(150, 20); this.txtHinhThuc.TabIndex = 6;
            this.dtpNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgayKy.Location = new System.Drawing.Point(360, 20); this.dtpNgayKy.Name = "dtpNgayKy"; this.dtpNgayKy.Size = new System.Drawing.Size(150, 20); this.dtpNgayKy.TabIndex = 7;
            this.txtNoiDung.Location = new System.Drawing.Point(360, 60); this.txtNoiDung.Multiline = true; this.txtNoiDung.Name = "txtNoiDung"; this.txtNoiDung.Size = new System.Drawing.Size(200, 60); this.txtNoiDung.TabIndex = 8;
            this.btnThem.Location = new System.Drawing.Point(580, 20); this.btnThem.Name = "btnThem"; this.btnThem.Size = new System.Drawing.Size(100, 30); this.btnThem.TabIndex = 9; this.btnThem.Text = "Thêm"; this.btnThem.UseVisualStyleBackColor = true; this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 410);
            this.Controls.Add(this.btnThem); this.Controls.Add(this.txtNoiDung); this.Controls.Add(this.dtpNgayKy); this.Controls.Add(this.txtHinhThuc); this.Controls.Add(this.txtSoTien); this.Controls.Add(this.cboMaNV); this.Controls.Add(this.cboDoiTuong); this.Controls.Add(this.cboLoaiQD); this.Controls.Add(this.txtSoQuyetDinh); this.Controls.Add(this.dataGridView1);
            this.Name = "FrmKhenThuongKyLuat"; this.Text = "Quản Lý Khen Thưởng & Kỷ Luật"; this.Load += new System.EventHandler(this.FrmKhenThuongKyLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit(); this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSoQuyetDinh;
        private System.Windows.Forms.ComboBox cboLoaiQD;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtHinhThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKy;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Button btnThem;
    }
}