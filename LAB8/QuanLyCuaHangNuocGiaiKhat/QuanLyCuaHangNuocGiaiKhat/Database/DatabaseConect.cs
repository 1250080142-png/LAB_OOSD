using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat.Database
{
    public class DatabaseConnect
    {
        // Chuỗi kết nối đến SQL Server (Sửa "MSI\SQLEXPRESS" thành tên Server của máy bạn nếu khác)
        private static string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLyCuaHangNuocGiaiKhat;Integrated Security=True";

        // Hàm lấy kết nối
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm thực thi câu lệnh Select (Trả về DataTable để đổ lên DataGridView)
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        // Hàm thực thi Insert, Update, Delete
        public static int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thực thi câu lệnh SQL: " + ex.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return rowsAffected;
        }
    }
}