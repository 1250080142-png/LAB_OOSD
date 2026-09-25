# BÀI THỰC HÀNH 3: HỆ THỐNG QUẢN LÝ KHÁCH SẠN
### TỪ PHÂN TÍCH YÊU CẦU - UML - CSDL - GIAO DIỆN ĐẾN CODE C# WINFORMS

* **Môn học:** Phân tích và Thiết kế Hướng đối tượng (OOSD)
* **Trường:** Đại học Tài Nguyên và Môi Trường TP.HCM 
* **Khoa:** Công nghệ Thông tin
* **Sinh viên thực hiện:** Nhan Phi Phố
* **Mã số sinh viên (MSSV):** 1250080142
* **Lớp:** 12_ĐH_CNPM2
* **Công nghệ sử dụng:** C# Windows Forms (.NET Framework 4.7.2), SQL Server (ADO.NET), Visual Studio 2022.

---

## 1. CẤU TRÚC THƯ MỤC BÀI NỘP
```text
LAB3/
├── README.md                          # Tài liệu hướng dẫn cài đặt, sử dụng & kiểm thử Lab 3
├── Database/
│   └── QuanLyKhachSan.sql             # Script SQL tạo CSDL QuanLyKhachSan và dữ liệu mẫu
└── QuanLyKhachSan/                    # Dự án mã nguồn Visual Studio 2022
    ├── QuanLyKhachSan.sln             # File Solution khởi chạy
    ├── App.config                     # Cấu hình chuỗi kết nối CSDL
    ├── Data/
    │   └── Db.cs                      # Lớp kết nối ADO.NET (OpenConnection, Query, Execute, Scalar)
    ├── Models/
    │   └── KetQuaXuLy.cs              # DTO: KetQuaXuLy, PhongDatItem, DenBuItem
    ├── Services/                      # Tầng xử lý nghiệp vụ & Transaction
    │   ├── DanhMucService.cs
    │   ├── PhongTienNghiService.cs
    │   ├── DatPhongService.cs
    │   ├── DichVuService.cs
    │   ├── TraPhongService.cs
    │   └── ThongKeService.cs
    └── Forms/                         # Tầng giao diện người dùng (Code-behind & Designer)
        ├── FrmMain                    # Màn hình chính điều hướng hệ thống
        ├── FrmDanhMuc                 # 5 Tab quản lý danh mục nền khách sạn
        ├── FrmPhongTienNghi           # Quản lý phòng, tiện nghi & phiếu lắp đặt
        ├── FrmDatPhong                # Đặt phòng, nhận phòng, quản lý người lưu trú
        ├── FrmDichVu                  # Ghi nhận dịch vụ phát sinh (tự cộng dồn)
        ├── FrmTraPhong                # Đền bù, lập hóa đơn, thanh toán nhiều lần
        └── FrmThongKe                 # Thống kê doanh thu, lượt ở và dịch vụ
