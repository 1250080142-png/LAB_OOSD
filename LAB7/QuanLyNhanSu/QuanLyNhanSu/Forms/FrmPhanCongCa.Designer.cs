namespace QuanLyNhanSu
{
    partial class FrmPhanCongCa
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboMaCa = new System.Windows.Forms.ComboBox();
            this.dtpNgayPhanCong = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(30, 30);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(200, 21);
            this.cboMaNV.TabIndex = 1;
            // 
            // cboMaCa
            // 
            this.cboMaCa.FormattingEnabled = true;
            this.cboMaCa.Location = new System.Drawing.Point(260, 30);
            this.cboMaCa.Name = "cboMaCa";
            this.cboMaCa.Size = new System.Drawing.Size(150, 21);
            this.cboMaCa.TabIndex = 2;
            // 
            // dtpNgayPhanCong
            // 
            this.dtpNgayPhanCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayPhanCong.Location = new System.Drawing.Point(30, 75);
            this.dtpNgayPhanCong.Name = "dtpNgayPhanCong";
            this.dtpNgayPhanCong.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayPhanCong.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(440, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Phân Công";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmPhanCongCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 390);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayPhanCong);
            this.Controls.Add(this.cboMaCa);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPhanCongCa";
            this.Text = "Phân Công Ca Làm Việc";
            this.Load += new System.EventHandler(this.FrmPhanCongCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMaCa;
        private System.Windows.Forms.DateTimePicker dtpNgayPhanCong;
        private System.Windows.Forms.Button btnThem;
    }
}