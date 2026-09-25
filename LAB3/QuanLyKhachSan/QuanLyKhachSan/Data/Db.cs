using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Data
{
    public static class Db
    {
        // Điền thẳng chuỗi kết nối vào đây (không cần dùng ConfigurationManager nữa)
        // Nếu máy bạn dùng LocalDB thì đổi thành: @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        public static string ConnectionString
    => @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;User ID=sa;Password=123;TrustServerCertificate=True";

        public static SqlConnection OpenConnection()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        public static DataTable Query(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int Execute(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                return cmd.ExecuteScalar();
            }
        }
    }
}