namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.btnLapDat = new System.Windows.Forms.Button();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.lblTTLD = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblLapPhong = new System.Windows.Forms.Label();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.lblLapTN = new System.Windows.Forms.Label();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.lblSoLD = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.lblKhu = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.tabTN = new System.Windows.Forms.TabPage();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.lblSTT = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.lblMaTN = new System.Windows.Forms.Label();
            this.tabLD = new System.Windows.Forms.TabPage();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.tabCtrl.SuspendLayout();
            this.tabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.tabTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            this.tabLD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            this.SuspendLayout();
            // tabCtrl
            this.tabCtrl.Controls.Add(this.tabPhong);
            this.tabCtrl.Controls.Add(this.tabTN);
            this.tabCtrl.Controls.Add(this.tabLD);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.Size = new System.Drawing.Size(784, 461);
            // Tab Phong (Bố trí đúng Hình 3 của bài Lab)
            this.tabPhong.Controls.Add(this.btnLapDat);
            this.tabPhong.Controls.Add(this.txtTTLD);
            this.tabPhong.Controls.Add(this.lblTTLD);
            this.tabPhong.Controls.Add(this.cboPhong);
            this.tabPhong.Controls.Add(this.lblLapPhong);
            this.tabPhong.Controls.Add(this.cboTN);
            this.tabPhong.Controls.Add(this.lblLapTN);
            this.tabPhong.Controls.Add(this.txtSoLD);
            this.tabPhong.Controls.Add(this.lblSoLD);
            this.tabPhong.Controls.Add(this.dgvPhong);
            this.tabPhong.Controls.Add(this.btnThemPhong);
            this.tabPhong.Controls.Add(this.numGia);
            this.tabPhong.Controls.Add(this.lblGia);
            this.tabPhong.Controls.Add(this.numMax);
            this.tabPhong.Controls.Add(this.lblMax);
            this.tabPhong.Controls.Add(this.cboKhu);
            this.tabPhong.Controls.Add(this.lblKhu);
            this.tabPhong.Controls.Add(this.txtPhong);
            this.tabPhong.Controls.Add(this.lblPhong);
            this.tabPhong.Text = "Phòng";
            // Hàng 1 trên cùng
            this.lblPhong.Location = new System.Drawing.Point(10, 15);
            this.lblPhong.Size = new System.Drawing.Size(65, 20);
            this.lblPhong.Text = "Số phòng:";
            this.txtPhong.Location = new System.Drawing.Point(80, 12);
            this.txtPhong.Size = new System.Drawing.Size(85, 22);
            this.lblKhu.Location = new System.Drawing.Point(180, 15);
            this.lblKhu.Size = new System.Drawing.Size(55, 20);
            this.lblKhu.Text = "Khu vực:";
            this.cboKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhu.Location = new System.Drawing.Point(240, 12);
            this.cboKhu.Size = new System.Drawing.Size(100, 24);
            this.lblMax.Location = new System.Drawing.Point(355, 15);
            this.lblMax.Size = new System.Drawing.Size(85, 20);
            this.lblMax.Text = "Số người tối đa:";
            this.numMax.Location = new System.Drawing.Point(445, 12);
            this.numMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numMax.Size = new System.Drawing.Size(55, 22);
            this.numMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
            this.lblGia.Location = new System.Drawing.Point(515, 15);
            this.lblGia.Size = new System.Drawing.Size(85, 20);
            this.lblGia.Text = "Đơn giá/ngày:";
            this.numGia.Location = new System.Drawing.Point(605, 12);
            this.numGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numGia.Size = new System.Drawing.Size(85, 22);
            this.btnThemPhong.Location = new System.Drawing.Point(698, 10);
            this.btnThemPhong.Size = new System.Drawing.Size(65, 26);
            this.btnThemPhong.Text = "Lưu";
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // Lưới phòng ở giữa
            this.dgvPhong.Location = new System.Drawing.Point(10, 50);
            this.dgvPhong.Size = new System.Drawing.Size(755, 290);
            // Hàng dưới: Lập phiếu lắp đặt
            this.lblSoLD.Location = new System.Drawing.Point(10, 360);
            this.lblSoLD.Size = new System.Drawing.Size(80, 20);
            this.lblSoLD.Text = "Phiếu lắp đặt:";
            this.txtSoLD.Location = new System.Drawing.Point(95, 357);
            this.txtSoLD.Size = new System.Drawing.Size(75, 22);
            this.lblLapTN.Location = new System.Drawing.Point(180, 360);
            this.lblLapTN.Size = new System.Drawing.Size(60, 20);
            this.lblLapTN.Text = "Tiện nghi:";
            this.cboTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTN.Location = new System.Drawing.Point(245, 357);
            this.cboTN.Size = new System.Drawing.Size(90, 24);
            this.lblLapPhong.Location = new System.Drawing.Point(345, 360);
            this.lblLapPhong.Size = new System.Drawing.Size(45, 20);
            this.lblLapPhong.Text = "Phòng:";
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Location = new System.Drawing.Point(395, 357);
            this.cboPhong.Size = new System.Drawing.Size(80, 24);
            this.lblTTLD.Location = new System.Drawing.Point(485, 360);
            this.lblTTLD.Size = new System.Drawing.Size(65, 20);
            this.lblTTLD.Text = "Tình trạng:";
            this.txtTTLD.Location = new System.Drawing.Point(555, 357);
            this.txtTTLD.Size = new System.Drawing.Size(80, 22);
            this.txtTTLD.Text = "Tốt";
            this.btnLapDat.Location = new System.Drawing.Point(650, 353);
            this.btnLapDat.Size = new System.Drawing.Size(115, 30);
            this.btnLapDat.Text = "Lập phiếu";
            this.btnLapDat.Click += new System.EventHandler(this.btnLapDat_Click);
            // Tab Tien Nghi
            this.tabTN.Controls.Add(this.dgvTN);
            this.tabTN.Controls.Add(this.btnThemTN);
            this.tabTN.Controls.Add(this.txtTinhTrang);
            this.tabTN.Controls.Add(this.lblTinhTrang);
            this.tabTN.Controls.Add(this.numSTT);
            this.tabTN.Controls.Add(this.lblSTT);
            this.tabTN.Controls.Add(this.cboLoai);
            this.tabTN.Controls.Add(this.lblLoai);
            this.tabTN.Controls.Add(this.txtMaTN);
            this.tabTN.Controls.Add(this.lblMaTN);
            this.tabTN.Text = "Tiện nghi";
            this.lblMaTN.Location = new System.Drawing.Point(15, 18);
            this.lblMaTN.Size = new System.Drawing.Size(30, 20);
            this.lblMaTN.Text = "Mã:";
            this.txtMaTN.Location = new System.Drawing.Point(50, 15);
            this.txtMaTN.Size = new System.Drawing.Size(90, 22);
            this.lblLoai.Location = new System.Drawing.Point(155, 18);
            this.lblLoai.Size = new System.Drawing.Size(55, 20);
            this.lblLoai.Text = "Loại TN:";
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Location = new System.Drawing.Point(215, 15);
            this.cboLoai.Size = new System.Drawing.Size(120, 24);
            this.lblSTT.Location = new System.Drawing.Point(350, 18);
            this.lblSTT.Size = new System.Drawing.Size(35, 20);
            this.lblSTT.Text = "STT:";
            this.numSTT.Location = new System.Drawing.Point(390, 15);
            this.numSTT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSTT.Size = new System.Drawing.Size(60, 22);
            this.numSTT.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.lblTinhTrang.Location = new System.Drawing.Point(465, 18);
            this.lblTinhTrang.Size = new System.Drawing.Size(65, 20);
            this.lblTinhTrang.Text = "Tình trạng:";
            this.txtTinhTrang.Location = new System.Drawing.Point(535, 15);
            this.txtTinhTrang.Size = new System.Drawing.Size(100, 22);
            this.txtTinhTrang.Text = "Tốt";
            this.btnThemTN.Location = new System.Drawing.Point(655, 12);
            this.btnThemTN.Size = new System.Drawing.Size(85, 28);
            this.btnThemTN.Text = "Thêm";
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            this.dgvTN.Location = new System.Drawing.Point(15, 55);
            this.dgvTN.Size = new System.Drawing.Size(745, 365);
            // Tab Lắp đặt (Danh sách lịch sử)
            this.tabLD.Controls.Add(this.dgvLD);
            this.tabLD.Text = "Lắp đặt / luân chuyển";
            this.dgvLD.Dock = System.Windows.Forms.DockStyle.Fill;
            // Controls ẩn phục vụ logic
            this.dtNgay.Visible = false;
            this.cboNV.Visible = false;
            this.txtGhiChu.Visible = false;
            // FrmPhongTienNghi
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabCtrl);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            this.Load += new System.EventHandler(this.FrmPhongTienNghi_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.tabTN.ResumeLayout(false);
            this.tabTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            this.tabLD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPhong, tabTN, tabLD;
        private System.Windows.Forms.DataGridView dgvPhong, dgvTN, dgvLD;
        private System.Windows.Forms.Label lblPhong, lblKhu, lblMax, lblGia, lblSoLD, lblLapTN, lblLapPhong, lblTTLD, lblMaTN, lblLoai, lblSTT, lblTinhTrang;
        private System.Windows.Forms.TextBox txtPhong, txtSoLD, txtTTLD, txtMaTN, txtTinhTrang, txtGhiChu;
        private System.Windows.Forms.NumericUpDown numMax, numGia, numSTT;
        private System.Windows.Forms.ComboBox cboKhu, cboTN, cboPhong, cboLoai, cboNV;
        private System.Windows.Forms.Button btnThemPhong, btnLapDat, btnThemTN;
        private System.Windows.Forms.DateTimePicker dtNgay;
    }
}