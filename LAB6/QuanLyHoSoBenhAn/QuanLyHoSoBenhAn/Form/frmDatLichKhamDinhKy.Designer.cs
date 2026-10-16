namespace QuanLyHoSoBenhAn.Form
{
    partial class frmDatLichKhamDinhKy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayGioHen = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLoaiHen = new System.Windows.Forms.ComboBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lịch Hẹn:";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(120, 27);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.ReadOnly = true;
            this.txtMaLH.Size = new System.Drawing.Size(200, 20);
            this.txtMaLH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Bệnh Nhân:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(120, 67);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(200, 20);
            this.txtMaBN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Hồ Sơ:";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(120, 107);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(200, 20);
            this.txtMaHS.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Giờ Hẹn:";
            // 
            // dtpNgayGioHen
            // 
            this.dtpNgayGioHen.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayGioHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGioHen.Location = new System.Drawing.Point(440, 27);
            this.dtpNgayGioHen.Name = "dtpNgayGioHen";
            this.dtpNgayGioHen.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayGioHen.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại Hẹn:";
            // 
            // cboLoaiHen
            // 
            this.cboLoaiHen.FormattingEnabled = true;
            this.cboLoaiHen.Items.AddRange(new object[] {
            "Khám định kỳ quý",
            "Tái khám"});
            this.cboLoaiHen.Location = new System.Drawing.Point(440, 67);
            this.cboLoaiHen.Name = "cboLoaiHen";
            this.cboLoaiHen.Size = new System.Drawing.Size(200, 21);
            this.cboLoaiHen.TabIndex = 9;
            this.cboLoaiHen.Text = "Khám định kỳ quý";
            // 
            // btnDatLich
            // 
            this.btnDatLich.Location = new System.Drawing.Point(440, 105);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(200, 25);
            this.btnDatLich.TabIndex = 10;
            this.btnDatLich.Text = "Xác Nhận Đặt Lịch Hẹn";
            this.btnDatLich.UseVisualStyleBackColor = true;
            // 
            // dgvLichHen
            // 
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Location = new System.Drawing.Point(30, 150);
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.Size = new System.Drawing.Size(610, 180);
            this.dgvLichHen.TabIndex = 11;
            // 
            // frmDatLichKhamDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 350);
            this.Controls.Add(this.dgvLichHen);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.cboLoaiHen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgayGioHen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.label1);
            this.Name = "frmDatLichKhamDinhKy";
            this.Text = "Đặt Lịch Khám Định Kỳ & Tái Khám";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayGioHen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoaiHen;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.DataGridView dgvLichHen;
    }
}