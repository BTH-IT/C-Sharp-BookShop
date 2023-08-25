using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using QuanLyCuaHangBanSach.DAO;

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

        public bool checkTextboxEmptyWithMsg(TextBox txt, string placeholder, string errMsg, Label errMsgLbl, Panel line) {

            if (txt.Text.Equals(placeholder) || txt.Text == string.Empty)
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

        public bool checkTextboxWithRegex(TextBox txt, Regex regex, string errMsg, Label errMsgLbl, Panel line)
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

        public bool checkTextbox(TextBox txt, Label errMsgLbl, Panel line, string placeholder, string[] rules)
        {
            foreach (string rule in rules)
            {
                switch (rule)
                {
                    case "required":
                        if (!checkTextboxEmptyWithMsg(txt, placeholder, "Trường không được phép để trống", errMsgLbl, line))
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
