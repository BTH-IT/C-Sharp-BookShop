using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class BookTypeModal : Form
    {
        public BookTypeDTO updateBookType = null;
        private bool isTouchBookTypeCbx = false;
        private bool isTouchBookTypeTypeCbx = false;
        private bool isTouchPublisherCbx = false;
        public bool isSubmitSuccess = false;
        public BookTypeModal(string title = "Thêm thể loại")
        {
            InitializeComponent();

            this.label1.Text = title;

            this.Text = title;
        }

        private void AddBookTypeModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
            );

            if (updateBookType != null)
            {
                this.BookTypeNameTxt.Text = updateBookType.TenTheLoai;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookTypeNameTxt_TextChanged(object sender, EventArgs e)
        {
            bool isBookType = CustomValidation.Instance.checkTextbox(
                this.BookTypeNameTxt,
                this.errorBookTypeNameMsg,
                this.nameLine,
                new string[] { "required" , "name", "space" }
            );

            if (isBookType)
            {
                if (updateBookType == null)
                {
                    isBookType = CustomValidation.Instance.checkDuplicateName(
                        this.errorBookTypeNameMsg,
                        this.nameLine,
                        BookTypeBUS.Instance.checkDuplicateName(this.BookTypeNameTxt.Text)
                    );
                }
                else
                {
                    isBookType = CustomValidation.Instance.checkDuplicateName(
                        this.errorBookTypeNameMsg,
                        this.nameLine,
                        BookTypeBUS.Instance.checkDuplicateName(this.BookTypeNameTxt.Text, updateBookType.MaTheLoai)
                    );
                }
            }
        }

        private bool validateForm()
        {
            bool isBookType = CustomValidation.Instance.checkTextbox(
                this.BookTypeNameTxt,
                this.errorBookTypeNameMsg,
                this.nameLine,
                new string[] { "required", "name", "space" }
            );

            if (isBookType)
            {
                if (updateBookType == null)
                {
                    isBookType = CustomValidation.Instance.checkDuplicateName(
                        this.errorBookTypeNameMsg,
                        this.nameLine,
                        BookTypeBUS.Instance.checkDuplicateName(this.BookTypeNameTxt.Text)
                    );
                }
                else
                {
                    isBookType = CustomValidation.Instance.checkDuplicateName(
                        this.errorBookTypeNameMsg,
                        this.nameLine,
                        BookTypeBUS.Instance.checkDuplicateName(this.BookTypeNameTxt.Text, updateBookType.MaTheLoai)
                    );
                }
            }
            return isBookType;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            bool isValid = this.validateForm();

            if (!isValid) return;

            string BookTypeName = this.BookTypeNameTxt.Text;

            int id = updateBookType != null ? updateBookType.MaTheLoai : 0;

            BookTypeDTO BookType = new BookTypeDTO(id, BookTypeName);

            bool isSuccess = updateBookType != null ? BookTypeBUS.Instance.update(BookType) : BookTypeBUS.Instance.insert(BookType);


            if (isSuccess)
            {
                this.isSubmitSuccess = isSuccess;
                MessageBox.Show(updateBookType != null ? "Sửa thành công" : "Thêm thành công");
                this.Close();
                return;
            }

            this.isSubmitSuccess = isSuccess;

            MessageBox.Show(updateBookType != null ? "Sửa thất bại" : "Thêm thất bại");
        }

        private void BookTypeModal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gunaButton1_Click(sender, e);
            }
        }
    }
}
