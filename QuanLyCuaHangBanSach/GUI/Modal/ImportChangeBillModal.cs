using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using BookShop_CNPM.BUS;
using BookShop_CNPM.DTO;
using BookShop_CNPM.GUI.UserControls;
using BookShop_CNPM.GUI.Vendor;
using static Guna.UI2.Native.WinApi;

namespace BookShop_CNPM.GUI.Modal
{
    public partial class ImportChangeBillModal : Form
    {
        public bool isSubmitSuccess = false;
        public ImportChangeBillDTO importChangeBill = null;
        private int staffId, supplierID;
        public int maNhaCungCap;
        private double gia2 = 0;

        public ImportChangeBillModal(int staffId, string title = "Thêm phiếu đổi nhập hàng")
        {
            InitializeComponent();
            this.Text = title;
            this.staffId = staffId;
        }

        private void ImportChangeBillModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
               (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
               (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
           );
            ChangeBookControl.OnChangeAmount = OnChangeAmountBook;
            ChangeBookControl.OnDeleteRefundBook = DeleteRefundBook;
            ChangeBookModal.OnChangeBook = OnChangeBook;
            //CartProductImportControl.OnDeleteBook = DeleteBookList;
            if (importChangeBill != null)
            {
                label1.Text = "Xem Chi Tiết Phiếu Đổi Bán Hàng";
                panel1.Visible = false;
                this.importBillInput.Text = importChangeBill.MaDonNhapHang.ToString();
                this.importBillInput.Enabled = false;
                this.BookInput.Enabled = false;
                this.staffTxt.Text = StaffBUS.Instance.getById(staffId.ToString()).Ten;
                this.dateTimeTo.Value = importChangeBill.NgayLap;
                this.conditionTxt.Text = importChangeBill.TinhTrangSanPham;
                this.conditionTxt.Enabled = false;
                this.reasonTxt.Text = importChangeBill.LiDo;
                this.reasonTxt.Enabled = false;
                this.submitBtn.Visible = false;
                this.cancelBtn.Visible = false;
                List<ImportBillDetailDTO> importBillDetail = ImportBillBUS.Instance.getImportBillDetailList(importChangeBill.MaDonNhapHang.ToString());
                loadDataToImportBookDetail(importBillDetail);
                List<ImportChangeBillDetailDTO> importChangeBillDetail = ImportChangeBillBUS.Instance.getImportChangeBillDetailList(importChangeBill.MaPhieu.ToString());
                loadDataToBookListDetail(importChangeBillDetail);
                List<ImportChangeBillDetailDTO> bookBill = ImportChangeBillBUS.Instance.getImportChangeBillDetailList(importChangeBill.MaPhieu.ToString());
                loadDataToBookListDetail2(bookBill);
                timer1.Stop();
                timer2.Stop();
            } 
            else
            {
                this.dateTimeTo.Value = DateTime.Now;
                this.staffTxt.Text = StaffBUS.Instance.getById(staffId.ToString()).Ten;
                timer1.Start();
                timer2.Start();
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
                else if (changeBookContainer.Controls.Count <= 0 && listBookContainer.Controls.Count > 0)
                {
                    MessageBox.Show($"Hãy chọn sản phẩm cần đổi");
                    return;
                }
                else if (changeBookContainer.Controls.Count > 0 && listBookContainer.Controls.Count <= 0)
                {
                    MessageBox.Show($"Hãy chọn sản phẩm muốn đổi");
                    return;
                }
                else if (changeBookContainer.Controls.Count > listBookContainer.Controls.Count)
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

                            if (control.GetBookAmount() != control2.GetBookAmount())
                            {
                                MessageBox.Show($"Hãy chọn sản phẩm {control2.GetBookName()} bằng số lượng sản phẩm {control.GetBookName()} tại vị trí{i}");
                                return;
                            }
                        }
                    }
                }
                ImportChangeBillDTO importChangeBillBill = new ImportChangeBillDTO();

                importChangeBillBill.MaDonNhapHang = Convert.ToInt32(this.importBillInput.Text);
                importChangeBillBill.MaNhanVien = this.staffId;
                importChangeBillBill.LiDo = this.reasonTxt.Text;
                importChangeBillBill.TinhTrangSanPham = this.conditionTxt.Text;
                importChangeBillBill.NgayLap = DateTime.Now;
                ImportChangeBillDTO newImportChangeBill = ImportChangeBillBUS.Instance.insertReturnBill(importChangeBillBill);

                if (newImportChangeBill == null)
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

                                ImportChangeBillDetailDTO item = new ImportChangeBillDetailDTO(
                                    newImportChangeBill.MaPhieu,
                                    control.getId(),
                                    control2.getId(),
                                    control.GetBookAmount()
                                );

                                ImportChangeBillBUS.Instance.createImportChangeBillDetail(item);
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

        private void importBillInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<ImportBillDetailDTO> importBillDetail;
                var importBill = ImportBillBUS.Instance.getById(this.importBillInput.Text);
                if (importBill != null)
                {
                    importBillDetail = ImportBillBUS.Instance.getImportBillDetailList(importBill.MaDonNhapHang.ToString());
                    this.supplierNameTxt.Text = SupplierBUS.Instance.getById(importBill.MaNhaCungCap.ToString()).TenNhaCungCap;
                    this.supplierID = importBill.MaNhaCungCap;
                    this.maNhaCungCap = importBill.MaNhaCungCap;
                }
                else
                {
                    importBillDetail = new List<ImportBillDetailDTO>();
                    this.supplierNameTxt.Text = "";
                    this.supplierID = 0;
                    listBookContainer.Controls.Clear();
                    BookContainer.Controls.Clear();
                    BookInput.Clear();
                }
                this.loadDataToImportBookDetail(importBillDetail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void loadDataToImportBookDetail(List<ImportBillDetailDTO> importBillDetail)
        {
            try
            {
                importBookContainer.Controls.Clear();
                if (importBillDetail != null)
                {
                    foreach (ImportBillDetailDTO importBillDetailDTO in importBillDetail)
                    {
                        BookDTO book = BookBUS.Instance.getById(importBillDetailDTO.MaSach.ToString());
                        ImportBookControl control = new ImportBookControl();
                        control.details(book, importBillDetailDTO.SoLuong,1);
                        this.importBookContainer.Controls.Add(control);
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
                List<ImportChangeBillDetailDTO> listRefundBillDetail = new List<ImportChangeBillDetailDTO>();
                if (this.importBookContainer.Controls.Count > 0)
                {
                    foreach (ImportBookControl control in importBookContainer.Controls)
                    {
                        if (control.check)
                        {
                            
                            BookDTO book = BookBUS.Instance.getById(control.getId().ToString());
                            ImportChangeBillDetailDTO importRefundBillDetail = new ImportChangeBillDetailDTO(0, book.MaSach, 0, 0);
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

        private void loadDataToBookList(List<ImportChangeBillDetailDTO> list)
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
                            ImportBillDetailDTO importBillDetail = ImportBillBUS.Instance.getImportBillDetailList(this.importBillInput.Text).Where(c => c.MaSach == book.MaSach).FirstOrDefault();
                            ChangeBookControl control = new ChangeBookControl();
                            control.details(book, importBillDetail.SoLuong,1);
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

        private void loadDataToBookListDetail(List<ImportChangeBillDetailDTO> list)
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
                            ImportChangeBillDetailDTO importBillDetail = ImportChangeBillBUS.Instance.getImportChangeBillDetailList(item.MaDon.ToString()).Where(c => c.SachCanDoi == book.MaSach).FirstOrDefault();
                            ImportBookControl control = new ImportBookControl();
                            control.details(book, importBillDetail.soLuong,1);
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
                ImportBookControl importControl = importBookContainer.Controls.OfType<ImportBookControl>()
                .Where(c => c.getId().ToString() == id)
                .FirstOrDefault();
                if (importControl != null)
                {
                    importControl.UncheckStatus();
                }
                ChangeBookControl bookControl = changeBookContainer.Controls.OfType<ChangeBookControl>()
                        .Where(c => c.getId().ToString() == id)
                        .FirstOrDefault();
                changeBookContainer.Controls.Remove(bookControl);
                changeBookContainer.Refresh();
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
                Console.WriteLine(importControl.GetBookAmount());
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
                    timer2.Start();
                    if (this.changeBookContainer.Controls.Count > 0)
                    {
                        List<BookDTO> Booklist;
                        var Book = BookBUS.Instance.getById(this.BookInput.Text);
                        Console.WriteLine(Book != null);
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
                        BookUserControl control = new BookUserControl(1);
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
                List<ImportBillDetailDTO> listImportBillDetail = new List<ImportBillDetailDTO>();
                if (this.BookContainer.Controls.Count > 0)
                {
                    foreach (BookUserControl control in BookContainer.Controls)
                    {
                        if (control.check)
                        {

                            BookDTO book = BookBUS.Instance.getById(control.getId().ToString());
                            ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(0, book.MaSach, 0, 0);
                            gia2 = book.GiaNhap;
                            listImportBillDetail.Add(importBillDetail);
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

        private void loadDataToBookList2(List<ImportBillDetailDTO> list)
        {
            if (list == null) return;
            try
            {
                if (list.Count > 0)
                {
                    if (changeBookContainer.Controls.Count <= 0)
                    {
                        listBookContainer.Controls.Clear();
                        BookInput.Clear();
                        BookContainer.Controls.Clear();
                    }
                    for (int i = 0; i < this.changeBookContainer.Controls.Count; i++)
                    {
                        ChangeBookControl lastControl = (ChangeBookControl)this.changeBookContainer.Controls[i];

                        if (i != this.listBookContainer.Controls.Count)
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
                                        CartProductImportControl control = new CartProductImportControl(1);
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

        private void loadDataToBookListDetail2(List<ImportChangeBillDetailDTO> list)
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
                            ImportChangeBillDetailDTO importBillDetail = ImportChangeBillBUS.Instance.getImportChangeBillDetailList(item.MaDon.ToString()).Where(c => c.SachMuonDoi == book.MaSach).FirstOrDefault();
                            ImportBookControl control = new ImportBookControl();
                            control.details(book, importBillDetail.soLuong, 1);
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

        private void OnChangeBook(string id, int index)
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
               
                listBookContainer.Controls.Remove(bookControl);
                listBookContainer.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
