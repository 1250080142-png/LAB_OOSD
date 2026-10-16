namespace QuanLyHoSoBenhAn.Form
{
    partial class frmKhamBenhVaKeToa
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

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPKB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhoaDieuTri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHuyetAp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThanNhiet = new System.Windows.Forms.TextBox();
            this.dgvXetNghiem = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDanhSachThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.btnLuuToaThuoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Khám:";
            // 
            // txtMaPKB
            // 
            this.txtMaPKB.Location = new System.Drawing.Point(120, 22);
            this.txtMaPKB.Name = "txtMaPKB";
            this.txtMaPKB.ReadOnly = true;
            this.txtMaPKB.Size = new System.Drawing.Size(180, 20);
            this.txtMaPKB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Hồ Sơ:";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(410, 25);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(43, 13);
            this.lblMaHS.TabIndex = 3;
            this.lblMaHS.Text = "[HS00]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa Điều Trị:";
            // 
            // txtKhoaDieuTri
            // 
            this.txtKhoaDieuTri.Location = new System.Drawing.Point(120, 62);
            this.txtKhoaDieuTri.Name = "txtKhoaDieuTri";
            this.txtKhoaDieuTri.Size = new System.Drawing.Size(180, 20);
            this.txtKhoaDieuTri.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Triệu Chứng:";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(120, 102);
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(350, 50);
            this.txtTrieuChung.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Huyết Áp:";
            // 
            // txtHuyetAp
            // 
            this.txtHuyetAp.Location = new System.Drawing.Point(120, 167);
            this.txtHuyetAp.Name = "txtHuyetAp";
            this.txtHuyetAp.Size = new System.Drawing.Size(80, 20);
            this.txtHuyetAp.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thân Nhiệt:";
            // 
            // txtThanNhiet
            // 
            this.txtThanNhiet.Location = new System.Drawing.Point(290, 167);
            this.txtThanNhiet.Name = "txtThanNhiet";
            this.txtThanNhiet.Size = new System.Drawing.Size(80, 20);
            this.txtThanNhiet.TabIndex = 11;
            // 
            // dgvXetNghiem
            // 
            this.dgvXetNghiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXetNghiem.Location = new System.Drawing.Point(500, 22);
            this.dgvXetNghiem.Name = "dgvXetNghiem";
            this.dgvXetNghiem.Size = new System.Drawing.Size(270, 195);
            this.dgvXetNghiem.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Danh Sách Thuốc:";
            // 
            // txtDanhSachThuoc
            // 
            this.txtDanhSachThuoc.Location = new System.Drawing.Point(120, 210);
            this.txtDanhSachThuoc.Multiline = true;
            this.txtDanhSachThuoc.Name = "txtDanhSachThuoc";
            this.txtDanhSachThuoc.Size = new System.Drawing.Size(350, 60);
            this.txtDanhSachThuoc.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cách Dùng:";
            // 
            // txtCachDung
            // 
            this.txtCachDung.Location = new System.Drawing.Point(120, 287);
            this.txtCachDung.Multiline = true;
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(350, 50);
            this.txtCachDung.TabIndex = 16;
            // 
            // btnLuuToaThuoc
            // 
            this.btnLuuToaThuoc.Location = new System.Drawing.Point(500, 290);
            this.btnLuuToaThuoc.Name = "btnLuuToaThuoc";
            this.btnLuuToaThuoc.Size = new System.Drawing.Size(270, 45);
            this.btnLuuToaThuoc.TabIndex = 17;
            this.btnLuuToaThuoc.Text = "Lưu Khám Bệnh & Kê Toa";
            this.btnLuuToaThuoc.UseVisualStyleBackColor = true;
            this.btnLuuToaThuoc.Click += new System.EventHandler(this.btnLuuToaThuoc_Click);
            // 
            // frmKhamBenhVaKeToa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.btnLuuToaThuoc);
            this.Controls.Add(this.txtCachDung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDanhSachThuoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvXetNghiem);
            this.Controls.Add(this.txtThanNhiet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHuyetAp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKhoaDieuTri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaPKB);
            this.Controls.Add(this.label1);
            this.Name = "frmKhamBenhVaKeToa";
            this.Text = "Khám Bệnh & Kê Toa Thuốc";
            this.Load += new System.EventHandler(this.frmKhamBenhVaKeToa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPKB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhoaDieuTri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHuyetAp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThanNhiet;
        private System.Windows.Forms.DataGridView dgvXetNghiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDanhSachThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnLuuToaThuoc;
    }
}