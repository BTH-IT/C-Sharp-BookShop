using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class CustomerBillModal : Form
    {
        private CustomerBillDTO customerBill;
        private List<CustomerBillDetailDTO> customerBillDetailList;
        public CustomerBillModal(int customerBillId)
        {
            InitializeComponent();

            this.customerBill = CustomerBillBUS.Instance.getById(customerBillId.ToString());
            this.customerBillDetailList = CustomerBillBUS.Instance.getCustomerBillDetail(customerBillId.ToString());
        }

        private void CustomerBillModal_Load(object sender, EventArgs e)
        {
            this.bookList.Controls.Clear();

            foreach (CustomerBillDetailDTO customerBillDetail in customerBillDetailList)
            {
                BookBill bookBill = new BookBill();

                bookBill.addData(customerBillDetail.MaSach, customerBillDetail.SoLuong, customerBillDetail.DonGia);

                this.bookList.Controls.Add(bookBill);
            }
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            using (AddBookToBillModal addBookToBillModal = new AddBookToBillModal(customerBill))
            {
                addBookToBillModal.ShowDialog();

                foreach (CustomerBillDetailDTO customerBillDetail in addBookToBillModal.selectedCustomerBillDetailList)
                {
                    Console.WriteLine(customerBillDetail.ToString());
                }
            }
        }
    }
}
