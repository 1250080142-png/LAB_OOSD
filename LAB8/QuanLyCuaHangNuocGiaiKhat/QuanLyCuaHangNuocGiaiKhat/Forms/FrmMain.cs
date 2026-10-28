using System;
using System.Windows.Forms;

namespace CuaHangNuocGiaiKhat
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MnuDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhMuc());
        }

        private void MnuNuocGiaiKhat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNuocGiaiKhat());
        }

        private void MnuKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhachHang());
        }

        private void MnuNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhapHang());
        }

        private void MnuBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBanHang());
        }

        private void MnuPhieuHen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPhieuHen());
        }

        private void MnuPhieuGhiNo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPhieuGhiNo());
        }

        private void MnuThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe());
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == childForm.GetType())
                {
                    f.Activate();
                    return;
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}