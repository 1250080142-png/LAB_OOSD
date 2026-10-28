using System;
using System.Windows.Forms;
using CuaHangNuocGiaiKhat;

namespace QuanLyCuaHangNuocGiaiKhat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Sửa Form1 thành FrmMain (Form Trang chủ của bạn)
            Application.Run(new FrmMain());
        }
    }
}