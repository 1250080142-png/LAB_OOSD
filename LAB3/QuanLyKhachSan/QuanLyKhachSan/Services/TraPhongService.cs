using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class TraPhongService
    {
        #region 1. LẤY DỮ LIỆU (SELECT)

        /// <summary>
        /// Lấy danh sách phiếu đặt phòng đang ở trạng thái 'Đang ở'
        /// </summary>
        public DataTable LayPhieuDangO()
        {
            string sql = @"SELECT d.SoPhieuDat, k.HoTen, d.NgayNhanThucTe, d.NgayTraDuKien 
                           FROM PhieuDatPhong d 
                           JOIN KhachHang k ON d.MaKhach = k.MaKhach 
                           WHERE d.TrangThai = N'Đang ở' 
                           ORDER BY d.SoPhieuDat";
            return Db.Query(sql);
        }

        /// <summary>
        /// Lấy danh sách phòng thuộc phiếu đặt
        /// </summary>
        public DataTable LayPhongTheoPhieu(string soPhieuDat)
        {
            string sql = @"SELECT c.SoPhong, p.DonGiaNgay 
                           FROM ChiTietDatPhong c 
                           JOIN Phong p ON c.SoPhong = p.SoPhong 
                           WHERE c.SoPhieuDat = @s";
            return Db.Query(sql, new SqlParameter("@s", soPhieuDat));
        }

        /// <summary>
        /// Lấy danh sách tiện nghi được lắp đặt trong phòng
        /// </summary>
        public DataTable LayTienNghiPhong(string soPhong)
        {
            string sql = @"SELECT TOP 100 p.MaTienNghi, l.TenLoaiTN, t.TinhTrangHienTai 
                           FROM PhieuLapDat p 
                           JOIN TienNghi t ON p.MaTienNghi = t.MaTienNghi 
                           JOIN LoaiTienNghi l ON t.MaLoaiTN = l.MaLoaiTN 
                           WHERE p.SoPhong = @p 
                           ORDER BY p.NgayLap DESC";
            return Db.Query(sql, new SqlParameter("@p", soPhong));
        }

        /// <summary>
        /// Lấy bảng quy định đền bù hư hỏng tiện nghi
        /// </summary>
        public DataTable LayQuyDinh()
        {
            string sql = @"SELECT q.*, l.TenLoaiTN 
                           FROM QuyDinhDenBu q 
                           JOIN LoaiTienNghi l ON q.MaLoaiTN = l.MaLoaiTN 
                           ORDER BY l.TenLoaiTN, q.MucDoThietHai";
            return Db.Query(sql);
        }

        /// <summary>
        /// Lấy danh sách hóa đơn thanh toán
        /// </summary>
        public DataTable LayHoaDon()
        {
            string sql = @"SELECT h.*, k.HoTen 
                           FROM HoaDon h 
                           JOIN PhieuDatPhong d ON h.SoPhieuDat = d.SoPhieuDat 
                           JOIN KhachHang k ON d.MaKhach = k.MaKhach 
                           ORDER BY h.NgayLap DESC";
            return Db.Query(sql);
        }

        #endregion

        #region 2. NGHIỆP VỤ ĐỀN BÙ TÀI SẢN / TIỆN NGHI

        /// <summary>
        /// Lập phiếu đền bù khi có hư hại tài sản trong phòng
        /// </summary>
        public KetQuaXuLy LapPhieuDenBu(string soPhieuDB, string soPhieuDat, string soPhong, DateTime ngay, string maNV, List<DenBuItem> dsDenBu)
        {
            if (string.IsNullOrWhiteSpace(soPhieuDB) ||
                string.IsNullOrWhiteSpace(soPhieuDat) ||
                string.IsNullOrWhiteSpace(soPhong) ||
                string.IsNullOrWhiteSpace(maNV) ||
                dsDenBu == null ||
                dsDenBu.Count == 0)
            {
                return KetQuaXuLy.Fail("Phiếu đền bù chưa đủ thông tin.");
            }

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    decimal tongTien = 0;
                    foreach (var x in dsDenBu)
                    {
                        if (x.SoTien < 0)
                        {
                            return KetQuaXuLy.Fail("Mức đền bù không hợp lệ.");
                        }
                        tongTien += x.SoTien;
                    }

                    // 1. Tạo PhieuDenBu
                    string sqlPhieu = "INSERT INTO PhieuDenBu VALUES(@so, @d, @p, @n, @nv, @t)";
                    var cmdPhieu = new SqlCommand(sqlPhieu, cn, tx);
                    cmdPhieu.Parameters.AddWithValue("@so", soPhieuDB);
                    cmdPhieu.Parameters.AddWithValue("@d", soPhieuDat);
                    cmdPhieu.Parameters.AddWithValue("@p", soPhong);
                    cmdPhieu.Parameters.AddWithValue("@n", ngay);
                    cmdPhieu.Parameters.AddWithValue("@nv", maNV);
                    cmdPhieu.Parameters.AddWithValue("@t", tongTien);
                    cmdPhieu.ExecuteNonQuery();

                    // 2. Thêm ChiTietPhieuDenBu
                    foreach (var x in dsDenBu)
                    {
                        string sqlCT = "INSERT INTO ChiTietPhieuDenBu VALUES(@so, @tn, @m, @t)";
                        var cmdCT = new SqlCommand(sqlCT, cn, tx);
                        cmdCT.Parameters.AddWithValue("@so", soPhieuDB);
                        cmdCT.Parameters.AddWithValue("@tn", x.MaTienNghi);
                        cmdCT.Parameters.AddWithValue("@m", x.MucDoThietHai);
                        cmdCT.Parameters.AddWithValue("@t", x.SoTien);
                        cmdCT.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã lập phiếu đền bù.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(ex.Message);
                }
            }
        }

        #endregion

        #region 3. NGHIỆP VỤ HÓA ĐƠN & THANH TOÁN

        /// <summary>
        /// Lập hóa đơn tiền phòng và dịch vụ cho lượt lưu trú
        /// </summary>
        public KetQuaXuLy LapHoaDon(string soHoaDon, string soPhieuDat, DateTime ngayLap, string maNV, int soNgayTinhTien)
        {
            if (string.IsNullOrWhiteSpace(soHoaDon) ||
                string.IsNullOrWhiteSpace(soPhieuDat) ||
                string.IsNullOrWhiteSpace(maNV) ||
                soNgayTinhTien <= 0)
            {
                return KetQuaXuLy.Fail("Thông tin hóa đơn chưa hợp lệ.");
            }

            try
            {
                // Tính tiền phòng = Tổng đơn giá các phòng trong phiếu * số ngày ở
                string sqlTienPhong = @"SELECT ISNULL(SUM(p.DonGiaNgay), 0) 
                                        FROM ChiTietDatPhong c 
                                        JOIN Phong p ON c.SoPhong = p.SoPhong 
                                        WHERE c.SoPhieuDat = @s";
                decimal tienPhong = Convert.ToDecimal(Db.Scalar(sqlTienPhong, new SqlParameter("@s", soPhieuDat))) * soNgayTinhTien;

                // Tính tiền dịch vụ = Tổng thành tiền các dịch vụ đã sử dụng
                string sqlTienDV = @"SELECT ISNULL(SUM(c.ThanhTien), 0) 
                                     FROM PhieuSuDungDV h 
                                     JOIN ChiTietPhieuSuDungDV c ON h.SoPhieuSDDV = c.SoPhieuSDDV 
                                     WHERE h.SoPhieuDat = @s";
                decimal tienDichVu = Convert.ToDecimal(Db.Scalar(sqlTienDV, new SqlParameter("@s", soPhieuDat)));

                // Thêm mới Hóa đơn
                string sqlInsertHD = @"INSERT INTO HoaDon(SoHoaDon, SoPhieuDat, NgayLap, MaNV, SoNgayTinhTien, TienPhong, TienDichVu, TrangThai) 
                                       VALUES(@h, @s, @n, @nv, @ng, @p, @d, N'Chưa thanh toán')";
                Db.Execute(sqlInsertHD,
                    new SqlParameter("@h", soHoaDon),
                    new SqlParameter("@s", soPhieuDat),
                    new SqlParameter("@n", ngayLap),
                    new SqlParameter("@nv", maNV),
                    new SqlParameter("@ng", soNgayTinhTien),
                    new SqlParameter("@p", tienPhong),
                    new SqlParameter("@d", tienDichVu));

                return KetQuaXuLy.Ok("Đã lập hóa đơn tiền phòng và dịch vụ. Số ngày tính tiền là dữ liệu nhân viên xác nhận vì đề gốc không quy định cách làm tròn ngày lưu trú.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Ghi nhận thanh toán tiền hóa đơn
        /// </summary>
        public KetQuaXuLy ThanhToan(string maThanhToan, string soHoaDon, DateTime ngayThanhToan, string hinhThuc, decimal soTien)
        {
            if (string.IsNullOrWhiteSpace(maThanhToan) ||
                string.IsNullOrWhiteSpace(soHoaDon) ||
                string.IsNullOrWhiteSpace(hinhThuc) ||
                soTien <= 0)
            {
                return KetQuaXuLy.Fail("Thông tin thanh toán không hợp lệ.");
            }

            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // Lấy tổng tiền của hóa đơn
                    var cmdCheckHD = new SqlCommand("SELECT TongTien FROM HoaDon WHERE SoHoaDon = @h", cn, tx);
                    cmdCheckHD.Parameters.AddWithValue("@h", soHoaDon);
                    object objTong = cmdCheckHD.ExecuteScalar();

                    if (objTong == null)
                    {
                        return KetQuaXuLy.Fail("Không tìm thấy hóa đơn.");
                    }
                    decimal tongTienHD = Convert.ToDecimal(objTong);

                    // Lấy số tiền đã thanh toán trước đó
                    var cmdPaid = new SqlCommand("SELECT ISNULL(SUM(SoTien), 0) FROM ThanhToan WHERE SoHoaDon = @h", cn, tx);
                    cmdPaid.Parameters.AddWithValue("@h", soHoaDon);
                    decimal daThanhToan = Convert.ToDecimal(cmdPaid.ExecuteScalar());

                    if (daThanhToan + soTien > tongTienHD)
                    {
                        return KetQuaXuLy.Fail("Số tiền thanh toán vượt số còn phải trả.");
                    }

                    // Ghi nhận lượt thanh toán
                    var cmdInsertTT = new SqlCommand("INSERT INTO ThanhToan VALUES(@m, @h, @n, @ht, @t)", cn, tx);
                    cmdInsertTT.Parameters.AddWithValue("@m", maThanhToan);
                    cmdInsertTT.Parameters.AddWithValue("@h", soHoaDon);
                    cmdInsertTT.Parameters.AddWithValue("@n", ngayThanhToan);
                    cmdInsertTT.Parameters.AddWithValue("@ht", hinhThuc);
                    cmdInsertTT.Parameters.AddWithValue("@t", soTien);
                    cmdInsertTT.ExecuteNonQuery();

                    // Nếu đã thanh toán đủ -> Cập nhật trạng thái Hóa đơn
                    if (daThanhToan + soTien == tongTienHD)
                    {
                        var cmdUpdateHD = new SqlCommand("UPDATE HoaDon SET TrangThai = N'Đã thanh toán' WHERE SoHoaDon = @h", cn, tx);
                        cmdUpdateHD.Parameters.AddWithValue("@h", soHoaDon);
                        cmdUpdateHD.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok($"Đã ghi nhận thanh toán bằng {hinhThuc}.");
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(ex.Message);
                }
            }
        }

        #endregion

        #region 4. NGHIỆP VỤ TRẢ PHÒNG

        /// <summary>
        /// Xử lý hoàn tất trả phòng và cập nhật trạng thái các phòng về 'Trống'
        /// </summary>
        public KetQuaXuLy TraPhong(string soPhieuDat, DateTime ngayTraThucTe)
        {
            using (var cn = Db.OpenConnection())
            using (var tx = cn.BeginTransaction())
            {
                try
                {
                    // Kiểm tra trạng thái hóa đơn
                    var cmdHD = new SqlCommand("SELECT h.SoHoaDon, h.TrangThai FROM HoaDon h WHERE h.SoPhieuDat = @s", cn, tx);
                    cmdHD.Parameters.AddWithValue("@s", soPhieuDat);

                    string soHD = null;
                    string trangThaiHD = null;

                    using (var rd = cmdHD.ExecuteReader())
                    {
                        if (!rd.Read())
                        {
                            return KetQuaXuLy.Fail("Chưa lập hóa đơn cho phiếu đặt phòng.");
                        }
                        soHD = Convert.ToString(rd[0]);
                        trangThaiHD = Convert.ToString(rd[1]);
                    }

                    if (trangThaiHD != "Đã thanh toán")
                    {
                        return KetQuaXuLy.Fail("Hóa đơn chưa thanh toán đủ.");
                    }

                    // Cập nhật trạng thái phiếu đặt -> 'Đã trả'
                    var cmdUpdatePhieu = new SqlCommand(
                        "UPDATE PhieuDatPhong SET TrangThai = N'Đã trả', NgayTraThucTe = @n WHERE SoPhieuDat = @s",
                        cn, tx);
                    cmdUpdatePhieu.Parameters.AddWithValue("@n", ngayTraThucTe);
                    cmdUpdatePhieu.Parameters.AddWithValue("@s", soPhieuDat);
                    cmdUpdatePhieu.ExecuteNonQuery();

                    // Cập nhật trạng thái phòng -> 'Trống'
                    var cmdUpdatePhong = new SqlCommand(
                        "UPDATE Phong SET TrangThai = N'Trống' WHERE SoPhong IN (SELECT SoPhong FROM ChiTietDatPhong WHERE SoPhieuDat = @s)",
                        cn, tx);
                    cmdUpdatePhong.Parameters.AddWithValue("@s", soPhieuDat);
                    cmdUpdatePhong.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã hoàn tất trả phòng.");
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