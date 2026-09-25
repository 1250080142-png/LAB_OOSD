# BÀI THỰC HÀNH 2: HỆ THỐNG QUẢN LÝ THƯ VIỆN
### TỪ PHÂN TÍCH YÊU CẦU - UML - CSDL - GIAO DIỆN ĐẾN CODE C# WINFORMS

* **Môn học:** Phân tích và Thiết kế Hướng đối tượng (OOSD)
* **Trường:** Đại học Tài Nguyên Và Môi Trường Thành Phố Hồ Chí Minh
* **Khoa:** Công nghệ Thông tin
* **Sinh viên thực hiện:** Nhan Phi Phố
* **Mã số sinh viên (MSSV):** 1250080142
* **Lớp:** 12_ĐH_CNPM2
* **Công nghệ sử dụng:** C# Windows Forms (.NET Framework 4.7.2), SQL Server (ADO.NET), Visual Studio 2022.

---

## 1. CẤU TRÚC THƯ MỤC BÀI NỘP
```text
LAB2/
├── README.md                      # Tài liệu hướng dẫn cài đặt, sử dụng & báo cáo kiểm thử
├── Báo cáo bài lab 2.docx        # Báo cáo Word chi tiết (Use Case, UML, Class Diagram, Sequence Diagram)
├── QuanLyThuVien.sql              # Script tạo CSDL QuanLyThuVienDB và dữ liệu mẫu
└── WindowsFormsApp1/              # Dự án mã nguồn Visual Studio 2022
    ├── WindowsFormsApp1.sln       # File Solution khởi chạy
    ├── App.config                 # Cấu hình chuỗi kết nối CSDL
    ├── Data/
    │   └── Db.cs                  # Lớp kết nối ADO.NET (OpenConnection, Query, Execute, Scalar)
    ├── Models.cs                  # Lớp đối tượng thực thể & DTO KetQuaXuLy
    ├── Services/                  # Tầng xử lý nghiệp vụ & Transaction
    │   ├── DanhMucService.cs
    │   ├── SachService.cs
    │   ├── DocGiaService.cs
    │   ├── MuonTraService.cs
    │   └── ThongKeService.cs
    └── Forms/                     # Tầng giao diện người dùng
        ├── FrmMain                # Màn hình chính điều hướng
        ├── FrmDanhMuc             # Quản lý Nhân viên, Thể loại, Nhà xuất bản
        ├── FrmSach                # Quản lý đầu sách và tìm kiếm
        ├── FrmDocGia              # Quản lý độc giả, cấp thẻ và gia hạn thẻ
        ├── FrmMuonTra             # Mượn sách, trả sách và xử lý phạt
        └── FrmThongKe             # Thống kê lượt mượn, quá hạn, hư hỏng, tiền phạt
