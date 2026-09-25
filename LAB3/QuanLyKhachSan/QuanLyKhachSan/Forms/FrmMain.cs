using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region MỞ CÁC FORM CHỨC NĂNG

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMuc())
            {
                f.ShowDialog(this);
            }
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmPhongTienNghi())
            {
                f.ShowDialog(this);
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDatPhong())
            {
                f.ShowDialog(this);
            }
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDichVu())
            {
                f.ShowDialog(this);
            }
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmTraPhong())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe())
            {
                f.ShowDialog(this);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        #endregion

        #region SỰ KIỆN TRỐNG (CÓ THỂ XÓA HOẶC ĐỂ NGUYÊN)

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnDanhMuc_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMuc()) f.ShowDialog(this);
        }

        private void btnPhongTienNghi_Click(object sender, EventArgs e)
        {
            using (var f = new FrmPhongTienNghi()) f.ShowDialog(this);
        }

        #endregion

        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmDatPhong()) f.ShowDialog(this);
        }

        private void btnTraPhong_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmTraPhong()) f.ShowDialog(this);
        }

        private void btnDichVu_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmDichVu()) f.ShowDialog(this);
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe()) f.ShowDialog(this);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
} // Đóng class FrmMain
     // Đóng namespace QuanLyKhachSan.Forms