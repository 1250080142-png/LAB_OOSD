using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Database
{
    public class Db
    {
        // Sử dụng tên Server đúng trên máy bạn (MSI\SQLEXPRESS)
        private string connString = @"Server=MSI\SQLEXPRESS;Database=QuanLyNhanSuDongA;Trusted_Connection=True;";

        // Hàm truy vấn trả về DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi truy vấn: " + ex.Message);
                }
            }
            return dt;
        }

        // Hàm thực thi Insert, Update, Delete
        public int ExecuteNonQuery(string query)
        {
            int rows = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi thực thi: " + ex.Message);
                }
            }
            return rows;
        }
    }
}