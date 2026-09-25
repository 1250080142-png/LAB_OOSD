using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        // Đã bổ sung hàm này để hết sạch lỗi:
        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            // Mặc định chọn từ ngày đầu tháng đến hôm nay và tự động thống kê khi vừa mở Form
            dtTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtDen.Value = DateTime.Now;
            btnTK_Click(sender, e);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Mốc 'Đến ngày' không được trước 'Từ ngày'.", "Lỗi dữ liệu");
                return;
            }

            // Lấy dữ liệu thống kê từ Service
            DataTable dtTH = s.TongHop(dtTu.Value, dtDen.Value);
            dgvTongHop.DataSource = dtTH;
            dgvDV.DataSource = s.DichVu(dtTu.Value, dtDen.Value);

            // Cập nhật các dòng chữ thống kê màu xanh như bài mẫu
            if (dtTH != null && dtTH.Rows.Count > 0)
            {
                DataRow r = dtTH.Rows[0];
                lblPhieuDat.Text = "Phiếu đặt: " + r["SoPhieuDat"];
                lblDangO.Text = "Đang ở: " + r["DangO"];
                lblHoaDon.Text = "Hóa đơn: " + r["SoHoaDon"];
                lblDoanhThuHD.Text = string.Format("Doanh thu HĐ: {0:N0} đ", r["DoanhThuHoaDon"]);
                lblTongDenBu.Text = string.Format("Tổng đền bù: {0:N0} đ", r["TongDenBu"]);
            }
        }
    }
}