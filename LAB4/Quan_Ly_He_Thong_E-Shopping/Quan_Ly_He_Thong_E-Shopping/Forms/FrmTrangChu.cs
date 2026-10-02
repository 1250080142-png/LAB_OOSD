using System;
using System.Windows.Forms;

namespace Quan_Ly_He_Thong_E_Shopping.Forms
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham frm = new FrmSanPham();
            frm.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            frm.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frm = new FrmDangKy();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}