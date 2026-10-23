using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Database;

namespace QuanLyNhanSu
{
    public partial class FrmChamCongPhuTroi : Form
    {
        Db db = new Db();
        public FrmChamCongPhuTroi() { InitializeComponent(); }
        private void FrmChamCongPhuTroi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM BangChamCong");
            cboMaNV.DataSource = db.ExecuteQuery("SELECT MaNV, Ho + ' ' + Ten AS HoTen FROM NhanVien");
            cboMaNV.DisplayMember = "HoTen"; cboMaNV.ValueMember = "MaNV";
        }
        private void btnLuuChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExecuteNonQuery($"INSERT INTO BangChamCong VALUES ({txtThang.Text}, {txtNam.Text}, '{cboMaNV.SelectedValue}', {txtNgayCong.Text}, {txtNgayNghi.Text})");
                dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM BangChamCong");
                MessageBox.Show("Lưu chấm công thành công!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}