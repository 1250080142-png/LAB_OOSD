using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat
{
    public partial class FrmPhieuGhiNo : Form
    {
        public FrmPhieuGhiNo()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaPhieuNo", typeof(string));
            dt.Columns.Add("SoHoaDon", typeof(string));
            dt.Columns.Add("MaKH", typeof(string));
            dt.Columns.Add("SoTienNo", typeof(decimal));
            dt.Columns.Add("NgayDuKienTra", typeof(DateTime));
            dt.Columns.Add("LyDoNo", typeof(string));

            dt.Rows.Add("PN01", "HD01", "KH01", 5000000, DateTime.Now.AddMonths(1), "Khách hẹn thanh toán cuối tháng");
            dgvPhieuNo.DataSource = dt;
        }
    }
}