using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.UserControls
{
    public partial class FilterUserControl : UserControl
    {
        public FilterUserControl()
        {
            InitializeComponent();
        }

        private void FilterUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void TypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(TypeCb.SelectedIndex);
        }

        private void AuthorCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(AuthorCb.SelectedIndex);
        }

        private void PublisherCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(PublisherCb.SelectedIndex);
        }
    }
}
