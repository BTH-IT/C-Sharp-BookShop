using System;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.GUI;
<<<<<<< HEAD
using QuanLyCuaHangBanSach.GUI.Manager;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach.GUI.Report;

=======
using QuanLyCuaHangBanSach.GUI.Vendor;
>>>>>>> 14301854a4d0a0ede14c465ef554d6d601366de2
namespace QuanLyCuaHangBanSach
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
            Application.Run(new ScannerModal());
        }
    }
}
