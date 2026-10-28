using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat
{
    public partial class FrmNhapHang : Form
    {
        public FrmNhapHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SoPhieuGiao", typeof(string));
            dt.Columns.Add("SoDDH", typeof(string));
            dt.Columns.Add("DotGiao", typeof(int));
            dt.Columns.Add("NgayGiao", typeof(DateTime));
            dt.Columns.Add("SoTienPhaiTra", typeof(decimal));

            dt.Rows.Add("PG01", "DDH01", 1, DateTime.Now.AddDays(-2), 15000000);
            dt.Rows.Add("PG02", "DDH01", 2, DateTime.Now, 10000000);

            dgvPhieuGiao.DataSource = dt;
        }
    }
}