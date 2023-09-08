using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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

        List<BookTypeDTO> types = BookTypeBUS.Instance.getAllData();
        List<AuthorDTO> authors = AuthorBUS.Instance.getAllData();
        List<PublisherDTO> publishers = PublisherBUS.Instance.getAllData();

        private void FilterUserControl_Load(object sender, EventArgs e)
        {
            foreach (var type in types)
            {
                TypeCb.Items.Add(type.TenTheLoai);    
            }
            foreach (var author in authors)
            {
                AuthorCb.Items.Add(author.Ten);
            }
            foreach (var publisher in publishers)
            {
                PublisherCb.Items.Add(publisher.TenNhaXuatBan);
            }

            TypeCb.SelectedIndex = 0;
            AuthorCb.SelectedIndex = 0;
            PublisherCb.SelectedIndex = 0;
        }

        private void TypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCb.SelectedIndex > 0)
            {
                /*Console.WriteLine(types[TypeCb.SelectedIndex - 1].MaTheLoai);*/
            }
        }

        private void AuthorCb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PublisherCb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PriceUpCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (PriceUpCkb.Checked)
            {
                PriceDownCkb.Checked = false;
                NameZACkb.Checked = false;
                NameAZCkb.Checked = false;
            }
        }

        private void PriceDownCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (PriceDownCkb.Checked)
            {
                PriceUpCkb.Checked = false;
                NameZACkb.Checked = false;
                NameAZCkb.Checked = false;
            }
        }

        private void NameAZCkb_CheckedChanged(object sender, EventArgs e)
        {
            if (NameAZCkb.Checked)
            {
                PriceUpCkb.Checked = false;
                PriceDownCkb.Checked = false;
                NameZACkb.Checked = false;
            }
        }

        private void NameZACkb_CheckedChanged(object sender, EventArgs e)
        {
            if (NameZACkb.Checked)
            {
                PriceUpCkb.Checked = false;
                PriceDownCkb.Checked = false;
                NameAZCkb.Checked = false;
            }
        }

        public static int Sort;
        public static int TypeID;
        public static int AuthorID;
        public static int PublisherID;
        public static bool ApplyClicked = false;

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Sort = PriceUpCkb.Checked ? 0 : (PriceDownCkb.Checked ? 1 : (NameAZCkb.Checked ? 2 : (NameZACkb.Checked ? 3 : -1)));
            TypeID = TypeCb.SelectedIndex > 0 ? types[TypeCb.SelectedIndex - 1].MaTheLoai : -1;
            AuthorID = AuthorCb.SelectedIndex > 0 ? authors[AuthorCb.SelectedIndex - 1].Ma : -1;
            PublisherID = PublisherCb.SelectedIndex > 0 ? publishers[PublisherCb.SelectedIndex - 1].MaNhaXuatBan : -1;
            ApplyClicked = true;
        }
    }
}
