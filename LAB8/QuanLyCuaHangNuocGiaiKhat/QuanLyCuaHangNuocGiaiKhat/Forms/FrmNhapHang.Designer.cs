namespace CuaHangNuocGiaiKhat
{
    partial class FrmNhapHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPhieuGiao;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPhieuGiao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGiao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(412, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHẬP HÀNG TỪ NHÀ CUNG ỨNG";
            // 
            // dgvPhieuGiao
            // 
            this.dgvPhieuGiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuGiao.Location = new System.Drawing.Point(30, 70);
            this.dgvPhieuGiao.Name = "dgvPhieuGiao";
            this.dgvPhieuGiao.Size = new System.Drawing.Size(948, 480);
            this.dgvPhieuGiao.TabIndex = 1;
            // 
            // FrmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.dgvPhieuGiao);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNhapHang";
            this.Text = "Quản Lý Đơn Đặt Hàng & Phiếu Giao NCU";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGiao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}