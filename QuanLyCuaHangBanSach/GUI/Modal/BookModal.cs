using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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

                authorList.Insert(0, new AuthorDTO(-1, "Chọn tác giả", "", 0));

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

                bookTypeList.Insert(0, new BookTypeDTO(-1, "Chọn thể loại"));

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

                publisherList.Insert(0, new PublisherDTO(-1, "Chọn nhà xuất bản", "", ""));

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
                    this.authorCbx.SelectedValue = updateBook.MaTacGia;
                    this.bookTypeCbx.SelectedValue = updateBook.MaTheLoai;
                    this.publisherCbx.SelectedValue = updateBook.MaNhaXuatBan;

                    guna2PictureBox1.Image = img;
                    guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    guna2PictureBox2.Image = img;
                }
				List<AuthDetailDTO> authDetails;
				authDetails = AuthDetailBUS.Instance.getByPositionId(MenuGUI.staff.MaChucVu.ToString());
				if (authDetails != null)
				{
                    // check quyen tac gia
					if (!authDetails.Any(c => c.maQuyenHan == 9 && c.TrangThai))
					{
						this.btnAddTacGia.Enabled = false;
					}
					else
					{
						this.btnAddTacGia.Enabled = true;
					}
                    // check quyen the loai
					if (!authDetails.Any(c => c.maQuyenHan == 4 && c.TrangThai))
					{
						this.addBookTypeBtn.Enabled = false;
					}
					else
					{
						this.addBookTypeBtn.Enabled = true;
					}
					// check quyen nha xuat ban
					if (!authDetails.Any(c => c.maQuyenHan == 5 && c.TrangThai))
					{
						this.addPublisherBtn.Enabled = false;
					}
					else
					{
						this.addPublisherBtn.Enabled = true;
					}

				}
				else
				{
					this.btnAddTacGia.Enabled = false;
                    this.addBookTypeBtn.Enabled = false;
                    this.addPublisherBtn.Enabled = false;
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

                return isBookName && isCheckCbx1 && isCheckCbx2 && isCheckCbx3 && isCheckPictureBox;
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
                decimal sellPrice = updateBook != null ? updateBook.GiaBan : 0;
                decimal importPrice = updateBook != null ? updateBook.GiaNhap : 0;
                int authorId = Convert.ToInt32(this.authorCbx.SelectedValue);
                int bookTypeId = Convert.ToInt32(this.bookTypeCbx.SelectedValue);
                int publisherId = Convert.ToInt32(this.publisherCbx.SelectedValue);

                int id = updateBook != null ? updateBook.MaSach : 0;

                BookDTO book = new BookDTO(id, bookName, img, bookTypeId, authorId, publisherId, sellPrice, importPrice);

                bool isSuccess = updateBook != null ? BookBUS.Instance.update(book) : BookBUS.Instance.insert(book);


                if (isSuccess)
                {
                    this.isSubmitSuccess = isSuccess;
                    MessageBox.Show(updateBook != null ? "Cập nhật thành công" : "Thêm mới thành công");
                    this.Close();
                    return;
                }

                this.isSubmitSuccess = isSuccess;

                MessageBox.Show(updateBook != null ? "Cập nhập thất bại" : "Thêm mới thất bại");
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

		private void addBookTypeBtn_Click(object sender, EventArgs e)
		{
			try
			{
				using (BookTypeModal BookTypeModal = new BookTypeModal())
				{
					BookTypeModal.ShowDialog();


					if (BookTypeModal.isSubmitSuccess)
					{
						loadBookTypeCbx();  
					}
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex);
			}
		}

		private void addPublisherBtn_Click(object sender, EventArgs e)
		{
			try
			{
				using (PublisherModal PublisherModal = new PublisherModal())
				{
					PublisherModal.ShowDialog();


					if (PublisherModal.isSubmitSuccess)
					{
                        loadPublisherCbx();
					}
				}
			}
			catch (Exception er)
			{

				Console.WriteLine(er);
			}
		}

		private void btnAddTacGia_Click(object sender, EventArgs e)
		{
            try
            {
				using (AuthorModal authorModal = new AuthorModal())
				{
					authorModal.ShowDialog();
					if (authorModal.isSubmitSuccess)
					{
						loadAuthorCbx();
					}
				}
			}
			catch (Exception er)
			{

				Console.WriteLine(er);
			}

		}

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gunaButton1_Click(sender, e);
            }
        }
    }
}
