using BookShop_CNPM.BUS;
using BookShop_CNPM.DTO;
using BookShop_CNPM.GUI.UserControls;
using BookShop_CNPM.GUI.Vendor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_CNPM.GUI.Modal
{
    public partial class ChangeBookModal : Form
    {
        public static Action<string,int> OnChangeBook;
        public int priceBook = 0;
        public int index = 0;
        public int mode = 0;


        public ChangeBookModal(int mode=0)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void BookInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(BookInput.Text !="")
                {
                    List<BookDTO> Booklist;
                    var Book = BookBUS.Instance.getById(this.BookInput.Text);
                    if (Book != null)
                    {
                        Booklist = BookBUS.Instance.getBookList(Book.MaSach.ToString());
                        this.loadDataToBook(Booklist);
                    }
                    else
                    {
                        MessageBox.Show("Không có sản phẩm");
                        BookInput.Clear();
                        BookContainer.Controls.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void loadDataToBook(List<BookDTO> Booklist)
        {
            try
            {
                BookContainer.Controls.Clear();
                if (Booklist != null)
                {
                    foreach (BookDTO bookDTO in Booklist)
                    {
                        BookDTO book = BookBUS.Instance.getById(bookDTO.MaSach.ToString());
                        BookUserControl control = new BookUserControl(mode);
                        control.details(book);
                        this.BookContainer.Controls.Add(control);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private bool validate()
        {
            try
            {

                bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                        this.BookInput,
                        this.errorBookInputMsg,
                        this.BookInputLine,
                        new string[] { "required" }
                );

                return isCheckTxt1;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool isValid = this.validate();
            if (!isValid) return;

            BookUserControl lastControl = (BookUserControl)BookContainer.Controls[0];
            if (priceBook== lastControl.GetPrice())
            {
                ChangeBookModal.OnChangeBook(this.BookInput.Text, index);
                this.Close();
            }
            else
            {
                MessageBox.Show($"Hãy chọn sản phẩm đổi cùng giá ({priceBook})");
                BookInput.Clear();
                BookContainer.Controls.Clear();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
