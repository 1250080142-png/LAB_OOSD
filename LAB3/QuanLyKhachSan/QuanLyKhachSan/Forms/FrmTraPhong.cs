using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmTraPhong : Form
    {
        readonly TraPhongService s = new TraPhongService();
        readonly DanhMucService dm = new DanhMucService();
        readonly BindingList<DenBuItem> db = new BindingList<DenBuItem>();

        public FrmTraPhong()
        {
            InitializeComponent();
        }

        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            cboDat.DataSource = s.LayPhieuDangO();
            cboDat.DisplayMember = "SoPhieuDat";
            cboDat.ValueMember = "SoPhieuDat";

            cboHT.Items.Clear();
            cboHT.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ", "Ví điện tử" });
            cboHT.SelectedIndex = 0;

            dgvDBChon.DataSource = db;
            Tai();
        }

        void Tai()
        {
            if (cboDat.SelectedValue != null)
                dgvPhong.DataSource = s.LayPhongTheoPhieu(cboDat.SelectedValue.ToString());
            dgvHD.DataSource = s.LayHoaDon();
        }

        string V(ComboBox c) => c.SelectedValue != null ? c.SelectedValue.ToString() : "";

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            txtPhong.Text = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
            dgvTN.DataSource = s.LayTienNghiPhong(txtPhong.Text);
        }

        private void btnThemDB_Click(object sender, EventArgs e)
        {
            if (dgvTN.CurrentRow == null) return;
            string ma = Convert.ToString(dgvTN.CurrentRow.Cells["MaTienNghi"].Value);
            string ten = Convert.ToString(dgvTN.CurrentRow.Cells["TenLoaiTN"].Value);
            foreach (var x in db)
            {
                if (x.MaTienNghi == ma) { MessageBox.Show("Tiện nghi đã có trong danh sách đền bù!"); return; }
            }
            db.Add(new DenBuItem { MaTienNghi = ma, TenLoaiTN = ten, MucDoThietHai = txtMucDo.Text.Trim(), SoTien = numDenBu.Value });
        }

        private void btnLapDB_Click(object sender, EventArgs e)
        {
            var k = s.LapPhieuDenBu(txtSoDB.Text.Trim(), V(cboDat), txtPhong.Text.Trim(), DateTime.Now, "NV01", new List<DenBuItem>(db));
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) db.Clear();
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            var k = s.LapHoaDon(txtSoHD.Text.Trim(), V(cboDat), DateTime.Now, "NV01", (int)numSoNgay.Value);
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }

        private void dgvHD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHD.CurrentRow != null)
                txtHDChon.Text = Convert.ToString(dgvHD.CurrentRow.Cells["SoHoaDon"].Value);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maTT = "TT" + DateTime.Now.ToString("mmss");
            var k = s.ThanhToan(maTT, txtHDChon.Text.Trim(), DateTime.Now, cboHT.Text, numTienTT.Value);
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            var k = s.TraPhong(V(cboDat), DateTime.Now);
            MessageBox.Show(k.ThongBao);
            if (k.ThanhCong) Tai();
        }
    }
}