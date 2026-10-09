using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyTourDuLich.Database;

namespace QuanLyTourDuLich.Frm
{
    public partial class FrmDanhSachBaoHiem : Form
    {
        public FrmDanhSachBaoHiem()
        {
            InitializeComponent();
            LoadPhieuDoan();
        }

        private void LoadPhieuDoan()
        {
            string q = "SELECT MaPhieu, TenDoan FROM PHIEU_DANG_KY_DOAN";
            cboMaPhieuDoan.DataSource = Db.ExecuteQuery(q);
            cboMaPhieuDoan.DisplayMember = "TenDoan";
            cboMaPhieuDoan.ValueMember = "MaPhieu";

            if (cboMaPhieuDoan.SelectedValue != null)
            {
                LoadDanhSachBaoHiem(cboMaPhieuDoan.SelectedValue.ToString());
            }
        }

        private void LoadDanhSachBaoHiem(string maPhieu)
        {
            string q = @"SELECT ID, MaPhieu AS 'Mã Phiếu Đoàn', HoTen AS 'Họ và Tên', 
                                CCCD AS 'Số CCCD/Passport', NgaySinh AS 'Ngày Sinh' 
                         FROM DANH_SACH_BAO_HIEM 
                         WHERE MaPhieu = @maPhieu";
            SqlParameter[] p = { new SqlParameter("@maPhieu", maPhieu) };
            dgvDanhSachBaoHiem.DataSource = Db.ExecuteQuery(q, p);
        }

        // Bổ sung phương thức xử lý sự kiện Thêm người vào danh sách bảo hiểm
        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            if (cboMaPhieuDoan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Phiếu Đăng Ký Đoàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và CCCD/Passport!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = cboMaPhieuDoan.SelectedValue.ToString();
            string qInsert = "INSERT INTO DANH_SACH_BAO_HIEM (MaPhieu, HoTen, CCCD, NgaySinh) VALUES (@maPhieu, @hoTen, @cccd, @ngaySinh)";
            SqlParameter[] p = {
                new SqlParameter("@maPhieu", maPhieu),
                new SqlParameter("@hoTen", txtHoTen.Text.Trim()),
                new SqlParameter("@cccd", txtCCCD.Text.Trim()),
                new SqlParameter("@ngaySinh", dtpNgaySinh.Value)
            };

            if (Db.ExecuteNonQuery(qInsert, p) > 0)
            {
                MessageBox.Show("Thêm thành viên vào danh sách bảo hiểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Clear();
                txtCCCD.Clear();
                LoadDanhSachBaoHiem(maPhieu);
            }
        }
    }
}