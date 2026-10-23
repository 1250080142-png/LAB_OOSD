using System;
using System.Windows.Forms;

namespace QuanLyNhanSuDongA
{
    public partial class FrmThoat : Form
    {
        public FrmThoat()
        {
            InitializeComponent();
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}