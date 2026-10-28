create database QuanLyCuaHangNuocGiaiKhat
go

use QuanLyCuaHangNuocGiaiKhat
go

-- 1. Bảng Nhà Cung Ứng
CREATE TABLE NHA_CUNG_UNG (
    MaNCC VARCHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(15)
);

-- 2. Bảng Nhãn Hiệu (Loại Nước Giải Khát)
CREATE TABLE NHAN_HIEU (
    MaLoai VARCHAR(10) PRIMARY KEY,
    TenLoai NVARCHAR(100) NOT NULL,
    MaNCC VARCHAR(10) FOREIGN KEY REFERENCES NHA_CUNG_UNG(MaNCC)
);

-- 3. Bảng Nước Giải Khát
CREATE TABLE NUOC_GIAI_KHAT (
    MaNGK VARCHAR(10) PRIMARY KEY,
    TenNGK NVARCHAR(100) NOT NULL,
    DonViTinh NVARCHAR(20),
    SoLuongTon INT CHECK (SoLuongTon >= 0),
    DonGiaBan DECIMAL(18,2),
    MaLoai VARCHAR(10) FOREIGN KEY REFERENCES NHAN_HIEU(MaLoai)
);

-- 4. Bảng Nhân Viên
CREATE TABLE NHAN_VIEN (
    MaNV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    SoDienThoai VARCHAR(15)
);

-- 5. Bảng Khách Hàng (Phân biệt Khách quen và Khách vãng lai)
CREATE TABLE KHACH_HANG (
    MaKH VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(15),
    LoaiKH NVARCHAR(20) CHECK (LoaiKH IN (N'Khách quen', N'Khách vãng lai'))
);

-- 6. Bảng Đơn Đặt Hàng
CREATE TABLE DON_DAT_HANG (
    SoDDH VARCHAR(10) PRIMARY KEY,
    NgayDatHang DATETIME,
    NgayNhanHang DATETIME,
    MaNCC VARCHAR(10) FOREIGN KEY REFERENCES NHA_CUNG_UNG(MaNCC),
    MaNV VARCHAR(10) FOREIGN KEY REFERENCES NHAN_VIEN(MaNV)
);

-- 7. Bảng Chi Tiết Đơn Đặt Hàng
CREATE TABLE CHI_TIET_DON_DAT_HANG (
    SoDDH VARCHAR(10) FOREIGN KEY REFERENCES DON_DAT_HANG(SoDDH),
    MaNGK VARCHAR(10) FOREIGN KEY REFERENCES NUOC_GIAI_KHAT(MaNGK),
    SoLuongDat INT CHECK (SoLuongDat > 0),
    PRIMARY KEY (SoDDH, MaNGK)
);

-- 8. Bảng Phiếu Giao Hàng (Hỗ trợ quản lý tối đa 3 đợt giao)
CREATE TABLE PHIEU_GIAO_HANG (
    SoPhieuGiao VARCHAR(10) PRIMARY KEY,
    DotGiao INT CHECK (DotGiao IN (1, 2, 3)),
    NgayGiao DATETIME,
    SoTienPhaiTra DECIMAL(18,2),
    SoDDH VARCHAR(10) FOREIGN KEY REFERENCES DON_DAT_HANG(SoDDH),
    MaNV VARCHAR(10) FOREIGN KEY REFERENCES NHAN_VIEN(MaNV)
);

-- 9. Bảng Chi Tiết Phiếu Giao Hàng
CREATE TABLE CHI_TIET_PHIEU_GIAO_HANG (
    SoPhieuGiao VARCHAR(10) FOREIGN KEY REFERENCES PHIEU_GIAO_HANG(SoPhieuGiao),
    MaNGK VARCHAR(10) FOREIGN KEY REFERENCES NUOC_GIAI_KHAT(MaNGK),
    SoLuongGiao INT CHECK (SoLuongGiao >= 0),
    DonGia DECIMAL(18,2),
    PRIMARY KEY (SoPhieuGiao, MaNGK)
);

-- 10. Bảng Hóa Đơn Bán Hàng
CREATE TABLE HOA_DON (
    SoHoaDon VARCHAR(10) PRIMARY KEY,
    NgayLap DATETIME,
    TongTien DECIMAL(18,2),
    TrangThaiGiao NVARCHAR(30),
    MaKH VARCHAR(10) FOREIGN KEY REFERENCES KHACH_HANG(MaKH),
    MaNV VARCHAR(10) FOREIGN KEY REFERENCES NHAN_VIEN(MaNV)
);

-- 11. Bảng Chi Tiết Hóa Đơn
CREATE TABLE CHI_TIET_HOA_DON (
    SoHoaDon VARCHAR(10) FOREIGN KEY REFERENCES HOA_DON(SoHoaDon),
    MaNGK VARCHAR(10) FOREIGN KEY REFERENCES NUOC_GIAI_KHAT(MaNGK),
    SoLuong INT CHECK (SoLuong > 0),
    SoLuongDaGiao INT DEFAULT 0,
    DonGia DECIMAL(18,2),
    PRIMARY KEY (SoHoaDon, MaNGK)
);

-- 12. Bảng Phiếu Hẹn Giao (Dành cho Khách quen khi thiếu kho)
CREATE TABLE PHIEU_HEN_GIAO (
    MaPhieuHen VARCHAR(10) PRIMARY KEY,
    NgayLap DATETIME,
    NgayHenGiao DATETIME,
    TrangThai NVARCHAR(30),
    NgayGiaoThucTe DATETIME,
    SoHoaDon VARCHAR(10) FOREIGN KEY REFERENCES HOA_DON(SoHoaDon)
);

-- 13. Bảng Chi Tiết Phiếu Hẹn Giao
CREATE TABLE CHI_TIET_PHIEU_HEN_GIAO (
    MaPhieuHen VARCHAR(10) FOREIGN KEY REFERENCES PHIEU_HEN_GIAO(MaPhieuHen),
    SoHoaDon VARCHAR(10),
    MaNGK VARCHAR(10),
    SoLuongHen INT CHECK (SoLuongHen > 0),
    FOREIGN KEY (SoHoaDon, MaNGK) REFERENCES CHI_TIET_HOA_DON(SoHoaDon, MaNGK),
    PRIMARY KEY (MaPhieuHen, SoHoaDon, MaNGK)
);

-- 14. Bảng Phiếu Ghi Nợ (Dành cho Khách quen mua trả chậm)
CREATE TABLE PHIEU_GHI_NO (
    MaPhieuNo VARCHAR(10) PRIMARY KEY,
    NgayLap DATETIME,
    SoTienNo DECIMAL(18,2) CHECK (SoTienNo >= 0),
    NgayDuKienTra DATETIME,
    LyDoNo NVARCHAR(255),
    SoHoaDon VARCHAR(10) FOREIGN KEY REFERENCES HOA_DON(SoHoaDon),
    MaKH VARCHAR(10) FOREIGN KEY REFERENCES KHACH_HANG(MaKH),
    MaNV VARCHAR(10) FOREIGN KEY REFERENCES NHAN_VIEN(MaNV)
);