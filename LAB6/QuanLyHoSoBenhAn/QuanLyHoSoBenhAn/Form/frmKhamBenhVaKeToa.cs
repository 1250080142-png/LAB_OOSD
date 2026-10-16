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
    // Bổ sung ": Form" ở đây để kế thừa đầy đủ tính năng Windows Forms
    public partial class frmKhamBenhVaKeToa : System.Windows.Forms.Form
    {
        Db db = new Db();
        public string MaHSBaoVuyen { get; set; }

        // 1. Constructor mặc định (Bắt buộc cho Visual Studio Designer)
        public frmKhamBenhVaKeToa()
        {
            InitializeComponent();
        }

        // 2. Constructor nhận mã hồ sơ từ form tra cứu
        public frmKhamBenhVaKeToa(string maHS) : this()
        {
            MaHSBaoVuyen = maHS;
        }

        private void frmKhamBenhVaKeToa_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            lblMaHS.Text = !string.IsNullOrEmpty(MaHSBaoVuyen) ? MaHSBaoVuyen : "[HS00]";
            txtMaPKB.Text = "PKB" + DateTime.Now.ToString("yyyyMMddHHmmss");
            LoadDanhSachXetNghiem();
        }

        private void LoadDanhSachXetNghiem()
        {
            try
            {
                string query = "SELECT maXN as [Mã XN], tenXetNghiem as [Tên Xét Nghiệm], ketQuaXN as [Kết Quả] FROM XET_NGHIEM WHERE maPKB = @maPKB";
                SqlParameter[] para = new SqlParameter[] {
                    new SqlParameter("@maPKB", txtMaPKB.Text)
                };
                DataTable dt = db.ExecuteQuery(query, para);
                dgvXetNghiem.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách xét nghiệm: " + ex.Message);
            }
        }

        private void btnLuuToaThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrieuChung.Text))
            {
                MessageBox.Show("Vui lòng nhập triệu chứng của bệnh nhân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = db.OpenConnection())
            {
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Lưu Phiếu Khám Bệnh
                    string queryPKB = "INSERT INTO PHIEU_KHAM_BENH (maPKB, maHS, maBS, ngayGioKham, khoaDieuTri, trieuChung, huyetAp, thanNhiet) " +
                                      "VALUES (@maPKB, @maHS, @maBS, @ngayGio, @khoa, @trieuChung, @huyetAp, @thanNhiet)";
                    SqlParameter[] paraPKB = new SqlParameter[] {
                        new SqlParameter("@maPKB", txtMaPKB.Text),
                        new SqlParameter("@maHS", lblMaHS.Text),
                        new SqlParameter("@maBS", "BS01"), // Mã bác sĩ mặc định hoặc lấy từ tài khoản đăng nhập
                        new SqlParameter("@ngayGio", DateTime.Now),
                        new SqlParameter("@khoa", txtKhoaDieuTri.Text),
                        new SqlParameter("@trieuChung", txtTrieuChung.Text),
                        new SqlParameter("@huyetAp", txtHuyetAp.Text),
                        new SqlParameter("@thanNhiet", string.IsNullOrEmpty(txtThanNhiet.Text) ? 0 : Convert.ToDouble(txtThanNhiet.Text))
                    };
                    db.ExecuteNonQuery(queryPKB, paraPKB);

                    // 2. Lưu Toa Thuốc
                    string queryToa = "INSERT INTO TOA_THUOC (maTT, maPKB, danhSachThuoc, cachDung) VALUES (@maTT, @maPKB, @thuoc, @cachDung)";
                    SqlParameter[] paraToa = new SqlParameter[] {
                        new SqlParameter("@maTT", "TT" + DateTime.Now.ToString("yyyyMMddHHmmss")),
                        new SqlParameter("@maPKB", txtMaPKB.Text),
                        new SqlParameter("@thuoc", txtDanhSachThuoc.Text),
                        new SqlParameter("@cachDung", txtCachDung.Text)
                    };
                    db.ExecuteNonQuery(queryToa, paraToa);

                    trans.Commit();
                    MessageBox.Show("Lưu thông tin khám bệnh và kê toa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}