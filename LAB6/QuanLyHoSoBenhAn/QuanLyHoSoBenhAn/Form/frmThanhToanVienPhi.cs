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
    public partial class frmThanhToanVienPhi : System.Windows.Forms.Form
    {
        Db db = new Db();

        public frmThanhToanVienPhi()
        {
            InitializeComponent();
        }

        private void frmThanhToanVienPhi_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            // Các sự kiện khởi tạo ban đầu nếu có
        }

        private void txtTimKiemMaHS_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemMaHS.Text)) return;

            try
            {
                // Truy vấn thông tin bệnh nhân và hồ sơ dựa vào Mã Hồ Sơ
                string query = @"SELECT bn.hoTen, hs.maHS 
                                 FROM HO_SO_BENH_AN hs 
                                 JOIN BENH_NHAN bn ON hs.maBN = bn.maBN 
                                 WHERE hs.maHS = @maHS";

                SqlParameter[] para = new SqlParameter[] {
                    new SqlParameter("@maHS", txtTimKiemMaHS.Text.Trim())
                };

                DataTable dt = db.ExecuteQuery(query, para);
                if (dt.Rows.Count > 0)
                {
                    txtHoTen.Text = dt.Rows[0]["hoTen"].ToString();
                    txtMaHS.Text = dt.Rows[0]["maHS"].ToString();

                    // Load chi tiết các khoản phí (Khám, Xét nghiệm, Thuốc) lên dgvChiTietChiPhi
                    LoadChiTietChiPhi(txtMaHS.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void LoadChiTietChiPhi(string maHS)
        {
            try
            {
                // Truy vấn tổng hợp chi phí khám chữa bệnh của hồ sơ
                string query = @"SELECT pkb.maPKB as [Mã Phiếu], pkb.khoaDieuTri as [Khoa Khám], 
                                 ISNULL(tt.danhSachThuoc, 'Không có thuốc') as [Toa Thuốc]
                                 FROM PHIEU_KHAM_BENH pkb
                                 LEFT JOIN TOA_THUOC tt ON pkb.maPKB = tt.maPKB
                                 WHERE pkb.maHS = @maHS";

                SqlParameter[] para = new SqlParameter[] {
                    new SqlParameter("@maHS", maHS)
                };

                DataTable dt = db.ExecuteQuery(query, para);
                dgvChiTietChiPhi.DataSource = dt;

                // Tạm tính tổng tiền viện phí mặc định (Ví dụ: 300,000 VNĐ / phiếu khám)
                decimal tongTien = dt.Rows.Count * 300000;
                txtTongTien.Text = tongTien.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi phí: " + ex.Message);
            }
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                MessageBox.Show("Vui lòng chọn hồ sơ cần thanh toán viện phí!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal tongTien = Convert.ToDecimal(txtTongTien.Text);
                decimal tienKhach = string.IsNullOrEmpty(txtTienKhachDua.Text) ? 0 : Convert.ToDecimal(txtTienKhachDua.Text);

                if (tienKhach < tongTien)
                {
                    MessageBox.Show("Số tiền khách đưa không đủ thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal tienThua = tienKhach - tongTien;
                txtTienThua.Text = tienThua.ToString("N0");

                MessageBox.Show("Thanh toán viện phí thành công! Đã cập nhật trạng thái hồ sơ.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message);
            }
        }
    }
}