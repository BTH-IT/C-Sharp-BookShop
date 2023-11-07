using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class PublisherModal : Form
    {
        public PublisherDTO updatePublisher = null;
        public bool isSubmitSuccess = false;
        public bool isGenderCbx = false;
        public PublisherModal(string title = "Thêm nhà xuất bản")
        {
            InitializeComponent();
            this.label1.Text = title;
            this.Text = title;

            this.Publishertxt.TextChanged += Publishertxt_TextChanged;
            this.addressTxt.TextChanged += addressTxt_TextChanged;
            this.phoneNumbertxt.TextChanged += phoneNumbertxt_TextChanged;
        }

        private void bookNameTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool isPublisher = CustomValidation.Instance.checkTextbox(
                    this.Publishertxt,
                    this.PublisherNameMsg,
                    this.nameLine,
                    new string[] { "required" }
                );

                if (isPublisher)
                {
                    CustomValidation.Instance.checkDuplicateName(
                        this.PublisherNameMsg,
                        this.nameLine,
                        PublisherBUS.Instance.checkDuplicateName(this.Publishertxt.Text)
                    );
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private bool validateForm()
        {
            try
            {
                bool isPublisher = CustomValidation.Instance.checkTextbox(
                    this.Publishertxt,
                    this.PublisherNameMsg,
                    this.nameLine,
                    new string[] { "required" }
                );

                if (isPublisher)
                {
                    CustomValidation.Instance.checkDuplicateName(
                        this.PublisherNameMsg,
                        this.nameLine,
                        PublisherBUS.Instance.checkDuplicateName(this.Publishertxt.Text)
                    );
                }

                bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                        this.phoneNumbertxt,
                        this.phoneNumberMsg,
                        this.phoneNumberLine,
                        new string[] { "required", "positive-number" }
                );

                bool isCheckTxt3 = CustomValidation.Instance.checkTextbox(
                        this.addressTxt,
                        this.addressMsg,
                        this.addressLine,
                        new string[] { "required" }
                    );



                return isPublisher && isCheckTxt2 && isCheckTxt3;
            }
            catch (Exception)
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

                string PublisherName = this.Publishertxt.Text;
                string phoneNumbertxt = this.phoneNumbertxt.Text;
                string addressTxt = this.addressTxt.Text;

                int id = updatePublisher != null ? updatePublisher.MaNhaXuatBan : 0;
                bool trangThai = this.statusSwitch.Checked;

                PublisherDTO book = new PublisherDTO(id, PublisherName, addressTxt, phoneNumbertxt, trangThai);

                bool isSuccess = updatePublisher != null ? PublisherBUS.Instance.update(book) : PublisherBUS.Instance.insert(book);


                if (isSuccess)
                {
                    this.isSubmitSuccess = isSuccess;
                    MessageBox.Show(updatePublisher != null ? "Update Success" : "Insert Success");
                    this.Close();
                    return;
                }

                this.isSubmitSuccess = isSuccess;

                MessageBox.Show(updatePublisher != null ? "Update Failure" : "Insert Failure");
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
                this.phoneNumbertxt.ForeColor = Color.Black;

                if (this.phoneNumbertxt.Text.Length > 0)
                {
                    CustomValidation.Instance.checkTextbox(
                        this.phoneNumbertxt,
                        this.phoneNumberMsg,
                        this.phoneNumberLine,
                        new string[] { "required", "positive-number" }
                    );
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void PublisherModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(
                       (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                       (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
                   );
                if (updatePublisher != null)
                {

                    this.Publishertxt.Text = updatePublisher.TenNhaXuatBan;
                    this.addressTxt.Text = updatePublisher.DiaChi;
                    this.phoneNumbertxt.Text = updatePublisher.SoDienThoai;
                    this.statusSwitch.Checked = updatePublisher.TrangThai;
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Publishertxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.Publishertxt,
                this.PublisherNameMsg,
                this.nameLine,
                new string[] { "required" }
            );
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.addressTxt,
                this.addressMsg,
                this.addressLine,
                new string[] { "required" }
            );
        }

        private void phoneNumbertxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.phoneNumbertxt,
                this.phoneNumberMsg,
                this.phoneNumberLine,
                new string[] { "required", "phone-number" }
            );
        }

		private void statusSwitch_CheckedChanged(object sender, EventArgs e)
		{
			if (this.statusSwitch.Checked)
			{
				this.statusSwitch.CheckedState.FillColor = Color.FromArgb(45, 210, 192);
			}
		}
    }
}
