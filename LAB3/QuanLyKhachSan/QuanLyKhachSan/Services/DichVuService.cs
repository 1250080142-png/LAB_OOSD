using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DichVuService
    {
        #region 1. LẤY DỮ LIỆU (SELECT)

        /// <summary>
        /// Lấy danh sách các phiếu đặt phòng có trạng thái 'Đang ở' kèm số phòng
        /// </summary>
        public DataTable LayPhieuDangO()
        {
            string sql = @"SELECT d.SoPhieuDat, k.HoTen, c.SoPhong 
                           FROM PhieuDatPhong d 
                           JOIN KhachHang k ON d.MaKhach = k.MaKhach 
                           JOIN ChiTietDatPhong c ON d.SoPhieuDat = c.SoPhieuDat 
                           WHERE d.TrangThai = N'Đang ở' 
                           ORDER BY d.SoPhieuDat, c.SoPhong";
            return Db.Query(sql);
        }

        /// <summary>
        /// Lấy danh sách tất cả các dịch vụ trong hệ thống
        /// </summary>
        public DataTable LayDichVu()
        {
            return Db.Query("SELECT * FROM DichVu ORDER BY MaDV");
        }

        /// <summary>
        /// Lấy lịch sử sử dụng dịch vụ theo Số Phiếu Đặt
        /// </summary>
        public DataTable LayLichSu(string soPhieuDat)
        {
            string sql = @"SELECT p.SoPhieuSDDV, p.SoPhong, p.NgaySuDung, d.TenDV, c.SoLuong, c.DonGia, c.ThanhTien 
                           FROM PhieuSuDungDV p 
                           JOIN ChiTietPhieuSuDungDV c ON p.SoPhieuSDDV = c.SoPhieuSDDV 
                           JOIN DichVu d ON c.MaDV = d.MaDV 
                           WHERE p.SoPhieuDat = @s 
                           ORDER BY p.NgaySuDung, p.SoPhong, d.TenDV";
            return Db.Query(sql, new SqlParameter("@s", soPhieuDat));
        }

        #endregion

        #region 2. NGHIỆP VỤ GHI NHẬN SỬ DỤNG DỊCH VỤ (TRANSACTION)

        /// <summary>
        /// Ghi nhận việc sử dụng dịch vụ của phòng. 
        /// Tự động cộng dồn số lượng nếu cùng dịch vụ được sử dụng trong cùng một ngày.
        /// </summary>
        public KetQuaXuLy GhiNhan(string soPhieuDat, string soPhong, DateTime ngay, string maNV, string maDV, int soLuong)
        {
            // 1. Kiểm tra đầu vào hợp lệ
            if (string.IsNullOrWhiteSpace(soPhieuDat) ||
                string.IsNullOrWhiteSpace(soPhong) ||
                string.IsNullOrWhiteSpace(maNV) ||
                string.IsNullOrWhiteSpace(maDV) ||
                soLuong <= 0)
            {
                return KetQuaXuLy.Fail("Thông tin sử dụng dịch vụ không hợp lệ.");
            }

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 2. Kiểm tra trạng thái phiếu đặt phòng phải là "Đang ở"
                    var cmdCheckStatus = new SqlCommand("SELECT TrangThai FROM PhieuDatPhong WHERE SoPhieuDat = @s", cn, tx);
                    cmdCheckStatus.Parameters.AddWithValue("@s", soPhieuDat);

                    if (Convert.ToString(cmdCheckStatus.ExecuteScalar()) != "Đang ở")
                    {
                        return KetQuaXuLy.Fail("Chỉ ghi nhận dịch vụ cho phiếu đang lưu trú.");
                    }

                    // 3. Lấy đơn giá dịch vụ
                    var cmdGetPrice = new SqlCommand("SELECT DonGia FROM DichVu WHERE MaDV = @d", cn, tx);
                    cmdGetPrice.Parameters.AddWithValue("@d", maDV);

                    object objGia = cmdGetPrice.ExecuteScalar();
                    if (objGia == null)
                    {
                        return KetQuaXuLy.Fail("Không tìm thấy dịch vụ.");
                    }
                    decimal donGia = Convert.ToDecimal(objGia);

                    // 4. Kiểm tra xem trong ngày đã có Phiếu Sử Dụng Dịch Vụ cho Phòng + Phiếu Đặt này chưa
                    var cmdFindPhieuSD = new SqlCommand(
                        "SELECT SoPhieuSDDV FROM PhieuSuDungDV WHERE SoPhieuDat = @s AND SoPhong = @p AND NgaySuDung = @n",
                        cn, tx);
                    cmdFindPhieuSD.Parameters.AddWithValue("@s", soPhieuDat);
                    cmdFindPhieuSD.Parameters.AddWithValue("@p", soPhong);
                    cmdFindPhieuSD.Parameters.AddWithValue("@n", ngay.Date);

                    string soPhieuSDDV = Convert.ToString(cmdFindPhieuSD.ExecuteScalar());

                    // Nếu chưa có, tạo mới PhieuSuDungDV
                    if (string.IsNullOrWhiteSpace(soPhieuSDDV))
                    {
                        soPhieuSDDV = "SD" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

                        var cmdInsertPhieuSD = new SqlCommand(
                            "INSERT INTO PhieuSuDungDV VALUES(@so, @s, @p, @n, @nv)",
                            cn, tx);
                        cmdInsertPhieuSD.Parameters.AddWithValue("@so", soPhieuSDDV);
                        cmdInsertPhieuSD.Parameters.AddWithValue("@s", soPhieuDat);
                        cmdInsertPhieuSD.Parameters.AddWithValue("@p", soPhong);
                        cmdInsertPhieuSD.Parameters.AddWithValue("@n", ngay.Date);
                        cmdInsertPhieuSD.Parameters.AddWithValue("@nv", maNV);
                        cmdInsertPhieuSD.ExecuteNonQuery();
                    }

                    // 5. Kiểm tra chi tiết dịch vụ đã tồn tại trong phiếu SDDV này chưa
                    var cmdCheckDetail = new SqlCommand(
                        "SELECT COUNT(*) FROM ChiTietPhieuSuDungDV WHERE SoPhieuSDDV = @so AND MaDV = @d",
                        cn, tx);
                    cmdCheckDetail.Parameters.AddWithValue("@so", soPhieuSDDV);
                    cmdCheckDetail.Parameters.AddWithValue("@d", maDV);

                    if (Convert.ToInt32(cmdCheckDetail.ExecuteScalar()) > 0)
                    {
                        // Đã có -> Cộng dồn số lượng và cập nhật đơn giá mới nhất
                        var cmdUpdateDetail = new SqlCommand(
                            "UPDATE ChiTietPhieuSuDungDV SET SoLuong = SoLuong + @sl, DonGia = @g WHERE SoPhieuSDDV = @so AND MaDV = @d",
                            cn, tx);
                        cmdUpdateDetail.Parameters.AddWithValue("@sl", soLuong);
                        cmdUpdateDetail.Parameters.AddWithValue("@g", donGia);
                        cmdUpdateDetail.Parameters.AddWithValue("@so", soPhieuSDDV);
                        cmdUpdateDetail.Parameters.AddWithValue("@d", maDV);
                        cmdUpdateDetail.ExecuteNonQuery();
                    }
                    else
                    {
                        // Chưa có -> Thêm dòng chi tiết dịch vụ mới
                        var cmdInsertDetail = new SqlCommand(
                            "INSERT INTO ChiTietPhieuSuDungDV VALUES(@so, @d, @sl, @g)",
                            cn, tx);
                        cmdInsertDetail.Parameters.AddWithValue("@so", soPhieuSDDV);
                        cmdInsertDetail.Parameters.AddWithValue("@d", maDV);
                        cmdInsertDetail.Parameters.AddWithValue("@sl", soLuong);
                        cmdInsertDetail.Parameters.AddWithValue("@g", donGia);
                        cmdInsertDetail.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã ghi nhận dịch vụ. Nếu cùng dịch vụ được dùng nhiều lần trong ngày, số lượng được cộng dồn trong cùng phiếu.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(ex.Message);
                }
            }
        }

        #endregion
    }
}