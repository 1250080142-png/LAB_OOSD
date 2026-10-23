namespace QuanLyNhanSu
{
    partial class FrmTinhLuong
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80); this.dataGridView1.Name = "dataGridView1"; this.dataGridView1.Size = new System.Drawing.Size(760, 300); this.dataGridView1.TabIndex = 0;
            this.txtThang.Location = new System.Drawing.Point(20, 25); this.txtThang.Name = "txtThang"; this.txtThang.Size = new System.Drawing.Size(80, 20); this.txtThang.TabIndex = 1;
            this.txtNam.Location = new System.Drawing.Point(110, 25); this.txtNam.Name = "txtNam"; this.txtNam.Size = new System.Drawing.Size(80, 20); this.txtNam.TabIndex = 2;
            this.btnTinhLuong.Location = new System.Drawing.Point(210, 20); this.btnTinhLuong.Name = "btnTinhLuong"; this.btnTinhLuong.Size = new System.Drawing.Size(120, 30); this.btnTinhLuong.TabIndex = 3; this.btnTinhLuong.Text = "Tính Lương"; this.btnTinhLuong.UseVisualStyleBackColor = true; this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 400);
            this.Controls.Add(this.btnTinhLuong); this.Controls.Add(this.txtNam); this.Controls.Add(this.txtThang); this.Controls.Add(this.dataGridView1);
            this.Name = "FrmTinhLuong"; this.Text = "Tính Lương Tổng Hợp"; this.Load += new System.EventHandler(this.FrmTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit(); this.ResumeLayout(false); this.PerformLayout();
        }
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnTinhLuong;
    }
}