using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat
{
    public partial class FrmNuocGiaiKhat : Form
    {
        public FrmNuocGiaiKhat()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNGK", typeof(string));
            dt.Columns.Add("TenNGK", typeof(string));
            dt.Columns.Add("DonViTinh", typeof(string));
            dt.Columns.Add("SoLuongTon", typeof(int));
            dt.Columns.Add("DonGiaBan", typeof(decimal));

            dt.Rows.Add("NGK01", "Pepsi Lon 330ml", "Lon", 150, 10000);
            dt.Rows.Add("NGK02", "Coca Cola Chai 1.5L", "Chai", 80, 20000);
            dt.Rows.Add("NGK03", "Bia Sài Gòn Special", "Thùng", 45, 330000);

            dgvNuocGiaiKhat.DataSource = dt;
        }
    }
}