using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Database;

namespace QuanLyNhanSu
{
    public partial class FrmQuyetDinhLuongChucVu : Form
    {
        Db db = new Db();
        public FrmQuyetDinhLuongChucVu() { InitializeComponent(); }
        private void FrmQuyetDinhLuongChucVu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM QuyetDinhLuong");
            cboMaNV.DataSource = db.ExecuteQuery("SELECT MaNV, Ho + ' ' + Ten AS HoTen FROM NhanVien");
            cboMaNV.DisplayMember = "HoTen"; cboMaNV.ValueMember = "MaNV";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExecuteNonQuery($"INSERT INTO QuyetDinhLuong VALUES ('{txtSoQD.Text}', '{cboMaNV.SelectedValue}', {txtLuongCoBan.Text}, {txtPhuCapLuong.Text}, {txtPhuCapDocHai.Text}, '{dtpNgayKy.Value:yyyy-MM-dd}')");
                dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM QuyetDinhLuong");
                MessageBox.Show("Thêm quyết định lương thành công!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}