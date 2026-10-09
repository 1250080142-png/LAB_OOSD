using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyTourDuLich.Database;

namespace QuanLyTourDuLich.Frm
{
    public partial class FrmDangKyDoan : Form
    {
        public FrmDangKyDoan()
        {
            InitializeComponent();
            LoadTour();
            LoadDanhSachDoan();
        }

        private void LoadTour()
        {
            cboTour.DataSource = Db.ExecuteQuery("SELECT MaTour, TenTour FROM TOUR");
            cboTour.DisplayMember = "TenTour";
            cboTour.ValueMember = "MaTour";
        }

        private void LoadDanhSachDoan()
        {
            string q = @"SELECT P.MaPhieu AS 'Mã Phiếu', P.TenDoan AS 'Tên Đoàn', T.TenTour AS 'Tên Tour', 
                                P.SoNguoi AS 'Số Lượng', P.NguoiDaiDien AS 'Đại Diện', P.SDTLienHe AS 'SĐT', P.TrangThai AS 'Trạng Thái'
                         FROM PHIEU_DANG_KY_DOAN P 
                         JOIN TOUR T ON P.MaTour = T.MaTour";
            dgvDanhSachDoan.DataSource = Db.ExecuteQuery(q);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboTour.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Tour!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenDoan.Text) || string.IsNullOrWhiteSpace(txtNguoiDuyet.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Đoàn và Người Đại Diện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = "PDK" + DateTime.Now.ToString("ddMMHHmm");
            string q = @"INSERT INTO PHIEU_DANG_KY_DOAN (MaPhieu, TenDoan, MaTour, SoNguoi, NguoiDaiDien, SDTLienHe, DiaChi, TrangThai) 
                         VALUES (@maPhieu, @tenDoan, @maTour, @soNguoi, @nguoiDD, @sdt, @diaChi, N'Đã cọc')";

            SqlParameter[] p = {
                new SqlParameter("@maPhieu", maPhieu),
                new SqlParameter("@tenDoan", txtTenDoan.Text.Trim()),
                new SqlParameter("@maTour", cboTour.SelectedValue.ToString()),
                new SqlParameter("@soNguoi", Convert.ToInt32(txtSoNguoi.Text)),
                new SqlParameter("@nguoiDD", txtNguoiDuyet.Text.Trim()),
                new SqlParameter("@sdt", txtSDT.Text.Trim()),
                new SqlParameter("@diaChi", txtDiaChi.Text.Trim())
            };

            if (Db.ExecuteNonQuery(q, p) > 0)
            {
                MessageBox.Show("Lập phiếu đăng ký tour đoàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDoan.Clear();
                txtNguoiDuyet.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
                LoadDanhSachDoan();
            }
        }
    }
}