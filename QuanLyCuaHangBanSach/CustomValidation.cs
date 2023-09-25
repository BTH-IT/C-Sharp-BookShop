using System;
using System.Drawing;
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
    }
}
