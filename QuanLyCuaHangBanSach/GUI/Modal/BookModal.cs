using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Markup;
using Guna.UI2.WinForms.Suite;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using static Guna.UI2.Native.WinApi;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class BookModal : Form
    {
        public BookDTO updateBook = null;
        private bool isTouchAuthorCbx = false;
        private bool isTouchBookTypeCbx = false;
        private bool isTouchPublisherCbx = false;
        public bool isSubmitSuccess = false;
        public BookModal(string title = "Thêm sách")
        {
            InitializeComponent();

            this.label1.Text = title;

            this.Text = title;
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

            if (updateBook != null)
            {
                MemoryStream ms = new MemoryStream(updateBook.HinhAnh);
                Image img = Image.FromStream(ms);

                this.bookNameTxt.Text = updateBook.TenSach;
                this.remainTxt.Text = updateBook.SoLuongConLai.ToString();
                this.sellPriceTxt.Text = updateBook.GiaBan.ToString();
                this.importPriceTxt.Text = updateBook.GiaNhap.ToString();
                this.publishYearTxt.Text = updateBook.NamXuatBan.ToString();
                this.authorCbx.SelectedValue = updateBook.MaTacGia;
                this.bookTypeCbx.SelectedValue = updateBook.MaTheLoai;
                this.publisherCbx.SelectedValue = updateBook.MaNhaXuatBan;

                guna2PictureBox1.Image = img;
                guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                guna2PictureBox2.Image = img;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.bookNameTxt.ForeColor = Color.Black;

            if (this.bookNameTxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.bookNameTxt,
                    this.errorBookNameMsg,
                    this.nameLine,
                    "Nhập tên sách",
                    new string[] { "required" }
                );
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.bookNameTxt.Text.Length <= 0)
            {
                this.bookNameTxt.Text = "Nhập tên sách";
                this.bookNameTxt.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.bookNameTxt,
                    this.errorBookNameMsg,
                    this.nameLine,
                    "Nhập tên sách",
                    new string[] { "required" }
                );
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (this.bookNameTxt.Text.Equals("Nhập tên sách"))
            {
                this.bookNameTxt.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.remainTxt.ForeColor = Color.Black;

            if (this.remainTxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.remainTxt,
                    this.errorRemainMsg,
                    this.remainLine,
                    "Nhập số lượng còn lại",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (this.remainTxt.Text.Length <= 0)
            {
                this.remainTxt.Text = "Nhập số lượng còn lại";
                this.remainTxt.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.remainTxt,
                    this.errorRemainMsg,
                    this.remainLine,
                    "Nhập số lượng còn lại",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (this.remainTxt.Text.Equals("Nhập số lượng còn lại"))
            {
                this.remainTxt.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.sellPriceTxt.ForeColor = Color.Black;

            if (this.sellPriceTxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.sellPriceTxt,
                    this.errorSellPriceMsg,
                    this.sellPriceLine,
                    "Nhập giá bán",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (this.sellPriceTxt.Text.Length <= 0)
            {
                this.sellPriceTxt.Text = "Nhập giá bán";
                this.sellPriceTxt.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.sellPriceTxt,
                    this.errorSellPriceMsg,
                    this.sellPriceLine,
                    "Nhập giá bán",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (this.sellPriceTxt.Text.Equals("Nhập giá bán"))
            {
                this.sellPriceTxt.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.importPriceTxt.ForeColor = Color.Black;

            if (this.importPriceTxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.importPriceTxt,
                    this.errorImportPriceMsg,
                    this.importPriceLine,
                    "Nhập giá nhập",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (this.importPriceTxt.Text.Length <= 0)
            {
                this.importPriceTxt.Text = "Nhập giá nhập";
                this.importPriceTxt.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.importPriceTxt,
                    this.errorImportPriceMsg,
                    this.importPriceLine,
                    "Nhập giá nhập",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (this.importPriceTxt.Text.Equals("Nhập giá nhập"))
            {
                this.importPriceTxt.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.publishYearTxt.ForeColor = Color.Black;

            if (this.publishYearTxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.publishYearTxt,
                    this.errorPublishYearMsg,
                    this.publishYearLine,
                    "Nhập năm xuất bản",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (this.publishYearTxt.Text.Length <= 0)
            {
                this.publishYearTxt.Text = "Nhập năm xuất bản";
                this.publishYearTxt.ForeColor = Color.LightGray;

                CustomValidation.Instance.checkTextbox(
                    this.publishYearTxt,
                    this.errorPublishYearMsg,
                    this.publishYearLine,
                    "Nhập năm xuất bản",
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (this.publishYearTxt.Text.Equals("Nhập năm xuất bản"))
            {
                this.publishYearTxt.Text = "";
            }
        }

        private bool validateForm()
        {
            bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                this.bookNameTxt,
                this.errorBookNameMsg,
                this.nameLine,
                "Nhập tên sách",
                new string[] {"required"}
            );

            bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                this.remainTxt,
                this.errorRemainMsg,
                this.remainLine,
                "Nhập số lượng còn lại",
                new string[] { "required", "positive-number" }
            );

            bool isCheckTxt3 = CustomValidation.Instance.checkTextbox(
                this.sellPriceTxt,
                this.errorSellPriceMsg,
                this.sellPriceLine,
                "Nhập giá bán",
                new string[] { "required", "positive-number" }
            );

            bool isCheckTxt4 = CustomValidation.Instance.checkTextbox(
                this.importPriceTxt,
                this.errorImportPriceMsg,
                this.importPriceLine,
                "Nhập giá nhập",
                new string[] { "required", "positive-number" }
            );

            bool isCheckTxt5 = CustomValidation.Instance.checkTextbox(
                this.publishYearTxt,
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
                && isCheckTxt5 && isCheckCbx1 && isCheckCbx2 && isCheckCbx3 && isCheckPictureBox;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            bool isValid = this.validateForm();

            if (!isValid) return;

            MemoryStream ms = new MemoryStream();

            guna2PictureBox2.Image.Save(ms, guna2PictureBox2.Image.RawFormat);

            byte[] img = ms.ToArray();

            string bookName = this.bookNameTxt.Text;
            int remain = Convert.ToInt32(this.remainTxt.Text);
            double sellPrice = Convert.ToInt32(this.sellPriceTxt.Text);
            double importPrice = Convert.ToInt32(this.importPriceTxt.Text);
            int publishYear = Convert.ToInt32(this.publishYearTxt.Text);
            int authorId = Convert.ToInt32(this.authorCbx.SelectedValue);
            int bookTypeId = Convert.ToInt32(this.bookTypeCbx.SelectedValue);
            int publisherId = Convert.ToInt32(this.publisherCbx.SelectedValue);

            int id = updateBook != null ? updateBook.MaSach : 0;

            BookDTO book = new BookDTO(id, bookName, img, bookTypeId, authorId, publisherId,
                remain, sellPrice, importPrice, publishYear);

            bool isSuccess = updateBook != null ? BookBUS.Instance.update(book) : BookBUS.Instance.insert(book);


            if (isSuccess)
            {
                this.isSubmitSuccess = isSuccess;
                MessageBox.Show(updateBook != null ? "Update Success" : "Insert Success");
                this.Close();
                return;
            }

            this.isSubmitSuccess = isSuccess;

            MessageBox.Show(updateBook != null ? "Update Failure" : "Insert Failure");
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
