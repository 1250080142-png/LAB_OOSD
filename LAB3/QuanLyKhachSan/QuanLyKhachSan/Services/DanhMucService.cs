using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DanhMucService
    {
        #region 1. LẤY DỮ LIỆU (SELECT)

        public DataTable LayKhuVuc()
        {
            return Db.Query("SELECT * FROM KhuVuc ORDER BY MaKhuVuc");
        }

        public DataTable LayNhanVien()
        {
            return Db.Query("SELECT * FROM NhanVien ORDER BY MaNV");
        }

        public DataTable LayLoaiTienNghi()
        {
            return Db.Query("SELECT * FROM LoaiTienNghi ORDER BY MaLoaiTN");
        }

        public DataTable LayDichVu()
        {
            return Db.Query("SELECT * FROM DichVu ORDER BY MaDV");
        }

        public DataTable LayQuyDinhDenBu()
        {
            string sql = @"SELECT q.*, l.TenLoaiTN 
                           FROM QuyDinhDenBu q 
                           JOIN LoaiTienNghi l ON q.MaLoaiTN = l.MaLoaiTN 
                           ORDER BY q.MaQuyDinh";
            return Db.Query(sql);
        }

        #endregion

        #region 2. THÊM DỮ LIỆU (INSERT)

        // 2.1 Thêm Khu Vực
        public KetQuaXuLy ThemKhu(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                return KetQuaXuLy.Fail("Mã khu vực và tên khu vực không được để trống.");
            }

            try
            {
                string sql = "INSERT INTO KhuVuc VALUES(@m, @t)";
                Db.Execute(sql,
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten));

                return KetQuaXuLy.Ok("Đã thêm khu vực.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        // 2.2 Thêm Nhân Viên
        public KetQuaXuLy ThemNhanVien(string ma, string ten, string vaiTro, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(vaiTro))
            {
                return KetQuaXuLy.Fail("Thông tin nhân viên chưa đầy đủ.");
            }

            try
            {
                string sql = "INSERT INTO NhanVien VALUES(@m, @t, @v, @s)";
                Db.Execute(sql,
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@v", vaiTro),
                    new SqlParameter("@s", (object)sdt ?? DBNull.Value));

                return KetQuaXuLy.Ok("Đã thêm nhân viên.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        // 2.3 Thêm Loại Tiện Nghi
        public KetQuaXuLy ThemLoaiTN(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                return KetQuaXuLy.Fail("Thông tin loại tiện nghi chưa đủ.");
            }

            try
            {
                string sql = "INSERT INTO LoaiTienNghi VALUES(@m, @t)";
                Db.Execute(sql,
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten));

                return KetQuaXuLy.Ok("Đã thêm loại tiện nghi.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        // 2.4 Thêm Dịch Vụ
        public KetQuaXuLy ThemDichVu(string ma, string ten, string dvt, decimal gia)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(dvt) || gia < 0)
            {
                return KetQuaXuLy.Fail("Thông tin dịch vụ không hợp lệ.");
            }

            try
            {
                string sql = "INSERT INTO DichVu VALUES(@m, @t, @d, @g)";
                Db.Execute(sql,
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@d", dvt),
                    new SqlParameter("@g", gia));

                return KetQuaXuLy.Ok("Đã thêm dịch vụ.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        // 2.5 Thêm Quy Định Đền Bù
        public KetQuaXuLy ThemQuyDinh(string ma, string loai, string muc, decimal tien)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(muc) || tien < 0)
            {
                return KetQuaXuLy.Fail("Quy định đền bù không hợp lệ.");
            }

            try
            {
                string sql = "INSERT INTO QuyDinhDenBu VALUES(@m, @l, @u, @t)";
                Db.Execute(sql,
                    new SqlParameter("@m", ma),
                    new SqlParameter("@l", loai),
                    new SqlParameter("@u", muc),
                    new SqlParameter("@t", tien));

                return KetQuaXuLy.Ok("Đã thêm quy định đền bù.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail(ex.Message);
            }
        }

        #endregion
    }
}