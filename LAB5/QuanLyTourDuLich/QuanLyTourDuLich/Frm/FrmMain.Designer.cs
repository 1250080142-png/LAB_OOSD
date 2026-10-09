namespace QuanLyTourDuLich.Frm
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.btnTour = new System.Windows.Forms.Button();
            this.btnChuyenDi = new System.Windows.Forms.Button();
            this.btnDangKyDoan = new System.Windows.Forms.Button();
            this.btnBanVe = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnBaoHiem = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlTopNav.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 60);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 25);
            this.lblTitle.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM";

            // lblSubTitle
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubTitle.Location = new System.Drawing.Point(22, 35);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(350, 17);
            this.lblSubTitle.Text = "Hệ Thống Quản Lý Tour - Chuyến Đi - Khách Hàng & Doanh Thu";

            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.pnlTopNav.Controls.Add(this.btnTour);
            this.pnlTopNav.Controls.Add(this.btnChuyenDi);
            this.pnlTopNav.Controls.Add(this.btnDangKyDoan);
            this.pnlTopNav.Controls.Add(this.btnBanVe);
            this.pnlTopNav.Controls.Add(this.btnPhanCong);
            this.pnlTopNav.Controls.Add(this.btnBaoCao);
            this.pnlTopNav.Controls.Add(this.btnBaoHiem);
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 60);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1200, 45);
            this.pnlTopNav.TabIndex = 1;

            // Thiết lập nút bấm Thanh Điều Hướng (Nav Buttons)
            System.Windows.Forms.Button[] navButtons = new System.Windows.Forms.Button[] {
                this.btnTour, this.btnChuyenDi, this.btnDangKyDoan, this.btnBanVe, this.btnPhanCong, this.btnBaoCao, this.btnBaoHiem
            };
            string[] navTexts = new string[] {
                "Quản Lý Tour", "Mở Chuyến Đi", "Đăng Ký Đoàn", "Bán Vé Lẻ", "Phân Công & Lương", "Khảo Sát & Báo Cáo", "Bảo Hiểm Đoàn"
            };

            int leftPos = 10;
            for (int i = 0; i < navButtons.Length; i++)
            {
                navButtons[i].BackColor = System.Drawing.Color.White;
                navButtons[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                navButtons[i].FlatAppearance.BorderSize = 1;
                navButtons[i].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
                navButtons[i].Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
                navButtons[i].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
                navButtons[i].Location = new System.Drawing.Point(leftPos, 6);
                navButtons[i].Size = new System.Drawing.Size(155, 33);
                navButtons[i].Text = navTexts[i];
                navButtons[i].UseVisualStyleBackColor = false;
                leftPos += 162;
            }

            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            this.btnChuyenDi.Click += new System.EventHandler(this.btnChuyenDi_Click);
            this.btnDangKyDoan.Click += new System.EventHandler(this.btnDangKyDoan_Click);
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            this.btnBaoHiem.Click += new System.EventHandler(this.btnBaoHiem_Click);

            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblDesc);
            this.pnlContent.Controls.Add(this.lblWelcome);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 105);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1200, 595);
            this.pnlContent.TabIndex = 2;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblWelcome.Location = new System.Drawing.Point(300, 200);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(600, 41);
            this.lblWelcome.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG QUẢN LÝ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDesc
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.lblDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblDesc.Location = new System.Drawing.Point(350, 255);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(500, 21);
            this.lblDesc.Text = "Vui lòng chọn chức năng trên thanh điều hướng để bắt đầu thao tác.";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopNav);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Tour Du Lịch - Văn Hóa Việt TP.HCM";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTopNav.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnChuyenDi;
        private System.Windows.Forms.Button btnDangKyDoan;
        private System.Windows.Forms.Button btnBanVe;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnBaoHiem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDesc;
    }
}