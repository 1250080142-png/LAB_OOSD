using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHoSoBenhAn.Database
{
    class Db
    {
        // Chuỗi kết nối đến SQL Server (Thay đổi Server Name và Initial Catalog cho phù hợp với máy của bạn)
        private string connStr = "Data Source=localhost;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True";

        /// <summary>
        /// Phương thức tạo và mở kết nối cơ sở dữ liệu
        /// </summary>
        public SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(connStr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        /// <summary>
        /// Phương thức thực thi câu lệnh truy vấn (SELECT) và trả về DataTable dùng để đổ dữ liệu lên DataGridView
        /// </summary>
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Phương thức thực thi các câu lệnh không trả về dữ liệu (INSERT, UPDATE, DELETE)
        /// Trả về số dòng bị ảnh hưởng
        /// </summary>
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowsAffected;
        }

        /// <summary>
        /// Phương thức dùng để lấy giá trị đơn (Ví dụ: tính COUNT, SUM, MAX, hoặc kiểm tra sự tồn tại)
        /// </summary>
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;
            using (SqlConnection conn = OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    result = cmd.ExecuteScalar();
                }
            }
            return result;
        }
    }
}