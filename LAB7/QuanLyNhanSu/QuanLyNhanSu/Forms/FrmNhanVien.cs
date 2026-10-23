using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSu.Database;

namespace QuanLyNhanSu // Đồng bộ về chung 1 namespace QuanLyNhanSu
{
    public partial class FrmNhanVien : System.Windows.Forms.Form
    {
        Db db = new Db();
        // Giữ nguyên toàn bộ nội dung phương thức bên dưới...