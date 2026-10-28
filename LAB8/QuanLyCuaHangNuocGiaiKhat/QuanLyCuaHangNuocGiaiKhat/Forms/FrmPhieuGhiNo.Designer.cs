namespace CuaHangNuocGiaiKhat
{
    partial class FrmPhieuGhiNo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPhieuNo;

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
            this.dgvPhieuNo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblTitle.Location = new System.Drawing.Point(310, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(384, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ PHIẾU GHI NỢ KHÁCH QUEN";
            // 
            // dgvPhieuNo
            // 
            this.dgvPhieuNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNo.Location = new System.Drawing.Point(30, 70);
            this.dgvPhieuNo.Name = "dgvPhieuNo";
            this.dgvPhieuNo.Size = new System.Drawing.Size(948, 480);
            this.dgvPhieuNo.TabIndex = 1;
            // 
            // FrmPhieuGhiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.dgvPhieuNo);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmPhieuGhiNo";
            this.Text = "Ghi Nhận Công Nợ Khách Quen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}