namespace QuanLyNhanSu
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnLuongCV = new System.Windows.Forms.Button();
            this.btnPhanCa = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnKTKL = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTitle.Location = new System.Drawing.Point(120, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(360, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ NHÂN SỰ SƠN ĐÔNG Á";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(50, 80);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(220, 45);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "1. Quản Lý Nhân Sự";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Location = new System.Drawing.Point(320, 80);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(220, 45);
            this.btnPhongBan.TabIndex = 2;
            this.btnPhongBan.Text = "2. Phòng Ban & Chức Vụ";
            this.btnPhongBan.UseVisualStyleBackColor = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Location = new System.Drawing.Point(50, 140);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(220, 45);
            this.btnHopDong.TabIndex = 3;
            this.btnHopDong.Text = "3. Tuyển Dụng & Hợp Đồng";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnLuongCV
            // 
            this.btnLuongCV.Location = new System.Drawing.Point(320, 140);
            this.btnLuongCV.Name = "btnLuongCV";
            this.btnLuongCV.Size = new System.Drawing.Size(220, 45);
            this.btnLuongCV.TabIndex = 4;
            this.btnLuongCV.Text = "4. Quyết Định Lương";
            this.btnLuongCV.UseVisualStyleBackColor = true;
            this.btnLuongCV.Click += new System.EventHandler(this.btnLuongCV_Click);
            // 
            // btnPhanCa
            // 
            this.btnPhanCa.Location = new System.Drawing.Point(50, 200);
            this.btnPhanCa.Name = "btnPhanCa";
            this.btnPhanCa.Size = new System.Drawing.Size(220, 45);
            this.btnPhanCa.TabIndex = 5;
            this.btnPhanCa.Text = "5. Phân Công Ca Làm";
            this.btnPhanCa.UseVisualStyleBackColor = true;
            this.btnPhanCa.Click += new System.EventHandler(this.btnPhanCa_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Location = new System.Drawing.Point(320, 200);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(220, 45);
            this.btnChamCong.TabIndex = 6;
            this.btnChamCong.Text = "6. Chấm Công & Phụ Trội";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnKTKL
            // 
            this.btnKTKL.Location = new System.Drawing.Point(50, 260);
            this.btnKTKL.Name = "btnKTKL";
            this.btnKTKL.Size = new System.Drawing.Size(220, 45);
            this.btnKTKL.TabIndex = 7;
            this.btnKTKL.Text = "7. Khen Thưởng & Kỷ Luật";
            this.btnKTKL.UseVisualStyleBackColor = true;
            this.btnKTKL.Click += new System.EventHandler(this.btnKTKL_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(320, 260);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(220, 45);
            this.btnTinhLuong.TabIndex = 8;
            this.btnTinhLuong.Text = "8. Tính Lương Tổng Hợp";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MistyRose;
            this.btnThoat.Location = new System.Drawing.Point(185, 330);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(220, 45);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "9. Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 400);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.btnKTKL);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.btnPhanCa);
            this.Controls.Add(this.btnLuongCV);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.btnPhongBan);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.labelTitle);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Nhân sự - Công ty Sơn Đông Á";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnLuongCV;
        private System.Windows.Forms.Button btnPhanCa;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnKTKL;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labelTitle;
    }
}