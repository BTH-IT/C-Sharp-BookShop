using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class BookModal : Form
    {
        public BookDTO updateBook = null;
        public bool isSubmitSuccess = false;
        public BookModal(string title = "Thêm sách")
        {
            InitializeComponent();

            this.label1.Text = title;

            this.Text = title;
        }

        private void loadAuthorCbx()
        {
            try
            {
                List<AuthorDTO> authorList = AuthorBUS.Instance.getAllData();

                authorList.Insert(0, new AuthorDTO(0, "Chọn tác giả", "", 0));

                this.authorCbx.ValueMember = "Ma";
                this.authorCbx.DisplayMember = "Ten";
                this.authorCbx.DataSource = authorList;

                this.authorCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadBookTypeCbx()
        {
            try
            {
                List<BookTypeDTO> bookTypeList = BookTypeBUS.Instance.getAllData();

                bookTypeList.Insert(0, new BookTypeDTO(0, "Chọn thể loại"));

                this.bookTypeCbx.ValueMember = "MaTheLoai";
                this.bookTypeCbx.DisplayMember = "TenTheLoai";
                this.bookTypeCbx.DataSource = bookTypeList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadPublisherCbx()
        {
            try
            {
                List<PublisherDTO> publisherList = PublisherBUS.Instance.getAllData();

                publisherList.Insert(0, new PublisherDTO(0, "Chọn nhà xuất bản", "", ""));

                this.publisherCbx.ValueMember = "MaNhaXuatBan";
                this.publisherCbx.DisplayMember = "TenNhaXuatBan";
                this.publisherCbx.DataSource = publisherList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AddBookModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(
                        (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                        (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
                    );

                this.loadAuthorCbx();
                this.loadBookTypeCbx();
                this.loadPublisherCbx();

                authorCbx.SelectedIndexChanged += authorCbx_SelectedIndexChanged;
                bookTypeCbx.SelectedIndexChanged += bookTypeCbx_SelectedIndexChanged;
                publisherCbx.SelectedIndexChanged += publisherCbx_SelectedIndexChanged;

                if (updateBook != null)
                {
                    MemoryStream ms = new MemoryStream(updateBook.HinhAnh);
                    Image img = Image.FromStream(ms);

                    this.bookNameTxt.Text = updateBook.TenSach;
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookNameTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool isBookName = CustomValidation.Instance.checkTextbox(
                    this.bookNameTxt,
                    this.errorBookNameMsg,
                    this.nameLine,
                    new string[] { "required" , "name", "space" }
                );

                if (isBookName)
                {
                    if (updateBook == null)
                    {
                        isBookName = CustomValidation.Instance.checkDuplicateName(
                            this.errorBookNameMsg,
                            this.nameLine,
                            BookBUS.Instance.checkDuplicateName(this.bookNameTxt.Text)
                        );
                    }
                    else
                    {
                        isBookName = CustomValidation.Instance.checkDuplicateName(
                            this.errorBookNameMsg,
                            this.nameLine,
                            BookBUS.Instance.checkDuplicateName(this.bookNameTxt.Text, updateBook.MaSach)
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void sellPriceTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool isSellPriceValid = CustomValidation.Instance.checkTextbox(
                    this.sellPriceTxt,
                    this.errorSellPriceMsg,
                    this.sellPriceLine,
                    new string[] { "required", "positive-number" , "space" }
                );
                if(isSellPriceValid)
                {
                    isSellPriceValid = CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(sellPriceTxt, importPriceTxt, "Giá bán phải lớn hơn giá nhập", errorSellPriceMsg, sellPriceLine, "after");
                }    
                CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(importPriceTxt, sellPriceTxt, "Giá nhập phải nhỏ hơn giá bán", this.errorImportPriceMsg, importPriceLine, "before");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void importPriceTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.importPriceTxt.ForeColor = Color.Black;

                bool isImportPriceValid =CustomValidation.Instance.checkTextbox(
                    this.importPriceTxt,
                    this.errorImportPriceMsg,
                    this.importPriceLine,
                    new string[] { "required", "positive-number", "space" }
                );
                if(isImportPriceValid)
                {
                    isImportPriceValid = CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(importPriceTxt,sellPriceTxt,  "Giá nhập phải nhỏ hơn giá bán", this.errorImportPriceMsg , importPriceLine, "before");
                }
                CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(sellPriceTxt, importPriceTxt, "Giá bán phải lớn hơn giá nhập", errorSellPriceMsg, sellPriceLine, "after");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        
        private void publishYearTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.publishYearTxt.ForeColor = Color.Black;

                CustomValidation.Instance.checkTextbox(
                    this.publishYearTxt,
                    this.errorPublishYearMsg,
                    this.publishYearLine,
                    new string[] { "required", "positive-number", "max-current-year", "space" }
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private bool validateForm()
        {
            try
            {
                bool isBookName = CustomValidation.Instance.checkTextbox(
                    this.bookNameTxt,
                    this.errorBookNameMsg,
                    this.nameLine,
                    new string[] { "required" , "name", "space" }
                );

                if (isBookName)
                {
                    if (updateBook == null)
                    {
                        isBookName = CustomValidation.Instance.checkDuplicateName(
                            this.errorBookNameMsg,
                            this.nameLine,
                            BookBUS.Instance.checkDuplicateName(this.bookNameTxt.Text)
                        );
                    }
                    else
                    {
                        isBookName = CustomValidation.Instance.checkDuplicateName(
                            this.errorBookNameMsg,
                            this.nameLine,
                            BookBUS.Instance.checkDuplicateName(this.bookNameTxt.Text, updateBook.MaSach)
                        );
                    }
                }

                bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                    this.sellPriceTxt,
                    this.errorSellPriceMsg,
                    this.sellPriceLine,
                    new string[] { "required", "positive-number", "space" }
                );
                if(isCheckTxt2)
                {
                    isCheckTxt2 = CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(sellPriceTxt, importPriceTxt, "Giá bán phải lớn hơn giá nhập", errorSellPriceMsg, sellPriceLine, "after");
				}
                bool isCheckTxt3 = CustomValidation.Instance.checkTextbox(
                    this.importPriceTxt,
                    this.errorImportPriceMsg,
                    this.importPriceLine,
                    new string[] { "required", "positive-number", "space" }
                );
                if(isCheckTxt3)
                {
                    isCheckTxt3 = CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(importPriceTxt, sellPriceTxt, "Giá nhập phải nhỏ hơn giá bán", this.errorImportPriceMsg, importPriceLine, "before");
				}
                bool isCheckTxt4 = CustomValidation.Instance.checkTextbox(
                    this.publishYearTxt,
                    this.errorPublishYearMsg,
                    this.publishYearLine,
                    new string[] { "required", "positive-number", "max-current-year", "space" }
                );

                bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                    this.authorCbx,
                    this.errorAuthorMsg,
                    new string[] { "required" }
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

                return isBookName && isCheckTxt2 && isCheckTxt3 && isCheckTxt4
                && isCheckCbx1 && isCheckCbx2 && isCheckCbx3 && isCheckPictureBox;
            }
            catch (Exception ex)
            {
                return false;
            }

            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = this.validateForm();

                if (!isValid) return;

                MemoryStream ms = new MemoryStream();

                guna2PictureBox2.Image.Save(ms, guna2PictureBox2.Image.RawFormat);

                byte[] img = ms.ToArray();

                string bookName = this.bookNameTxt.Text;
                decimal sellPrice = Convert.ToDecimal(this.sellPriceTxt.Text);
                decimal importPrice = Convert.ToDecimal(this.importPriceTxt.Text);
                int publishYear = Convert.ToInt32(this.publishYearTxt.Text);
                int authorId = Convert.ToInt32(this.authorCbx.SelectedValue);
                int bookTypeId = Convert.ToInt32(this.bookTypeCbx.SelectedValue);
                int publisherId = Convert.ToInt32(this.publisherCbx.SelectedValue);

                int id = updateBook != null ? updateBook.MaSach : 0;

                BookDTO book = new BookDTO(id, bookName, img, bookTypeId, authorId, publisherId, sellPrice, importPrice, publishYear);

                bool isSuccess = updateBook != null ? BookBUS.Instance.update(book) : BookBUS.Instance.insert(book);


                if (isSuccess)
                {
                    this.isSubmitSuccess = isSuccess;
                    MessageBox.Show(updateBook != null ? "Sửa sách thành công" : "Tạo sách thành công");
                    this.Close();
                    return;
                }

                this.isSubmitSuccess = isSuccess;

                MessageBox.Show(updateBook != null ? "Sửa sách thất bại" : "Tạo sách thất bại");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void authorCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CustomValidation.Instance.checkCombobox(
                    this.authorCbx,
                    this.errorAuthorMsg,
                    new string[] { "required" }
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void bookTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CustomValidation.Instance.checkCombobox(
                    this.bookTypeCbx,
                    this.errorBookTypeMsg,
                    new string[] { "required" }
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void publisherCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CustomValidation.Instance.checkCombobox(
                    this.publisherCbx,
                    this.errorPublisherMsg,
                    new string[] { "required" }
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void authorCbx_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
	}
}
