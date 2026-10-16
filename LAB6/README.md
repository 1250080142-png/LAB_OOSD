# BÀI THỰC HÀNH 6: HỆ THỐNG QUẢN LÝ TOUR DU LỊCH (VĂN HÓA VIỆT TP.HCM)
### TỪ PHÂN TÍCH YÊU CẦU - PHÂN QUYỀN (RBAC) - HÓA ĐƠN - BIỂU ĐỒ ĐẾN CODE C# WINFORMS

- **Môn học:** Phân tích và Thiết kế Hướng đối tượng (OOSD)
- **Trường:** Đại học Tài Nguyên và Môi Trường TP.HCM 
- **Khoa:** Công nghệ Thông tin
- **Sinh viên thực hiện:** Nhan Phi Phố
- **Mã số sinh viên (MSSV):** 1250080142
- **Lớp:** 12_ĐH_CNPM2
- **Công nghệ sử dụng:** C# Windows Forms (.NET Framework 4.8), SQL Server (ADO.NET), Visual Studio 2022, `System.Windows.Forms.DataVisualization.Charting`.

---

## 1. CẤU TRÚC THƯ MỤC BÀI NỘP
```text
LAB6/
├── README.md                          # Tài liệu hướng dẫn cài đặt, sử dụng & kiểm thử Lab 6
├── Database/
    ├── QuanLyTourDuLich.sql           # Script SQL tạo CSDL Lab 5 (8 bảng cơ bản)
    └── QuanLyTourDuLich_Lab6.sql      # Script SQL bổ sung CSDL Lab 6 (Tài khoản & Hóa đơn)
└── QuanLyTourDuLich/                  # Dự án mã nguồn Visual Studio 2022
    ├── QuanLyTourDuLich.sln           # File Solution khởi chạy dự án
    ├── App.config                     # Cấu hình chuỗi kết nối SQL Server
    ├── Database/
    │   └── Db.cs                      # Lớp truy vấn dữ liệu SQL Server (ExecuteQuery, ExecuteNonQuery)
    ├── Frm/                           # Tầng giao diện người dùng (Code-behind & Designer)
    │   ├── FrmLogin.cs                # Màn hình Đăng nhập & Xác thực phân quyền hệ thống
    │   ├── FrmMain.cs                 # Màn hình chính Dashboard điều hướng (Phân quyền Admin/NV)
    │   ├── FrmTourManager.cs          # Quản lý danh mục Tour du lịch
    │   ├── FrmChuyenDiMangager.cs     # Quản lý chuyến đi & mở lịch khởi hành
    │   ├── FrmDangKyDoan.cs           # Đăng ký Tour cho đoàn khách đông người
    │   ├── FrmBanVeKhachLe.cs         # Bán vé & đặt chỗ cho khách lẻ
    │   ├── FrmPhanCongVaLuong.cs      # Phân công HDV (kiểm tra trùng lịch) & Tính lương
    │   ├── FrmLapHoaDon.cs            # Lập hóa đơn thanh toán tiền Tour (Đoàn & Khách lẻ)
    │   ├── FrmThongKeBieuDo.cs        # Biểu đồ trực quan hóa doanh thu theo Tour (Chart)
    │   ├── FrmKhaoSatBaoCao.cs        # Khảo sát chất lượng & Báo cáo doanh thu
    │   └── FrmDanhSachBaoHiem.cs      # Quản lý danh sách bảo hiểm du lịch
    └── Program.cs                     # Điểm khởi chạy ứng dụng (Khởi động từ FrmLogin)
2. HƯỚNG DẪN CÀI ĐẶT & KHỞI CHẠY HỆ THỐNG CHI TIẾT (TỪ A ĐẾN Z)
2.1 Yêu cầu môi trường & Phần mềm
Môi trường phát triển: Microsoft Visual Studio 2022 (cài đặt workload .NET desktop development).

Hệ quản trị CSDL: Microsoft SQL Server (Phiên bản 2016 trở lên, SQL Server Express, hoặc LocalDB).

Công cụ quản lý CSDL: SQL Server Management Studio (SSMS) hoặc Azure Data Studio.

Môi trường thực thi: .NET Framework 4.8 Runtime.

2.2 Các bước cài đặt CSDL SQL Server (Lab 5 & Lab 6)
Khởi động phần mềm quản lý CSDL:

Mở SQL Server Management Studio (SSMS).

Nhập Server name tương ứng trên máy tính của bạn (Ví dụ: .\SQLEXPRESS, LOCALHOST hoặc MSI\SQLEXPRESS).

Chọn phương thức xác thực Windows Authentication và nhấn Connect.

Thực thi Script khởi tạo CSDL:

Tạo cửa sổ truy vấn mới (New Query) và thực thi đoạn script tổng hợp bổ sung đầy đủ các bảng nâng cao của Lab 6:
CREATE DATABASE QuanLyTourDuLich;
GO

USE QuanLyTourDuLich;
GO

-- 1. Bảng TOUR
CREATE TABLE TOUR (
    MaTour VARCHAR(20) PRIMARY KEY,
    TenTour NVARCHAR(200) NOT NULL,
    GiaTour DECIMAL(18,2) DEFAULT 0
);

-- 2. Bảng CHUYEN_DI
CREATE TABLE CHUYEN_DI (
    MaChuyen VARCHAR(20) PRIMARY KEY,
    MaTour VARCHAR(20) REFERENCES TOUR(MaTour),
    NgayKhoiHanh DATETIME,
    SoChoConLai INT DEFAULT 40
);

-- 3. Bảng PHIEU_DANG_KY_DOAN
CREATE TABLE PHIEU_DANG_KY_DOAN (
    MaPhieu VARCHAR(20) PRIMARY KEY,
    TenDoan NVARCHAR(150),
    MaTour VARCHAR(20) REFERENCES TOUR(MaTour),
    SoNguoi INT,
    NguoiDaiDien NVARCHAR(100),
    SDTLienHe VARCHAR(15),
    DiaChi NVARCHAR(200),
    TrangThai NVARCHAR(50)
);

-- 4. Bảng VE_KHACH_LE
CREATE TABLE VE_KHACH_LE (
    MaVe VARCHAR(20) PRIMARY KEY,
    MaChuyen VARCHAR(20) REFERENCES CHUYEN_DI(MaChuyen),
    TenKhach NVARCHAR(100),
    SDT VARCHAR(15),
    GiaVe DECIMAL(18,2),
    NgayDat DATETIME DEFAULT GETDATE()
);

-- 5. Bảng NHAN_VIEN
CREATE TABLE NHAN_VIEN (
    MaNV VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100),
    LuongCoBan DECIMAL(18,2) DEFAULT 5000000
);

-- 6. Bảng PHAN_CONG
CREATE TABLE PHAN_CONG (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MaNV VARCHAR(20) REFERENCES NHAN_VIEN(MaNV),
    MaChuyen VARCHAR(20) REFERENCES CHUYEN_DI(MaChuyen),
    PhuCapTour DECIMAL(18,2) DEFAULT 500000,
    NgayBatDau DATETIME,
    NgayKetThuc DATETIME
);

-- 7. Bảng KHAO_SAT
CREATE TABLE KHAO_SAT (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MaChuyen VARCHAR(20) REFERENCES CHUYEN_DI(MaChuyen),
    DiemDanhGia INT,
    YKienKhachHang NVARCHAR(MAX),
    NgayKhaoSat DATETIME DEFAULT GETDATE()
);

-- 8. Bảng DANH_SACH_BAO_HIEM
CREATE TABLE DANH_SACH_BAO_HIEM (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieu VARCHAR(20) REFERENCES PHIEU_DANG_KY_DOAN(MaPhieu),
    HoTen NVARCHAR(100),
    CCCD VARCHAR(20),
    NgaySinh DATETIME
);

-- 9. Bảng TAI_KHOAN (Bổ sung Lab 6 - Phân quyền)
CREATE TABLE TAI_KHOAN (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(100) NOT NULL,
    HoTenNhanVien NVARCHAR(100),
    QuyenHan VARCHAR(20) CHECK (QuyenHan IN ('Admin', 'NhanVien')),
    TrangThai INT DEFAULT 1
);

-- 10. Bảng HOA_DON (Bổ sung Lab 6 - Thanh toán)
CREATE TABLE HOA_DON (
    MaHoaDon VARCHAR(20) PRIMARY KEY,
    LoaiKhach VARCHAR(20) CHECK (LoaiKhach IN ('Doan', 'KhachLe')),
    MaThamChieu VARCHAR(20),
    NgayLapHD DATETIME DEFAULT GETDATE(),
    TongTien DECIMAL(18,2),
    HinhThucThanhToan NVARCHAR(50),
    NguoiThuTien NVARCHAR(100)
);

-- Dữ liệu mẫu khởi tạo
INSERT INTO TOUR VALUES ('T001', N'Tour Đà Lạt 3N2Đ - Khám Phá Thành Phố Sương Mù', 3500000);
INSERT INTO TOUR VALUES ('T002', N'Tour Phú Quốc 4N3Đ - Thiên Đường Biển Đảo', 5800000);

INSERT INTO CHUYEN_DI VALUES ('CD001', 'T001', GETDATE() + 5, 35);
INSERT INTO NHAN_VIEN VALUES ('NV01', N'Nguyễn Văn A', 8000000);

INSERT INTO TAI_KHOAN VALUES ('admin', '123456', N'Nhan Phi Phố (Quản trị viên)', 'Admin', 1);
INSERT INTO TAI_KHOAN VALUES ('nhanvien01', '123456', N'Nguyễn Văn Nhân Viên', 'NhanVien', 1);
INSERT INTO HOA_DON VALUES ('HD001', 'KhachLe', 'VE001', GETDATE(), 3500000, N'Tiền mặt', N'Nhan Phi Phố');
Nhấn Execute (hoặc phím F5). Kiểm tra cửa sổ kết quả bên dưới để đảm bảo hiển thị thông báo Commands completed successfully. và CSDL đã khởi tạo đủ 10 bảng.
2.3 Cấu hình chuỗi kết nối trong Dự án
Mở Solution QuanLyTourDuLich.sln trong Visual Studio 2022.

Mở file App.config nằm ở gốc project QuanLyTourDuLich và cập nhật cấu hình chuỗi kết nối:
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <connectionStrings>
        <add name="QuanLyTourDuLichDB"
             connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTourDuLich;Integrated Security=True;TrustServerCertificate=True"
             providerName="System.Data.SqlClient" />
    </connectionStrings>
    <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
    </startup>
</configuration>
Lưu ý: Thay .\SQLEXPRESS thành tên SQL Server Instance trên máy tính cá nhân của bạn (ví dụ: MSI\SQLEXPRESS, LOCALHOST hoặc .).
