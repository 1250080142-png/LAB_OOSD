using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Database;

namespace QuanLyNhanSu
{
    public partial class FrmHopDongTuyenDung : Form
    {
        Db db = new Db();
        public FrmHopDongTuyenDung() { InitializeComponent(); }
        private void FrmHopDongTuyenDung_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM HopDongLaoDong");
            cboMaNV.DataSource = db.ExecuteQuery("SELECT MaNV, Ho + ' ' + Ten AS HoTen FROM NhanVien");
            cboMaNV.DisplayMember = "HoTen"; cboMaNV.ValueMember = "MaNV";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int bhyt = chkCoBHYT.Checked ? 1 : 0;
                int bhxh = chkCoBHXH.Checked ? 1 : 0;
                db.ExecuteNonQuery($"INSERT INTO HopDongLaoDong VALUES ('{txtSoHopDong.Text}', '{cboMaNV.SelectedValue}', N'{cboLoaiHopDong.Text}', '{dtpNgayBatDau.Value:yyyy-MM-dd}', '{dtpNgayKetThuc.Value:yyyy-MM-dd}', {bhyt}, {bhxh})");
                dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM HopDongLaoDong");
                MessageBox.Show("Thêm hợp đồng thành công!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}