namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLuot = new System.Windows.Forms.Label();
            this.cboLuot = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.cboDV = new System.Windows.Forms.ComboBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblSL = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnGhi = new System.Windows.Forms.Button();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // Hàng 1
            this.lblLuot.Location = new System.Drawing.Point(20, 20);
            this.lblLuot.Size = new System.Drawing.Size(95, 20);
            this.lblLuot.Text = "Phiếu lưu trú:";
            this.cboLuot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuot.Location = new System.Drawing.Point(120, 18);
            this.cboLuot.Size = new System.Drawing.Size(130, 24);
            this.cboLuot.SelectedIndexChanged += new System.EventHandler(this.cboLuot_SelectedIndexChanged);
            this.lblPhong.Location = new System.Drawing.Point(270, 20);
            this.lblPhong.Size = new System.Drawing.Size(55, 20);
            this.lblPhong.Text = "Phòng:";
            this.txtPhong.Location = new System.Drawing.Point(330, 18);
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(90, 22);
            this.lblDV.Location = new System.Drawing.Point(440, 20);
            this.lblDV.Size = new System.Drawing.Size(60, 20);
            this.lblDV.Text = "Dịch vụ:";
            this.cboDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDV.Location = new System.Drawing.Point(505, 18);
            this.cboDV.Size = new System.Drawing.Size(150, 24);
            // Hàng 2
            this.lblNgay.Location = new System.Drawing.Point(20, 60);
            this.lblNgay.Size = new System.Drawing.Size(95, 20);
            this.lblNgay.Text = "Ngày sử dụng:";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(120, 58);
            this.dtNgay.Size = new System.Drawing.Size(130, 22);
            this.lblSL.Location = new System.Drawing.Point(270, 60);
            this.lblSL.Size = new System.Drawing.Size(55, 20);
            this.lblSL.Text = "Số lượng:";
            this.numSL.Location = new System.Drawing.Point(330, 58);
            this.numSL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSL.Size = new System.Drawing.Size(90, 22);
            this.numSL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.btnGhi.Location = new System.Drawing.Point(505, 53);
            this.btnGhi.Size = new System.Drawing.Size(150, 32);
            this.btnGhi.Text = "Ghi nhận";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // Lưới dữ liệu lớn bên dưới (như Hình 5)
            this.dgvLichSu.Location = new System.Drawing.Point(20, 105);
            this.dgvLichSu.Size = new System.Drawing.Size(700, 325);
            // FrmDichVu
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.lblLuot);
            this.Controls.Add(this.cboLuot);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.cboDV);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.dgvLichSu);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblLuot, lblPhong, lblDV, lblNgay, lblSL;
        private System.Windows.Forms.ComboBox cboLuot, cboDV;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.DataGridView dgvLichSu;
    }
}