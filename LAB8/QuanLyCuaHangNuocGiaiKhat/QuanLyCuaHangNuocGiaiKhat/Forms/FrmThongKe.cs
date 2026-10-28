using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("NgayThongKe", typeof(DateTime));
            dt.Columns.Add("TongSoHoaDon", typeof(int));
            dt.Columns.Add("TongDoanhThu", typeof(decimal));

            dt.Rows.Add(DateTime.Now.Date, 12, 45000000);
            dgvThongKe.DataSource = dt;
        }
    }
}