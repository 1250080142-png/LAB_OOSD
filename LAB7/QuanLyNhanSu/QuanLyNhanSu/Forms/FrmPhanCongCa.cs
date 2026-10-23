using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Database;

namespace QuanLyNhanSu
{
    public partial class FrmPhanCongCa : Form
    {
        Db db = new Db();

        public FrmPhanCongCa()
        {
            InitializeComponent();
        }

        private void FrmPhanCongCa_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxes();
        }

        private void LoadData()
        {
            string query = @"SELECT pc.ID, nv.Ho + ' ' + Ten AS HoTen, c.TenCa, pc.NgayPhanCong 
                             FROM PhanCongCa pc 
                             JOIN NhanVien nv ON pc.MaNV = nv.MaNV 
                             JOIN CaLamViec c ON pc.MaCa = c.MaCa";
            dataGridView1.DataSource = db.ExecuteQuery(query);
        }

        private void LoadComboBoxes()
        {
            cboMaNV.DataSource = db.ExecuteQuery("SELECT MaNV, Ho + ' ' + Ten AS HoTen FROM NhanVien");
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";

            cboMaCa.DataSource = db.ExecuteQuery("SELECT MaCa, TenCa FROM CaLamViec");
            cboMaCa.DisplayMember = "TenCa";
            cboMaCa.ValueMember = "MaCa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = cboMaNV.SelectedValue.ToString();
                string maCa = cboMaCa.SelectedValue.ToString();
                string ngayPC = dtpNgayPhanCong.Value.ToString("yyyy-MM-dd");

                string query = $"INSERT INTO PhanCongCa VALUES ('{maNV}', '{maCa}', '{ngayPC}')";
                db.ExecuteNonQuery(query);

                MessageBox.Show("Phân công ca thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}