# BÀI THỰC HÀNH LAB 6: HỆ THỐNG QUẢN LÝ HỒ SƠ BỆNH ÁN
### TỪ PHÂN TÍCH YÊU CẦU - SƠ ĐỒ UML - CSDL SQL SERVER ĐẾN ỨNG DỤNG C# WINFORMS

- **Môn học:** Phân tích và Thiết kế Hướng đối tượng (OOSD)
- **Trường:** Đại học Tài Nguyên và Môi Trường TP.HCM (HCMUNRE)
- **Khoa:** Công nghệ Thông tin
- **Sinh viên thực hiện:** Nhan Phi Phố
- **Mã số sinh viên (MSSV):** 1250080142
- **Lớp:** 12_ĐH_CNPM2
- **Công nghệ sử dụng:** C# Windows Forms (.NET Framework 4.7.2 / 4.8), SQL Server (ADO.NET), Visual Studio 2022, Draw.io.

---

## 1. CẤU TRÚC THƯ MỤC BÀI NỘP LAB 6
```text
LAB_OOSD/
└── LAB6/
    ├── README.md                                # Tài liệu hướng dẫn cài đặt, cấu trúc & kiểm thử
    ├── database.qlhosobenhan.sql                # Script khởi tạo CSDL QuanLyHoSoBenhAn & dữ liệu mẫu
    ├── uc_tong_quat.drawio                      # Sơ đồ Use Case tổng quát hệ thống
    ├── 1250080142_NhanPhiPho_CNPM2...docx       # Báo cáo chi tiết phân tích thiết kế hệ thống
    └── QuanLyHoSoBenhAn/                        # Dự án mã nguồn C# WinForms Visual Studio
        ├── QuanLyHoSoBenhAn.sln                 # Tập tin Solution khởi chạy dự án
        ├── App.config                           # Cấu hình chuỗi kết nối SQL Server
        ├── Database/
        │   └── Db.cs                            # Lớp kết nối & truy vấn CSDL ADO.NET dùng chung
        └── Form/                                # Tầng giao diện người dùng (Forms)
            ├── frmMain.cs                       # Màn hình Trang chủ Dashboard & Thống kê
            ├── frmDangKyVaCapHoSo.cs            # Tiếp nhận, Đăng ký & Cấp Hồ sơ bệnh án
            ├── frmTraCuuHoSo.cs                 # Tra cứu Hồ sơ bệnh án & Lịch sử khám bệnh
            ├── frmKhamBenhVaKeToa.cs            # Khám bệnh, Chẩn đoán & Kê đơn thuốc
            ├── frmDatLichKhamDinhKy.cs          # Đặt lịch khám định kỳ & Tái khám
            └── frmThanhToanVienPhi.cs           # Thanh toán viện phí & Xuất hóa đơn
