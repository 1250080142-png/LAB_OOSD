using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyTourDuLich.Database;

namespace QuanLyTourDuLich.Frm
{
    public partial class FrmPhanCongVaLuong : Form
    {
        public FrmPhanCongVaLuong()
        {
            InitializeComponent();
            LoadHDV();
            LoadChuyenDi();
        }

        private void LoadHDV()
        {
            cboHDV.DataSource = Db.ExecuteQuery("SELECT MaNV, HoTen FROM NHAN_VIEN");
            cboHDV.DisplayMember = "HoTen";
            cboHDV.ValueMember = "MaNV";
        }

        private void LoadChuyenDi()
        {
            cboChuyenDi.DataSource = Db.ExecuteQuery("SELECT MaChuyen FROM CHUYEN_DI");
            cboChuyenDi.DisplayMember = "MaChuyen";
            cboChuyenDi.ValueMember = "MaChuyen";
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (cboHDV.SelectedValue == null || cboChuyenDi.SelectedValue == null) return;

            string maNV = cboHDV.SelectedValue.ToString();
            DateTime ngayBD = dtpNgayBD.Value;
            DateTime ngayKT = dtpNgayKT.Value;

            string qKiemTra = @"SELECT COUNT(*) FROM PHAN_CONG 
                               WHERE MaNV = @maNV AND NOT (NgayKetThuc < @ngayBD OR NgayBatDau > @ngayKT)";
            SqlParameter[] pKiemTra = {
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@ngayBD", ngayBD),
                new SqlParameter("@ngayKT", ngayKT)
            };

            int count = Convert.ToInt32(Db.ExecuteQuery(qKiemTra, pKiemTra).Rows[0][0]);
            if (count > 0)
            {
                MessageBox.Show("Hướng dẫn viên này đã bị TRÙNG LỊCH phân công trong khoảng thời gian trên!", "Cảnh báo trùng lịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string qSave = "INSERT INTO PHAN_CONG (MaNV, MaChuyen, PhuCapTour, NgayBatDau, NgayKetThuc) VALUES (@maNV, @maC, @phuCap, @ngayBD, @ngayKT)";
            SqlParameter[] pSave = {
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@maC", cboChuyenDi.SelectedValue.ToString()),
                new SqlParameter("@phuCap", Convert.ToDecimal(txtPhuCap.Text)),
                new SqlParameter("@ngayBD", ngayBD),
                new SqlParameter("@ngayKT", ngayKT)
            };
            Db.ExecuteNonQuery(qSave, pSave);
            MessageBox.Show("Phân công Hướng dẫn viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (cboThang.SelectedItem == null || string.IsNullOrEmpty(txtNam.Text)) return;

            int thang = Convert.ToInt32(cboThang.SelectedItem);
            int nam = Convert.ToInt32(txtNam.Text);

            string qLuong = @"SELECT NV.MaNV AS 'Mã NV', NV.HoTen AS 'Tên HDV', NV.LuongCoBan AS 'Lương Cơ Bản',
                                    ISNULL(SUM(PC.PhuCapTour), 0) AS 'Tổng Phụ Cấp Tour',
                                    (NV.LuongCoBan + ISNULL(SUM(PC.PhuCapTour), 0)) AS 'Tổng Lương Thực Nhận'
                             FROM NHAN_VIEN NV
                             LEFT JOIN PHAN_CONG PC ON NV.MaNV = PC.MaNV 
                             AND MONTH(PC.NgayBatDau) = @thang AND YEAR(PC.NgayBatDau) = @nam
                             GROUP BY NV.MaNV, NV.HoTen, NV.LuongCoBan";

            SqlParameter[] p = { new SqlParameter("@thang", thang), new SqlParameter("@nam", nam) };
            dgvBangLuong.DataSource = Db.ExecuteQuery(qLuong, p);
        }
    }
}