using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat
{
    public partial class FrmPhieuHen : Form
    {
        public FrmPhieuHen()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaPhieuHen", typeof(string));
            dt.Columns.Add("SoHoaDon", typeof(string));
            dt.Columns.Add("NgayHenGiao", typeof(DateTime));
            dt.Columns.Add("TrangThai", typeof(string));

            dt.Rows.Add("PH01", "HD01", DateTime.Now.AddDays(3), "Chờ giao đợt 2");
            dgvPhieuHen.DataSource = dt;
        }
    }
}