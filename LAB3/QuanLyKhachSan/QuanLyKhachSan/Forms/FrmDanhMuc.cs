using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService service = new DanhMucService();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        #region 1. SỰ KIỆN LOAD & TẢI DỮ LIỆU

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        /// <summary>
        /// Tải toàn bộ danh sách dữ liệu lên các DataGridView và ComboBox
        /// </summary>
        private void TaiDuLieu()
        {
            // Tải dữ liệu lên các DataGridView
            dgvKhu.DataSource = service.LayKhuVuc();
            dgvNV.DataSource = service.LayNhanVien();
            dgvLoaiTN.DataSource = service.LayLoaiTienNghi();
            dgvDV.DataSource = service.LayDichVu();
            dgvQD.DataSource = service.LayQuyDinhDenBu();

            // Cấu hình ComboBox Loại Tiện Nghi cho Quy Định Đền Bù
            cboQDLoai.DataSource = service.LayLoaiTienNghi();
            cboQDLoai.DisplayMember = "TenLoaiTN";
            cboQDLoai.ValueMember = "MaLoaiTN";
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

        #endregion

        #region 2. XỬ LÝ SỰ KIỆN NÚT BẤM (BUTTON CLICK)

        // Thêm Khu Vực
        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            var ketQua = service.ThemKhu(
                txtKhuMa.Text.Trim(),
                txtKhuTen.Text.Trim()
            );
            HienThiKetQua(ketQua);
        }

        // Thêm Nhân Viên
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            var ketQua = service.ThemNhanVien(
                txtNVMa.Text.Trim(),
                txtNVTen.Text.Trim(),
                txtNVVaiTro.Text.Trim(),
                txtNVSDT.Text.Trim()
            );
            HienThiKetQua(ketQua);
        }

        // Thêm Loại Tiện Nghi
        private void btnThemLoaiTN_Click(object sender, EventArgs e)
        {
            var ketQua = service.ThemLoaiTN(
                txtLoaiMa.Text.Trim(),
                txtLoaiTen.Text.Trim()
            );
            HienThiKetQua(ketQua);
        }

        // Thêm Dịch Vụ
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            var ketQua = service.ThemDichVu(
                txtDVMa.Text.Trim(),
                txtDVTen.Text.Trim(),
                txtDVDVT.Text.Trim(),
                numDVGia.Value
            );
            HienThiKetQua(ketQua);
        }

        // Thêm Quy Định Đền Bù
        private void btnThemQD_Click(object sender, EventArgs e)
        {
            string maLoaiTN = cboQDLoai.SelectedValue == null ? "" : cboQDLoai.SelectedValue.ToString();

            var ketQua = service.ThemQuyDinh(
                txtQDMa.Text.Trim(),
                maLoaiTN,
                txtQDMucDo.Text.Trim(),
                numQDTien.Value
            );
            HienThiKetQua(ketQua);
        }

        // Đóng Form
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}