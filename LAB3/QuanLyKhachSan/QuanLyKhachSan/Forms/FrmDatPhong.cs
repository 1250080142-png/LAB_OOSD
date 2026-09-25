using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDatPhong : Form
    {
        private readonly DatPhongService datPhongService = new DatPhongService();
        private readonly DanhMucService danhMucService = new DanhMucService();

        // Danh sách lưu trữ tạm thời các phòng được chọn để đặt
        private readonly BindingList<PhongDatItem> danhSachPhongChon = new BindingList<PhongDatItem>();

        public FrmDatPhong()
        {
            InitializeComponent();
        }

        #region 1. SỰ KIỆN LOAD & TẢI DỮ LIỆU

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            // Tải danh sách Khách hàng vào ComboBox
            cboKhach.DataSource = datPhongService.LayKhach();
            cboKhach.DisplayMember = "HoTen";
            cboKhach.ValueMember = "MaKhach";

            // Tải danh sách Nhân viên Lễ tân vào ComboBox
            cboNV.DataSource = danhMucService.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            // Khởi tạo kênh đặt phòng
            cboKenh.Items.Clear();
            cboKenh.Items.AddRange(new object[] { "Điện thoại", "Website", "Trực tiếp" });
            cboKenh.SelectedIndex = 0;

            // Gán BindingList cho DataGridView danh sách phòng chọn
            dgvChon.DataSource = danhSachPhongChon;

            TaiDuLieu();
        }

        /// <summary>
        /// Tải toàn bộ danh sách dữ liệu lên các DataGridView chính
        /// </summary>
        private void TaiDuLieu()
        {
            dgvKhach.DataSource = datPhongService.LayKhach();
            dgvPhong.DataSource = datPhongService.LayPhong();
            dgvPhieu.DataSource = datPhongService.LayPhieuDat();
        }

        /// <summary>
        /// Hiển thị thông báo kết quả xử lý và tải lại dữ liệu nếu thành công
        /// </summary>
        private void HienThiKetQua(KetQuaXuLy ketQua)
        {
            MessageBox.Show(ketQua.ThongBao, "Thông báo", MessageBoxButtons.OK,
                            ketQua.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (ketQua.ThanhCong)
            {
                TaiDuLieu();
            }
        }

        /// <summary>
        /// Lấy giá trị SelectedValue của ComboBox an toàn
        /// </summary>
        private string LayGiaTriComboBox(ComboBox cbo)
        {
            return cbo.SelectedValue == null ? "" : cbo.SelectedValue.ToString();
        }

        #endregion

        #region 2. XỬ LÝ CHỌN PHÒNG & TẠO PHIẾU ĐẶT PHÒNG

        // Thêm khách hàng mới
        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            var ketQua = datPhongService.ThemKhach(
                txtMaKH.Text.Trim(),
                txtTenKH.Text.Trim(),
                txtCMND.Text.Trim(),
                txtQT.Text.Trim(),
                txtSDT.Text.Trim()
            );
            HienThiKetQua(ketQua);
        }

        // Chọn phòng từ dgvPhong đưa vào danh sách chờ đặt (dgvChon)
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;

            string soPhong = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);

            // Kiểm tra trùng phòng trong danh sách tạm
            foreach (var item in danhSachPhongChon)
            {
                if (item.SoPhong == soPhong)
                {
                    MessageBox.Show("Phòng đã có trong phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int soNguoi = (int)numSoNguoi.Value;
            decimal donGia = Convert.ToDecimal(dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value);

            danhSachPhongChon.Add(new PhongDatItem
            {
                SoPhong = soPhong,
                SoNguoi = soNguoi,
                DonGiaNgay = donGia
            });
        }

        // Bỏ chọn phòng khỏi danh sách chờ đặt
        private void btnBoPhong_Click(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow != null &&
                dgvChon.CurrentRow.Index >= 0 &&
                dgvChon.CurrentRow.Index < danhSachPhongChon.Count)
            {
                danhSachPhongChon.RemoveAt(dgvChon.CurrentRow.Index);
            }
        }

        // Lập phiếu đặt phòng chính thức
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            var ketQua = datPhongService.TaoDatPhong(
                txtSoPhieu.Text.Trim(),
                LayGiaTriComboBox(cboKhach),
                LayGiaTriComboBox(cboNV),
                dtLap.Value,
                dtNhan.Value,
                dtTra.Value,
                numCoc.Value,
                cboKenh.Text,
                new List<PhongDatItem>(danhSachPhongChon)
            );

            HienThiKetQua(ketQua);

            if (ketQua.ThanhCong && danhSachPhongChon.Count > 0)
            {
                danhSachPhongChon.Clear();
            }
        }

        #endregion

        #region 3. CHI TIẾT PHIẾU ĐẶT, NGƯỜI LƯU TRÚ & TRẠNG THÁI PHÒNG

        // Khi bấm vào 1 dòng trong danh sách Phiếu Đặt Phong
        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow == null) return;

            string soPhieuDat = Convert.ToString(dgvPhieu.CurrentRow.Cells["SoPhieuDat"].Value);
            txtPhieuChon.Text = soPhieuDat;

            // Load Chi tiết đặt phòng và Người lưu trú tương ứng
            dgvCT.DataSource = datPhongService.LayChiTiet(soPhieuDat);
            dgvNguoi.DataSource = datPhongService.LayNguoiLuuTru(soPhieuDat);
        }

        // Thêm thông tin người lưu trú thực tế vào phòng
        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            var ketQua = datPhongService.ThemNguoiLuuTru(
                txtPhieuChon.Text.Trim(),
                txtNguoiPhong.Text.Trim(),
                txtNguoiTen.Text.Trim(),
                txtNguoiCMND.Text.Trim(),
                txtNguoiQT.Text.Trim()
            );
            HienThiKetQua(ketQua);
        }

        // Xác nhận khách Nhận Phong
        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            var ketQua = datPhongService.NhanPhong(txtPhieuChon.Text.Trim(), DateTime.Now);
            HienThiKetQua(ketQua);
        }

        // Đánh dấu Khách không đến (No-Show)
        private void btnNoShow_Click(object sender, EventArgs e)
        {
            var ketQua = datPhongService.DanhDauNoShow(txtPhieuChon.Text.Trim());
            HienThiKetQua(ketQua);
        }

        // Đóng Form
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}