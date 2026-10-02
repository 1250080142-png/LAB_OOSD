using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quan_Ly_He_Thong_E_Shopping
{
    public partial class FrmChiTietSanPham : Form
    {
        private int maSP;

        public FrmChiTietSanPham()
        {
            InitializeComponent();
        }

        public FrmChiTietSanPham(int maSP) : this()
        {
            this.maSP = maSP;
        }

        private void FrmChiTietSanPham_Load(object sender, EventArgs e)
        {
            if (maSP > 0)
            {
                LoadChiTiet();
            }
        }

        private void LoadChiTiet()
        {
            string query = @"SELECT sp.TenSP, sp.MaSanPham, np.TenNhom, sp.NhaSanXuat, sp.Gia, sp.MoTa, sp.ThongSo, sp.TrangThaiTonKho 
                            FROM SAN_PHAM sp 
                            LEFT JOIN NHOM_SAN_PHAM np ON sp.MaNhom = np.MaNhom 
                            WHERE sp.MaSP = @MaSP";

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@MaSP", maSP)
            };

            DataTable dt = Db.GetData(query, p);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                txtTenSP.Text = dr["TenSP"].ToString();
                txtMaSP.Text = dr["MaSanPham"].ToString();
                txtNhom.Text = dr["TenNhom"].ToString();
                txtNhaSanXuat.Text = dr["NhaSanXuat"].ToString();
                txtGia.Text = string.Format("{0:N0} VNĐ", dr["Gia"]);
                txtMoTa.Text = dr["MoTa"].ToString();
                txtThongSo.Text = dr["ThongSo"].ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}