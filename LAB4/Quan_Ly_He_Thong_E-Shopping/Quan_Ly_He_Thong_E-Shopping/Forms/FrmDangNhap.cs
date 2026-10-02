using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quan_Ly_He_Thong_E_Shopping.Forms
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập Email và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT MaKH, HoTen FROM KHACH_HANG WHERE Email = @Email AND MatKhau = @MatKhau";
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Email", email),
                new SqlParameter("@MatKhau", matKhau)
            };

            DataTable dt = Db.GetData(query, p);

            if (dt != null && dt.Rows.Count > 0)
            {
                string hoTen = dt.Rows[0]["HoTen"].ToString();
                MessageBox.Show($"Đăng nhập thành công! Chào mừng {hoTen}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}