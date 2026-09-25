# BÀI THỰC HÀNH 1: PHÂN TÍCH YÊU CẦU & MÔ HÌNH HÓA USE CASE HỆ THỐNG THƯ VIỆN TRỰC TUYẾN

* **Trường:** Đại học Tài Nguyên Và Môi Trường Thành Phố Hồ Chí Minh
* **Khoa:** Công nghệ Thông tin
* **Sinh viên thực hiện:** Nhan Phi Phố
* **Mã số sinh viên (MSSV):** 1250080142
* **Lớp:** 12_ĐH_CNPM2

---

## 1. PHÂN TÍCH YÊU CẦU

### 1.1. Yêu cầu chức năng của hệ thống
1. **Tìm kiếm tài liệu:** Hỗ trợ tìm kiếm theo nhiều tiêu chí (tựa sách, tác giả, năm xuất bản, từ khóa).
2. **Đăng ký & Đăng nhập/Đăng xuất:** Quản lý xác thực độc giả và phân quyền thủ thư.
3. **Đọc/Tải tài liệu điện tử:** Đọc trực tuyến hoặc tải e-book về máy sau khi xác thực mã thẻ.
4. **Đăng ký mượn sách giấy:** Cho phép độc giả đăng ký mượn trước sách vật lý còn tồn kho.
5. **Yêu cầu đặt mua tài liệu:** Cho phép độc giả đề xuất thư viện mua bổ sung sách mới.
6. **Quản lý mượn - trả sách:** Thủ thư cập nhật giao sách, nhận trả sách và ghi nhận quá hạn.
7. **Quản lý danh mục sách:** Thủ thư thêm mới, sửa, xóa, ngừng cung cấp tài liệu.
8. **Quản lý yêu cầu mua:** Thủ thư phê duyệt hoặc từ chối các đề xuất mua sách của độc giả.
9. **Tự động gửi email thông báo:** Hệ thống tự động quét và gửi mail nhắc nhở trước hạn trả sách 3 ngày.

### 1.2. Bảng thuật ngữ của hệ thống
| Thuật ngữ | Ý nghĩa / Định nghĩa |
| :--- | :--- |
| **Độc giả** | Bao gồm giảng viên, cán bộ nhân viên và sinh viên trường có nhu cầu tra cứu, mượn sách. |
| **Thủ thư** | Nhân viên thư viện chịu trách nhiệm quản lý kho sách, xét duyệt và xử lý nghiệp vụ mượn - trả. |
| **Thẻ thư viện** | Thẻ định danh duy nhất cấp cho độc giả để sử dụng các dịch vụ thư viện. |
| **Yêu cầu đặt mua** | Đề xuất mua tài liệu mới do độc giả gửi lên hệ thống chờ thủ thư xem xét phê duyệt. |

---

## 2. MÔ HÌNH HÓA USE CASE (USE CASE MODEL)

### 2.1. Xác định Actor (Tác nhân)
* **Độc giả:** Sinh viên, giảng viên, nhân viên sở hữu thẻ thư viện.
* **Thủ thư:** Nhân viên quản lý thư viện (kế thừa các quyền tìm kiếm, đọc, tải của Độc giả).
* **Hệ thống Email tự động:** Tác nhân ngoài (hệ thống nền) kích hoạt gửi email định kỳ.

### 2.2. Danh sách Use Case
* **Phân hệ Độc giả:**
  * `UC01`: Đăng ký tài khoản
  * `UC02`: Đăng nhập hệ thống
  * `UC03`: Tìm kiếm tài liệu
  * `UC04`: Đọc sách điện tử
  * `UC05`: Tải sách điện tử
  * `UC06`: Đăng ký mượn sách thư viện
  * `UC07`: Yêu cầu đặt mua tài liệu mới
* **Phân hệ Thủ thư:**
  * `UC08`: Quản lý thông tin mượn - trả sách
  * `UC09`: Xem tình trạng tài liệu đang mượn / quá hạn
  * `UC10`: Cập nhật danh mục sách
  * `UC11`: Chấp nhận / từ chối các yêu cầu đặt mua
* **Hệ thống tự động:**
  * `UC12`: Tự động gửi email thông báo nhắc hẹn trả sách trước 3 ngày

---

## 3. SƠ ĐỒ USE CASE TỔNG QUÁT

```mermaid
flowchart LR
    subgraph System["Hệ thống Thư viện trực tuyến"]
        UC01((Đăng ký tài khoản))
        UC02((Đăng nhập hệ thống))
        UC03((Tìm kiếm tài liệu))
        UC04((Đọc sách điện tử))
        UC05((Tải sách điện tử))
        UC06((Đăng ký mượn sách))
        UC07((Yêu cầu đặt sách))
        UC08((Quản lý mượn-trả))
        UC09((Xem tình trạng mượn/ quá hạn))
        UC10((Cập nhật danh mục))
        UC11((Chấp nhận/ Từ chối mua))
        UC12((Gửi email nhắc hạn))
    end

    DocGia[Độc giả] --> UC01
    DocGia --> UC02
    DocGia --> UC03
    DocGia --> UC04
    DocGia --> UC05
    DocGia --> UC06
    DocGia --> UC07

    ThuThu[Thủ thư] -. Kế thừa .-> DocGia
    ThuThu --> UC08
    ThuThu --> UC09
    ThuThu --> UC10
    ThuThu --> UC11

    EmailSys[Hệ thống Email] --> UC12
