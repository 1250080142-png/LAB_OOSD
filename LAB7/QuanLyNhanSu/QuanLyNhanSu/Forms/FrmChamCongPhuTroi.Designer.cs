namespace QuanLyNhanSu
{
    partial class FrmChamCongPhuTroi
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtNgayCong = new System.Windows.Forms.TextBox();
            this.txtNgayNghi = new System.Windows.Forms.TextBox();
            this.btnLuuChamCong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140); this.dataGridView1.Name = "dataGridView1"; this.dataGridView1.Size = new System.Drawing.Size(660, 230); this.dataGridView1.TabIndex = 0;
            this.txtThang.Location = new System.Drawing.Point(20, 20); this.txtThang.Name = "txtThang"; this.txtThang.Size = new System.Drawing.Size(100, 20); this.txtThang.TabIndex = 1;
            this.txtNam.Location = new System.Drawing.Point(130, 20); this.txtNam.Name = "txtNam"; this.txtNam.Size = new System.Drawing.Size(100, 20); this.txtNam.TabIndex = 2;
            this.cboMaNV.Location = new System.Drawing.Point(20, 60); this.cboMaNV.Name = "cboMaNV"; this.cboMaNV.Size = new System.Drawing.Size(210, 21); this.cboMaNV.TabIndex = 3;
            this.txtNgayCong.Location = new System.Drawing.Point(250, 20); this.txtNgayCong.Name = "txtNgayCong"; this.txtNgayCong.Size = new System.Drawing.Size(120, 20); this.txtNgayCong.TabIndex = 4;
            this.txtNgayNghi.Location = new System.Drawing.Point(250, 60); this.txtNgayNghi.Name = "txtNgayNghi"; this.txtNgayNghi.Size = new System.Drawing.Size(120, 20); this.txtNgayNghi.TabIndex = 5;
            this.btnLuuChamCong.Location = new System.Drawing.Point(400, 20); this.btnLuuChamCong.Name = "btnLuuChamCong"; this.btnLuuChamCong.Size = new System.Drawing.Size(120, 30); this.btnLuuChamCong.TabIndex = 6; this.btnLuuChamCong.Text = "Lưu Chấm Công"; this.btnLuuChamCong.UseVisualStyleBackColor = true; this.btnLuuChamCong.Click += new System.EventHandler(this.btnLuuChamCong_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 390);
            this.Controls.Add(this.btnLuuChamCong); this.Controls.Add(this.txtNgayNghi); this.Controls.Add(this.txtNgayCong); this.Controls.Add(this.cboMaNV); this.Controls.Add(this.txtNam); this.Controls.Add(this.txtThang); this.Controls.Add(this.dataGridView1);
            this.Name = "FrmChamCongPhuTroi"; this.Text = "Quản Lý Chấm Công"; this.Load += new System.EventHandler(this.FrmChamCongPhuTroi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit(); this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtNgayCong;
        private System.Windows.Forms.TextBox txtNgayNghi;
        private System.Windows.Forms.Button btnLuuChamCong;
    }
}