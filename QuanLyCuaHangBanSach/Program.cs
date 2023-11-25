using System;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.GUI;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach.GUI.Importer;
using QuanLyCuaHangBanSach.GUI.Manager;

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
            Application.Run(new MenuGUI(1));
        }
    }
}
