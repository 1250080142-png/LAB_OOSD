using System;
using System.Windows.Forms;
using QuanLyTourDuLich.Frm;

namespace QuanLyTourDuLich
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy Form chính FrmMain thay vì Form1
            Application.Run(new FrmMain());
        }
    }
}