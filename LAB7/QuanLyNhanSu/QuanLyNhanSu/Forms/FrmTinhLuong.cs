using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Database;

namespace QuanLyNhanSu
{
    public partial class FrmTinhLuong : Form
    {
        Db db = new Db();
        public FrmTinhLuong() { InitializeComponent(); }
        private void FrmTinhLuong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM BangLuong");
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Đã tính lương tháng {txtThang.Text}/{txtNam.Text} thành công!");
            dataGridView1.DataSource = db.ExecuteQuery("SELECT * FROM BangLuong");
        }
    }
}