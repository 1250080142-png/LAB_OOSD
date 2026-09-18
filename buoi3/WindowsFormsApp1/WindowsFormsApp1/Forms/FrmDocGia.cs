using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FrmDocGia : Form
    {
        // Bảng dữ liệu tạm thời để lưu thông tin độc giả
        private DataTable dtDocGia = new DataTable();

        public FrmDocGia()
        {
            InitializeComponent();
        }

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình cột cho DataTable
            dtDocGia.Columns.Add("Mã", typeof(string));
            dtDocGia.Columns.Add("Họ", typeof(string));
            dtDocGia.Columns.Add("Tên", typeof(string));
            dtDocGia.Columns.Add("Phái", typeof(string));
            dtDocGia.Columns.Add("Điện thoại", typeof(string));
            dtDocGia.Columns.Add("Email", typeof(string));
            dtDocGia.Columns.Add("Hạn thẻ", typeof(string));

            // Thêm các trường ẩn để lưu thông tin chi tiết
            dtDocGia.Columns.Add("Ngày sinh", typeof(string));
            dtDocGia.Columns.Add("Địa chỉ", typeof(string));
            dtDocGia.Columns.Add("Ảnh 3x4", typeof(string));
            dtDocGia.Columns.Add("Ngày cấp", typeof(string));
            dtDocGia.Columns.Add("Đã đóng lệ phí", typeof(bool));

            // 2. Thêm dữ liệu mẫu ban đầu (như trong hình)
            dtDocGia.Rows.Add(
                "DG001", "Lê", "Minh", "Nam", "0911000001", "minh@example.com", "12/09/2027",
                "12/05/2003", "TP.HCM", @"C:\Anh\DG001.jpg", "12/09/2026", true
            );

            // 3. Gán dữ liệu vào DataGridView
            dgvDocGia.DataSource = dtDocGia;

            // Đặt định dạng hiển thị cho DataGridView
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocGia.MultiSelect = false;

            // Ẩn các cột chi tiết trên bảng
            if (dgvDocGia.Columns["Ngày sinh"] != null) dgvDocGia.Columns["Ngày sinh"].Visible = false;
            if (dgvDocGia.Columns["Địa chỉ"] != null) dgvDocGia.Columns["Địa chỉ"].Visible = false;
            if (dgvDocGia.Columns["Ảnh 3x4"] != null) dgvDocGia.Columns["Ảnh 3x4"].Visible = false;
            if (dgvDocGia.Columns["Ngày cấp"] != null) dgvDocGia.Columns["Ngày cấp"].Visible = false;
            if (dgvDocGia.Columns["Đã đóng lệ phí"] != null) dgvDocGia.Columns["Đã đóng lệ phí"].Visible = false;

            // Nạp dòng đầu tiên lên Form
            HienThiDongDauTien();
        }

        // Hiển thị dữ liệu từ DataGridView lên các TextBox
        private void HienThiDongDauTien()
        {
            if (dgvDocGia.Rows.Count > 0 && dgvDocGia.Rows[0].Cells["Mã"].Value != null)
            {
                DataGridViewRow row = dgvDocGia.Rows[0];
                HienThiThongTinDong(row);
            }
        }

        private void HienThiThongTinDong(DataGridViewRow row)
        {
            txtMaDocGia.Text = row.Cells["Mã"].Value?.ToString();
            txtHo.Text = row.Cells["Họ"].Value?.ToString();
            txtTen.Text = row.Cells["Tên"].Value?.ToString();
            txtPhai.Text = row.Cells["Phái"].Value?.ToString();
            txtDienThoai.Text = row.Cells["Điện thoại"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtHanSuDung.Text = row.Cells["Hạn thẻ"].Value?.ToString();

            txtNgaySinh.Text = row.Cells["Ngày sinh"].Value?.ToString();
            txtDiaChi.Text = row.Cells["Địa chỉ"].Value?.ToString();
            txtAnh.Text = row.Cells["Ảnh 3x4"].Value?.ToString();
            txtNgayCap.Text = row.Cells["Ngày cấp"].Value?.ToString();

            if (row.Cells["Đã đóng lệ phí"].Value != null)
            {
                chkDaDongLePhi.Checked = Convert.ToBoolean(row.Cells["Đã đóng lệ phí"].Value);
            }
        }

        // Sự kiện click chọn dòng trên DataGridView
        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDocGia.Rows.Count)
            {
                DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];
                if (row.Cells["Mã"].Value != null && !string.IsNullOrEmpty(row.Cells["Mã"].Value.ToString()))
                {
                    HienThiThongTinDong(row);
                }
            }
        }

        // Nút Thêm độc giả mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập mã độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã
            foreach (DataRow row in dtDocGia.Rows)
            {
                if (row["Mã"].ToString().Equals(txtMaDocGia.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã độc giả đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            dtDocGia.Rows.Add(
                txtMaDocGia.Text.Trim(),
                txtHo.Text.Trim(),
                txtTen.Text.Trim(),
                txtPhai.Text.Trim(),
                txtDienThoai.Text.Trim(),
                txtEmail.Text.Trim(),
                txtHanSuDung.Text.Trim(),
                txtNgaySinh.Text.Trim(),
                txtDiaChi.Text.Trim(),
                txtAnh.Text.Trim(),
                txtNgayCap.Text.Trim(),
                chkDaDongLePhi.Checked
            );

            MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Cập nhật thông tin độc giả
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maDG = txtMaDocGia.Text.Trim();
            DataRow rowToUpdate = null;

            foreach (DataRow row in dtDocGia.Rows)
            {
                if (row["Mã"].ToString().Equals(maDG, StringComparison.OrdinalIgnoreCase))
                {
                    rowToUpdate = row;
                    break;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate["Họ"] = txtHo.Text.Trim();
                rowToUpdate["Tên"] = txtTen.Text.Trim();
                rowToUpdate["Phái"] = txtPhai.Text.Trim();
                rowToUpdate["Điện thoại"] = txtDienThoai.Text.Trim();
                rowToUpdate["Email"] = txtEmail.Text.Trim();
                rowToUpdate["Hạn thẻ"] = txtHanSuDung.Text.Trim();
                rowToUpdate["Ngày sinh"] = txtNgaySinh.Text.Trim();
                rowToUpdate["Địa chỉ"] = txtDiaChi.Text.Trim();
                rowToUpdate["Ảnh 3x4"] = txtAnh.Text.Trim();
                rowToUpdate["Ngày cấp"] = txtNgayCap.Text.Trim();
                rowToUpdate["Đã đóng lệ phí"] = chkDaDongLePhi.Checked;

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy độc giả để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Cấp thẻ
        private void btnCapThe_Click(object sender, EventArgs e)
        {
            txtNgayCap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtHanSuDung.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");
            chkDaDongLePhi.Checked = true;

            MessageBox.Show("Đã cấp thẻ mới có thời hạn 1 năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Nút Gia hạn thẻ
        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(txtHanSuDung.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime hanHienTai))
            {
                txtHanSuDung.Text = hanHienTai.AddYears(1).ToString("dd/MM/yyyy");
            }
            else
            {
                txtHanSuDung.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");
            }

            chkDaDongLePhi.Checked = true;
            MessageBox.Show("Gia hạn thẻ thành công thêm 1 năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}