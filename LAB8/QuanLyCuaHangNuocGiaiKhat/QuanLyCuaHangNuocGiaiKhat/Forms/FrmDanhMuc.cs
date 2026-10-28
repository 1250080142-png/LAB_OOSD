using System;
using System.Data;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat
{
    public partial class FrmDanhMuc : Form
    {
        public FrmDanhMuc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Data demo Nhà cung ứng
            DataTable dtNCC = new DataTable();
            dtNCC.Columns.Add("MaNCC", typeof(string));
            dtNCC.Columns.Add("TenNCC", typeof(string));
            dtNCC.Columns.Add("DiaChi", typeof(string));
            dtNCC.Columns.Add("SoDienThoai", typeof(string));
            dtNCC.Rows.Add("NCC01", "Công ty PepsiCo Việt Nam", "TP. Hồ Chí Minh", "02838221100");
            dtNCC.Rows.Add("NCC02", "Công ty Coca-Cola Việt Nam", "TP. Hồ Chí Minh", "02838222200");
            dgvNCC.DataSource = dtNCC;

            // Data demo Nhãn hiệu
            DataTable dtNH = new DataTable();
            dtNH.Columns.Add("MaLoai", typeof(string));
            dtNH.Columns.Add("TenLoai", typeof(string));
            dtNH.Columns.Add("MaNCC", typeof(string));
            dtNH.Rows.Add("L01", "Nước ngọt Pepsi", "NCC01");
            dtNH.Rows.Add("L02", "Nước ngọt Coca Cola", "NCC02");
            dgvNhanHieu.DataSource = dtNH;

            // Data demo Nhân viên
            DataTable dtNV = new DataTable();
            dtNV.Columns.Add("MaNV", typeof(string));
            dtNV.Columns.Add("HoTen", typeof(string));
            dtNV.Columns.Add("SoDienThoai", typeof(string));
            dtNV.Rows.Add("NV01", "Nhan Phi Phố", "0901234567");
            dgvNhanVien.DataSource = dtNV;
        }
    }
}