# BÀI THỰC HÀNH 5: HỆ THỐNG QUẢN LÝ TOUR DU LỊCH (VĂN HÓA VIỆT TP.HCM)
### TỪ PHÂN TÍCH YÊU CẦU - UML - CSDL - GIAO DIỆN ĐẾN CODE C# WINFORMS

- **Môn học:** Phân tích và Thiết kế Hướng đối tượng (OOSD)
- **Trường:** Đại học Tài Nguyên và Môi Trường TP.HCM 
- **Khoa:** Công nghệ Thông tin
- **Sinh viên thực hiện:** Nhan Phi Phố
- **Mã số sinh viên (MSSV):** 1250080142
- **Lớp:** 12_ĐH_CNPM2
- **Công nghệ sử dụng:** C# Windows Forms (.NET Framework 4.8), SQL Server (ADO.NET), Visual Studio 2022.

---

## 1. CẤU TRÚC THƯ MỤC BÀI NỘP
```text
LAB5/
├── README.md                          # Tài liệu hướng dẫn cài đặt, sử dụng & kiểm thử Lab 5
├── Database/
│   └── QuanLyTourDuLich.sql           # Script SQL tạo CSDL QuanLyTourDuLich và dữ liệu mẫu
└── QuanLyTourDuLich/                  # Dự án mã nguồn Visual Studio 2022
    ├── QuanLyTourDuLich.sln           # File Solution khởi chạy dự án
    ├── App.config                     # Cấu hình chuỗi kết nối SQL Server
    ├── Database/
    │   └── Db.cs                      # Lớp truy vấn dữ liệu SQL Server (ExecuteQuery, ExecuteNonQuery)
    ├── Frm/                           # Tầng giao diện người dùng (Code-behind & Designer)
    │   ├── FrmMain.cs                 # Màn hình chính Dashboard điều hướng hệ thống
    │   ├── FrmTourManager.cs          # Quản lý danh mục Tour du lịch
    │   ├── FrmChuyenDiMangager.cs     # Quản lý chuyến đi & mở lịch khởi hành
    │   ├── FrmDangKyDoan.cs           # Đăng ký Tour cho đoàn khách đông người
    │   ├── FrmBanVeKhachLe.cs         # Bán vé & đặt chỗ cho khách lẻ
    │   ├── FrmPhanCongVaLuong.cs      # Phân công HDV (kiểm tra trùng lịch) & Tính lương
    │   ├── FrmKhaoSatBaoCao.cs        # Khảo sát chất lượng & Báo cáo doanh thu
    │   └── FrmDanhSachBaoHiem.cs      # Quản lý danh sách bảo hiểm du lịch
    └── Program.cs                     # Điểm khởi chạy ứng dụng (Application.Run)
```

---

## 2. HƯỚNG DẪN CÀI ĐẶT & KHỞI CHẠY HỆ THỐNG CHI TIẾT (TỪ A ĐẾN Z)

### 2.1 Yêu cầu môi trường & Phần mềm
1. **Môi trường phát triển:** Microsoft Visual Studio 2022 (cài đặt workload **.NET desktop development**).
2. **Hệ quản trị CSDL:** Microsoft SQL Server (Phiên bản 2016 trở lên, SQL Server Express, hoặc LocalDB).
3. **Công cụ quản lý CSDL:** SQL Server Management Studio (SSMS) hoặc Azure Data Studio.
4. **Môi trường thực thi:** .NET Framework 4.8 Runtime.

---

### 2.2 Các bước cài đặt CSDL SQL Server

1. **Khởi động phần mềm quản lý CSDL:**
   - Mở **SQL Server Management Studio (SSMS)**.
   - Nhập **Server name** tương ứng trên máy tính của bạn (Ví dụ: `.\SQLEXPRESS`, `LOCALHOST` hoặc `MSI\SQLEXPRESS`).
   - Chọn phương thức xác thực **Windows Authentication** và nhấn **Connect**.

2. **Thực thi Script khởi tạo CSDL:**
   - Nhấn **Ctrl + O** (hoặc vào menu `File > Open > File...`) và chọn tập tin `LAB5/Database/QuanLyTourDuLich.sql`.
   - Hoặc tạo một cửa sổ truy vấn mới (**New Query**) và thực thi đoạn script SQL sau:

```sql
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

-- Dữ liệu mẫu khởi tạo
INSERT INTO TOUR VALUES ('T001', N'Tour Đà Lạt 3N2Đ - Khám Phá Thành Phố Sương Mù', 3500000);
INSERT INTO TOUR VALUES ('T002', N'Tour Phú Quốc 4N3Đ - Thiên Đường Biển Đảo', 5800000);

INSERT INTO CHUYEN_DI VALUES ('CD001', 'T001', GETDATE() + 5, 35);
INSERT INTO NHAN_VIEN VALUES ('NV01', N'Nguyễn Văn A', 8000000);
```

3. Nhấn **Execute** (hoặc phím `F5`). Kiểm tra cửa sổ kết quả bên dưới để đảm bảo hiển thị thông báo `Commands completed successfully.` và CSDL `QuanLyTourDuLich` đã khởi tạo đủ 8 bảng.

---

### 2.3 Cấu hình chuỗi kết nối trong Dự án

1. Mở Solution `QuanLyTourDuLich.sln` trong Visual Studio 2022.
2. Mở file **`App.config`** nằm ở gốc project `QuanLyTourDuLich` và cập nhật cấu hình chuỗi kết nối:
   ```xml
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
   ```
   *Lưu ý:* Thay `.\SQLEXPRESS` thành tên SQL Server Instance trên máy tính cá nhân của bạn (ví dụ: `MSI\SQLEXPRESS`, `LOCALHOST` hoặc `.`).

3. Mở tập tin **`Database/Db.cs`** để kiểm tra lớp dùng chung kết nối ADO.NET:
   ```csharp
   using System.Configuration;
   using System.Data;
   using System.Data.SqlClient;

   namespace QuanLyTourDuLich.Database
   {
       public static class Db
       {
           public static string connectionString = ConfigurationManager.ConnectionStrings["QuanLyTourDuLichDB"]?.ConnectionString 
               ?? @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTourDuLich;Integrated Security=True;TrustServerCertificate=True";

           public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
           {
               using (SqlConnection conn = new SqlConnection(connectionString))
               {
                   using (SqlCommand cmd = new SqlCommand(query, conn))
                   {
                       if (parameters != null) cmd.Parameters.AddRange(parameters);
                       using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                       {
                           DataTable dt = new DataTable();
                           adapter.Fill(dt);
                           return dt;
                       }
                   }
               }
           }

           public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
           {
               using (SqlConnection conn = new SqlConnection(connectionString))
               {
                   conn.Open();
                   using (SqlCommand cmd = new SqlCommand(query, conn))
                   {
                       if (parameters != null) cmd.Parameters.AddRange(parameters);
                       return cmd.ExecuteNonQuery();
                   }
               }
           }
       }
   }
   ```

---

### 2.4 Biên dịch và Khởi chạy Ứng dụng

1. Trên thanh công cụ Visual Studio, chọn cấu hình biên dịch `Debug` với nền tảng `Any CPU`.
2. Nhấn tổ hợp phím **`Ctrl + Shift + B`** (hoặc chọn menu **Build > Rebuild Solution**) để biên dịch lại toàn bộ dự án.
3. Kiểm tra cửa sổ Output đảm bảo kết quả báo: **`Rebuild All: 1 succeeded, 0 failed, 0 skipped`**.
4. Nhấn phím **`F5`** (hoặc nút **Start** màu xanh) để khởi chạy ứng dụng C# WinForms.

---

## 3. MÔ TẢ CÁC PHÂN HỆ VÀ CHỨC NĂNG CHÍNH

### 3.1 Màn hình chính Dashboard (`FrmMain`)
- **Giao diện:** Thiết kế theo chuẩn Dashboard thương hiệu màu xanh Navy `#1B365D` của Công ty Du lịch Văn Hóa Việt TP.HCM.
- **Chức năng:** Thanh điều hướng Top-Nav tích hợp chuyển đổi mượt mà giữa các phân hệ con lồng trực tiếp vào `Panel` hiển thị trung tâm (`pnlContent`).

### 3.2 Quản lý Danh mục Tour (`FrmTourManager`)
- Thêm/sửa/xóa và tra cứu danh mục các Tour du lịch do công ty phát hành.
- Quản lý mã Tour, tên chương trình du lịch, đơn giá tour chuẩn cho từng hành trình.

### 3.3 Quản lý Chuyến đi & Mở lịch khởi hành (`FrmChuyenDiMangager`)
- Lập lịch chuyến đi thực tế cho từng Tour theo ngày khởi hành cụ thể.
- Quản lý số chỗ còn lại, tự động khởi tạo tải trọng chỗ ngồi cho mỗi chuyến đi.

### 3.4 Đăng ký Tour theo Đoàn (`FrmDangKyDoan`)
- Tiếp nhận yêu cầu đăng ký Tour du lịch từ các cơ quan, doanh nghiệp, trường học.
- Ghi nhận thông tin người đại diện, số lượng thành viên đoàn, thông tin liên hệ và trạng thái phiếu đăng ký.

### 3.5 Bán vé & Đặt chỗ Khách lẻ (`FrmBanVeKhachLe`)
- Phục vụ đăng ký lẻ cho du khách tự do.
- Tự động sinh mã vé (`VE` + thời gian), lưu trữ họ tên, số điện thoại, giá vé và ngày đặt.

### 3.6 Phân công Hướng dẫn viên & Tính lương (`FrmPhanCongVaLuong`)
- **Kiểm tra trùng lịch:** Tự động đối soát khoảng thời gian công tác của Hướng dẫn viên để ngăn chặn tình trạng phân công 1 HDV đi 2 tour trùng thời gian.
- **Tính lương tháng:** Thống kê tổng phụ cấp tour cộng dồn cùng lương cơ bản của nhân viên theo từng tháng/năm.

### 3.7 Khảo sát chất lượng & Báo cáo doanh thu (`FrmKhaoSatBaoCao`)
- Thu thập đánh giá điểm số (1 - 5 sao) và ý kiến đóng góp của du khách sau chuyến đi.
- Tổng hợp báo cáo doanh thu công ty thu được từ các chuyến đi trong kỳ.

### 3.8 Quản lý Danh sách Bảo hiểm Du lịch (`FrmDanhSachBaoHiem`)
- Nhập danh sách trích ngang thành viên tham gia tour (Họ tên, CCCD/CMND, Ngày sinh).
- Lưu trữ dữ liệu sẵn sàng phục vụ mua hợp đồng bảo hiểm du lịch bắt buộc cho đoàn.

---

## 4. BẢNG KIỂM THỬ KỊCH BẢN NGHIỆP VỤ (TEST CASE CHECKLIST)

| STT | Phân hệ / Chức năng | Hành động thực hiện | Kết quả kỳ vọng | Trạng thái |
|:---:|:---|:---|:---|:---:|
| 1 | Khởi tạo CSDL | Chạy script SQL `QuanLyTourDuLich.sql` | Database tạo thành công với 8 bảng và dữ liệu mẫu | PASS |
| 2 | Kết nối CSDL | Khởi chạy ứng dụng WinForms | Kết nối CSDL thành công qua `Db.cs`, hiển thị dữ liệu lên DataGridView | PASS |
| 3 | Quản lý Tour | Thêm 1 Tour mới "Tour Nha Trang 3N2Đ" | Dữ liệu cập nhật chính xác vào CSDL và hiển thị trên bảng | PASS |
| 4 | Mở Chuyến đi | Tạo chuyến đi mới cho Tour T001 ngày khởi hành sắp tới | CSDL lưu thông tin chuyến đi, chỗ còn lại mặc định là 40 | PASS |
| 5 | Đăng ký Đoàn | Tạo phiếu đăng ký tour cho Công ty X (30 người) | Lưu thông tin phiếu đăng ký đoàn thành công | PASS |
| 6 | Bán vé Khách lẻ | Xuất vé cho khách lẻ Nguyễn Văn B đi chuyến CD001 | Hệ thống tự động sinh mã vé và ghi nhận thông tin bán vé | PASS |
| 7 | Phân công HDV | Phân công HDV trùng lịch thời gian đã có tour | Hệ thống cảnh báo lỗi trùng lịch và ngăn chặn lưu dữ liệu | PASS |
| 8 | Thống kê Lương | Tra cứu bảng lương tháng 10/2026 | Hiển thị chính xác Tổng lương = Lương cơ bản + Tổng phụ cấp tour | PASS |

---

## 5. TÁC GIẢ & THÔNG TIN LIÊN HỆ
- **Sinh viên:** Nhan Phi Phố
- **Mã số sinh viên (MSSV):** 1250080142
- **Lớp:** 12_ĐH_CNPM2 - Khoa Công nghệ Thông tin
- **Trường:** Đại học Tài Nguyên và Môi Trường TP.HCM
- **Môn học:** Phân tích và Thiết kế Hướng đối tượng (OOSD)