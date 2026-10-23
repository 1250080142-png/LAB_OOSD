namespace QuanLyNhanSu
{
    partial class FrmQuyetDinhLuongChucVu
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSoQD = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtPhuCapLuong = new System.Windows.Forms.TextBox();
            this.txtPhuCapDocHai = new System.Windows.Forms.TextBox();
            this.dtpNgayKy = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160); this.dataGridView1.Name = "dataGridView1"; this.dataGridView1.Size = new System.Drawing.Size(760, 230); this.dataGridView1.TabIndex = 0;
            this.txtSoQD.Location = new System.Drawing.Point(20, 20); this.txtSoQD.Name = "txtSoQD"; this.txtSoQD.Size = new System.Drawing.Size(150, 20); this.txtSoQD.TabIndex = 1;
            this.cboMaNV.Location = new System.Drawing.Point(20, 60); this.cboMaNV.Name = "cboMaNV"; this.cboMaNV.Size = new System.Drawing.Size(150, 21); this.cboMaNV.TabIndex = 2;
            this.txtLuongCoBan.Location = new System.Drawing.Point(20, 100); this.txtLuongCoBan.Name = "txtLuongCoBan"; this.txtLuongCoBan.Size = new System.Drawing.Size(150, 20); this.txtLuongCoBan.TabIndex = 3;
            this.txtPhuCapLuong.Location = new System.Drawing.Point(200, 20); this.txtPhuCapLuong.Name = "txtPhuCapLuong"; this.txtPhuCapLuong.Size = new System.Drawing.Size(150, 20); this.txtPhuCapLuong.TabIndex = 4;
            this.txtPhuCapDocHai.Location = new System.Drawing.Point(200, 60); this.txtPhuCapDocHai.Name = "txtPhuCapDocHai"; this.txtPhuCapDocHai.Size = new System.Drawing.Size(150, 20); this.txtPhuCapDocHai.TabIndex = 5;
            this.dtpNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgayKy.Location = new System.Drawing.Point(200, 100); this.dtpNgayKy.Name = "dtpNgayKy"; this.dtpNgayKy.Size = new System.Drawing.Size(150, 20); this.dtpNgayKy.TabIndex = 6;
            this.btnThem.Location = new System.Drawing.Point(400, 20); this.btnThem.Name = "btnThem"; this.btnThem.Size = new System.Drawing.Size(100, 30); this.btnThem.TabIndex = 7; this.btnThem.Text = "Thêm QĐ"; this.btnThem.UseVisualStyleBackColor = true; this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 410);
            this.Controls.Add(this.btnThem); this.Controls.Add(this.dtpNgayKy); this.Controls.Add(this.txtPhuCapDocHai); this.Controls.Add(this.txtPhuCapLuong); this.Controls.Add(this.txtLuongCoBan); this.Controls.Add(this.cboMaNV); this.Controls.Add(this.txtSoQD); this.Controls.Add(this.dataGridView1);
            this.Name = "FrmQuyetDinhLuongChucVu"; this.Text = "Quản Lý Quyết Định Lương"; this.Load += new System.EventHandler(this.FrmQuyetDinhLuongChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit(); this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSoQD;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtPhuCapLuong;
        private System.Windows.Forms.TextBox txtPhuCapDocHai;
        private System.Windows.Forms.DateTimePicker dtpNgayKy;
        private System.Windows.Forms.Button btnThem;
    }
}