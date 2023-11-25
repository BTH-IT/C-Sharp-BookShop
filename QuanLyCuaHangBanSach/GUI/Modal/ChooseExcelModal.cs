using System;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class ChooseExcelModal : Form
    {
        public bool isRequest = false;
        public bool isImport = false;
        public ChooseExcelModal(string title = "Chọn mục đích tệp Excel")
        {
            InitializeComponent();

            this.label1.Text = title;
            this.Text = title;
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            try
            {
				isRequest = true;
                Close();
			}
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

		private void ImportBtn_Click(object sender, EventArgs e)
		{
			try
			{
                isImport = true;
				Close();
			}
			catch (Exception er)
			{

				Console.WriteLine(er);
			}
		}

		private void ChooseExcelModal_Load(object sender, EventArgs e)
        {
            try
            {
                //this.Location = new Point(
                //        (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                //        (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
                //    );
  
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
        }
	}
}
