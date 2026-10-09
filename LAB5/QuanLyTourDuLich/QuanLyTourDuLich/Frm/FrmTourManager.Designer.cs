namespace QuanLyTourDuLich.Frm
{
    partial class FrmTourManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSelectTour = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.tabDetail = new System.Windows.Forms.TabControl();
            this.tabDiemDung = new System.Windows.Forms.TabPage();
            this.dgvDiemDung = new System.Windows.Forms.DataGridView();
            this.tabDiemThamQuan = new System.Windows.Forms.TabPage();
            this.dgvDiemThamQuan = new System.Windows.Forms.DataGridView();

            this.tabDetail.SuspendLayout();
            this.tabDiemDung.SuspendLayout();
            this.tabDiemThamQuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThamQuan)).BeginInit();
            this.SuspendLayout();

            this.lblSelectTour.Location = new System.Drawing.Point(20, 20);
            this.lblSelectTour.Text = "Chọn Tour du lịch:";
            this.cboTour.Location = new System.Drawing.Point(140, 17);
            this.cboTour.Size = new System.Drawing.Size(350, 23);
            

            this.tabDetail.Controls.Add(this.tabDiemDung);
            this.tabDetail.Controls.Add(this.tabDiemThamQuan);
            this.tabDetail.Location = new System.Drawing.Point(20, 60);
            this.tabDetail.Size = new System.Drawing.Size(920, 520);

            this.tabDiemDung.Controls.Add(this.dgvDiemDung);
            this.tabDiemDung.Text = "Điểm Dừng Chân (Ăn/Ở/Phương tiện)";
            this.dgvDiemDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.tabDiemThamQuan.Controls.Add(this.dgvDiemThamQuan);
            this.tabDiemThamQuan.Text = "Danh Sách Điểm Tham Quan";
            this.dgvDiemThamQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemThamQuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.lblSelectTour);
            this.Controls.Add(this.cboTour);
            this.Controls.Add(this.tabDetail);
            this.Text = "Chi tiết Lộ trình Tour";
            this.tabDetail.ResumeLayout(false);
            this.tabDiemDung.ResumeLayout(false);
            this.tabDiemThamQuan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThamQuan)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblSelectTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.TabControl tabDetail;
        private System.Windows.Forms.TabPage tabDiemDung;
        private System.Windows.Forms.DataGridView dgvDiemDung;
        private System.Windows.Forms.TabPage tabDiemThamQuan;
        private System.Windows.Forms.DataGridView dgvDiemThamQuan;
    }
}