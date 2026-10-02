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
```

---

## 2. HƯỚNG DẪN CÀI ĐẶT & KHỞI CHẠY HỆ THỐNG

### 2.1 Yêu cầu môi trường
1. **Môi trường phát triển:** Microsoft Visual Studio 2022 (cài đặt workload **.NET desktop development**).
2. **Hệ quản trị CSDL:** Microsoft SQL Server (Phiên bản 2016 trở lên hoặc SQL Server Express / LocalDB).
3. **Môi trường thực thi:** .NET Framework 4.7.2.

### 2.2 Các bước cài đặt CSDL SQL Server
1. Mở **SQL Server Management Studio (SSMS)** và kết nối tới SQL Server Instance của bạn.
2. Mở file script SQL tại đường dẫn `LAB3/Database/QuanLyKhachSan.sql`.
3. Thực thi toàn bộ script (`F5` hoặc nhấn **Execute**) để khởi tạo database `QuanLyKhachSan`, các bảng, ràng buộc khóa chính / khóa ngoại và dữ liệu mẫu ban đầu.

### 2.3 Cấu hình chuỗi kết nối (App.config)
1. Mở file `QuanLyKhachSan.sln` bằng Visual Studio 2022.
2. Mở file `App.config` nằm ở thư mục gốc của project `QuanLyKhachSan`.
3. Thay đổi giá trị `connectionString` trong thẻ `<connectionStrings>` sao cho phù hợp với SQL Server trên máy bạn:
   ```xml
   <connectionStrings>
       <add name="QuanLyKhachSanConnectionString" 
            connectionString="Data Source=.;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True" 
            providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
   *Lưu ý:* Thay `Data Source=.` thành tên Server Instance của bạn (ví dụ: `.\SQLEXPRESS` hoặc `LOCALHOST`).

### 2.4 Biên dịch và Khởi chạy
1. Trong Visual Studio 2022, chọn cấu hình `Debug` hoặc `Release` với nền tảng `Any CPU`.
2. Nhấn **Build > Rebuild Solution** để biên dịch lại mã nguồn.
3. Nhấn `F5` hoặc nút **Start** để khởi chạy ứng dụng C# WinForms.

---

## 3. MÔ TẢ CÁC PHÂN HỆ VÀ CHỨC NĂNG CHÍNH

### 3.1 Màn hình chính (`FrmMain`)
* **Chức năng:** Điều hướng truy cập tập trung vào toàn bộ các phân hệ quản lý của ứng dụng.
* **Giao diện:** Bao gồm thanh menu / dashboard dạng thẻ để mở các form chức năng con.

### 3.2 Quản lý Danh mục nền (`FrmDanhMuc`)
* Tích hợp 5 tab quản lý danh mục CRUD cơ bản:
  1. **Danh mục Loại phòng:** Mã loại, tên loại, đơn giá theo giờ/ngày, số người tối đa.
  2. **Danh mục Loại tiện nghi:** Nhóm tiện nghi (điện tử, nội thất, vệ sinh...).
  3. **Danh mục Dịch vụ:** Mã dịch vụ, tên dịch vụ, đơn vị tính, đơn giá.
  4. **Danh mục Loại khách hàng:** Phân loại VIP, Thường, Doanh nghiệp.
  5. **Danh mục Tiện nghi:** Mã tiện nghi, tên tiện nghi, thông số kỹ thuật.

### 3.3 Quản lý Phòng & Lắp đặt Tiện nghi (`FrmPhongTienNghi`)
* **Chức năng:** Thêm/sửa/xóa thông tin phòng ở các tầng.
* **Quản lý Tiện nghi phòng:** Lập phiếu lắp đặt/bàn giao tiện nghi cho từng phòng, cập nhật số lượng và trạng thái tiện nghi.

### 3.4 Phân hệ Đặt phòng & Nhận phòng (`FrmDatPhong`)
* **Quy trình nghiệp vụ:**
  - Tra cứu tình trạng phòng trống theo khoảng thời gian.
  - Tạo phiếu đặt phòng, ghi nhận tiền cọc, ngày nhận phòng (Check-in) và ngày trả phòng (Check-out) dự kiến.
  - Quản lý danh sách người lưu trú đi kèm theo từng phòng.
  - Chuyển trạng thái phiếu đặt từ *Đã đặt* sang *Đã nhận phòng*.

### 3.5 Phân hệ Ghi nhận Dịch vụ phát sinh (`FrmDichVu`)
* Cho phép ghi nhận khách hàng gọi các dịch vụ trong quá trình lưu trú (ăn uống, giặt ủi, spa...).
* Tự động cộng dồn số lượng và cập nhật tổng tiền dịch vụ vào chi tiết phiếu lưu trú của phòng.

### 3.6 Phân hệ Trả phòng, Đền bù & Thanh toán (`FrmTraPhong`)
* **Kiểm tra phòng & Đền bù:** Ghi nhận tiện nghi bị hỏng/mất mát (nếu có) và tính tiền đền bù theo đơn giá quy định.
* **Lập Hóa đơn:** Tự động tính tiền phòng (theo số giờ/ngày ở thực tế), tiền dịch vụ cộng dồn và tiền đền bù tài sản. Trừ đi khoản tiền cọc ban đầu.
* **Thanh toán:** Hỗ trợ ghi nhận thanh toán nhiều lần hoặc thanh toán toàn bộ, cập nhật trạng thái phòng về *Trống/Chờ dọn dẹp*.

### 3.7 Phân hệ Báo cáo & Thống kê (`FrmThongKe`)
* Thống kê tổng doanh thu theo khoảng thời gian (theo ngày, tháng, năm).
* Thống kê tần suất/lượt thuê của từng loại phòng và phòng.
* Thống kê các dịch vụ được sử dụng nhiều nhất.

---

## 4. BẢNG KIỂM THỬ KỊCH BẢN NGHIỆP VỤ (TEST CASE CHECKLIST)

| STT | Phân hệ / Chức năng | Hành động thực hiện | Kết quả kỳ vọng | Trạng thái |
|:---:|:---|:---|:---|:---:|
| 1 | Khởi tạo CSDL | Chạy script `QuanLyKhachSan.sql` | Database tạo thành công với đầy đủ các bảng và dữ liệu mẫu | PASS |
| 2 | Kết nối CSDL | Khởi chạy ứng dụng WinForms | Kết nối CSDL thành công qua `Db.cs`, không bị lỗi chuỗi kết nối | PASS |
| 3 | Quản lý Danh mục | Thêm/Sửa/Xóa 1 Loại phòng mới | Dữ liệu cập nhật chính xác vào CSDL và phản ánh ngay lên DataGridView | PASS |
| 4 | Đặt phòng | Chọn phòng trống và tạo Phiếu đặt phòng mới | CSDL lưu phiếu đặt, chuyển trạng thái phòng thành *Đã đặt* | PASS |
| 5 | Ghi nhận Dịch vụ | Thêm dịch vụ "Nước suối" số lượng 2 cho Phòng 101 | Hệ thống tự cộng dồn tiền dịch vụ vào phòng 101 | PASS |
| 6 | Trả phòng & Đền bù | Chọn phòng trả, thêm 1 mục tiện nghi bị hỏng | Hóa đơn tự tổng hợp: Tiền phòng + Dịch vụ + Đền bù - Tiền cọc | PASS |
| 7 | Thanh toán Hóa đơn | Xác nhận thanh toán hóa đơn | Chuyển trạng thái hóa đơn thành *Đã thanh toán*, phòng trở về *Trống* | PASS |
| 8 | Thống kê Doanh thu | Tra cứu doanh thu theo tháng hiện tại | Hiển thị chính xác tổng số tiền và biểu đồ/bảng số liệu doanh thu | PASS |

---

## 5. TÁC GIẢ & THÔNG TIN LIÊN HỆ
* **Sinh viên:** Nhan Phi Phố
* **Lớp:** 12_ĐH_CNPM2 - Khoa CNTT
* **Trường:** Đại học Tài Nguyên và Môi Trường TP.HCM
* **Email / MSSV:** 1250080142