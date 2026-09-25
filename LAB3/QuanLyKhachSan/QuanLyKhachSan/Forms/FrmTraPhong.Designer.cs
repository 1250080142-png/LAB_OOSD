namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPhieu = new System.Windows.Forms.Label();
            this.cboDat = new System.Windows.Forms.ComboBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.lblSoDB = new System.Windows.Forms.Label();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.lblSoTienDB = new System.Windows.Forms.Label();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.btnLapDB = new System.Windows.Forms.Button();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.lblSoTienTT = new System.Windows.Forms.Label();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThemDB = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtHDChon = new System.Windows.Forms.TextBox();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.cboNV2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            this.SuspendLayout();
            // Hàng 1: Phiếu đang ở
            this.lblPhieu.Location = new System.Drawing.Point(15, 15);
            this.lblPhieu.Size = new System.Drawing.Size(95, 20);
            this.lblPhieu.Text = "Phiếu đang ở:";
            this.cboDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDat.Location = new System.Drawing.Point(115, 12);
            this.cboDat.Size = new System.Drawing.Size(150, 24);
            // Hàng 2: 3 DataGridView đặt ngang nhau (y hệt ảnh 1)
            this.dgvPhong.Location = new System.Drawing.Point(15, 45);
            this.dgvPhong.Size = new System.Drawing.Size(250, 125);
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            this.dgvTN.Location = new System.Drawing.Point(280, 45);
            this.dgvTN.Size = new System.Drawing.Size(260, 125);
            this.dgvDBChon.Location = new System.Drawing.Point(555, 45);
            this.dgvDBChon.Size = new System.Drawing.Size(245, 125);
            // Hàng 3: Đền bù
            this.lblSoDB.Location = new System.Drawing.Point(15, 185);
            this.lblSoDB.Size = new System.Drawing.Size(95, 20);
            this.lblSoDB.Text = "Số phiếu đền bù:";
            this.txtSoDB.Location = new System.Drawing.Point(115, 182);
            this.txtSoDB.Size = new System.Drawing.Size(90, 22);
            this.lblMucDo.Location = new System.Drawing.Point(220, 185);
            this.lblMucDo.Size = new System.Drawing.Size(55, 20);
            this.lblMucDo.Text = "Mức độ:";
            this.txtMucDo.Location = new System.Drawing.Point(280, 182);
            this.txtMucDo.Size = new System.Drawing.Size(120, 22);
            this.lblSoTienDB.Location = new System.Drawing.Point(415, 185);
            this.lblSoTienDB.Size = new System.Drawing.Size(50, 20);
            this.lblSoTienDB.Text = "Số tiền:";
            this.numDenBu.Location = new System.Drawing.Point(470, 182);
            this.numDenBu.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numDenBu.Size = new System.Drawing.Size(95, 22);
            this.btnLapDB.Location = new System.Drawing.Point(660, 180);
            this.btnLapDB.Size = new System.Drawing.Size(140, 28);
            this.btnLapDB.Text = "Lập phiếu đền bù";
            this.btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);
            this.btnThemDB.Location = new System.Drawing.Point(575, 180);
            this.btnThemDB.Size = new System.Drawing.Size(75, 28);
            this.btnThemDB.Text = "+ Thêm";
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);
            // Hàng 4: Lập hóa đơn
            this.lblSoHD.Location = new System.Drawing.Point(15, 225);
            this.lblSoHD.Size = new System.Drawing.Size(75, 20);
            this.lblSoHD.Text = "Số hóa đơn:";
            this.txtSoHD.Location = new System.Drawing.Point(115, 222);
            this.txtSoHD.Size = new System.Drawing.Size(90, 22);
            this.lblSoNgay.Location = new System.Drawing.Point(220, 225);
            this.lblSoNgay.Size = new System.Drawing.Size(100, 20);
            this.lblSoNgay.Text = "Số ngày tính tiền:";
            this.numSoNgay.Location = new System.Drawing.Point(325, 222);
            this.numSoNgay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNgay.Size = new System.Drawing.Size(55, 22);
            this.numSoNgay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.btnLapHD.Location = new System.Drawing.Point(400, 219);
            this.btnLapHD.Size = new System.Drawing.Size(110, 28);
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // Hàng 5: Lưới Hóa đơn lớn
            this.dgvHD.Location = new System.Drawing.Point(15, 260);
            this.dgvHD.Size = new System.Drawing.Size(785, 160);
            this.dgvHD.SelectionChanged += new System.EventHandler(this.dgvHD_SelectionChanged);
            // Hàng 6: Thanh toán và Hoàn tất
            this.lblHinhThuc.Location = new System.Drawing.Point(15, 435);
            this.lblHinhThuc.Size = new System.Drawing.Size(65, 20);
            this.lblHinhThuc.Text = "Hình thức:";
            this.cboHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHT.Location = new System.Drawing.Point(85, 432);
            this.cboHT.Size = new System.Drawing.Size(110, 24);
            this.lblSoTienTT.Location = new System.Drawing.Point(210, 435);
            this.lblSoTienTT.Size = new System.Drawing.Size(50, 20);
            this.lblSoTienTT.Text = "Số tiền:";
            this.numTienTT.Location = new System.Drawing.Point(265, 432);
            this.numTienTT.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numTienTT.Size = new System.Drawing.Size(110, 22);
            this.btnThanhToan.Location = new System.Drawing.Point(410, 428);
            this.btnThanhToan.Size = new System.Drawing.Size(110, 30);
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            this.btnTraPhong.Location = new System.Drawing.Point(580, 427);
            this.btnTraPhong.Size = new System.Drawing.Size(160, 32);
            this.btnTraPhong.Text = "Hoàn tất trả phòng";
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // Controls ẩn phục vụ code-behind
            this.txtPhong.Visible = false;
            this.txtHDChon.Visible = false;
            this.txtMaTT.Visible = false;
            this.cboNV2.Visible = false;
            // FrmTraPhong
            this.ClientSize = new System.Drawing.Size(815, 480);
            this.Controls.Add(this.btnThemDB);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.numTienTT);
            this.Controls.Add(this.lblSoTienTT);
            this.Controls.Add(this.cboHT);
            this.Controls.Add(this.lblHinhThuc);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.numSoNgay);
            this.Controls.Add(this.lblSoNgay);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.lblSoHD);
            this.Controls.Add(this.btnLapDB);
            this.Controls.Add(this.numDenBu);
            this.Controls.Add(this.lblSoTienDB);
            this.Controls.Add(this.txtMucDo);
            this.Controls.Add(this.lblMucDo);
            this.Controls.Add(this.txtSoDB);
            this.Controls.Add(this.lblSoDB);
            this.Controls.Add(this.dgvDBChon);
            this.Controls.Add(this.dgvTN);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.cboDat);
            this.Controls.Add(this.lblPhieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng - Đền bù - Hóa đơn - Thanh toán";
            this.Load += new System.EventHandler(this.FrmTraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblPhieu, lblSoDB, lblMucDo, lblSoTienDB, lblSoHD, lblSoNgay, lblHinhThuc, lblSoTienTT;
        private System.Windows.Forms.ComboBox cboDat, cboHT, cboNV2;
        private System.Windows.Forms.DataGridView dgvPhong, dgvTN, dgvDBChon, dgvHD;
        private System.Windows.Forms.TextBox txtSoDB, txtMucDo, txtSoHD, txtPhong, txtHDChon, txtMaTT;
        private System.Windows.Forms.NumericUpDown numDenBu, numSoNgay, numTienTT;
        private System.Windows.Forms.Button btnLapDB, btnThemDB, btnLapHD, btnThanhToan, btnTraPhong;
    }
}