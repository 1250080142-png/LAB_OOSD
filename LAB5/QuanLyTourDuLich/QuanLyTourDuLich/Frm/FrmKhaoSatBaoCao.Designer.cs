namespace QuanLyTourDuLich.Frm
{
    partial class FrmKhaoSatBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpKhaoSat = new System.Windows.Forms.GroupBox();
            this.lblMaChuyen = new System.Windows.Forms.Label();
            this.txtMaChuyen = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.cboDiemDanhGia = new System.Windows.Forms.ComboBox();
            this.lblGopY = new System.Windows.Forms.Label();
            this.txtGopY = new System.Windows.Forms.TextBox();
            this.btnLuuKhaoSat = new System.Windows.Forms.Button();

            this.grpBaoCao = new System.Windows.Forms.GroupBox();
            this.btnBaoCaoDoanhThu = new System.Windows.Forms.Button();
            this.lblDoanhThuLe = new System.Windows.Forms.Label();
            this.lblDoanhThuDoan = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();

            this.grpKhaoSat.SuspendLayout();
            this.grpBaoCao.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpKhaoSat
            // 
            this.grpKhaoSat.Controls.Add(this.lblMaChuyen);
            this.grpKhaoSat.Controls.Add(this.txtMaChuyen);
            this.grpKhaoSat.Controls.Add(this.lblDiem);
            this.grpKhaoSat.Controls.Add(this.cboDiemDanhGia);
            this.grpKhaoSat.Controls.Add(this.lblGopY);
            this.grpKhaoSat.Controls.Add(this.txtGopY);
            this.grpKhaoSat.Controls.Add(this.btnLuuKhaoSat);
            this.grpKhaoSat.Location = new System.Drawing.Point(15, 12);
            this.grpKhaoSat.Name = "grpKhaoSat";
            this.grpKhaoSat.Size = new System.Drawing.Size(930, 200);
            this.grpKhaoSat.TabIndex = 0;
            this.grpKhaoSat.TabStop = false;
            this.grpKhaoSat.Text = "Thu Nhận Phiếu Khảo Sát Ý Kiến Khách Hàng";

            // lblMaChuyen & txtMaChuyen
            this.lblMaChuyen.AutoSize = true;
            this.lblMaChuyen.Location = new System.Drawing.Point(15, 30);
            this.lblMaChuyen.Text = "Mã Chuyến/Đoàn:";
            this.txtMaChuyen.Location = new System.Drawing.Point(130, 26);
            this.txtMaChuyen.Size = new System.Drawing.Size(180, 23);

            // lblDiem & cboDiemDanhGia
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(340, 30);
            this.lblDiem.Text = "Điểm Đánh Giá (1-5 sao):";
            this.cboDiemDanhGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDanhGia.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            this.cboDiemDanhGia.Location = new System.Drawing.Point(490, 26);
            this.cboDiemDanhGia.Size = new System.Drawing.Size(80, 23);
            this.cboDiemDanhGia.SelectedIndex = 4;

            // lblGopY & txtGopY
            this.lblGopY.AutoSize = true;
            this.lblGopY.Location = new System.Drawing.Point(15, 70);
            this.lblGopY.Text = "Ý Kiến Phản Hồi:";
            this.txtGopY.Location = new System.Drawing.Point(130, 67);
            this.txtGopY.Multiline = true;
            this.txtGopY.Size = new System.Drawing.Size(440, 110);

            // btnLuuKhaoSat
            this.btnLuuKhaoSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.btnLuuKhaoSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuKhaoSat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuuKhaoSat.ForeColor = System.Drawing.Color.White;
            this.btnLuuKhaoSat.Location = new System.Drawing.Point(600, 67);
            this.btnLuuKhaoSat.Size = new System.Drawing.Size(180, 110);
            this.btnLuuKhaoSat.Text = "Lưu Khảo Sát";
            this.btnLuuKhaoSat.UseVisualStyleBackColor = false;
            this.btnLuuKhaoSat.Click += new System.EventHandler(this.btnLuuKhaoSat_Click);

            // 
            // grpBaoCao
            // 
            this.grpBaoCao.Controls.Add(this.btnBaoCaoDoanhThu);
            this.grpBaoCao.Controls.Add(this.lblDoanhThuLe);
            this.grpBaoCao.Controls.Add(this.lblDoanhThuDoan);
            this.grpBaoCao.Controls.Add(this.lblTongDoanhThu);
            this.grpBaoCao.Location = new System.Drawing.Point(15, 230);
            this.grpBaoCao.Name = "grpBaoCao";
            this.grpBaoCao.Size = new System.Drawing.Size(930, 200);
            this.grpBaoCao.TabIndex = 1;
            this.grpBaoCao.TabStop = false;
            this.grpBaoCao.Text = "Thống Kê Doanh Thu Hệ Thống";

            // btnBaoCaoDoanhThu
            this.btnBaoCaoDoanhThu.Location = new System.Drawing.Point(15, 35);
            this.btnBaoCaoDoanhThu.Size = new System.Drawing.Size(200, 40);
            this.btnBaoCaoDoanhThu.Text = "Tổng Hợp Doanh Thu";
            this.btnBaoCaoDoanhThu.UseVisualStyleBackColor = true;
            this.btnBaoCaoDoanhThu.Click += new System.EventHandler(this.btnBaoCaoDoanhThu_Click);

            // Labels
            this.lblDoanhThuLe.AutoSize = true;
            this.lblDoanhThuLe.Location = new System.Drawing.Point(240, 35);
            this.lblDoanhThuLe.Text = "Doanh thu Khách lẻ: 0 VNĐ";

            this.lblDoanhThuDoan.AutoSize = true;
            this.lblDoanhThuDoan.Location = new System.Drawing.Point(240, 70);
            this.lblDoanhThuDoan.Text = "Doanh thu Khách đoàn: 0 VNĐ";

            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(240, 110);
            this.lblTongDoanhThu.Text = "TỔNG DOANH THU: 0 VNĐ";

            // 
            // FrmKhaoSatBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.grpBaoCao);
            this.Controls.Add(this.grpKhaoSat);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmKhaoSatBaoCao";
            this.Text = "Khảo Sát & Báo Cáo Doanh Thu";
            this.grpKhaoSat.ResumeLayout(false);
            this.grpKhaoSat.PerformLayout();
            this.grpBaoCao.ResumeLayout(false);
            this.grpBaoCao.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpKhaoSat;
        private System.Windows.Forms.Label lblMaChuyen;
        private System.Windows.Forms.TextBox txtMaChuyen;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.ComboBox cboDiemDanhGia;
        private System.Windows.Forms.Label lblGopY;
        private System.Windows.Forms.TextBox txtGopY;
        private System.Windows.Forms.Button btnLuuKhaoSat;

        private System.Windows.Forms.GroupBox grpBaoCao;
        private System.Windows.Forms.Button btnBaoCaoDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuLe;
        private System.Windows.Forms.Label lblDoanhThuDoan;
        private System.Windows.Forms.Label lblTongDoanhThu;
    }
}