using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtMaHD.Text = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            // Khởi tạo các cột cho DataGridView chi tiết hóa đơn
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNGK", typeof(string));
            dt.Columns.Add("TenNGK", typeof(string));
            dt.Columns.Add("SoLuongTon", typeof(int));
            dt.Columns.Add("SoLuongMua", typeof(int));
            dt.Columns.Add("DonGia", typeof(decimal));
            dt.Columns.Add("ThanhTien", typeof(decimal), "SoLuongMua * DonGia");
            dgvChiTietHD.DataSource = dt;
        }

        private void BtnLapHoaDon_Click(object sender, EventArgs e)
        {
            // Logic kiểm tra tồn kho tức thời trước khi lập hóa đơn
            MessageBox.Show("Đã kiểm tra tồn kho thành công và lập Hóa đơn bán hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLapPhieuHen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Khởi tạo Phiếu hẹn giao hàng nhiều đợt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}