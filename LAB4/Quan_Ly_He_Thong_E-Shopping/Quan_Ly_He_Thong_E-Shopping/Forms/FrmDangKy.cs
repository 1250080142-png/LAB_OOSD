using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quan_Ly_He_Thong_E_Shopping.Forms
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryCheck = "SELECT COUNT(*) FROM KHACH_HANG WHERE Email = @Email";
            SqlParameter[] pCheck = new SqlParameter[] { new SqlParameter("@Email", email) };

            int count = Convert.ToInt32(Db.GetData(queryCheck, pCheck).Rows[0][0]);
            if (count > 0)
            {
                MessageBox.Show("Email này đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryInsert = @"INSERT INTO KHACH_HANG (HoTen, Email, MatKhau, SoDienThoai, DiaChi) 
                                 VALUES (@HoTen, @Email, @MatKhau, @SoDienThoai, @DiaChi)";
            SqlParameter[] pInsert = new SqlParameter[]
            {
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@Email", email),
                new SqlParameter("@MatKhau", matKhau),
                new SqlParameter("@SoDienThoai", soDienThoai),
                new SqlParameter("@DiaChi", diaChi)
            };

            if (Db.ExecuteNonQuery(queryInsert, pInsert) > 0)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}