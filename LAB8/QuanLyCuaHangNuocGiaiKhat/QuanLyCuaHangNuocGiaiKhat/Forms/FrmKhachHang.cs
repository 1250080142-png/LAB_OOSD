using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat
{
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaKH", typeof(string));
            dt.Columns.Add("HoTen", typeof(string));
            dt.Columns.Add("DiaChi", typeof(string));
            dt.Columns.Add("SoDienThoai", typeof(string));
            dt.Columns.Add("LoaiKH", typeof(string));

            dt.Rows.Add("KH01", "Nguyễn Văn A", "Quận 1, TP.HCM", "0912345678", "Khách quen");
            dt.Rows.Add("KH02", "Khách Bán Lẻ", "Tại cửa hàng", "-", "Khách vãng lai");

            dgvKhachHang.DataSource = dt;
        }
    }
}