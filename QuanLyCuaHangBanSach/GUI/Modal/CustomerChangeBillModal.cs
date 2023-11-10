using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using BookShop_CNPM.BUS;
using BookShop_CNPM.DTO;
using BookShop_CNPM.GUI.UserControls;
using BookShop_CNPM.GUI.Vendor;
using static Guna.UI2.Native.WinApi;

namespace BookShop_CNPM.GUI.Modal
{
    public partial class CustomerChangeBillModal : Form
    {
        public bool isSubmitSuccess = false;
        public CustomerChangeBillDTO customerChangeBill = null;
        private int staffId, customerID;
        public int maKhachHang;
        private double gia2=0;

        public CustomerChangeBillModal(int staffId, string title = "Thêm phiếu đổi bán hàng")
        {
            InitializeComponent();
            this.Text = title;
            this.staffId = staffId;
        }

        private void CustomerChangeBillModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
               (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
               (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
            );
            ChangeBookControl.OnChangeAmount = OnChangeAmountBook;
            ChangeBookControl.OnDeleteRefundBook = DeleteRefundBook;
            ChangeBookModal.OnChangeBook = OnChangeBook;
            //CartProductImportControl.OnDeleteBook = DeleteBookList;
            if (customerChangeBill != null)
            {
                label1.Text = "Xem Chi Tiết Đơn Nhập Hàng Thay Đổi";
                panel1.Visible= false;
                this.customerBillInput.Text = customerChangeBill.MaDonKhachHang.ToString();
                this.customerBillInput.Enabled = false;
                this.BookInput.Enabled = false;
                this.staffTxt.Text = StaffBUS.Instance.getById(staffId.ToString()).Ten;
                this.dateTimeTo.Value = customerChangeBill.NgayLap;
                this.conditionTxt.Text = customerChangeBill.TinhTrangSanPham;
                this.conditionTxt.Enabled = false;
                this.reasonTxt.Text = customerChangeBill.LiDo;
                this.reasonTxt.Enabled = false;
                this.submitBtn.Visible = false;
                this.cancelBtn.Visible = false;
                List<CustomerBillDetailDTO> customerBillDetail = CustomerBillBUS.Instance.getCustomerBillDetailList(customerChangeBill.MaDonKhachHang.ToString());
                loadDataToImportBookDetail(customerBillDetail);
                List<CustomerChangeBillDetailDTO> customerChangeBillDetail = CustomerChangeBillBUS.Instance.getCustomerChangeBillDetailList(customerChangeBill.MaPhieu.ToString());
                loadDataToBookListDetail(customerChangeBillDetail);
                List<CustomerChangeBillDetailDTO> bookBill = CustomerChangeBillBUS.Instance.getCustomerChangeBillDetailList(customerChangeBill.MaPhieu.ToString());
                loadDataToBookListDetail2(bookBill);
                timer1.Stop();
                timer2.Stop();
            }
            else
            {
                this.dateTimeTo.Value = DateTime.Now;
                this.staffTxt.Text = StaffBUS.Instance.getById(staffId.ToString()).Ten;
                timer1.Start();
            }
        }

        private bool validate()
        {
            try
            {

                bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                        this.reasonTxt,
                        this.errorReasonMsg,
                        this.reasonLine,
                        new string[] { "required" }
                );

                bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                        this.conditionTxt,
                        this.errorConditionMsg,
                        this.conditionLine,
                        new string[] { "required" }
                );

                return isCheckTxt1 && isCheckTxt2;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = this.validate();

                if (!isValid) return;
                if (changeBookContainer.Controls.Count <= 0 && listBookContainer.Controls.Count <= 0)
                {
                    MessageBox.Show($"Hãy chọn sản phẩm cần đổi và muốn đổi");
                    return;
                }
                else if(changeBookContainer.Controls.Count<=0 && listBookContainer.Controls.Count > 0)
                {
                    MessageBox.Show($"Hãy chọn sản phẩm cần đổi");
                    return;
                }
                else if (changeBookContainer.Controls.Count > 0 && listBookContainer.Controls.Count <= 0)
                {
                    MessageBox.Show($"Hãy chọn sản phẩm muốn đổi");
                    return;
                }
                else if(changeBookContainer.Controls.Count > listBookContainer.Controls.Count)
                {
                    MessageBox.Show($"Số lượng sản phẩm muốn đổi ít hơn số lượng cần đổi");
                    return;
                }

                for (int i = 0; i < this.changeBookContainer.Controls.Count; i++)
                {
                    ChangeBookControl control = (ChangeBookControl)this.changeBookContainer.Controls[i];

                    for (int j = 0; j < this.listBookContainer.Controls.Count; j++)
                    {
                        if (i == j)
                        {
                            CartProductImportControl control2 = (CartProductImportControl)this.listBookContainer.Controls[j];

                            if (control.GetBookAmount()!=control2.GetBookAmount())
                            {
                                MessageBox.Show($"Hãy chọn sản phẩm {control2.GetBookName()} bằng số lượng sản phẩm {control.GetBookName()} tại vị trí {i+1}");
                                return;
                            }    
                        }
                    }
                }
                CustomerChangeBillDTO customerChangeBillBill = new CustomerChangeBillDTO();
                customerChangeBillBill.MaDonKhachHang = Convert.ToInt32(this.customerBillInput.Text);
                customerChangeBillBill.NgayLap = DateTime.Now;
                customerChangeBillBill.LiDo = this.reasonTxt.Text;
                customerChangeBillBill.TinhTrangSanPham = this.conditionTxt.Text;
                customerChangeBillBill.MaNhanVien = this.staffId;

                CustomerChangeBillDTO newCustomerChangeBill = CustomerChangeBillBUS.Instance.insertReturnBill(customerChangeBillBill);

                if (newCustomerChangeBill == null)
                {

                    MessageBox.Show("Failure");
                    this.isSubmitSuccess = false;
                }
                else
                {
                    for (int i = 0; i < this.changeBookContainer.Controls.Count; i++)
                    {
                        ChangeBookControl control = (ChangeBookControl)this.changeBookContainer.Controls[i];

                        for (int j = 0; j < this.listBookContainer.Controls.Count; j++)
                        {
                            if (i == j)
                            {
                                CartProductImportControl control2 = (CartProductImportControl)this.listBookContainer.Controls[j];

                                CustomerChangeBillDetailDTO item = new CustomerChangeBillDetailDTO(
                                    newCustomerChangeBill.MaPhieu,
                                    control.getId(),
                                    control2.getId(),
                                    control.GetBookAmount()
                                );

                                CustomerChangeBillBUS.Instance.createCustomerChangeBillDetail(item);
                            }
                        }
                    }

                    MessageBox.Show("Success");

                    this.isSubmitSuccess = true;
                    this.Close();
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

        private void reasonTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                        this.reasonTxt,
                        this.errorReasonMsg,
                        this.reasonLine,
                        new string[] { "required" }
                );
        }

        private void conditionTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                        this.conditionTxt,
                        this.errorConditionMsg,
                        this.conditionLine,
                        new string[] { "required" }
                );
        }

        private void customerBillInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDetailDTO> customerBillDetail;
                var customerBill = CustomerBillBUS.Instance.getById(this.customerBillInput.Text);
                if (customerBill != null)
                {
                    customerBillDetail = CustomerBillBUS.Instance.getCustomerBillDetailList(customerBill.MaDonKhachHang.ToString());
                    var customer = CustomerBUS.Instance.getById(customerBill.MaKhachHang.ToString());
                    this.customerNameTxt.Text = customer != null ? customer.Ten : "Vãn lai";
                    this.customerID = customer != null ? customer.Ma : 0;
                    this.maKhachHang = customer != null ? customer.Ma : 0; 
                }
                else
                {
                    customerBillDetail = new List<CustomerBillDetailDTO>();
                    this.customerNameTxt.Text = "";
                    this.customerID = 0;
                    timer2.Start();
                    listBookContainer.Controls.Clear();
                    BookContainer.Controls.Clear();
                    BookInput.Clear();
                }
                this.loadDataToImportBookDetail(customerBillDetail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void loadDataToImportBookDetail(List<CustomerBillDetailDTO> customerBillDetail)
        {
            try
            {
                customerBookContainer.Controls.Clear();
                if (customerBillDetail != null)
                {
                    foreach (CustomerBillDetailDTO customerBillDetailDTO in customerBillDetail)
                    {
                        BookDTO book = BookBUS.Instance.getById(customerBillDetailDTO.MaSach.ToString());
                        ImportBookControl control = new ImportBookControl();
                        control.details(book, customerBillDetailDTO.SoLuong,0);
                        this.customerBookContainer.Controls.Add(control);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                List<CustomerChangeBillDetailDTO> listRefundBillDetail = new List<CustomerChangeBillDetailDTO>();
                if (this.customerBookContainer.Controls.Count > 0)
                {
                    foreach (ImportBookControl control in customerBookContainer.Controls)
                    {
                        if (control.check)
                        {

                            BookDTO book = BookBUS.Instance.getById(control.getId().ToString());
                            CustomerChangeBillDetailDTO importRefundBillDetail = new CustomerChangeBillDetailDTO(0, book.MaSach, 0, 0);
                            listRefundBillDetail.Add(importRefundBillDetail);
                        }
                    }
                }
                loadDataToBookList(listRefundBillDetail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void loadDataToBookList(List<CustomerChangeBillDetailDTO> list)
        {
            if (list == null) return;
            try
            {
                if (list.Count > 0)
                {

                    foreach (var item in list)
                    {
                        BookDTO book = BookBUS.Instance.getById(item.SachCanDoi.ToString());
                        Type targetType = typeof(ChangeBookControl);
                        List<ChangeBookControl> bookControls = changeBookContainer.Controls.OfType<ChangeBookControl>()
                                                                .Where(i => targetType.IsAssignableFrom(i.GetType()))
                                                                .ToList();
                        if (!bookControls.Any(a => a.getId() == book.MaSach))
                        {
                            CustomerBillDetailDTO customerBillDetail = CustomerBillBUS.Instance.getCustomerBillDetailList(this.customerBillInput.Text).Where(c => c.MaSach == book.MaSach).FirstOrDefault();
                            ChangeBookControl control = new ChangeBookControl();
                            control.details(book, customerBillDetail.SoLuong,0);
                            this.changeBookContainer.Controls.Add(control);
                        };
                    }
                }
                else
                {
                    changeBookContainer.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void loadDataToBookListDetail(List<CustomerChangeBillDetailDTO> list)
        {

            if (list == null) return;
            try
            {
                if (list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        BookDTO book = BookBUS.Instance.getById(item.SachCanDoi.ToString());
                        Type targetType = typeof(ImportBookControl);
                        List<ImportBookControl> bookControls = changeBookContainer.Controls.OfType<ImportBookControl>()
                                                                .Where(i => targetType.IsAssignableFrom(i.GetType()))
                                                                .ToList();
                        if (!bookControls.Any(a => a.getId() == book.MaSach))
                        {
                            CustomerChangeBillDetailDTO customerBillDetail = CustomerChangeBillBUS.Instance.getCustomerChangeBillDetailList(item.MaDon.ToString()).Where(c => c.SachCanDoi == book.MaSach).FirstOrDefault();
                            ImportBookControl control = new ImportBookControl();
                            control.details(book, customerBillDetail.soLuong,0);
                            this.changeBookContainer.Controls.Add(control);
                        };
                    }
                }
                else
                {
                    changeBookContainer.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DeleteRefundBook(string id)
        {
            try
            {
                ImportBookControl importControl = customerBookContainer.Controls.OfType<ImportBookControl>()
                .Where(c => c.getId().ToString() == id)
                .FirstOrDefault();
                if (importControl != null)
                {
                    importControl.UncheckStatus();
                }
                ChangeBookControl bookControl = changeBookContainer.Controls.OfType<ChangeBookControl>()
                        .Where(c => c.getId().ToString() == id)
                        .FirstOrDefault();
                int index = changeBookContainer.Controls.IndexOf(bookControl);
                changeBookContainer.Controls.Remove(bookControl);
                listBookContainer.Controls.RemoveAt(index);
                changeBookContainer.Refresh();
                listBookContainer.Refresh();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void OnChangeAmountBook(string id)
        {
            try
            {
                ChangeBookControl importControl = changeBookContainer.Controls.OfType<ChangeBookControl>()
                .Where(c => c.getId().ToString() == id)
                .FirstOrDefault();
                int index = changeBookContainer.Controls.IndexOf(importControl);
                CartProductImportControl lastControl = (CartProductImportControl)this.listBookContainer.Controls[index];
                lastControl.ChangeAmountBook(importControl.GetBookAmount());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BookInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BookInput.Text != "")
                {
                    if (this.changeBookContainer.Controls.Count > 0)
                    {
                        timer2.Start();
                        List<BookDTO> Booklist;
                        var Book = BookBUS.Instance.getById(this.BookInput.Text);
                        if (Book != null)
                        {
                            Booklist = BookBUS.Instance.getBookList(Book.MaSach.ToString());
                            this.loadDataToBook(Booklist);
                        }
                        else
                        {
                            timer2.Stop();
                            MessageBox.Show("Không có sản phẩm");
                            BookInput.Clear();
                            BookContainer.Controls.Clear();
                        }
                    }
                    else
                    {
                        timer2.Stop();
                        MessageBox.Show("Hãy chọn sản phẩm cần đổi trước");
                        BookInput.Clear();
                        BookContainer.Controls.Clear();
                    }
                }
                else
                {
                    List<BookDTO> Booklist = new List<BookDTO>();
                    this.loadDataToBook(Booklist);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void loadDataToBook(List<BookDTO> Booklist)
        {
            try
            {
                BookContainer.Controls.Clear();
                if (Booklist != null)
                {
                    foreach (BookDTO bookDTO in Booklist)
                    {
                        BookDTO book = BookBUS.Instance.getById(bookDTO.MaSach.ToString());
                        BookUserControl control = new BookUserControl(0);
                        control.details(book);
                        this.BookContainer.Controls.Add(control);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDetailDTO> listImportBillDetail = new List<CustomerBillDetailDTO>();
                if (this.BookContainer.Controls.Count > 0)
                {
                    foreach (BookUserControl control in BookContainer.Controls)
                    {
                        if (control.check)
                        {
                            BookDTO book = BookBUS.Instance.getById(control.getId().ToString());
                            CustomerBillDetailDTO customerBillDetail = new CustomerBillDetailDTO(0, book.MaSach, 0, 0);
                            gia2=book.GiaBan;
                            listImportBillDetail.Add(customerBillDetail);
                        }
                    }
                }
                loadDataToBookList2(listImportBillDetail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void loadDataToBookList2(List<CustomerBillDetailDTO> list)
        {
            if (list == null) return;
            try
            {
                if (list.Count > 0)
                {
                    if (changeBookContainer.Controls.Count <= 0)
                    {
                        MessageBox.Show("Hãy chọn sản phẩm cần đổi trước");
                        listBookContainer.Controls.Clear();
                        BookInput.Clear();
                        BookContainer.Controls.Clear();
                        return;
                    }
                    for (int i = 0; i < this.changeBookContainer.Controls.Count; i++)
                    {
                        ChangeBookControl lastControl = (ChangeBookControl)this.changeBookContainer.Controls[i];

                        if (i != this.listBookContainer.Controls.Count )
                        {
                            continue;
                        }
                        if (i == this.listBookContainer.Controls.Count)
                        {
                            if (lastControl.getPrice() == gia2)
                            {
                                foreach (var item in list)
                                {
                                    BookDTO book = BookBUS.Instance.getById(item.MaSach.ToString());
                                    Type targetType = typeof(CartProductImportControl);
                                    List<CartProductImportControl> bookControls = listBookContainer.Controls.OfType<CartProductImportControl>()
                                                                            .Where(k => targetType.IsAssignableFrom(k.GetType()))
                                                                            .ToList();
                                    if (!bookControls.Any(a => a.getId() == book.MaSach))
                                    {
                                        CartProductImportControl control = new CartProductImportControl(0);
                                        control.details(book, lastControl.GetBookAmount());
                                        this.listBookContainer.Controls.Add(control);
                                        int index = listBookContainer.Controls.IndexOf(control);
                                        control.setIndex(index);
                                    };
                                }
                                BookInput.Clear();
                                BookContainer.Controls.Clear();
                                timer2.Stop();
                                break;
                            }
                            else
                            {
                                timer2.Stop();
                                MessageBox.Show("Hãy chọn sản phẩm đổi cùng giá");
                                BookInput.Clear();
                                BookContainer.Controls.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void loadDataToBookListDetail2(List<CustomerChangeBillDetailDTO> list)
        {
            if (list == null) return;
            try
            {
                if (list.Count > 0)
                {

                    foreach (var item in list)
                    {
                        BookDTO book = BookBUS.Instance.getById(item.SachMuonDoi.ToString());
                        Type targetType = typeof(ImportBookControl);
                        List<ImportBookControl> bookControls = listBookContainer.Controls.OfType<ImportBookControl>()
                                                                .Where(i => targetType.IsAssignableFrom(i.GetType()))
                                                                .ToList();
                        if (!bookControls.Any(a => a.getId() == book.MaSach))
                        {
                            CustomerChangeBillDetailDTO importBillDetail = CustomerChangeBillBUS.Instance.getCustomerChangeBillDetailList(item.MaDon.ToString()).Where(c => c.SachMuonDoi == book.MaSach).FirstOrDefault();
                            ImportBookControl control = new ImportBookControl();
                            control.details(book, importBillDetail.soLuong,0);
                            this.listBookContainer.Controls.Add(control);
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void OnChangeBook(string id,int index)
        {
            try
            {
                ChangeBookControl lastControl = (ChangeBookControl)this.changeBookContainer.Controls[index];
                BookDTO book = BookBUS.Instance.getById(id);
                Type targetType = typeof(CartProductImportControl);
                List<CartProductImportControl> bookControls = listBookContainer.Controls.OfType<CartProductImportControl>()
                                                        .Where(k => targetType.IsAssignableFrom(k.GetType()))
                                                        .ToList();
                if (!bookControls.Any(a => a.getId() == book.MaSach))
                {
                    CartProductImportControl control = (CartProductImportControl)this.listBookContainer.Controls[index];
                    control.details(book, lastControl.GetBookAmount());
                    control.setIndex(index);
                    listBookContainer.Refresh();
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã có trong danh sách đổi. Vui lòng chọn sản phẩm thay đổi khác");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DeleteBookList(string id)
        {
            try
            {
                BookUserControl bookChangeControl = BookContainer.Controls.OfType<BookUserControl>()
                .Where(c => c.getId().ToString() == id)
                .FirstOrDefault();
                if (bookChangeControl != null)
                {
                    bookChangeControl.UncheckStatus();
                }
                CartProductImportControl bookControl = listBookContainer.Controls.OfType<CartProductImportControl>()
                        .Where(c => c.getId().ToString() == id)
                        .FirstOrDefault();
                int index = listBookContainer.Controls.IndexOf(bookControl);
                listBookContainer.Controls.Remove(bookControl);
                changeBookContainer.Controls.RemoveAt(index);
                listBookContainer.Refresh();
                changeBookContainer.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
