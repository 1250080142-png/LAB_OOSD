using System;
using System.Data;
using System.Windows.Forms;

namespace Quan_Ly_He_Thong_E_Shopping.Forms
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT MaSP, TenSP, Gia, TrangThaiTonKho, MoTa FROM SAN_PHAM";
            DataTable dt = Db.GetData(query);
            if (dt != null)
            {
                dgvSanPham.DataSource = dt;
            }
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maSP = Convert.ToInt32(dgvSanPham.Rows[e.RowIndex].Cells["MaSP"].Value);
                FrmChiTietSanPham frm = new FrmChiTietSanPham(maSP);
                frm.ShowDialog();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}