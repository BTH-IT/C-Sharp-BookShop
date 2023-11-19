using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;

namespace QuanLyCuaHangBanSach
{
    public class CustomValidation
    {
        private static CustomValidation instance;

        public static CustomValidation Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomValidation();
                }

                return CustomValidation.instance;
            }
            private set { CustomValidation.instance = value; }
        }

        public CustomValidation() { }

        public bool checkTextboxEmptyWithMsg(Guna2TextBox txt, string errMsg, Label errMsgLbl, Panel line) {

            if (txt.Text == string.Empty)
            {
                errMsgLbl.Text = errMsg;
                line.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                errMsgLbl.Text = "";
                line.BackColor = Color.FromArgb(45, 212, 191);
            }
            return true;
        }

        public bool checkDuplicateName(Label errMsgLbl, Panel line, bool isDuplicate, string errMsg = "Tên đã có trong hệ thống")
        {

            if (isDuplicate)
            {
                errMsgLbl.Text = errMsg;
                line.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                errMsgLbl.Text = "";
                line.BackColor = Color.FromArgb(45, 212, 191);
            }
            return true;
        }


        public bool checkTextboxMax(Guna2TextBox txt, string errMsg, Label errMsgLbl, Panel line, int max)
        {

            if (int.TryParse(txt.Text, out int result) && result > max)
            {
                errMsgLbl.Text = errMsg;
                line.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                errMsgLbl.Text = "";
                line.BackColor = Color.FromArgb(45, 212, 191);
            }
            return true;
        }

        public bool checkTextboxMin(Guna2TextBox txt, string errMsg, Label errMsgLbl, Panel line, int min)
        {

            if (int.TryParse(txt.Text, out int result) && result < min)
            {
                errMsgLbl.Text = errMsg;
                line.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                errMsgLbl.Text = "";
                line.BackColor = Color.FromArgb(45, 212, 191);
            }
            return true;
        }

        public bool checkTextboxMatchWithOtherTextBox(Guna2TextBox txt1, Guna2TextBox txt2, string errMsg, Label errMsgLbl, Panel line)
        {
            if (!txt1.Text.Equals(txt2.Text))
            {
                errMsgLbl.Text = errMsg;
                line.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                errMsgLbl.Text = "";
                line.BackColor = Color.FromArgb(45, 212, 191);
            }
            return true;
        }

        public bool checkTextboxWithRegex(Guna2TextBox txt, Regex regex, string errMsg, Label errMsgLbl, Panel line)
        {
            if (!regex.IsMatch(txt.Text.ToString().Trim()))
            {
                errMsgLbl.Text = errMsg;
                line.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                errMsgLbl.Text = "";
                line.BackColor = Color.FromArgb(45, 212, 191);
            }

            return true;
        }

        public bool checkTextbox(Guna2TextBox txt, Label errMsgLbl, Panel line, string[] rules)
        {
            foreach (string rule in rules)
            {
                Console.WriteLine(rule);
                switch (rule)
                {
                    case "required":
                        if (!checkTextboxEmptyWithMsg(txt, "Trường không được phép để trống", errMsgLbl, line))
                        {
                            return false;
                        }
                        break;
                    case "positive-number":
                        if (!checkTextboxWithRegex(txt, new Regex("^\\d+$"), "Trường này phải là một số dương", errMsgLbl, line))
                        {
                            return false;
                        }
                        break;
                    case "max-current-year":
                        int currentYear = DateTime.Now.Year;
                        if (int.TryParse(txt.Text, out int result) && result > currentYear)
                        {
                            errMsgLbl.Text = "Trường này không được lớn hơn " + currentYear;
                            line.BackColor = Color.FromArgb(239, 68, 68);
                            return false; 
                        }
                        else
                        {
                            errMsgLbl.Text = "";
                            line.BackColor = Color.FromArgb(45, 212, 191);
                        }
                        break;
                    case "email":
                        if (!checkTextboxWithRegex(txt, new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"), "Trường này phải là một email", errMsgLbl, line))
                        {
                            return false;
                        }
                        break;
                    case "phone-number":
                        if (!checkTextboxWithRegex(txt,new Regex("^0(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$"),"Trường này phải là một số điện thoại",errMsgLbl,line))
                        {
                            return false;
                        }
                        break;
                    case "custom-supplier-required":
						if (!checkTextboxEmptyWithMsg(txt, "Vui lòng chọn Nhà Cung cấp qua Phiếu nhập", errMsgLbl, line))
						{
							return false;
						}
						break;
                    case "name":
                        if (!checkTextboxWithRegex(txt, new Regex("^[^\\d!@#\\$%^&*()_+={}\\[\\]:;<>,.?/~\\\\-]*$"), "Không được chứa số/kí tự đặc biệt", errMsgLbl, line))
                        {
                            return false;
                        }
                        break;
                    case "space":
                        if (!checkDuplicateName(errMsgLbl, line, string.IsNullOrWhiteSpace(txt.Text) || txt.Text.Trim() == "" || txt.Text.Trim() != txt.Text, "Không được chứa số/kí tự đặc biệt\nKhông được có khoảng trắng đầu cuối"))
                        {
                            return false;
                        }
                        break;
                    case "password":
                        string password = txt.Text;
                        bool checkSpecificChar = password.Any(char.IsPunctuation) || password.Any(char.IsSymbol);
						if (password.Length < 6 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !checkSpecificChar)
                        {
								errMsgLbl.Text = "Mật khẩu phải dài hơn 6.Chứa các kí tự đặc biệt,số,\nin hoa,in thường";
								line.BackColor = Color.FromArgb(239, 68, 68);
								return false;
                        }
                        else
                        {
							errMsgLbl.Text = "";
							line.BackColor = Color.FromArgb(45, 212, 191);
                        } 
                        break;
                    case "age-restrict-staff":
                        if(int.TryParse(txt.Text.ToString(),out  result))
                        {
                            int currentYearN = DateTime.Now.Year;
							int age = currentYearN - result;
							if (age >= 18 && age <= 60)
                            {
								errMsgLbl.Text = "";
								line.BackColor = Color.FromArgb(45, 212, 191);
                            }
                            else
                            {
								errMsgLbl.Text = "Tuổi nhân viên từ 18 đến 60 tuổi";
								line.BackColor = Color.FromArgb(239, 68, 68);
								return false;
							}    

                        }
                        else
                        {
							errMsgLbl.Text = "Tuổi không hợp lệ";
							line.BackColor = Color.FromArgb(239, 68, 68);
							return false;
						}  
                        break;
					case "age-restrict-customer":
						if (int.TryParse(txt.Text.ToString(), out result))
						{
							int currentYearN = DateTime.Now.Year;
                            int age = currentYearN - result;
							if (age >= 14 && age <= 100)
							{
								errMsgLbl.Text = "";
								line.BackColor = Color.FromArgb(45, 212, 191);
							}
							else
							{
								errMsgLbl.Text = "Tuổi khách phải từ 14 tuổi đến 100 tuổi ";
								line.BackColor = Color.FromArgb(239, 68, 68);
								return false;
							}

						}
						else
						{
							errMsgLbl.Text = "Tuổi không hợp lệ";
							line.BackColor = Color.FromArgb(239, 68, 68);
							return false;
						}
						break;

				}
            }

            return true;
        }

        public bool checkComboboxEmptyWithMsg(GunaComboBox cbx, string errMsg, Label errMsgLbl)
        {

            if (cbx.SelectedIndex == 0)
            {
                errMsgLbl.Text = errMsg;
                cbx.BorderColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                errMsgLbl.Text = "";
                cbx.BorderColor = Color.FromArgb(45, 212, 191);
            }
            return true;
        }

        public bool checkCombobox(GunaComboBox cbx, Label errMsgLbl, string[] rules)
        {
            foreach (string rule in rules)
            {
                switch (rule)
                {
                    case "required":
                        if (!checkComboboxEmptyWithMsg(cbx, "Trường không được phép để trống", errMsgLbl))
                        {
                            return false;
                        }
                        break;
                }
            }

            return true;
        }

        public bool checkPictureBox(Guna2PictureBox pic, Label errMsgLbl, string[] rules)
        {
            foreach (string rule in rules)
            {
                switch (rule)
                {
                    case "required":
                        if (pic == null || pic.Image == null)
                        {
                            errMsgLbl.Text = "Trường không được phép để trống";
                            return false;
                        }
                        else
                        {
                            errMsgLbl.Text = "";
                        }
                        break;
                }
            }

            return true;
        }

        public bool checkDateTimePicker(GunaDateTimePicker guna, Label errorLabel, string[] requirements, DateTime dateTimeToCompare, string errorMessage = null)
        {
            try
            {
               
                foreach (string rule in requirements)
                {
					DateTime dateTime1 = new DateTime(guna.Value.Year, guna.Value.Month, guna.Value.Day, guna.Value.Hour, guna.Value.Minute, guna.Value.Second);
					DateTime dateTime2 = new DateTime(dateTimeToCompare.Year, dateTimeToCompare.Month, dateTimeToCompare.Day, dateTimeToCompare.Hour, dateTimeToCompare.Minute, dateTimeToCompare.Second);
					switch (rule)
                    {
                        case "after":
							if (DateTime.Compare(dateTime1, dateTime2) > 0)
                            {
                                errorLabel.Text = "";
                                return true;
                            }
                            else
                            {

                                errorLabel.Text = errorMessage != null ? errorMessage : "Ngày giờ phải lớn hơn thời gian hiện tại";
                                return false;
                            }
                        case "before":
                            if (DateTime.Compare(guna.Value, dateTimeToCompare) <= 0)
                            {
                                errorLabel.Text = "";
                                return true;
                            }
                            else
                            {

                                errorLabel.Text = errorMessage != null ? errorMessage : "Ngày giờ phải nhỏ hơn hoặc bằng thời gian hiện tại";
                                return false;
                            }
                        default:
                            return false;
                    }
                }
            }
            catch
            {

            }

            return false;
        }
    }
}
