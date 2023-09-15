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
            types.Insert(0, new BookTypeDTO(0, "Tất cả"));
            TypeCb.DataSource = types;
            TypeCb.DisplayMember = "tenTheLoai";
            TypeCb.ValueMember = "maTheLoai";

            authors.Insert(0, new AuthorDTO(0, "Tất cả", "", 0));
            AuthorCb.DataSource = authors;
            AuthorCb.DisplayMember = "Ten";
            AuthorCb.ValueMember = "Ma";

            publishers.Insert(0, new PublisherDTO(0, "Tất cả", "", ""));
            PublisherCb.DataSource = publishers;
            PublisherCb.DisplayMember = "tenNhaXuatBan";
            PublisherCb.ValueMember = "maNhaXuatBan";

            TypeCb.SelectedIndex = 0;
            AuthorCb.SelectedIndex = 0;
            PublisherCb.SelectedIndex = 0;
        }

        private void TypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        public static string TypeID;
        public static string AuthorID;
        public static string PublisherID;
        public static bool ApplyClicked = false;

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Sort = PriceUpCkb.Checked ? 0 : (PriceDownCkb.Checked ? 1 : (NameAZCkb.Checked ? 2 : (NameZACkb.Checked ? 3 : -1)));
            TypeID = TypeCb.SelectedValue.ToString();
            AuthorID = AuthorCb.SelectedValue.ToString();
            PublisherID = PublisherCb.SelectedValue.ToString();
            ApplyClicked = true;
        }
    }
}
