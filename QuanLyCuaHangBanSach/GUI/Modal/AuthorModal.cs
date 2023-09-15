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
            this.authorName.ForeColor = Color.Black;

            if (this.authorName.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.authorName,
                    this.authorNameMsg,
                    this.nameLine,
                    new string[] { "required" }
                );
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
                    new string[] { "required", "positive-number" }
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


        private void genderCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isGenderCbx) return;

            CustomValidation.Instance.checkCombobox(
                this.genderCbx,
                this.genderMsg,
                new string[] { "required" }
            );
        }




        private void genderCbx_Click(object sender, EventArgs e)
        {
            if (!isGenderCbx)
            {
                isGenderCbx = true;
            }
        }

        private void birthYear_TextChanged(object sender, EventArgs e)
        {
            this.birthYear.ForeColor = Color.Black;

            if (this.birthYear.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.birthYear,
                    this.birthYearMsg,
                    this.birthYearLine,
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void AuthorModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
            );
            this.genderCbx.SelectedItem = 0;
            if (updateAuthor != null)
            {

                this.authorName.Text = updateAuthor.Ten;
                this.genderCbx.SelectedItem = updateAuthor.GioiTinh;
                this.birthYear.Text = updateAuthor.NamSinh.ToString();

            }
        }
    }
}
