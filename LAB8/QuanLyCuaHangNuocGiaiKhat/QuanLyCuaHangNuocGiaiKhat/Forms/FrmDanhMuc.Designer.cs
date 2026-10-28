namespace CuaHangNuocGiaiKhat
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControlDanhMuc;
        private System.Windows.Forms.TabPage tabNhaCungUng;
        private System.Windows.Forms.TabPage tabNhanHieu;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.DataGridView dgvNhanHieu;
        private System.Windows.Forms.DataGridView dgvNhanVien;

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
            this.tabControlDanhMuc = new System.Windows.Forms.TabControl();
            this.tabNhaCungUng = new System.Windows.Forms.TabPage();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.tabNhanHieu = new System.Windows.Forms.TabPage();
            this.dgvNhanHieu = new System.Windows.Forms.DataGridView();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabControlDanhMuc.SuspendLayout();
            this.tabNhaCungUng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.tabNhanHieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanHieu)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblTitle.Location = new System.Drawing.Point(340, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(328, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ DANH MỤC HỆ THỐNG";
            // 
            // tabControlDanhMuc
            // 
            this.tabControlDanhMuc.Controls.Add(this.tabNhaCungUng);
            this.tabControlDanhMuc.Controls.Add(this.tabNhanHieu);
            this.tabControlDanhMuc.Controls.Add(this.tabNhanVien);
            this.tabControlDanhMuc.Location = new System.Drawing.Point(30, 65);
            this.tabControlDanhMuc.Name = "tabControlDanhMuc";
            this.tabControlDanhMuc.SelectedIndex = 0;
            this.tabControlDanhMuc.Size = new System.Drawing.Size(948, 490);
            this.tabControlDanhMuc.TabIndex = 1;
            // 
            // tabNhaCungUng
            // 
            this.tabNhaCungUng.Controls.Add(this.dgvNCC);
            this.tabNhaCungUng.Location = new System.Drawing.Point(4, 22);
            this.tabNhaCungUng.Name = "tabNhaCungUng";
            this.tabNhaCungUng.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhaCungUng.Size = new System.Drawing.Size(940, 464);
            this.tabNhaCungUng.TabIndex = 0;
            this.tabNhaCungUng.Text = "Nhà Cung Ứng";
            this.tabNhaCungUng.UseVisualStyleBackColor = true;
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNCC.Location = new System.Drawing.Point(3, 3);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.Size = new System.Drawing.Size(934, 458);
            this.dgvNCC.TabIndex = 0;
            // 
            // tabNhanHieu
            // 
            this.tabNhanHieu.Controls.Add(this.dgvNhanHieu);
            this.tabNhanHieu.Location = new System.Drawing.Point(4, 22);
            this.tabNhanHieu.Name = "tabNhanHieu";
            this.tabNhanHieu.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanHieu.Size = new System.Drawing.Size(940, 464);
            this.tabNhanHieu.TabIndex = 1;
            this.tabNhanHieu.Text = "Nhãn Hiệu / Loại NGK";
            this.tabNhanHieu.UseVisualStyleBackColor = true;
            // 
            // dgvNhanHieu
            // 
            this.dgvNhanHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanHieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanHieu.Location = new System.Drawing.Point(3, 3);
            this.dgvNhanHieu.Name = "dgvNhanHieu";
            this.dgvNhanHieu.Size = new System.Drawing.Size(934, 458);
            this.dgvNhanHieu.TabIndex = 0;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.dgvNhanVien);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(940, 464);
            this.tabNhanVien.TabIndex = 2;
            this.tabNhanVien.Text = "Nhân Viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 3);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(934, 458);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.tabControlDanhMuc);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmDanhMuc";
            this.Text = "Quản Lý Danh Mục Nền Tảng";
            this.tabControlDanhMuc.ResumeLayout(false);
            this.tabNhaCungUng.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.tabNhanHieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanHieu)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}