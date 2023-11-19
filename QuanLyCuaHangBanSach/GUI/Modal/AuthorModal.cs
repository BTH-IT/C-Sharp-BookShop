using System;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class AuthorModal : Form
    {
        public AuthorDTO updateAuthor = null;
        public bool isSubmitSuccess = false;
        public bool isGenderCbx = false;
        public AuthorModal(string title = "Thêm tác giả")
        {
            InitializeComponent();

            this.label1.Text = title;
            this.Text = title;
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookNameTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool isAuthor = CustomValidation.Instance.checkTextbox(
                    this.authorName,
                    this.authorNameMsg,
                    this.nameLine,
                    new string[] { "required", "name", "space" }
                );

                if (isAuthor)
                {
                    if (updateAuthor == null)
                    {
                        isAuthor = CustomValidation.Instance.checkDuplicateName(
                            this.authorNameMsg,
                            this.nameLine,
                            AuthorBUS.Instance.checkDuplicateName(this.authorName.Text)
                        );
                    }
                    else
                    {
                        isAuthor = CustomValidation.Instance.checkDuplicateName(
                            this.authorNameMsg,
                            this.nameLine,
                            AuthorBUS.Instance.checkDuplicateName(this.authorName.Text, updateAuthor.Ma)
                        );
                    }
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private bool validateForm()
        {
            bool isAuthor = CustomValidation.Instance.checkTextbox(
                this.authorName,
                this.authorNameMsg,
                this.nameLine,
                new string[] { "required", "name" , "space" }
            );

            if (isAuthor)
            {
                if (updateAuthor == null)
                {
                    isAuthor = CustomValidation.Instance.checkDuplicateName(
                        this.authorNameMsg,
                        this.nameLine,
                        AuthorBUS.Instance.checkDuplicateName(this.authorName.Text)
                    );
                }
                else
                {
                    isAuthor = CustomValidation.Instance.checkDuplicateName(
                        this.authorNameMsg,
                        this.nameLine,
                        AuthorBUS.Instance.checkDuplicateName(this.authorName.Text, updateAuthor.Ma)
                    );
                }
            }

            bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                this.birthYear,
                    this.birthYearMsg,
                    this.birthYearLine,
                    new string[] { "required", "positive-number", "max-curent-year", "space" }
            );


            bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                this.genderCbx,
                this.genderMsg,
                new string[] { "required" }
            );

            return isAuthor && isCheckTxt2 && isCheckCbx1;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = this.validateForm();
                if (!isValid) return;

                string authorName = this.authorName.Text;
                int birthYear = Convert.ToInt32(this.birthYear.Text);
                string genderCbx = this.genderCbx.SelectedItem.ToString();
                int id = updateAuthor != null ? updateAuthor.Ma : 0;

                AuthorDTO book = new AuthorDTO(id, authorName, genderCbx, birthYear);

                bool isSuccess = updateAuthor != null ? AuthorBUS.Instance.update(book) : AuthorBUS.Instance.insert(book);

                if (isSuccess)
                {
                    this.isSubmitSuccess = isSuccess;
                    MessageBox.Show(updateAuthor != null ? "Update Success" : "Insert Success");
                    this.Close();
                    return;
                }
                this.isSubmitSuccess = isSuccess;
                MessageBox.Show(updateAuthor != null ? "Update Failure" : "Insert Failure");
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void genderCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CustomValidation.Instance.checkCombobox(
                    this.genderCbx,
                    this.genderMsg,
                    new string[] { "required" }
                );
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void birthYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.birthYear.ForeColor = Color.Black;

                CustomValidation.Instance.checkTextbox(
                    this.birthYear,
                    this.birthYearMsg,
                    this.birthYearLine,
                    new string[] { "required", "positive-number", "max-current-year" , "space" }
                );
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void AuthorModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(
                        (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                        (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
                    );
                this.genderCbx.SelectedIndex = 0;
                genderCbx.SelectedIndexChanged += this.genderCbx_SelectedIndexChanged;  
                if (updateAuthor != null)
                {

                    this.authorName.Text = updateAuthor.Ten;
                    this.genderCbx.SelectedItem = updateAuthor.GioiTinh;
                    this.birthYear.Text = updateAuthor.NamSinh.ToString();

                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }
    }
}
