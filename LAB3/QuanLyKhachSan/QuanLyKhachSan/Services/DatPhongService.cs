using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DatPhongService
    {
        #region 1. LẤY DỮ LIỆU (SELECT)

        public DataTable LayKhach()
        {
            return Db.Query("SELECT * FROM KhachHang ORDER BY HoTen");
        }

        public DataTable LayPhong()
        {
            string sql = @"SELECT p.*, k.TenKhuVuc 
                           FROM Phong p 
                           JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc 
                           ORDER BY p.SoPhong";
            return Db.Query(sql);
        }

        public DataTable LayPhieuDat()
        {
            string sql = @"SELECT d.*, k.HoTen 
                           FROM PhieuDatPhong d 
                           JOIN KhachHang k ON d.MaKhach = k.MaKhach 
                           ORDER BY d.NgayLap DESC";
            return Db.Query(sql);
        }

        public DataTable LayChiTiet(string soPhieuDat)
        {
            string sql = @"SELECT c.*, p.SoNguoiToiDa, p.DonGiaNgay 
                           FROM ChiTietDatPhong c 
                           JOIN Phong p ON c.SoPhong = p.SoPhong 
                           WHERE c.SoPhieuDat = @s";
            return Db.Query(sql, new SqlParameter("@s", soPhieuDat));
        }

        public DataTable LayNguoiLuuTru(string soPhieuDat)
        {
            string sql = @"SELECT * 
                           FROM NguoiLuuTru 
                           WHERE SoPhieuDat = @s 
                           ORDER BY SoPhong, MaNguoiLT";
            return Db.Query(sql, new SqlParameter("@s", soPhieuDat));
        }

        #endregion

        #region 2. QUẢN LÝ KHÁCH HÀNG & NGƯỜI LƯU TRÚ

        public KetQuaXuLy ThemKhach(string ma, string ten, string cmnd, string qt, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) ||
                string.IsNullOrWhiteSpace(cmnd) || string.IsNullOrWhiteSpace(qt))
            {
                return KetQuaXuLy.Fail("Thông tin khách chưa đầy đủ.");
            }

            try
            {
                string sql = "INSERT INTO KhachHang VALUES(@m, @t, @c, @q, @s)";
                Db.Execute(sql,
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@c", cmnd),
                    new SqlParameter("@q", qt),
                    new SqlParameter("@s", (object)sdt ?? DBNull.Value));

                return KetQuaXuLy.Ok("Đã lưu khách hàng.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        public KetQuaXuLy ThemNguoiLuuTru(string soPhieuDat, string soPhong, string ten, string cmnd, string qt)
        {
            if (string.IsNullOrWhiteSpace(soPhieuDat) || string.IsNullOrWhiteSpace(soPhong) ||
                string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(cmnd) || string.IsNullOrWhiteSpace(qt))
            {
                return KetQuaXuLy.Fail("Thông tin người lưu trú chưa đầy đủ.");
            }

            try
            {
                int max = Convert.ToInt32(Db.Scalar(
                    "SELECT SoNguoi FROM ChiTietDatPhong WHERE SoPhieuDat = @s AND SoPhong = @p",
                    new SqlParameter("@s", soPhieuDat),
                    new SqlParameter("@p", soPhong)));

                int dem = Convert.ToInt32(Db.Scalar(
                    "SELECT COUNT(*) FROM NguoiLuuTru WHERE SoPhieuDat = @s AND SoPhong = @p",
                    new SqlParameter("@s", soPhieuDat),
                    new SqlParameter("@p", soPhong)));

                if (dem >= max)
                {
                    return KetQuaXuLy.Fail("Đã đủ số người đăng ký cho phòng này.");
                }

                string sql = @"INSERT INTO NguoiLuuTru(SoPhieuDat, SoPhong, HoTen, SoCMND, QuocTich) 
                               VALUES(@s, @p, @t, @c, @q)";
                Db.Execute(sql,
                    new SqlParameter("@s", soPhieuDat),
                    new SqlParameter("@p", soPhong),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@c", cmnd),
                    new SqlParameter("@q", qt));

                return KetQuaXuLy.Ok("Đã thêm người lưu trú.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        #endregion

        #region 3. NGHIỆP VỤ ĐẶT PHÒNG & NHẬN PHÒNG (TRANSACTION)

        private bool PhongTrungLich(SqlConnection cn, SqlTransaction tx, string phong, DateTime nhan, DateTime tra)
        {
            string sql = @"SELECT COUNT(*) 
                           FROM ChiTietDatPhong c 
                           JOIN PhieuDatPhong d ON c.SoPhieuDat = d.SoPhieuDat 
                           WHERE c.SoPhong = @p 
                             AND d.TrangThai IN (N'Đã đặt', N'Đang ở') 
                             AND @nhan <= d.NgayTraDuKien 
                             AND @tra >= d.NgayNhan";

            var cmd = new SqlCommand(sql, cn, tx);
            cmd.Parameters.AddWithValue("@p", phong);
            cmd.Parameters.AddWithValue("@nhan", nhan.Date);
            cmd.Parameters.AddWithValue("@tra", tra.Date);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public KetQuaXuLy TaoDatPhong(string soPhieuDat, string maKhach, string maNV, DateTime ngayLap, DateTime nhan, DateTime tra, decimal coc, string kenh, List<PhongDatItem> dsPhong)
        {
            if (string.IsNullOrWhiteSpace(soPhieuDat) || string.IsNullOrWhiteSpace(maKhach) ||
                string.IsNullOrWhiteSpace(maNV) || dsPhong == null || dsPhong.Count == 0)
            {
                return KetQuaXuLy.Fail("Phiếu đặt phòng chưa đủ thông tin.");
            }

            if (tra.Date < nhan.Date)
            {
                return KetQuaXuLy.Fail("Ngày trả dự kiến không được trước ngày nhận.");
            }

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // 1. Kiểm tra tính hợp lệ của từng phòng
                    foreach (var item in dsPhong)
                    {
                        var cmdCheckCap = new SqlCommand("SELECT SoNguoiToiDa FROM Phong WHERE SoPhong = @p", cn, tx);
                        cmdCheckCap.Parameters.AddWithValue("@p", item.SoPhong);
                        var maxCap = cmdCheckCap.ExecuteScalar();

                        if (maxCap == null)
                        {
                            return KetQuaXuLy.Fail("Không tìm thấy phòng " + item.SoPhong);
                        }

                        if (item.SoNguoi <= 0 || item.SoNguoi > Convert.ToInt32(maxCap))
                        {
                            return KetQuaXuLy.Fail($"Số người của phòng {item.SoPhong} vượt sức chứa.");
                        }

                        if (PhongTrungLich(cn, tx, item.SoPhong, nhan, tra))
                        {
                            return KetQuaXuLy.Fail($"Phòng {item.SoPhong} bị trùng lịch đặt.");
                        }
                    }

                    // 2. Thêm Phiếu Đặt Phòng
                    string sqlPhieu = @"INSERT INTO PhieuDatPhong(SoPhieuDat, MaKhach, MaNVLeTan, NgayLap, NgayNhan, NgayTraDuKien, TienCoc, KenhDat, TrangThai) 
                                        VALUES(@s, @k, @nv, @lap, @nhan, @tra, @c, @kenh, N'Đã đặt')";

                    var cmdPhieu = new SqlCommand(sqlPhieu, cn, tx);
                    cmdPhieu.Parameters.AddWithValue("@s", soPhieuDat);
                    cmdPhieu.Parameters.AddWithValue("@k", maKhach);
                    cmdPhieu.Parameters.AddWithValue("@nv", maNV);
                    cmdPhieu.Parameters.AddWithValue("@lap", ngayLap);
                    cmdPhieu.Parameters.AddWithValue("@nhan", nhan.Date);
                    cmdPhieu.Parameters.AddWithValue("@tra", tra.Date);
                    cmdPhieu.Parameters.AddWithValue("@c", coc);
                    cmdPhieu.Parameters.AddWithValue("@kenh", kenh);
                    cmdPhieu.ExecuteNonQuery();

                    // 3. Thêm Chi Tiết Đặt Phòng & Cập nhật Trạng thái Phòng
                    foreach (var item in dsPhong)
                    {
                        var cmdChiTiet = new SqlCommand("INSERT INTO ChiTietDatPhong VALUES(@s, @p, @n)", cn, tx);
                        cmdChiTiet.Parameters.AddWithValue("@s", soPhieuDat);
                        cmdChiTiet.Parameters.AddWithValue("@p", item.SoPhong);
                        cmdChiTiet.Parameters.AddWithValue("@n", item.SoNguoi);
                        cmdChiTiet.ExecuteNonQuery();

                        var cmdUpdatePhong = new SqlCommand("UPDATE Phong SET TrangThai = N'Đã đặt' WHERE SoPhong = @p", cn, tx);
                        cmdUpdatePhong.Parameters.AddWithValue("@p", item.SoPhong);
                        cmdUpdatePhong.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã lập phiếu đặt phòng.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(ex.Message);
                }
            }
        }

        public KetQuaXuLy NhanPhong(string soPhieuDat, DateTime thucTe)
        {
            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    string sqlPhieu = @"UPDATE PhieuDatPhong 
                                        SET TrangThai = N'Đang ở', NgayNhanThucTe = @n 
                                        WHERE SoPhieuDat = @s AND TrangThai = N'Đã đặt'";

                    var cmdPhieu = new SqlCommand(sqlPhieu, cn, tx);
                    cmdPhieu.Parameters.AddWithValue("@n", thucTe);
                    cmdPhieu.Parameters.AddWithValue("@s", soPhieuDat);

                    if (cmdPhieu.ExecuteNonQuery() == 0)
                    {
                        return KetQuaXuLy.Fail("Phiếu không ở trạng thái có thể nhận phòng.");
                    }

                    string sqlPhong = @"UPDATE Phong 
                                        SET TrangThai = N'Đang ở' 
                                        WHERE SoPhong IN (SELECT SoPhong FROM ChiTietDatPhong WHERE SoPhieuDat = @s)";

                    var cmdPhong = new SqlCommand(sqlPhong, cn, tx);
                    cmdPhong.Parameters.AddWithValue("@s", soPhieuDat);
                    cmdPhong.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã nhận phòng.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(ex.Message);
                }
            }
        }

        public KetQuaXuLy DanhDauNoShow(string soPhieuDat)
        {
            try
            {
                string sqlPhieu = "UPDATE PhieuDatPhong SET TrangThai = N'No-show' WHERE SoPhieuDat = @s AND TrangThai = N'Đã đặt'";
                Db.Execute(sqlPhieu, new SqlParameter("@s", soPhieuDat));

                string sqlPhong = "UPDATE Phong SET TrangThai = N'Trống' WHERE SoPhong IN (SELECT SoPhong FROM ChiTietDatPhong WHERE SoPhieuDat = @s)";
                Db.Execute(sqlPhong, new SqlParameter("@s", soPhieuDat));

                return KetQuaXuLy.Ok("Đã đánh dấu không nhận phòng (No-show).");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        #endregion
    }
}