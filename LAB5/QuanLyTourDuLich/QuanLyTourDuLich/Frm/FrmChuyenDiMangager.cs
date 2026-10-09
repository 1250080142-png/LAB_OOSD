using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyTourDuLich.Database;

namespace QuanLyTourDuLich.Frm
{
    public partial class FrmChuyenDiMangager : Form
    {
        public FrmChuyenDiMangager()
        {
            InitializeComponent();
            LoadTour();
            LoadDanhSachChuyen();
        }

        private void LoadTour()
        {
            cboTour.DataSource = Db.ExecuteQuery("SELECT MaTour, TenTour FROM TOUR");
            cboTour.DisplayMember = "TenTour";
            cboTour.ValueMember = "MaTour";
        }

        private void LoadDanhSachChuyen()
        {
            string q = @"SELECT C.MaChuyen AS 'Mã Chuyến', T.TenTour AS 'Tên Tour', 
                                C.NgayKhoiHanh AS 'Ngày Khởi Hành', C.SoChoConLai AS 'Chỗ Còn Lại' 
                         FROM CHUYEN_DI C 
                         JOIN TOUR T ON C.MaTour = T.MaTour";
            dgvDanhSachChuyen.DataSource = Db.ExecuteQuery(q);
        }

        // Bổ sung phương thức xử lý sự kiện Tạo Chuyến Đi Mới
        private void btnTaoChuyen_Click(object sender, EventArgs e)
        {
            if (cboTour.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Tour du lịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaChuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Chuyến Đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soCho = 40;
            int.TryParse(txtSoCho.Text, out soCho);

            string qInsert = "INSERT INTO CHUYEN_DI (MaChuyen, MaTour, NgayKhoiHanh, SoChoConLai) VALUES (@maC, @maTour, @ngayKH, @soCho)";
            SqlParameter[] p = {
                new SqlParameter("@maC", txtMaChuyen.Text.Trim()),
                new SqlParameter("@maTour", cboTour.SelectedValue.ToString()),
                new SqlParameter("@ngayKH", dtpNgayKhoiHanh.Value),
                new SqlParameter("@soCho", soCho)
            };

            if (Db.ExecuteNonQuery(qInsert, p) > 0)
            {
                MessageBox.Show("Mở chuyến đi mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChuyen.Clear();
                LoadDanhSachChuyen();
            }
        }
    }
}