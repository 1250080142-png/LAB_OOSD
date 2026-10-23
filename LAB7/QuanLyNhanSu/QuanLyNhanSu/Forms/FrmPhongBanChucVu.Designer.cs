using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Database;

namespace QuanLyNhanSu
{
    public partial class FrmPhongBanChucVu : Form
    {
        Db db = new Db();
        public FrmPhongBanChucVu() { InitializeComponent(); }
        private void FrmPhongBanChucVu_Load(object sender, EventArgs e) { LoadData(); }
        private void LoadData() { dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM PhongBan"); }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExecuteNonQuery($"INSERT INTO PhongBan VALUES ('{txtMaPhong.Text}', N'{txtTenPhong.Text}', N'{txtMoTa.Text}')");
                LoadData(); MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExecuteNonQuery($"UPDATE PhongBan SET TenPhong = N'{txtTenPhong.Text}', MoTa = N'{txtMoTa.Text}' WHERE MaPhong = '{txtMaPhong.Text}'");
                LoadData(); MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExecuteNonQuery($"DELETE FROM PhongBan WHERE MaPhong = '{txtMaPhong.Text}'");
                LoadData(); MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells["MaPhong"].Value.ToString();
                txtTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }
    }
}