namespace QuanLyHoSoBenhAn.Form
{
    partial class frmTraCuuHoSo
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvHoSoBenhAn = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTenBN = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.dgvLichSuKham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSoBenhAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã HS / SĐT:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(145, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(415, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 25);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tra Cứu";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvHoSoBenhAn
            // 
            this.dgvHoSoBenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoSoBenhAn.Location = new System.Drawing.Point(28, 65);
            this.dgvHoSoBenhAn.Name = "dgvHoSoBenhAn";
            this.dgvHoSoBenhAn.Size = new System.Drawing.Size(477, 160);
            this.dgvHoSoBenhAn.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDienThoai);
            this.groupBox1.Controls.Add(this.lblNgaySinh);
            this.groupBox1.Controls.Add(this.lblHoTenBN);
            this.groupBox1.Controls.Add(this.lblMaHS);
            this.groupBox1.Location = new System.Drawing.Point(525, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(20, 110);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(62, 13);
            this.lblDienThoai.TabIndex = 3;
            this.lblDienThoai.Text = "Điện Thoại:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 80);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(59, 13);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblHoTenBN
            // 
            this.lblHoTenBN.AutoSize = true;
            this.lblHoTenBN.Location = new System.Drawing.Point(20, 50);
            this.lblHoTenBN.Name = "lblHoTenBN";
            this.lblHoTenBN.Size = new System.Drawing.Size(46, 13);
            this.lblHoTenBN.TabIndex = 1;
            this.lblHoTenBN.Text = "Họ Tên:";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(20, 25);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(65, 13);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã Hồ Sơ:";
            // 
            // dgvLichSuKham
            // 
            this.dgvLichSuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuKham.Location = new System.Drawing.Point(28, 240);
            this.dgvLichSuKham.Name = "dgvLichSuKham";
            this.dgvLichSuKham.Size = new System.Drawing.Size(747, 160);
            this.dgvLichSuKham.TabIndex = 5;
            // 
            // frmTraCuuHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.dgvLichSuKham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHoSoBenhAn);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "frmTraCuuHoSo";
            this.Text = "Tra Cứu Hồ Sơ Bệnh Án";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSoBenhAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHoSoBenhAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTenBN;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.DataGridView dgvLichSuKham;
    }
}