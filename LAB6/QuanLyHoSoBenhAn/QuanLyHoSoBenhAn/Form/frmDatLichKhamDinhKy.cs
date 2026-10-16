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
    public partial class frmDatLichKhamDinhKy : System.Windows.Forms.Form
    {
        Db db = new Db();

        public frmDatLichKhamDinhKy()
        {
            InitializeComponent();
        }

        private void frmDatLichKhamDinhKy_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            // Tự động sinh mã lịch hẹn
            txtMaLH.Text = "LH" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Load danh sách lịch hẹn lên DataGridView
            LoadDanhSachLichHen();
        }

        private void LoadDanhSachLichHen()
        {
            try
            {
                string query = "SELECT maLH as [Mã Lịch Hẹn], maBN as [Mã BN], maHS as [Mã Hồ Sơ], ngayGioHen as [Ngày Giờ Hẹn], loaiHen as [Loại Hẹn] FROM LICH_HEN";
                DataTable dt = db.ExecuteQuery(query);
                dgvLichHen.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lịch hẹn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBN.Text) || string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Bệnh Nhân và Mã Hồ Sơ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO LICH_HEN (maLH, maBN, maHS, ngayGioHen, loaiHen) VALUES (@maLH, @maBN, @maHS, @ngayGioHen, @loaiHen)";
                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@maLH", txtMaLH.Text),
                    new SqlParameter("@maBN", txtMaBN.Text),
                    new SqlParameter("@maHS", txtMaHS.Text),
                    new SqlParameter("@ngayGioHen", dtpNgayGioHen.Value),
                    new SqlParameter("@loaiHen", cboLoaiHen.Text)
                };

                int row = db.ExecuteNonQuery(query, parameters);
                if (row > 0)
                {
                    MessageBox.Show("Đặt lịch khám định kỳ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDatLichKhamDinhKy_Load(sender, e); // Làm mới lại form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}