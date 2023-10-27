using System;
using System.Drawing;
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
                this.authorName.ForeColor = Color.Black;
                CustomValidation.Instance.checkTextbox(
                    this.authorName,
                    this.authorNameMsg,
                    this.nameLine,
                    new string[] { "required" }
                );
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private bool validateForm()
        {
            bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                this.authorName,
                this.authorNameMsg,
                this.nameLine,
                new string[] { "required" }
            );

            bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                this.birthYear,
                    this.birthYearMsg,
                    this.birthYearLine,
                    new string[] { "required", "positive-number", "max-current-year" }
            );


            bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                this.genderCbx,
                this.genderMsg,
                new string[] { "required" }
            );

            return isCheckTxt1 && isCheckTxt2 && isCheckCbx1;
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
                bool trangThai = this.statusSwitch.Checked;

                AuthorDTO book = new AuthorDTO(id, authorName, genderCbx, birthYear, trangThai);

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
                if (!isGenderCbx) return;

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

        private void genderCbx_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isGenderCbx)
                {
                    isGenderCbx = true;
                }
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
                    new string[] { "required", "positive-number", "max-current-year" }
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
                
                if (updateAuthor != null)
                {

                    this.authorName.Text = updateAuthor.Ten;
                    this.genderCbx.SelectedItem = updateAuthor.GioiTinh;
                    this.birthYear.Text = updateAuthor.NamSinh.ToString();
                    this.statusSwitch.Checked = updateAuthor.TrangThai;

                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }
    }
}
