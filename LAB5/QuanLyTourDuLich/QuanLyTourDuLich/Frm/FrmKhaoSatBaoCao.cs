using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyTourDuLich.Database;

namespace QuanLyTourDuLich.Frm
{
    public partial class FrmKhaoSatBaoCao : Form
    {
        public FrmKhaoSatBaoCao()
        {
            InitializeComponent();
        }

        // 1. Phương thức xử lý sự kiện lưu khảo sát
        private void btnLuuKhaoSat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaChuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Chuyến hoặc Mã Phiếu Đoàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string q = "INSERT INTO PHIEU_KHAO_SAT (MaChuyen, NoiDungGopY, DiemDanhGia) VALUES (@maC, @gopY, @diem)";
            SqlParameter[] p = {
                new SqlParameter("@maC", txtMaChuyen.Text),
                new SqlParameter("@gopY", txtGopY.Text),
                new SqlParameter("@diem", Convert.ToInt32(cboDiemDanhGia.SelectedItem))
            };

            if (Db.ExecuteNonQuery(q, p) > 0)
            {
                MessageBox.Show("Cảm ơn bạn đã gửi ý kiến khảo sát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChuyen.Clear();
                txtGopY.Clear();
            }
        }

        // 2. Phương thức xử lý sự kiện báo cáo doanh thu
        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            string qLe = "SELECT ISNULL(SUM(GiaVe), 0) FROM VE_KHACH_LE";
            decimal dtLe = Convert.ToDecimal(Db.ExecuteQuery(qLe).Rows[0][0]);

            string qDoan = "SELECT ISNULL(SUM(T.DonGiaKhach * P.SoNguoi), 0) FROM PHIEU_DANG_KY_DOAN P JOIN TOUR T ON P.MaTour = T.MaTour WHERE P.TrangThai = N'Hoàn tất' OR P.TrangThai = N'Đã cọc'";
            decimal dtDoan = Convert.ToDecimal(Db.ExecuteQuery(qDoan).Rows[0][0]);

            lblDoanhThuLe.Text = string.Format("Doanh thu Khách lẻ: {0:N0} VNĐ", dtLe);
            lblDoanhThuDoan.Text = string.Format("Doanh thu Khách đoàn: {0:N0} VNĐ", dtDoan);
            lblTongDoanhThu.Text = string.Format("TỔNG DOANH THU: {0:N0} VNĐ", dtLe + dtDoan);
        }
    }
}