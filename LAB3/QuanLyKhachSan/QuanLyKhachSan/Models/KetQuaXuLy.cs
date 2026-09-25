using System;

namespace QuanLyKhachSan
{
    // Class thông báo kết quả trả về
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }

        public static KetQuaXuLy Ok(string thongBao = "Thành công")
            => new KetQuaXuLy { ThanhCong = true, ThongBao = thongBao };

        public static KetQuaXuLy Fail(string thongBao)
            => new KetQuaXuLy { ThanhCong = false, ThongBao = thongBao };
    }

    // Class danh sách phòng đặt
    public class PhongDatItem
    {
        public string SoPhong { get; set; }
        public int SoNguoi { get; set; }
        public decimal DonGiaNgay { get; set; }
    }

    // Class danh sách đền bù
    public class DenBuItem
    {
        public string MaTienNghi { get; set; }
        public string TenLoaiTN { get; set; }
        public string MucDoThietHai { get; set; }
        public decimal SoTien { get; set; }
    }
}

// Bổ sung namespace này để triệt tiêu toàn bộ lỗi "Models does not exist" ở tất cả các file:
namespace QuanLyKhachSan.Models
{
    internal class DummyModel { }
}