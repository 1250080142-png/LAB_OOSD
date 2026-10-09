using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTourDuLich.Frm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, Button activeBtn)
        {
            // Reset màu sắc các nút bấm trên thanh điều hướng
            foreach (Control c in pnlTopNav.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.FromArgb(27, 54, 93);
                }
            }

            // Highlight nút đang chọn
            if (activeBtn != null)
            {
                activeBtn.BackColor = Color.FromArgb(27, 54, 93);
                activeBtn.ForeColor = Color.White;
            }

            // Mở Form con lồng vào pnlContent
            if (pnlContent.Controls.Count > 0)
            {
                pnlContent.Controls[0].Dispose();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.Show();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTourManager(), (Button)sender);
        }

        private void btnChuyenDi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChuyenDiMangager(), (Button)sender);
        }

        private void btnDangKyDoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDangKyDoan(), (Button)sender);
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBanVeKhachLe(), (Button)sender);
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPhanCongVaLuong(), (Button)sender);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhaoSatBaoCao(), (Button)sender);
        }

        private void btnBaoHiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachBaoHiem(), (Button)sender);
        }
    }
}