namespace CuaHangNuocGiaiKhat
{
    partial class FrmNuocGiaiKhat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.TextBox txtMaNGK;
        private System.Windows.Forms.Label lblMaNGK;
        private System.Windows.Forms.TextBox txtTenNGK;
        private System.Windows.Forms.Label lblTenNGK;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.DataGridView dgvNuocGiaiKhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;

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
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.txtTenNGK = new System.Windows.Forms.TextBox();
            this.lblTenNGK = new System.Windows.Forms.Label();
            this.txtMaNGK = new System.Windows.Forms.TextBox();
            this.lblMaNGK = new System.Windows.Forms.Label();
            this.dgvNuocGiaiKhat = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuocGiaiKhat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(54)))), ((int)(((byte)(93)))));
            this.lblTitle.Location = new System.Drawing.Point(310, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(388, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NƯỚC GIẢI KHÁT & TỒN KHO";
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.txtDonGiaBan);
            this.grpDetail.Controls.Add(this.lblDonGiaBan);
            this.grpDetail.Controls.Add(this.txtSoLuongTon);
            this.grpDetail.Controls.Add(this.lblSoLuongTon);
            this.grpDetail.Controls.Add(this.txtTenNGK);
            this.grpDetail.Controls.Add(this.lblTenNGK);
            this.grpDetail.Controls.Add(this.txtMaNGK);
            this.grpDetail.Controls.Add(this.lblMaNGK);
            this.grpDetail.Location = new System.Drawing.Point(30, 60);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(948, 100);
            this.grpDetail.TabIndex = 1;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Thông tin nước giải khát";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(580, 60);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(250, 20);
            this.txtDonGiaBan.TabIndex = 7;
            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Location = new System.Drawing.Point(490, 63);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(68, 13);
            this.lblDonGiaBan.TabIndex = 6;
            this.lblDonGiaBan.Text = "Đơn Giá Bán:";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(120, 60);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(250, 20);
            this.txtSoLuongTon.TabIndex = 5;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Location = new System.Drawing.Point(30, 63);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(78, 13);
            this.lblSoLuongTon.TabIndex = 4;
            this.lblSoLuongTon.Text = "Số Lượng Tồn:";
            // 
            // txtTenNGK
            // 
            this.txtTenNGK.Location = new System.Drawing.Point(580, 25);
            this.txtTenNGK.Name = "txtTenNGK";
            this.txtTenNGK.Size = new System.Drawing.Size(250, 20);
            this.txtTenNGK.TabIndex = 3;
            // 
            // lblTenNGK
            // 
            this.lblTenNGK.AutoSize = true;
            this.lblTenNGK.Location = new System.Drawing.Point(490, 28);
            this.lblTenNGK.Name = "lblTenNGK";
            this.lblTenNGK.Size = new System.Drawing.Size(55, 13);
            this.lblTenNGK.TabIndex = 2;
            this.lblTenNGK.Text = "Tên NGK:";
            // 
            // txtMaNGK
            // 
            this.txtMaNGK.Location = new System.Drawing.Point(120, 25);
            this.txtMaNGK.Name = "txtMaNGK";
            this.txtMaNGK.Size = new System.Drawing.Size(250, 20);
            this.txtMaNGK.TabIndex = 1;
            // 
            // lblMaNGK
            // 
            this.lblMaNGK.AutoSize = true;
            this.lblMaNGK.Location = new System.Drawing.Point(30, 28);
            this.lblMaNGK.Name = "lblMaNGK";
            this.lblMaNGK.Size = new System.Drawing.Size(51, 13);
            this.lblMaNGK.TabIndex = 0;
            this.lblMaNGK.Text = "Mã NGK:";
            // 
            // dgvNuocGiaiKhat
            // 
            this.dgvNuocGiaiKhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuocGiaiKhat.Location = new System.Drawing.Point(30, 180);
            this.dgvNuocGiaiKhat.Name = "dgvNuocGiaiKhat";
            this.dgvNuocGiaiKhat.Size = new System.Drawing.Size(948, 320);
            this.dgvNuocGiaiKhat.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(680, 520);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(780, 520);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 35);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(880, 520);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 35);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // FrmNuocGiaiKhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 581);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNuocGiaiKhat);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNuocGiaiKhat";
            this.Text = "Danh Mục Nước Giải Khát";
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuocGiaiKhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}