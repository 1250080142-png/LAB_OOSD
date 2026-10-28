namespace CuaHangNuocGiaiKhat
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Button btnThongKeTonKho;
        private System.Windows.Forms.DataGridView dgvThongKe;

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
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btnThongKeTonKho = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblTitle.Location = new System.Drawing.Point(340, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO THỐNG KÊ HỆ THỐNG";
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(30, 60);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(150, 35);
            this.btnThongKeDoanhThu.TabIndex = 1;
            this.btnThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnThongKeTonKho
            // 
            this.btnThongKeTonKho.Location = new System.Drawing.Point(200, 60);
            this.btnThongKeTonKho.Name = "btnThongKeTonKho";
            this.btnThongKeTonKho.Size = new System.Drawing.Size(150, 35);
            this.btnThongKeTonKho.TabIndex = 2;
            this.btnThongKeTonKho.Text = "Báo Cáo Tồn Kho";
            this.btnThongKeTonKho.UseVisualStyleBackColor = true;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(30, 110);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(948, 440);
            this.dgvThongKe.TabIndex = 3;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.btnThongKeTonKho);
            this.Controls.Add(this.btnThongKeDoanhThu);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmThongKe";
            this.Text = "Thống Kê & Báo Cáo Doanh Thu Tồn Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}