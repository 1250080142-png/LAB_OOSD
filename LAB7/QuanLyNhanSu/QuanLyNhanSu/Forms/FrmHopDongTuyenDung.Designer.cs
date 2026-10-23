namespace QuanLyNhanSu
{
    partial class FrmHopDongTuyenDung
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSoHopDong = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboLoaiHopDong = new System.Windows.Forms.ComboBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.chkCoBHYT = new System.Windows.Forms.CheckBox();
            this.chkCoBHXH = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180); this.dataGridView1.Name = "dataGridView1"; this.dataGridView1.Size = new System.Drawing.Size(760, 230); this.dataGridView1.TabIndex = 0;
            this.txtSoHopDong.Location = new System.Drawing.Point(20, 20); this.txtSoHopDong.Name = "txtSoHopDong"; this.txtSoHopDong.Size = new System.Drawing.Size(150, 20); this.txtSoHopDong.TabIndex = 1;
            this.cboMaNV.Location = new System.Drawing.Point(20, 60); this.cboMaNV.Name = "cboMaNV"; this.cboMaNV.Size = new System.Drawing.Size(150, 21); this.cboMaNV.TabIndex = 2;
            this.cboLoaiHopDong.FormattingEnabled = true; this.cboLoaiHopDong.Items.AddRange(new object[] { "Dài hạn", "Ngắn hạn" });
            this.cboLoaiHopDong.Location = new System.Drawing.Point(20, 100); this.cboLoaiHopDong.Name = "cboLoaiHopDong"; this.cboLoaiHopDong.Size = new System.Drawing.Size(150, 21); this.cboLoaiHopDong.TabIndex = 3;
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgayBatDau.Location = new System.Drawing.Point(200, 20); this.dtpNgayBatDau.Name = "dtpNgayBatDau"; this.dtpNgayBatDau.Size = new System.Drawing.Size(150, 20); this.dtpNgayBatDau.TabIndex = 4;
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgayKetThuc.Location = new System.Drawing.Point(200, 60); this.dtpNgayKetThuc.Name = "dtpNgayKetThuc"; this.dtpNgayKetThuc.Size = new System.Drawing.Size(150, 20); this.dtpNgayKetThuc.TabIndex = 5;
            this.chkCoBHYT.AutoSize = true; this.chkCoBHYT.Location = new System.Drawing.Point(200, 102); this.chkCoBHYT.Name = "chkCoBHYT"; this.chkCoBHYT.Size = new System.Drawing.Size(71, 17); this.chkCoBHYT.TabIndex = 6; this.chkCoBHYT.Text = "Có BHYT"; this.chkCoBHYT.UseVisualStyleBackColor = true;
            this.chkCoBHXH.AutoSize = true; this.chkCoBHXH.Location = new System.Drawing.Point(290, 102); this.chkCoBHXH.Name = "chkCoBHXH"; this.chkCoBHXH.Size = new System.Drawing.Size(73, 17); this.chkCoBHXH.TabIndex = 7; this.chkCoBHXH.Text = "Có BHXH"; this.chkCoBHXH.UseVisualStyleBackColor = true;
            this.btnThem.Location = new System.Drawing.Point(400, 20); this.btnThem.Name = "btnThem"; this.btnThem.Size = new System.Drawing.Size(100, 30); this.btnThem.TabIndex = 8; this.btnThem.Text = "Thêm HĐ"; this.btnThem.UseVisualStyleBackColor = true; this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 430);
            this.Controls.Add(this.btnThem); this.Controls.Add(this.chkCoBHXH); this.Controls.Add(this.chkCoBHYT); this.Controls.Add(this.dtpNgayKetThuc); this.Controls.Add(this.dtpNgayBatDau); this.Controls.Add(this.cboLoaiHopDong); this.Controls.Add(this.cboMaNV); this.Controls.Add(this.txtSoHopDong); this.Controls.Add(this.dataGridView1);
            this.Name = "FrmHopDongTuyenDung"; this.Text = "Quản Lý Hợp Đồng Lao Động"; this.Load += new System.EventHandler(this.FrmHopDongTuyenDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit(); this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSoHopDong;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboLoaiHopDong;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.CheckBox chkCoBHYT;
        private System.Windows.Forms.CheckBox chkCoBHXH;
        private System.Windows.Forms.Button btnThem;
    }
}