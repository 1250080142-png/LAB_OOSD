namespace CuaHangNuocGiaiKhat
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNuocGiaiKhat;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuHen;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuGhiNo;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;

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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuocGiaiKhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuHen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuGhiNo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuNuocGiaiKhat,
            this.mnuKhachHang,
            this.mnuNhapHang,
            this.mnuBanHang,
            this.mnuPhieuHen,
            this.mnuPhieuGhiNo,
            this.mnuThongKe});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1008, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "1. Danh mục";
            this.mnuDanhMuc.Click += new System.EventHandler(this.MnuDanhMuc_Click);
            // 
            // mnuNuocGiaiKhat
            // 
            this.mnuNuocGiaiKhat.Name = "mnuNuocGiaiKhat";
            this.mnuNuocGiaiKhat.Size = new System.Drawing.Size(95, 20);
            this.mnuNuocGiaiKhat.Text = "2. Nước giải khát";
            this.mnuNuocGiaiKhat.Click += new System.EventHandler(this.MnuNuocGiaiKhat_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(86, 20);
            this.mnuKhachHang.Text = "3. Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.MnuKhachHang_Click);
            // 
            // mnuNhapHang
            // 
            this.mnuNhapHang.Name = "mnuNhapHang";
            this.mnuNhapHang.Size = new System.Drawing.Size(80, 20);
            this.mnuNhapHang.Text = "4. Nhập hàng";
            this.mnuNhapHang.Click += new System.EventHandler(this.MnuNhapHang_Click);
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Size = new System.Drawing.Size(73, 20);
            this.mnuBanHang.Text = "5. Bán hàng";
            this.mnuBanHang.Click += new System.EventHandler(this.MnuBanHang_Click);
            // 
            // mnuPhieuHen
            // 
            this.mnuPhieuHen.Name = "mnuPhieuHen";
            this.mnuPhieuHen.Size = new System.Drawing.Size(73, 20);
            this.mnuPhieuHen.Text = "6. Phiếu hẹn";
            this.mnuPhieuHen.Click += new System.EventHandler(this.MnuPhieuHen_Click);
            // 
            // mnuPhieuGhiNo
            // 
            this.mnuPhieuGhiNo.Name = "mnuPhieuGhiNo";
            this.mnuPhieuGhiNo.Size = new System.Drawing.Size(84, 20);
            this.mnuPhieuGhiNo.Text = "7. Phiếu ghi nợ";
            this.mnuPhieuGhiNo.Click += new System.EventHandler(this.MnuPhieuGhiNo_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(74, 20);
            this.mnuThongKe.Text = "8. Thống kê";
            this.mnuThongKe.Click += new System.EventHandler(this.MnuThongKe_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Size = new System.Drawing.Size(161, 17);
            this.lblStatusUser.Text = "Hệ thống Quản lý Cửa hàng NGK";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Cửa Hàng Nước Giải Khát - HUTECH";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}