using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class AddBookModal : Form
    {
        public AddBookModal()
        {
            InitializeComponent();
        }

        private void AddBookModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
