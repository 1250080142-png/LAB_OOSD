using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDichVu : Form
    {
        readonly DichVuService s = new DichVuService();

        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            cboLuot.DataSource = s.LayPhieuDangO();
            cboLuot.DisplayMember = "SoPhieuDat";
            cboLuot.ValueMember = "SoPhieuDat";

            cboDV.DataSource = s.LayDichVu();
            cboDV.DisplayMember = "TenDV";
            cboDV.ValueMember = "MaDV";

            Tai();
        }

        void Tai()
        {
            if (cboLuot.SelectedValue != null)
                dgvLichSu.DataSource = s.LayLichSu(cboLuot.SelectedValue.ToString());
        }

        string V(ComboBox c) => c.SelectedValue != null ? c.SelectedValue.ToString() : "";

        private void cboLuot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuot.SelectedItem is DataRowView r)
                txtPhong.Text = Convert.ToString(r["SoPhong"]);
            Tai();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            var k = s.GhiNhan(V(cboLuot), txtPhong.Text.Trim(), dtNgay.Value, "NV01", V(cboDV), (int)numSL.Value);
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }

        private void cboDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}