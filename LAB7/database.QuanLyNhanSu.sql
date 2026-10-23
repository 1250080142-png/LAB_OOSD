CREATE DATABASE QuanLyNhanSuDongA;
GO

USE QuanLyNhanSuDongA;
GO

-- ==========================================
-- 1. DANH MỤC PHÒNG BAN & NHÂN VIÊN
-- ==========================================

CREATE TABLE PhongBan (
    MaPhong VARCHAR(20) PRIMARY KEY,
    TenPhong NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255)
);
GO

CREATE TABLE NhanVien (
    MaNV VARCHAR(20) PRIMARY KEY,
    Ho NVARCHAR(50) NOT NULL,
    Ten NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    DienThoai VARCHAR(20),
    Email VARCHAR(100),
    MaPhong VARCHAR(20),
    FOREIGN KEY (MaPhong) REFERENCES PhongBan(MaPhong)
);
GO

-- ==========================================
-- 2. QUẢN LÝ QUYẾT ĐỊNH & HỢP ĐỒNG
-- ==========================================

CREATE TABLE QuyetDinhTuyenDung (
    SoQuyetDinh VARCHAR(50) PRIMARY KEY,
    MaNV VARCHAR(20),
    MaPhong VARCHAR(20),
    NgayKy DATE,
    ThoiGianThuViec INT, -- Tính theo tháng
    LuongThuViec DECIMAL(18, 2),
    NoiDung NVARCHAR(MAX),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaPhong) REFERENCES PhongBan(MaPhong)
);
GO

CREATE TABLE HopDongLaoDong (
    SoHopDong VARCHAR(50) PRIMARY KEY,
    MaNV VARCHAR(20),
    LoaiHopDong NVARCHAR(50), -- "Dài hạn" hoặc "Ngắn hạn"
    NgayBatDau DATE,
    NgayKetThuc DATE,
    CoBHYT BIT DEFAULT 0,
    CoBHXH BIT DEFAULT 0,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

CREATE TABLE ChucVu (
    MaChucVu VARCHAR(20) PRIMARY KEY,
    TenChucVu NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE QuyetDinhChucVu (
    SoQuyetDinh VARCHAR(50) PRIMARY KEY,
    MaNV VARCHAR(20),
    MaChucVu VARCHAR(20),
    PhuCapChucVu DECIMAL(18, 2) DEFAULT 0,
    NgayKy DATE,
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
);
GO

CREATE TABLE QuyetDinhLuong (
    SoQuyetDinh VARCHAR(50) PRIMARY KEY,
    MaNV VARCHAR(20),
    LuongCoBan DECIMAL(18, 2) NOT NULL,
    PhuCapLuong DECIMAL(18, 2) DEFAULT 0,
    PhuCapDocHai DECIMAL(18, 2) DEFAULT 0, -- Đặc thù ngành sơn
    NgayKy DATE,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- ==========================================
-- 3. KHEN THƯỞNG & KỶ LUẬT
-- ==========================================

CREATE TABLE QuyetDinhKhenThuongKyLuat (
    SoQuyetDinh VARCHAR(50) PRIMARY KEY,
    LoaiQuyetDinh NVARCHAR(50), -- "Khen thưởng" hoặc "Kỷ luật"
    DoiTuongApDung NVARCHAR(50), -- "Cá nhân" hoặc "Tập thể"
    MaNV VARCHAR(20) NULL,
    MaPhong VARCHAR(20) NULL,
    SoTien DECIMAL(18, 2) NOT NULL,
    HinhThucXuLy NVARCHAR(100), -- "Phiếu chi khen thưởng", "Trừ lương", "Phiếu thu nộp phạt"
    NgayKy DATE,
    NoiDungLyDo NVARCHAR(MAX),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaPhong) REFERENCES PhongBan(MaPhong)
);
GO

-- ==========================================
-- 4. CA LÀM VIỆC & PHỤ TRỘI (TĂNG CA)
-- ==========================================

CREATE TABLE CaLamViec (
    MaCa VARCHAR(20) PRIMARY KEY,
    TenCa NVARCHAR(50) NOT NULL,
    GioBatDau TIME,
    GioKetThuc TIME
);
GO

CREATE TABLE PhanCongCa (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    MaNV VARCHAR(20),
    MaCa VARCHAR(20),
    NgayPhanCong DATE,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaCa) REFERENCES CaLamViec(MaCa)
);
GO

CREATE TABLE PhieuPhuTroi (
    SoPhieu VARCHAR(50) PRIMARY KEY,
    NgayPhuTroi DATE,
    HinhThucPhuTroi NVARCHAR(50), -- "Tăng ca", "Ngày lễ", "Ngày nghỉ"
    HeSo FLOAT DEFAULT 1.5
);
GO

CREATE TABLE ChiTietPhuTroi (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    SoPhieu VARCHAR(50),
    MaNV VARCHAR(20),
    SoGioPhuTroi FLOAT,
    FOREIGN KEY (SoPhieu) REFERENCES PhieuPhuTroi(SoPhieu),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- ==========================================
-- 5. CHẤM CÔNG & TÍNH LƯƠNG HÀNG THÁNG
-- ==========================================

CREATE TABLE BangChamCong (
    MaChamCong INT IDENTITY(1,1) PRIMARY KEY,
    Thang INT,
    Nam INT,
    MaNV VARCHAR(20),
    SoNgayCongThucTe FLOAT,
    SoNgayNghi FLOAT,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

CREATE TABLE BangLuong (
    MaBangLuong INT IDENTITY(1,1) PRIMARY KEY,
    Thang INT,
    Nam INT,
    MaNV VARCHAR(20),
    LuongCoBan DECIMAL(18, 2),
    PhuCap DECIMAL(18, 2),
    TienPhuTroi DECIMAL(18, 2),
    TienThuong DECIMAL(18, 2),
    TienPhat DECIMAL(18, 2),
    TruBHXH_BHYT DECIMAL(18, 2),
    ThucLinh DECIMAL(18, 2),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- ==========================================
-- FORM 1: DANH MỤC PHÒNG BAN & CHỨC VỤ
-- ==========================================

-- 1. Bảng PhongBan (6 phòng ban)
INSERT INTO PhongBan (MaPhong, TenPhong, MoTa) VALUES
('PB01', N'Phòng Tài chính Kế toán', N'Quản lý tài chính, quỹ lương và thu chi công ty'),
('PB02', N'Phòng Kỹ thuật', N'Nghiên cứu pha chế và kiểm định chất lượng sơn'),
('PB03', N'Phòng Sản xuất', N'Vận hành dây chuyền sản xuất sơn các loại'),
('PB04', N'Phòng Kinh doanh & Marketing', N'Phát triển thị trường, phân phối sản phẩm'),
('PB05', N'Phòng Hành chính Nhân sự', N'Quản lý nhân sự, tuyển dụng và chế độ phúc lợi'),
('PB06', N'Phân xưởng Đóng gói', N'Đóng lon, thùng và kho vận chuyển hàng');
GO

-- 2. Bảng ChucVu (6 chức vụ)
INSERT INTO ChucVu (MaChucVu, TenChucVu) VALUES
('CV01', N'Giám đốc điều hành'),
('CV02', N'Trưởng phòng'),
('CV03', N'Quản đốc phân xưởng'),
('CV04', N'Kế toán viên'),
('CV05', N'Kỹ thuật viên pha chế'),
('CV06', N'Nhân viên vận hành sản xuất');
GO

-- ==========================================
-- FORM 2: QUẢN LÝ NHÂN SỰ (6 Nhân viên)
-- ==========================================
INSERT INTO NhanVien (MaNV, Ho, Ten, NgaySinh, GioiTinh, DiaChi, DienThoai, Email, MaPhong) VALUES
('NV01', N'Nguyễn Văn', N'An', '1995-03-12', N'Nam', N'Quận 1, TP.HCM', '0901112233', 'an.nv@dongapaint.vn', 'PB01'),
('NV02', N'Trần Thị', N'Bình', '1992-07-25', N'Nữ', N'Quận 3, TP.HCM', '0902223344', 'binh.tt@dongapaint.vn', 'PB02'),
('NV03', N'Lê Văn', N'Cường', '1990-11-05', N'Nam', N'TP. Biên Hòa, Đồng Nai', '0903334455', 'cuong.lv@dongapaint.vn', 'PB03'),
('NV04', N'Phạm Thị', N'Dung', '1996-02-18', N'Nữ', N'Quận 5, TP.HCM', '0904445566', 'dung.pt@dongapaint.vn', 'PB04'),
('NV05', N'Hoàng Văn', N'Em', '1993-09-30', N'Nam', N'TP. Thủ Đức, TP.HCM', '0905556677', 'em.hv@dongapaint.vn', 'PB05'),
('NV06', N'Vũ Thị', N'Giang', '1997-04-14', N'Nữ', N'Quận 12, TP.HCM', '0906667788', 'giang.vt@dongapaint.vn', 'PB06');
GO

-- ==========================================
-- FORM 3: QUYẾT ĐỊNH TUYỂN DỤNG & HỢP ĐỒNG
-- ==========================================

-- 1. Bảng QuyetDinhTuyenDung (6 quyết định)
INSERT INTO QuyetDinhTuyenDung (SoQuyetDinh, MaNV, MaPhong, NgayKy, ThoiGianThuViec, LuongThuViec, NoiDung) VALUES
('QDTD01', 'NV01', 'PB01', '2025-01-02', 2, 8000000, N'Thử việc vị trí Kế toán viên trong 2 tháng'),
('QDTD02', 'NV02', 'PB02', '2025-01-05', 2, 9000000, N'Thử việc vị trí Kỹ thuật viên pha chế sơn'),
('QDTD03', 'NV03', 'PB03', '2025-02-01', 1, 8500000, N'Thử việc vị trí Quản đốc dây chuyền sản xuất'),
('QDTD04', 'NV04', 'PB04', '2025-02-10', 2, 7500000, N'Thử việc vị trí Chuyên viên Kinh doanh'),
('QDTD05', 'NV05', 'PB05', '2025-03-01', 2, 8000000, N'Thử việc vị trí Chuyên viên Hành chính Nhân sự'),
('QDTD06', 'NV06', 'PB06', '2025-03-15', 1, 7000000, N'Thử việc vị trí Nhân viên Đóng gói');
GO

-- 2. Bảng HopDongLaoDong (6 hợp đồng)
INSERT INTO HopDongLaoDong (SoHopDong, MaNV, LoaiHopDong, NgayBatDau, NgayKetThuc, CoBHYT, CoBHXH) VALUES
('HDLD01', 'NV01', N'Dài hạn', '2025-03-02', '2028-03-02', 1, 1),
('HDLD02', 'NV02', N'Dài hạn', '2025-03-05', '2028-03-05', 1, 1),
('HDLD03', 'NV03', N'Dài hạn', '2025-03-01', '2028-03-01', 1, 1),
('HDLD04', 'NV04', N'Ngắn hạn', '2025-04-10', '2025-10-10', 0, 0),
('HDLD05', 'NV05', N'Dài hạn', '2025-05-01', '2028-05-01', 1, 1),
('HDLD06', 'NV06', N'Ngắn hạn', '2025-04-15', '2025-10-15', 0, 0);
GO

-- ==========================================
-- FORM 4: QUYẾT ĐỊNH LƯƠNG & CHỨC VỤ
-- ==========================================

-- 1. Bảng QuyetDinhChucVu (6 quyết định)
INSERT INTO QuyetDinhChucVu (SoQuyetDinh, MaNV, MaChucVu, PhuCapChucVu, NgayKy, GhiChu) VALUES
('QDCV01', 'NV01', 'CV04', 1000000, '2025-03-02', N'Bổ nhiệm Kế toán viên chính'),
('QDCV02', 'NV02', 'CV05', 1500000, '2025-03-05', N'Bổ nhiệm Kỹ thuật viên pha chế sơn'),
('QDCV03', 'NV03', 'CV03', 2000000, '2025-03-01', N'Bổ nhiệm Quản đốc phân xưởng sản xuất'),
('QDCV04', 'NV04', 'CV06', 500000,  '2025-04-10', N'Bổ nhiệm Nhân viên kinh doanh'),
('QDCV05', 'NV05', 'CV02', 2500000, '2025-05-01', N'Bổ nhiệm Trưởng phòng Hành chính Nhân sự'),
('QDCV06', 'NV06', 'CV06', 500000,  '2025-04-15', N'Bổ nhiệm Nhân viên đóng gói kho');
GO

-- 2. Bảng QuyetDinhLuong (6 quyết định)
INSERT INTO QuyetDinhLuong (SoQuyetDinh, MaNV, LuongCoBan, PhuCapLuong, PhuCapDocHai, NgayKy) VALUES
('QDL01', 'NV01', 10000000, 1000000, 0,       '2025-03-02'),
('QDL02', 'NV02', 12000000, 1500000, 1500000, '2025-03-05'), -- Hóa chất pha chế sơn
('QDL03', 'NV03', 14000000, 2000000, 2000000, '2025-03-01'), -- Phân xưởng sản xuất
('QDL04', 'NV04', 9000000,  500000,  0,       '2025-04-10'),
('QDL05', 'NV05', 15000000, 2500000, 0,       '2025-05-01'),
('QDL06', 'NV06', 8000000,  500000,  1000000, '2025-04-15'); -- Tiếp xúc bụi bẩn đóng gói
GO

-- ==========================================
-- FORM 5: CA LÀM VIỆC & PHÂN CÔNG CA
-- ==========================================

-- 1. Bảng CaLamViec (6 ca làm việc)
INSERT INTO CaLamViec (MaCa, TenCa, GioBatDau, GioKetThuc) VALUES
('CA01', N'Ca Sáng', '07:30:00', '11:30:00'),
('CA02', N'Ca Chiều', '13:00:00', '17:00:00'),
('CA03', N'Ca Hành chính', '08:00:00', '17:00:00'),
('CA04', N'Ca Đêm (Sản xuất)', '22:00:00', '06:00:00'),
('CA05', N'Ca Tăng cường 1', '17:30:00', '21:30:00'),
('CA06', N'Ca Tăng cường 2', '06:00:00', '12:00:00');
GO

-- 2. Bảng PhanCongCa (6 phân công)
INSERT INTO PhanCongCa (MaNV, MaCa, NgayPhanCong) VALUES
('NV01', 'CA03', '2025-10-01'),
('NV02', 'CA01', '2025-10-01'),
('NV03', 'CA04', '2025-10-01'),
('NV04', 'CA03', '2025-10-01'),
('NV05', 'CA03', '2025-10-01'),
('NV06', 'CA02', '2025-10-01');
GO

-- ==========================================
-- FORM 6: CHẤM CÔNG & GIỜ PHỤ TRỘI
-- ==========================================

-- 1. Bảng PhieuPhuTroi (6 phiếu)
INSERT INTO PhieuPhuTroi (SoPhieu, NgayPhuTroi, HinhThucPhuTroi, HeSo) VALUES
('PPT01', '2025-10-05', N'Tăng ca', 1.5),
('PPT02', '2025-10-10', N'Ngày lễ', 1.5),
('PPT03', '2025-10-12', N'Ngày nghỉ', 1.5),
('PPT04', '2025-10-15', N'Tăng ca', 1.5),
('PPT05', '2025-10-20', N'Tăng ca', 1.5),
('PPT06', '2025-10-25', N'Ngày nghỉ', 1.5);
GO

-- 2. Bảng ChiTietPhuTroi (6 chi tiết)
INSERT INTO ChiTietPhuTroi (SoPhieu, MaNV, SoGioPhuTroi) VALUES
('PPT01', 'NV02', 4.0),
('PPT02', 'NV03', 8.0),
('PPT03', 'NV06', 6.0),
('PPT04', 'NV01', 3.0),
('PPT05', 'NV03', 4.0),
('PPT06', 'NV02', 5.0);
GO

-- 3. Bảng BangChamCong (6 dòng chấm công tháng 10/2025)
INSERT INTO BangChamCong (Thang, Nam, MaNV, SoNgayCongThucTe, SoNgayNghi) VALUES
(10, 2025, 'NV01', 22.0, 0.0),
(10, 2025, 'NV02', 21.5, 0.5),
(10, 2025, 'NV03', 22.0, 0.0),
(10, 2025, 'NV04', 20.0, 2.0),
(10, 2025, 'NV05', 22.0, 0.0),
(10, 2025, 'NV06', 21.0, 1.0);
GO

-- ==========================================
-- FORM 7: KHEN THƯỞNG & KỶ LUẬT (6 quyết định)
-- ==========================================
INSERT INTO QuyetDinhKhenThuongKyLuat (SoQuyetDinh, LoaiQuyetDinh, DoiTuongApDung, MaNV, MaPhong, SoTien, HinhThucXuLy, NgayKy, NoiDungLyDo) VALUES
('QDKT01', N'Khen thưởng', N'Cá nhân', 'NV02', NULL,   2000000, N'Phiếu chi khen thưởng', '2025-10-15', N'Sáng kiến cải tiến quy trình pha chế sơn'),
('QDKT02', N'Khen thưởng', N'Tập thể', NULL,   'PB03', 5000000, N'Phiếu chi khen thưởng', '2025-10-18', N'Vượt chỉ tiêu sản xuất sơn tháng 9'),
('QDKL01', N'Kỷ luật',    N'Cá nhân', 'NV04', NULL,   500000,  N'Trừ lương',            '2025-10-20', N'Đi muộn quá 3 lần trong tháng'),
('QDKT03', N'Khen thưởng', N'Cá nhân', 'NV03', NULL,   1500000, N'Phiếu chi khen thưởng', '2025-10-22', N'Hoàn thành xuất sắc nhiệm vụ an toàn lao động'),
('QDKL02', N meN'Kỷ luật', N'Cá nhân', 'NV06', NULL,   300000,  N'Phiếu thu nộp phạt',   '2025-10-25', N'Không tuân thủ quy định bảo hộ lao động'),
('QDKT04', N'Khen thưởng', N'Tập thể', NULL,   'PB01', 3000000, N'Phiếu chi khen thưởng', '2025-10-28', N'Hoàn thành quyết toán tài chính đúng hạn');
GO

-- ==========================================
-- FORM 8: BẢNG LƯƠNG TỔNG HỢP (6 dòng cho tháng 10/2025)
-- ==========================================
INSERT INTO BangLuong (Thang, Nam, MaNV, LuongCoBan, PhuCap, TienPhuTroi, TienThuong, TienPhat, TruBHXH_BHYT, ThucLinh) VALUES
(10, 2025, 'NV01', 10000000, 2000000, 300000,  0,       0,      1050000, 11250000),
(10, 2025, 'NV02', 12000000, 3000000, 900000,  2000000, 0,      1260000, 16640000),
(10, 2025, 'NV03', 14000000, 4000000, 1800000, 1500000, 0,      1470000, 19830000),
(10, 2025, 'NV04', 9000000,  1000000, 0,       0,       500000, 0,       9500000),
(10, 2025, 'NV05', 15000000, 5000000, 0,       0,       0,      1575000, 18425000),
(10, 2025, 'NV06', 8000000,  1500000, 600000,  0,       300000, 0,       9800000);
GO