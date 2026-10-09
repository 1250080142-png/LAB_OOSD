using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyTourDuLich.Database;

namespace QuanLyTourDuLich.Frm
{
    public partial class FrmBanVeKhachLe : Form
    {
        public FrmBanVeKhachLe()
        {
            InitializeComponent();
            LoadChuyenDi();
            LoadDanhSachVe();
        }

        private void LoadChuyenDi()
        {
            cboChuyenDi.DataSource = Db.ExecuteQuery("SELECT MaChuyen FROM CHUYEN_DI");
            cboChuyenDi.DisplayMember = "MaChuyen";
            cboChuyenDi.ValueMember = "MaChuyen";
        }

        private void LoadDanhSachVe()
        {
            string q = @"SELECT MaVe AS 'Mã Vé', MaChuyen AS 'Mã Chuyến', TenKhach AS 'Họ Tên Khách', 
                                SDT AS 'SĐT', GiaVe AS 'Giá Vé', NgayDat AS 'Ngày Đặt' 
                         FROM VE_KHACH_LE";
            dgvDanhSachVe.DataSource = Db.ExecuteQuery(q);
        }

        // Bổ sung phương thức xử lý sự kiện Xuất vé khách lẻ
        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            if (cboChuyenDi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Chuyến đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Khách Hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maVe = "VE" + DateTime.Now.ToString("ddMMHHmm");
            decimal giaVe = 0;
            decimal.TryParse(txtGiaVe.Text, out giaVe);

            string qInsert = @"INSERT INTO VE_KHACH_LE (MaVe, MaChuyen, TenKhach, SDT, GiaVe, NgayDat) 
                         VALUES (@maVe, @maChuyen, @tenKhach, @sdt, @giaVe, GETDATE())";

            SqlParameter[] p = {
                new SqlParameter("@maVe", maVe),
                new SqlParameter("@maChuyen", cboChuyenDi.SelectedValue.ToString()),
                new SqlParameter("@tenKhach", txtTenKhach.Text.Trim()),
                new SqlParameter("@sdt", txtSDT.Text.Trim()),
                new SqlParameter("@giaVe", giaVe)
            };

            if (Db.ExecuteNonQuery(qInsert, p) > 0)
            {
                MessageBox.Show("Xuất vé thành công! Mã vé: " + maVe, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Clear();
                txtSDT.Clear();
                LoadDanhSachVe();
            }
        }
    }
}