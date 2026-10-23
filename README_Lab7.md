# BÀI THỰC HÀNH 7: HỆ THỐNG QUẢN LÝ NHÂN SỰ (CÔNG TY SƠN ĐÔNG Á)

### TỪ PHÂN TÍCH YÊU CẦU - MÔ HÌNH HÓA UML ĐẾN THIẾT KẾ HƯỚNG ĐỐI TƯỢNG

- **Môn học:** Phân tích và Thiết kế Hướng đối tượng (OOSD)
- **Trường:** Đại học Công nghệ TP.HCM (HUTECH)
- **Khoa:** Công nghệ Thông tin
- **Sinh viên thực hiện:** Nhan Phi Phố
- **Mã số sinh viên (MSSV):** 1250080142
- **Lớp:** 12_ĐH_CNPM2
- **Công cụ sử dụng:** StarUML, Microsoft Word.

---

## 1. CẤU TRÚC THƯ MỤC BÀI NỘP

```text
LAB7/
├── README.md
├── TaiLieu/
│   └── Bai_7_Quan_ly_nhan_su.docx
└── UML/
    ├── ClassDiagram.mdj
    ├── UseCaseTongQuat.mdj
    ├── UseCaseThuViecDenChinhThuc.mdj
    ├── ActivityThuViecDenChinhThuc.mdj
    └── SequenceLapQuyetDinhKhenThuong.mdj
```

**Mô tả các tập tin và thư mục:**

- `README.md`: Tài liệu giới thiệu đề tài, hướng dẫn thực hiện và checklist kiểm tra bài nộp Lab 7.
- `TaiLieu/Bai_7_Quan_ly_nhan_su.docx`: Đề bài Word mô tả nghiệp vụ quản lý nhân sự và sáu câu hỏi cần thực hiện.
- `UML/ClassDiagram.mdj`: Mô hình lớp, thuộc tính, phương thức, ID và mối liên kết giữa các lớp.
- `UML/UseCaseTongQuat.mdj`: Use Case Diagram tổng quát của hệ thống quản lý nhân sự.
- `UML/UseCaseThuViecDenChinhThuc.mdj`: Use Case Diagram phân rã quy trình từ tiếp nhận nhân viên thử việc đến ký hợp đồng chính thức.
- `UML/ActivityThuViecDenChinhThuc.mdj`: Activity Diagram mô tả luồng hoạt động của quy trình thử việc đến ký hợp đồng chính thức.
- `UML/SequenceLapQuyetDinhKhenThuong.mdj`: Sequence Diagram mô tả nghiệp vụ lập quyết định khen thưởng.

*Lưu ý: Cấu trúc trên là cấu trúc đề xuất để sắp xếp bài nộp. Các tệp mô hình cần được tạo và lưu bằng StarUML; không phải tất cả tệp đã được tạo sẵn.*

---

## 2. HƯỚNG DẪN CHUẨN BỊ VÀ THỰC HIỆN BÀI THỰC HÀNH

### 2.1 Yêu cầu môi trường và phần mềm

1. **Công cụ mô hình hóa UML:** StarUML.
2. **Tài liệu đề bài:** Microsoft Word hoặc phần mềm đọc tệp `.docx`.
3. **Công cụ soạn thảo báo cáo:** Microsoft Word.
4. **Định dạng tệp mô hình:** Lưu project StarUML với phần mở rộng `.mdj`.
5. **Định dạng hình ảnh sơ đồ:** Có thể xuất sơ đồ thành ảnh để chèn vào tài liệu Word hoặc nộp kèm khi được yêu cầu.

### 2.2 Tạo project và lưu mô hình trong StarUML

1. Mở StarUML trên máy tính.
2. Tạo một project mới cho đề tài **Quản lý nhân sự**.
3. Tạo các sơ đồ theo yêu cầu của đề bài:
   - Class Diagram.
   - Use Case Diagram tổng quát.
   - Use Case Diagram phân rã quy trình thử việc đến hợp đồng chính thức.
   - Activity Diagram cho quy trình trên.
   - Sequence Diagram cho nghiệp vụ lập quyết định khen thưởng.
4. Đặt tên từng sơ đồ rõ ràng, tương ứng với câu hỏi trong đề.
5. Bổ sung các lớp, thuộc tính, phương thức, Actor, Use Case, quan hệ, luồng hoạt động và thông điệp theo đúng loại sơ đồ.
6. Kiểm tra lại tên gọi, ký hiệu UML, bội số quan hệ và trình tự nghiệp vụ.
7. Lưu project bằng chức năng **File > Save** hoặc **Save As**, trong thư mục `UML/`.
8. Nếu giảng viên yêu cầu hình ảnh, xuất từng sơ đồ và chèn vào phần bài làm tương ứng trong file Word.

### 2.3 Hướng dẫn cài đặt StarUML

1. Mở trình duyệt web và truy cập trang chủ StarUML: https://staruml.io/.
2. Chọn mục tải xuống (**Download**) và tải phiên bản phù hợp với hệ điều hành đang sử dụng.
3. Mở tệp cài đặt vừa tải về.
4. Thực hiện các bước cài đặt theo hướng dẫn hiển thị trên màn hình.
5. Sau khi cài đặt hoàn tất, mở StarUML từ màn hình Desktop hoặc menu Start.
6. Nếu phần mềm yêu cầu giấy phép hoặc đăng nhập, thực hiện theo hướng dẫn của nhà cung cấp. Có thể kiểm tra chính sách dùng thử/giấy phép hiện hành trên trang chủ StarUML.

*Lưu ý:* Các bước và giao diện có thể thay đổi tùy phiên bản StarUML. README này không cung cấp bộ cài đặt kèm theo.

### 2.4 Hướng dẫn tạo và lưu project

1. Khởi động StarUML.
2. Chọn **File > New** để tạo project mới.
3. Trong Model Explorer, nhấp phải vào Model hoặc package phù hợp để thêm sơ đồ.
4. Chọn loại sơ đồ cần tạo, chẳng hạn **Add Diagram > Class Diagram**, **Use Case Diagram**, **Activity Diagram** hoặc **Sequence Diagram**.
5. Đổi tên sơ đồ theo nội dung câu hỏi để dễ quản lý.
6. Chọn **File > Save** hoặc **File > Save As** để lưu project với phần mở rộng `.mdj` trong thư mục `UML/`.
7. Trong quá trình làm bài, thường xuyên nhấn **Ctrl + S** để lưu thay đổi.

### 2.5 Hướng dẫn sử dụng StarUML cho bài Lab 7

**A. Vẽ Class Diagram**

1. Tạo một Class Diagram.
2. Chọn công cụ **Class** trên thanh công cụ và nhấp vào vùng vẽ để tạo lớp.
3. Đặt tên lớp; thêm thuộc tính và phương thức trong phần thuộc tính của lớp hoặc bảng Specification.
4. Xác định thuộc tính định danh (ID) cho mỗi lớp theo yêu cầu Câu 1.
5. Dùng các công cụ quan hệ như Association, Generalization, Aggregation hoặc Composition khi phù hợp với mô hình nghiệp vụ.
6. Ghi bội số quan hệ ở hai đầu đường liên kết khi cần, sau đó sắp xếp các lớp để sơ đồ dễ đọc.

**B. Vẽ Use Case Diagram tổng quát**

1. Tạo Use Case Diagram.
2. Thêm Actor đại diện cho vai trò tương tác với hệ thống.
3. Thêm các Use Case tương ứng với nghiệp vụ quản lý nhân sự được nêu trong đề.
4. Vẽ ranh giới hệ thống bằng Subject/System Boundary nếu cần.
5. Nối Actor với Use Case bằng Association; chỉ dùng `<<include>>` hoặc `<<extend>>` khi quan hệ đó thực sự phù hợp.

**C. Vẽ Use Case Diagram phân rã quy trình thử việc**

1. Tạo một Use Case Diagram riêng.
2. Tập trung vào quy trình từ khi nhân viên được nhận vào thử việc đến khi ký hợp đồng chính thức.
3. Bổ sung Actor, Use Case và quan hệ cần thiết để làm rõ các bước của quy trình.
4. Kiểm tra sự nhất quán với sơ đồ Use Case tổng quát.

**D. Vẽ Activity Diagram**

1. Tạo Activity Diagram cho quy trình ở Câu 4.
2. Bố trí Initial Node ở đầu luồng.
3. Thêm các Action theo thứ tự nghiệp vụ.
4. Dùng Decision Node cho các điều kiện rẽ nhánh và Merge Node khi cần hội tụ luồng.
5. Kết thúc bằng Activity Final Node; sắp xếp các mũi tên tránh chồng chéo.

**E. Vẽ Sequence Diagram**

1. Tạo Sequence Diagram cho nghiệp vụ lập quyết định khen thưởng.
2. Thêm Actor hoặc các đối tượng tham gia nghiệp vụ.
3. Tạo Lifeline cho từng đối tượng.
4. Thêm các Message theo thứ tự thời gian từ trên xuống dưới.
5. Kiểm tra trình tự thông điệp thể hiện đúng việc lập quyết định khen thưởng cho cá nhân hoặc tập thể.

### 2.6 Xuất sơ đồ và đưa vào tài liệu Word

1. Chọn sơ đồ cần xuất trong StarUML.
2. Mở menu **Diagram** hoặc chức năng xuất hình ảnh tương ứng của phiên bản đang sử dụng.
3. Chọn định dạng ảnh được phần mềm hỗ trợ, ví dụ PNG hoặc JPEG.
4. Lưu ảnh vào thư mục bài nộp, có thể tạo thêm thư mục `HinhAnh/`.
5. Mở file Word `Bai_7_Quan_ly_nhan_su.docx`, tìm phần Câu 1 đến Câu 6 và chèn ảnh vào đúng vị trí.
6. Kiểm tra ảnh đủ rõ, không bị cắt mất tên lớp, ký hiệu, thông điệp hoặc đường liên kết; sau đó lưu file Word.

### 2.7 Phạm vi nghiệp vụ cần mô hình hóa

Theo đề bài, hệ thống quản lý nhân sự tại Công ty Sơn Đông Á cần quản lý các nghiệp vụ sau:

- **Tuyển dụng và thử việc:** Ghi nhận quyết định tuyển dụng, phòng ban tiếp nhận, thời gian thử việc, mức lương thử việc và các điều khoản liên quan.
- **Hợp đồng lao động:** Theo dõi việc ký hợp đồng sau thời gian thử việc; quản lý hợp đồng dài hạn và ngắn hạn.
- **Bảo hiểm:** Đối với hợp đồng dài hạn, quản lý hồ sơ bảo hiểm y tế, bảo hiểm xã hội và phần trích đóng trong bảng lương.
- **Quyết định nhân sự:** Ghi nhận quyết định bổ nhiệm chức vụ, phụ cấp chức vụ, quyết định lương và quá trình tăng lương.
- **Chấm công và giờ phụ trội:** Quản lý kế hoạch làm việc theo ca, bảng chấm công và phiếu ghi nhận giờ phụ trội.
- **Tính lương:** Tính lương hằng tháng dựa trên quyết định lương, quyết định chức vụ, chấm công và giờ phụ trội.
- **Khen thưởng và kỷ luật:** Quản lý quyết định khen thưởng hoặc xử phạt đối với cá nhân hay tập thể; ghi nhận phiếu chi khen thưởng, phiếu thu nộp phạt hoặc khoản trừ lương.

### 2.8 Quy tắc nghiệp vụ được nêu trong đề

1. Quyết định tuyển dụng phải thể hiện thời gian thử việc tại phòng ban có nhu cầu tuyển dụng.
2. Quyết định tuyển dụng ghi rõ mức lương thử việc và điều khoản giữa hai bên.
3. Sau thời gian thử việc, nhân viên có thể được ký hợp đồng chính thức và nhận các quyết định nhân sự liên quan.
4. Hợp đồng lao động gồm hai loại: dài hạn và ngắn hạn.
5. Nhân viên có hợp đồng dài hạn được lập hồ sơ bảo hiểm y tế và bảo hiểm xã hội theo mô tả đề bài.
6. Giờ phụ trội được tính bằng **1,5 lần giờ lao động bình thường**, theo nội dung đề bài.
7. Khen thưởng và xử phạt phải gắn với quyết định tương ứng và chứng từ hoặc hình thức ghi nhận được mô tả trong đề.

---

## 3. MÔ TẢ CÁC MÔ HÌNH UML CẦN THỰC HIỆN

### 3.1 Class Diagram – Sơ đồ lớp

- Xác định các lớp đại diện cho những đối tượng nghiệp vụ trong hệ thống quản lý nhân sự.
- Khai báo thuộc tính, phương thức và thuộc tính định danh (ID) cho từng lớp.
- Thể hiện các mối liên kết giữa lớp và bội số phù hợp với nghiệp vụ.
- Đảm bảo mô hình bao quát các thông tin về nhân viên, quyết định nhân sự, hợp đồng, chấm công, giờ phụ trội, bảng lương, khen thưởng và kỷ luật theo phạm vi đề bài.

### 3.2 Use Case Diagram tổng quát

- Xác định các Actor tương tác với hệ thống.
- Xác định các Use Case tổng quát cần có để quản lý các thực thể và nghiệp vụ được mô tả.
- Thể hiện ranh giới hệ thống và các mối liên hệ giữa Actor với Use Case.
- Đặt tên Use Case bằng cụm từ thể hiện hành động nghiệp vụ rõ ràng.

### 3.3 Use Case Diagram phân rã quy trình thử việc

- Mô tả chi tiết quy trình từ khi nhân viên được tiếp nhận vào thử việc đến khi ký hợp đồng chính thức.
- Thể hiện các hoạt động và trường hợp xử lý có liên quan theo yêu cầu của đề bài.
- Bảo đảm sơ đồ phân rã thống nhất với sơ đồ Use Case tổng quát.

### 3.4 Activity Diagram – Sơ đồ hoạt động

- Mô tả trình tự hoạt động của quy trình thử việc đến ký hợp đồng chính thức.
- Thể hiện điểm bắt đầu, hoạt động, nhánh quyết định và điểm kết thúc phù hợp.
- Sắp xếp luồng hoạt động rõ ràng, hạn chế đường nối chồng chéo.

### 3.5 Sequence Diagram – Sơ đồ tuần tự

- Mô tả nghiệp vụ **lập quyết định khen thưởng** cho cá nhân hoặc tập thể phòng ban, đơn vị.
- Thể hiện các đối tượng tham gia, đường sống (lifeline), thông điệp trao đổi và thứ tự xử lý.
- Nội dung phải nhất quán với nghiệp vụ khen thưởng được nêu trong đề bài.

---

## 4. BẢNG KIỂM TRA BÀI LÀM (CHECKLIST)

| STT | Câu | Hạng mục | Kết quả cần đạt | Trạng thái |
|:---:|:---:|:---|:---|:---:|
| 1 | 1 | Xác định Class | Có các lớp, thuộc tính, phương thức và ID | Chưa thực hiện |
| 2 | 2 | Class Diagram | Thể hiện đúng mối liên kết và bội số giữa các lớp | Chưa thực hiện |
| 3 | 3 | Use Case tổng quát | Có Actor và các Use Case chính của hệ thống | Chưa thực hiện |
| 4 | 4 | Use Case phân rã | Mô tả quy trình từ thử việc đến ký hợp đồng chính thức | Chưa thực hiện |
| 5 | 5 | Activity Diagram | Thể hiện luồng hoạt động của quy trình ở Câu 4 | Chưa thực hiện |
| 6 | 6 | Sequence Diagram | Mô tả nghiệp vụ lập quyết định khen thưởng | Chưa thực hiện |
| 7 | — | Lưu project | Các sơ đồ được lưu trong project StarUML | Chưa kiểm tra |
| 8 | — | Hoàn thiện tài liệu | README và file Word được sắp xếp trong thư mục bài nộp | Chưa kiểm tra |

*Trạng thái trong bảng là trạng thái mẫu để tự cập nhật khi hoàn thành bài; không khẳng định các sơ đồ đã được thực hiện hoặc kiểm thử.*

---

## 5. HƯỚNG DẪN HOÀN THIỆN VÀ NỘP BÀI

1. Đọc đầy đủ mô tả nghiệp vụ trong `Bai_7_Quan_ly_nhan_su.docx`.
2. Thực hiện lần lượt sáu câu hỏi theo đúng thứ tự đề bài.
3. Lưu các mô hình StarUML trong thư mục `UML/` và đặt tên tệp dễ nhận biết.
4. Kiểm tra tính nhất quán giữa Class Diagram, Use Case Diagram, Activity Diagram và Sequence Diagram.
5. Nếu yêu cầu nộp ảnh sơ đồ, xuất ảnh rõ nét và chèn vào đúng phần Câu 1 đến Câu 6 trong file Word.
6. Kiểm tra lại thông tin sinh viên, tên tệp và cấu trúc thư mục trước khi nộp.

---

## 6. TÁC GIẢ & THÔNG TIN LIÊN HỆ

- **Sinh viên:** Nhan Phi Phố
- **Mã số sinh viên (MSSV):** 1250080142
- **Lớp:** 12_ĐH_CNPM2 - Khoa Công nghệ Thông tin
- **Trường theo thông tin sinh viên:** Đại học Tài Nguyên và Môi Trường TP.HCM
- **Môn học:** Phân tích và Thiết kế Hướng đối tượng (OOSD)
- **Bài thực hành:** Lab 7 – Quản lý nhân sự

*Lưu ý: File Word Lab 7 ghi đơn vị đào tạo là Đại học Công nghệ TP.HCM (HUTECH), trong khi README Lab 5 ghi Đại học Tài Nguyên và Môi Trường TP.HCM. Phần thông tin sinh viên ở trên giữ theo README Lab 5 để đồng bộ mẫu; bạn nên xác nhận lại trường trước khi nộp.*
