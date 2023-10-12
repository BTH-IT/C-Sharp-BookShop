using System;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.GUI;
using QuanLyCuaHangBanSach.GUI.Importer;
using QuanLyCuaHangBanSach.GUI.Manager;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach.GUI.Report;
using QuanLyCuaHangBanTacGia.GUI.Manager;

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
            /*Application.Run(LoginGUI.Instance);*/
            Application.Run(new CustomerStatisticGUI(1));
        }
    }
}
