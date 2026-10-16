using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Database;

namespace QuanLyHoSoBenhAn.Form
{
    // Thêm ": Form" ở đây để kế thừa đầy đủ tính năng Windows Forms
    public partial class frmMain : System.Windows.Forms.Form
    {
        Db db = new Db();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            LoadDashboardStats();
            LoadDanhSachBenhNhanMoi();

            // Gán sự kiện mở form khi bấm menu
            mnuDangKyKham.Click += (s, ev) => new frmDangKyVaCapHoSo().ShowDialog();
            mnuTraCuuHoSo.Click += (s, ev) => new frmTraCuuHoSo().ShowDialog();
            mnuKhamVaKeToa.Click += (s, ev) => new frmKhamBenhVaKeToa().ShowDialog();
            mnuThanhToanVienPhi.Click += (s, ev) => new frmThanhToanVienPhi().ShowDialog();
            mnuDatLichHen.Click += (s, ev) => new frmDatLichKhamDinhKy().ShowDialog();
            mnuThoat.Click += (s, ev) => Application.Exit();
        }

        private void LoadDashboardStats()
        {
            try
            {
                object tongBN = db.ExecuteScalar("SELECT COUNT(*) FROM BENH_NHAN");
                lblTongBenhNhan.Text = tongBN != null ? tongBN.ToString() : "0";

                object choKham = db.ExecuteScalar("SELECT COUNT(*) FROM PHIEU_DANG_KY WHERE CAST(ngayDangKy AS DATE) = CAST(GETDATE() AS DATE)");
                lblSoBenhNhanChoKham.Text = choKham != null ? choKham.ToString() : "0";

                object lichHen = db.ExecuteScalar("SELECT COUNT(*) FROM LICH_HEN WHERE CAST(ngayGioHen AS DATE) = CAST(GETDATE() AS DATE)");
                lblLichHenHomNay.Text = lichHen != null ? lichHen.ToString() : "0";
            }
            catch { }
        }

        private void LoadDanhSachBenhNhanMoi()
        {
            try
            {
                DataTable dt = db.ExecuteQuery("SELECT TOP 10 maBN as [Mã BN], hoTen as [Họ Tên], dienThoai as [SĐT], diaChi as [Địa Chỉ] FROM BENH_NHAN ORDER BY maBN DESC");
                dgvBenhNhanMoi.DataSource = dt;
            }
            catch { }
        }
    }
}