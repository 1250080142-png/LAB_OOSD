using System;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.ShowDialog();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            FrmPhongBanChucVu frm = new FrmPhongBanChucVu();
            frm.ShowDialog();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            FrmHopDongTuyenDung frm = new FrmHopDongTuyenDung();
            frm.ShowDialog();
        }

        private void btnLuongCV_Click(object sender, EventArgs e)
        {
            FrmQuyetDinhLuongChucVu frm = new FrmQuyetDinhLuongChucVu();
            frm.ShowDialog();
        }

        private void btnPhanCa_Click(object sender, EventArgs e)
        {
            FrmPhanCongCa frm = new FrmPhanCongCa();
            frm.ShowDialog();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            FrmChamCongPhuTroi frm = new FrmChamCongPhuTroi();
            frm.ShowDialog();
        }

        private void btnKTKL_Click(object sender, EventArgs e)
        {
            FrmKhenThuongKyLuat frm = new FrmKhenThuongKyLuat();
            frm.ShowDialog();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            FrmTinhLuong frm = new FrmTinhLuong();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmThoat frm = new FrmThoat();
            frm.ShowDialog();
        }
    }
}