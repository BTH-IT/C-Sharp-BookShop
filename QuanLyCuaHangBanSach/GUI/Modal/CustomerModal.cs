using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class CustomerModal : Form
    {
        public CustomerDTO currentCustomer = null;
        public bool isSubmitSuccess = false;
        public CustomerModal(string title = "Thêm khách hàng")
        {
            InitializeComponent();
            this.title.Text = title;    
            this.Text = title;
            
        }
   

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           if(this.validateForm())
            {
               string customerName = this.customerNameTxtBox.Text;
               int birthYear = Convert.ToInt32(this.birthYearTxtBox.Text);
               string phoneNumber = this.phoneNumberTxtBox.Text;
               string gender = this.genderCbx.SelectedItem.ToString();
               int id = this.currentCustomer != null ? currentCustomer.Ma : 0;

               CustomerDTO customer = new CustomerDTO(maKhachHang: id, tenKhachHang: customerName,soDienThoai:phoneNumber,gioiTinh:gender,namSinh: birthYear);
                
                bool isSuccess = currentCustomer != null ? CustomerBUS.Instance.update(customer) : CustomerBUS.Instance.insert(customer);

                if (isSuccess)
                {
                    this.isSubmitSuccess = isSuccess;
                    MessageBox.Show(id != 0 ? "Cập nhật thành công" : "Thêm dữ liệu thành công");
                    this.Close();
                    return;
                }    
                
            }
                
   
        }
        private void CustomerModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
            );

            string[] genders = { "Chọn giới tính", "Nam", "Nữ" };
            this.genderCbx.Items.AddRange(genders);
            this.genderCbx.SelectedItem = genders[0];

            if (currentCustomer != null)
            {
                this.customerNameTxtBox.Text = currentCustomer.Ten;
                this.phoneNumberTxtBox.Text = currentCustomer.SoDienThoai;
                this.birthYearTxtBox.Text= currentCustomer.NamSinh.ToString();  
                this.genderCbx.Text = currentCustomer.GioiTinh == "Nam" ? genders[1] : genders[2];
            }    
        }
        private bool validateForm()
        {
            bool isCustomerNameValid = CustomValidation.Instance.checkTextbox(
                    this.customerNameTxtBox,
                    this.errorCustomerNameMsg,
                    this.customerNameLine,
                    new string[] { "required" }
                );
            bool isBirthYearValid = CustomValidation.Instance.checkTextbox(
                   this.birthYearTxtBox,
                   this.errorBirthYearMsg,
                   this.birthYearLine,
                   new string[] { "required" , "positive-number" }  
                );
            bool isPhoneNumberValid = CustomValidation.Instance.checkTextbox(
                   this.phoneNumberTxtBox,
                   this.errorPhoneNumberMsg,
                   this.phoneNumberLine,
                   new string[] { "required" ,"phone-number" }
                );
            bool isGenderValid = CustomValidation.Instance.checkCombobox(
                    this.genderCbx,
                    this.errorGenderMsg,
                    new string[] {"required"}
                ); 
            return isBirthYearValid && isCustomerNameValid && isGenderValid && isPhoneNumberValid;
        }
    }
}
