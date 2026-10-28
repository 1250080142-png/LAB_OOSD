namespace CuaHangNuocGiaiKhat
{
    partial class FrmPhieuHen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPhieuHen;

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
            this.dgvPhieuHen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuHen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblTitle.Location = new System.Drawing.Point(320, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ PHIẾU HẸN GIAO NHIỀU ĐỢT";
            // 
            // dgvPhieuHen
            // 
            this.dgvPhieuHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuHen.Location = new System.Drawing.Point(30, 70);
            this.dgvPhieuHen.Name = "dgvPhieuHen";
            this.dgvPhieuHen.Size = new System.Drawing.Size(948, 480);
            this.dgvPhieuHen.TabIndex = 1;
            // 
            // FrmPhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.dgvPhieuHen);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmPhieuHen";
            this.Text = "Phiếu Hẹn Giao Hàng Kèm Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuHen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}