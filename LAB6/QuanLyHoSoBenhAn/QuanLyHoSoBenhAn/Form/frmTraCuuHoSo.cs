using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Database;

namespace QuanLyHoSoBenhAn.Form
{
    // Thêm ": Form" ở đây để kế thừa đầy đủ tính năng Windows Forms
    public partial class frmTraCuuHoSo : System.Windows.Forms.Form
    {
        Db db = new Db();

        public frmTraCuuHoSo()
        {
            InitializeComponent();
        }

        private void frmTraCuuHoSo_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            LoadDanhSachHoSo();
        }

        private void LoadDanhSachHoSo()
        {
            try
            {
                string query = @"SELECT hs.maHS as [Mã Hồ Sơ], bn.maBN as [Mã BN], bn.hoTen as [Họ Tên], 
                                 bn.ngaySinh as [Ngày Sinh], bn.dienThoai as [Điện Thoại], hs.ngayLap as [Ngày Lập HS]
                                 FROM HO_SO_BENH_AN hs
                                 JOIN BENH_NHAN bn ON hs.maBN = bn.maBN";
                DataTable dt = db.ExecuteQuery(query);
                dgvHoSoBenhAn.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hồ sơ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadDanhSachHoSo();
                return;
            }

            try
            {
                string query = @"SELECT hs.maHS as [Mã Hồ Sơ], bn.maBN as [Mã BN], bn.hoTen as [Họ Tên], 
                                 bn.ngaySinh as [Ngày Sinh], bn.dienThoai as [Điện Thoại], hs.ngayLap as [Ngày Lập HS]
                                 FROM HO_SO_BENH_AN hs
                                 JOIN BENH_NHAN bn ON hs.maBN = bn.maBN
                                 WHERE hs.maHS LIKE @kw OR bn.dienThoai LIKE @kw OR bn.hoTen LIKE @kw";

                SqlParameter[] para = new SqlParameter[] {
                    new SqlParameter("@kw", "%" + keyword + "%")
                };

                DataTable dt = db.ExecuteQuery(query, para);
                dgvHoSoBenhAn.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoSoBenhAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoSoBenhAn.Rows[e.RowIndex];
                string maHS = row.Cells["Mã Hồ Sơ"].Value.ToString();

                // Hiển thị thông tin chi tiết lên các Label bên cạnh
                lblMaHS.Text = "Mã Hồ Sơ: " + maHS;
                lblHoTenBN.Text = "Họ Tên: " + row.Cells["Họ Tên"].Value.ToString();
                lblNgaySinh.Text = "Ngày Sinh: " + Convert.ToDateTime(row.Cells["Ngày Sinh"].Value).ToString("dd/MM/yyyy");
                lblDienThoai.Text = "Điện Thoại: " + row.Cells["Điện Thoại"].Value.ToString();

                // Load lịch sử khám bệnh của hồ sơ này lên dgvLichSuKham
                LoadLichSuKham(maHS);
            }
        }

        private void LoadLichSuKham(string maHS)
        {
            try
            {
                string query = @"SELECT maPKB as [Mã Phiếu Khám], ngayGioKham as [Thời Gian], 
                                 khoaDieuTri as [Khoa Điều Trị], trieuChung as [Triệu Chứng], 
                                 huyetAp as [Huyết Áp], thanNhiet as [Thân Nhiệt]
                                 FROM PHIEU_KHAM_BENH 
                                 WHERE maHS = @maHS 
                                 ORDER BY ngayGioKham DESC";

                SqlParameter[] para = new SqlParameter[] {
                    new SqlParameter("@maHS", maHS)
                };

                DataTable dt = db.ExecuteQuery(query, para);
                dgvLichSuKham.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử khám: " + ex.Message);
            }
        }
    }
}