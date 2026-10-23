using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Database;

namespace QuanLyNhanSu
{
    public partial class FrmKhenThuongKyLuat : Form
    {
        Db db = new Db();
        public FrmKhenThuongKyLuat() { InitializeComponent(); }
        private void FrmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM QuyetDinhKhenThuongKyLuat");
            cboMaNV.DataSource = db.ExecuteQuery("SELECT MaNV, Ho + ' ' + Ten AS HoTen FROM NhanVien");
            cboMaNV.DisplayMember = "HoTen"; cboMaNV.ValueMember = "MaNV";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExecuteNonQuery($"INSERT INTO QuyetDinhKhenThuongKyLuat VALUES ('{txtSoQuyetDinh.Text}', N'{cboLoaiQD.Text}', N'{cboDoiTuong.Text}', '{cboMaNV.SelectedValue}', NULL, {txtSoTien.Text}, N'{txtHinhThuc.Text}', '{dtpNgayKy.Value:yyyy-MM-dd}', N'{txtNoiDung.Text}')");
                dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM QuyetDinhKhenThuongKyLuat");
                MessageBox.Show("Thêm quyết định thành công!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}