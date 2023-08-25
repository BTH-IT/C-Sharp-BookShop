using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class AddBookModal : Form
    {
        private bool isTouchAuthorCbx = false;
        private bool isTouchBookTypeCbx = false;
        private bool isTouchPublisherCbx = false;
        public AddBookModal()
        {
            InitializeComponent();
        }

        private void loadAuthorCbx()
        {
            List<AuthorDTO> authorList = AuthorBUS.Instance.getAllData();

            authorList.Insert(0, new AuthorDTO(0, "Chọn tác giả", "", 0));

            this.authorCbx.ValueMember = "MaTacGia";
            this.authorCbx.DisplayMember = "TenTacGia";
            this.authorCbx.DataSource = authorList;

            this.authorCbx.SelectedIndex = 0;
        }

        private void loadBookTypeCbx()
        {
            List<BookTypeDTO> bookTypeList = BookTypeBUS.Instance.getAllData();

            bookTypeList.Insert(0, new BookTypeDTO(0, "Chọn thể loại"));

            this.bookTypeCbx.ValueMember = "MaTheLoai";
            this.bookTypeCbx.DisplayMember = "TenTheLoai";
            this.bookTypeCbx.DataSource = bookTypeList;
        }

        private void loadPublisherCbx()
        {
            List<PublisherDTO> publisherList = PublisherBUS.Instance.getAllData();

            publisherList.Insert(0, new PublisherDTO(0, "Chọn nhà xuất bản", "", ""));

            this.publisherCbx.ValueMember = "MaNhaXuatBan";
            this.publisherCbx.DisplayMember = "TenNhaXuatBan";
            this.publisherCbx.DataSource = publisherList;
        }

        private void AddBookModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
            );

            this.loadAuthorCbx();
            this.loadBookTypeCbx();
            this.loadPublisherCbx();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Black;

            if (this.textBox1.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.textBox1,
                    this.errorBookNameMsg,
                    this.nameLine,
                    "Nhập tên sách",
                    new string[] { "required" }
                );
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length <= 0)
            {
                this.textBox1.Text = "Nhập tên sách";
                this.textBox1.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.textBox1,
                    this.errorBookNameMsg,
                    this.nameLine,
                    "Nhập tên sách",
                    new string[] { "required" }
                );
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals("Nhập tên sách"))
            {
                this.textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.ForeColor = Color.Black;

            if (this.textBox2.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.textBox2,
                    this.errorRemainMsg,
                    this.remainLine,
                    "Nhập số lượng còn lại",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length <= 0)
            {
                this.textBox2.Text = "Nhập số lượng còn lại";
                this.textBox2.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.textBox2,
                    this.errorRemainMsg,
                    this.remainLine,
                    "Nhập số lượng còn lại",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Equals("Nhập số lượng còn lại"))
            {
                this.textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.textBox3.ForeColor = Color.Black;

            if (this.textBox3.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.textBox3,
                    this.errorSellPriceMsg,
                    this.sellPriceLine,
                    "Nhập giá bán",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (this.textBox3.Text.Length <= 0)
            {
                this.textBox3.Text = "Nhập giá bán";
                this.textBox3.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.textBox3,
                    this.errorSellPriceMsg,
                    this.sellPriceLine,
                    "Nhập giá bán",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (this.textBox3.Text.Equals("Nhập giá bán"))
            {
                this.textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.textBox4.ForeColor = Color.Black;

            if (this.textBox4.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.textBox4,
                    this.errorImportPriceMsg,
                    this.importPriceLine,
                    "Nhập giá nhập",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Length <= 0)
            {
                this.textBox4.Text = "Nhập giá nhập";
                this.textBox4.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.textBox4,
                    this.errorImportPriceMsg,
                    this.importPriceLine,
                    "Nhập giá nhập",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Equals("Nhập giá nhập"))
            {
                this.textBox4.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.textBox5.ForeColor = Color.Black;

            if (this.textBox5.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.textBox5,
                    this.errorPublishYearMsg,
                    this.publishYearLine,
                    "Nhập năm xuất bản",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (this.textBox5.Text.Length <= 0)
            {
                this.textBox5.Text = "Nhập năm xuất bản";
                this.textBox5.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.textBox5,
                    this.errorPublishYearMsg,
                    this.publishYearLine,
                    "Nhập năm xuất bản",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (this.textBox5.Text.Equals("Nhập năm xuất bản"))
            {
                this.textBox5.Text = "";
            }
        }

        private bool validateForm()
        {
            bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                this.textBox1,
                this.errorBookNameMsg,
                this.nameLine,
                "Nhập tên sách",
                new string[] {"required"}
            );

            bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                this.textBox2,
                this.errorRemainMsg,
                this.remainLine,
                "Nhập số lượng còn lại",
                new string[] { "required", "positive-number" }
            );

            bool isCheckTxt3 = CustomValidation.Instance.checkTextbox(
                this.textBox3,
                this.errorSellPriceMsg,
                this.sellPriceLine,
                "Nhập giá bán",
                new string[] { "required", "positive-number" }
            );

            bool isCheckTxt4 = CustomValidation.Instance.checkTextbox(
                this.textBox4,
                this.errorImportPriceMsg,
                this.importPriceLine,
                "Nhập giá nhập",
                new string[] { "required", "positive-number" }
            );

            bool isCheckTxt5 = CustomValidation.Instance.checkTextbox(
                this.textBox5,
                this.errorPublishYearMsg,
                this.publishYearLine,
                "Nhập năm xuất bản",
                new string[] { "required", "positive-number" }
            );

            bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                this.authorCbx,
                this.errorAuthorMsg,
                new string[] { "required"}
            );

            bool isCheckCbx2 = CustomValidation.Instance.checkCombobox(
                this.bookTypeCbx,
                this.errorBookTypeMsg,
                new string[] { "required" }
            );

            bool isCheckCbx3 = CustomValidation.Instance.checkCombobox(
                this.publisherCbx,
                this.errorPublisherMsg,
                new string[] { "required" }
            );

            bool isCheckPictureBox = CustomValidation.Instance.checkPictureBox(
                this.guna2PictureBox2,
                this.errorImageMsg,
                new string[] { "required" }
            );

            return isCheckTxt1 && isCheckTxt2 && isCheckTxt3 && isCheckTxt4
                && isCheckTxt5 && isCheckCbx1 && isCheckCbx2 && isCheckCbx3;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            bool isValid = this.validateForm();

            if (guna2PictureBox2 == null || guna2PictureBox2.Image == null)
            {
                Console.WriteLine("ssss");
            }

        }

        private void authorCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isTouchAuthorCbx) return;

            CustomValidation.Instance.checkCombobox(
                this.authorCbx,
                this.errorAuthorMsg,
                new string[] { "required" }
            );
        }

        private void bookTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isTouchBookTypeCbx) return;

            CustomValidation.Instance.checkCombobox(
                this.bookTypeCbx,
                this.errorBookTypeMsg,
                new string[] { "required" }
            );
        }

        private void publisherCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isTouchPublisherCbx) return;

            CustomValidation.Instance.checkCombobox(
                this.publisherCbx,
                this.errorPublisherMsg,
                new string[] { "required" }
            );
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;)|*.jpg;*png";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox1.Image = Image.FromFile(opf.FileName);
                guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                guna2PictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void authorCbx_Click(object sender, EventArgs e)
        {
            if (!isTouchAuthorCbx)
            {
                isTouchAuthorCbx = true;
            }
        }

        private void bookTypeCbx_Click(object sender, EventArgs e)
        {
            if (!isTouchBookTypeCbx)
            {
                isTouchBookTypeCbx = true;
            }
        }

        private void publisherCbx_Click(object sender, EventArgs e)
        {
            if (!isTouchPublisherCbx)
            {
                isTouchPublisherCbx = true;
            }
        }
    }
}
