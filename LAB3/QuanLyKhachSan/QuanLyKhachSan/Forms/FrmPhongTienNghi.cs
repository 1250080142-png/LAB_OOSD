using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmPhongTienNghi : Form
    {
        private readonly PhongTienNghiService phongService = new PhongTienNghiService();
        private readonly DanhMucService danhMucService = new DanhMucService();

        public FrmPhongTienNghi()
        {
            InitializeComponent();
        }

        #region 1. SỰ KIỆN LOAD & TẢI DỮ LIỆU

        private void FrmPhongTienNghi_Load(object sender, EventArgs e)
        {
            // Load danh sách dữ liệu vào các ComboBox
            cboKhu.DataSource = danhMucService.LayKhuVuc();
            cboKhu.DisplayMember = "TenKhuVuc";
            cboKhu.ValueMember = "MaKhuVuc";

            cboLoai.DataSource = danhMucService.LayLoaiTienNghi();
            cboLoai.DisplayMember = "TenLoaiTN";
            cboLoai.ValueMember = "MaLoaiTN";

            cboTN.DataSource = phongService.LayTienNghi();
            cboTN.DisplayMember = "MaTienNghi";
            cboTN.ValueMember = "MaTienNghi";

            cboPhong.DataSource = phongService.LayPhong();
            cboPhong.DisplayMember = "SoPhong";
            cboPhong.ValueMember = "SoPhong";

            cboNV.DataSource = danhMucService.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            TaiDuLieu();
        }

        /// <summary>
        /// Tải toàn bộ danh sách dữ liệu lên các DataGridView
        /// </summary>
        private void TaiDuLieu()
        {
            dgvPhong.DataSource = phongService.LayPhong();
            dgvTN.DataSource = phongService.LayTienNghi();
            dgvLD.DataSource = phongService.LayLapDat();
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
        /// Hàm bổ trợ lấy giá trị SelectedValue của ComboBox an toàn
        /// </summary>
        private string LayGiaTriComboBox(ComboBox cbo)
        {
            return cbo.SelectedValue == null ? "" : cbo.SelectedValue.ToString();
        }

        #endregion

        #region 2. XỬ LÝ SỰ KIỆN NÚT BẤM (BUTTON CLICK)

        // Thêm Phòng
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            var ketQua = phongService.ThemPhong(
                txtPhong.Text.Trim(),
                LayGiaTriComboBox(cboKhu),
                (int)numMax.Value,
                numGia.Value
            );
            HienThiKetQua(ketQua);
        }

        // Thêm Tiện Nghi
        private void btnThemTN_Click(object sender, EventArgs e)
        {
            var ketQua = phongService.ThemTienNghi(
                txtMaTN.Text.Trim(),
                LayGiaTriComboBox(cboLoai),
                (int)numSTT.Value,
                txtTinhTrang.Text.Trim()
            );
            HienThiKetQua(ketQua);
        }

        // Lập Phếu Lắp Đặt
        private void btnLapDat_Click(object sender, EventArgs e)
        {
            var ketQua = phongService.LapDat(
                txtSoLD.Text.Trim(),
                LayGiaTriComboBox(cboTN),
                LayGiaTriComboBox(cboPhong),
                dtNgay.Value,
                txtTTLD.Text.Trim(),
                LayGiaTriComboBox(cboNV),
                txtGhiChu.Text.Trim()
            );
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