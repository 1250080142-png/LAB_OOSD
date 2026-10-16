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
using QuanLyHoSoBenhAn.Database; // Gọi namespace chứa lớp Db mà bạn đã tạo

namespace QuanLyHoSoBenhAn.Form
{
    public partial class frmDangKyVaCapHoSo : System.Windows.Forms.Form
    {
        Db db = new Db(); // Khởi tạo lớp kết nối CSDL

        public frmDangKyVaCapHoSo()
        {
            InitializeComponent();
        }

        private void frmDangKyVaCapHoSo_Load(object sender, EventArgs e)
        {
            // Tránh lỗi khi mở giao diện Design trong Visual Studio
            if (this.DesignMode) return;

            // Tự động sinh các mã định danh ban đầu
            txtMaBN.Text = "BN" + DateTime.Now.ToString("yyyyMMddHHmmss");
            txtMaPDK.Text = "PDK" + DateTime.Now.ToString("yyyyMMddHHmmss");
            txtMaHS.Text = "HS" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Load danh sách bệnh nhân lên DataGridView
            LoadDanhSachBenhNhan();
        }

        private void LoadDanhSachBenhNhan()
        {
            try
            {
                string query = "SELECT maBN as [Mã BN], hoTen as [Họ Tên], ngaySinh as [Ngày Sinh], diaChi as [Địa Chỉ], dienThoai as [SĐT] FROM BENH_NHAN";
                DataTable dt = db.ExecuteQuery(query);
                dgvDanhSachBenhNhan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuVaCapHoSo_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            using (SqlConnection conn = db.OpenConnection())
            {
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Thêm bệnh nhân mới
                    string sqlBN = "INSERT INTO BENH_NHAN (maBN, hoTen, ngaySinh, diaChi, dienThoai, anh3x4) VALUES (@maBN, @hoTen, @ngaySinh, @diaChi, @dienThoai, @anh3x4)";
                    SqlParameter[] paraBN = new SqlParameter[] {
                        new SqlParameter("@maBN", txtMaBN.Text),
                        new SqlParameter("@hoTen", txtHoTen.Text),
                        new SqlParameter("@ngaySinh", dtpNgaySinh.Value),
                        new SqlParameter("@diaChi", txtDiaChi.Text),
                        new SqlParameter("@dienThoai", txtDienThoai.Text),
                        new SqlParameter("@anh3x4", "")
                    };

                    using (SqlCommand cmd = new SqlCommand(sqlBN, conn, trans))
                    {
                        cmd.Parameters.AddRange(paraBN);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Thêm phiếu đăng ký & lệ phí năm
                    string sqlPDK = "INSERT INTO PHIEU_DANG_KY (maPDK, maBN, ngayDangKy, lePhiHangNam) VALUES (@maPDK, @maBN, @ngayDangKy, @lePhi)";
                    SqlParameter[] paraPDK = new SqlParameter[] {
                        new SqlParameter("@maPDK", txtMaPDK.Text),
                        new SqlParameter("@maBN", txtMaBN.Text),
                        new SqlParameter("@ngayDangKy", DateTime.Now),
                        new SqlParameter("@lePhi", Convert.ToDecimal(txtLePhi.Text))
                    };

                    using (SqlCommand cmd = new SqlCommand(sqlPDK, conn, trans))
                    {
                        cmd.Parameters.AddRange(paraPDK);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Cấp mã hồ sơ bệnh án (Trang bìa)
                    string sqlHS = "INSERT INTO HO_SO_BENH_AN (maHS, maBN, ngayLap) VALUES (@maHS, @maBN, @ngayLap)";
                    SqlParameter[] paraHS = new SqlParameter[] {
                        new SqlParameter("@maHS", txtMaHS.Text),
                        new SqlParameter("@maBN", txtMaBN.Text),
                        new SqlParameter("@ngayLap", DateTime.Now)
                    };

                    using (SqlCommand cmd = new SqlCommand(sqlHS, conn, trans))
                    {
                        cmd.Parameters.AddRange(paraHS);
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Đăng ký thông tin và cấp hồ sơ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới lại dữ liệu và sinh mã mới cho lượt tiếp theo
                    frmDangKyVaCapHoSo_Load(sender, e);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi thực thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}