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
            this.BookTypeNameTxt.ForeColor = Color.Black;

            if (this.BookTypeNameTxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.BookTypeNameTxt,
                    this.errorBookTypeNameMsg,
                    this.nameLine,
                    new string[] { "required" }
                );
            }
        }

        private bool validateForm()
        {
            bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                this.BookTypeNameTxt,
                this.errorBookTypeNameMsg,
                this.nameLine,
                new string[] { "required" }
            );
            return isCheckTxt1;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            bool isValid = this.validateForm();

            if (!isValid) return;

            string BookTypeName = this.BookTypeNameTxt.Text;

            int id = updateBookType != null ? updateBookType.MaTheLoai : 0;
            bool trangThai = false;

            BookTypeDTO BookType = new BookTypeDTO(id, BookTypeName, trangThai);

            bool isSuccess = updateBookType != null ? BookTypeBUS.Instance.update(BookType) : BookTypeBUS.Instance.insert(BookType);


            if (isSuccess)
            {
                this.isSubmitSuccess = isSuccess;
                MessageBox.Show(updateBookType != null ? "Update Success" : "Insert Success");
                this.Close();
                return;
            }

            this.isSubmitSuccess = isSuccess;

            MessageBox.Show(updateBookType != null ? "Update Failure" : "Insert Failure");
        }
    }
}
