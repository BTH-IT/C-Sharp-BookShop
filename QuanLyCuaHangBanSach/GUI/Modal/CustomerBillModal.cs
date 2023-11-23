using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class CustomerBillModal : Form
    {
        public bool isSubmitSuccess = false;
        private List<CustomerBillDetailDTO> customerBillDetailList = new List<CustomerBillDetailDTO>();
        private int staffId;
        private decimal salePrice = 0;
        private int diemConLai = 0;
        public CustomerBillModal(int staffId)
        {
            InitializeComponent();

            this.staffId = staffId;
            customerBillDetailList = new List<CustomerBillDetailDTO>();
        }

        private void loadCustomerCbx()
        {
            try
            {
                List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

                customerList.Insert(0, new CustomerDTO(-1, "Chọn khách hàng", "", 0, "Chọn khách hàng", 0));
                customerList.Insert(1, new CustomerDTO(0, "Vãng lai", "", 0, "Vãng lai", 0));

                this.customerCbx.ValueMember = "Ma";
                this.customerCbx.DisplayMember = "Ten";
                this.customerCbx.DataSource = customerList;

                this.customerCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadSaleCbx()
        {
            try
            {
                List<SaleDTO> saleList = SaleBUS.Instance.getAllNotExpired() == null ? new List<SaleDTO>() : SaleBUS.Instance.getAllNotExpired();

                saleList.Insert(0, new SaleDTO(-1, "Chọn khuyến mãi", 0, new DateTime(), new DateTime()));
                saleList.Insert(1, new SaleDTO(0, "Không có khuyến mãi", 0, new DateTime(), new DateTime()));

                this.saleCbx.ValueMember = "MaKhuyenMai";
                this.saleCbx.DisplayMember = "TenKhuyenMai";
                this.saleCbx.DataSource = saleList;

                this.saleCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void calculateTotal(decimal total)
        {
            try
            {
                if (this.saleCbx.SelectedIndex != 1 && this.saleCbx.SelectedIndex != 0)
                {
                    int phanTram = SaleBUS.Instance.getById(this.saleCbx.SelectedValue.ToString()).PhanTram;

                    this.percentTxt.Text = phanTram + "%";

                    salePrice = total * (phanTram / Convert.ToDecimal(100.0));

                    salePrice = Convert.ToDecimal(salePrice.ToString().Split('.')[0]);
                }
                else
                {
                    this.percentTxt.Text = "Không có";
                    this.totalPriceTxt.Text = total + "";
                    salePrice = 0;
                }

                int diem = 0;

                if (this.customerCbx.SelectedIndex != 1 && this.customerCbx.SelectedIndex != 0)
                {
                    diem = CustomerBUS.Instance.getById(this.customerCbx.SelectedValue.ToString()).Diem;
                    scoreTxt.Text = diem + " điểm";
                    if (diem <= 0)
                    {
                        this.PointToggleBtn.Enabled = false;
                    } else
                    {
                        this.PointToggleBtn.Enabled = true;
                    }
                }
                else
                {
                    scoreTxt.Text = diem + " điểm";
                }

                if (total - salePrice <= 0)
                {
                    this.totalPriceTxt.Text = "0";
                    total = 0;
                }
                else
                {
                    this.totalPriceTxt.Text = (total - salePrice) + "";
                    total = Convert.ToDecimal(this.totalPriceTxt.Text);
                }

                if (this.customerCbx.SelectedIndex != 1 && this.customerCbx.SelectedIndex != 0 && this.PointToggleBtn.Checked)
                {
                    scoreTxt.Text = 0 + " điểm";
                    decimal scorePrice = diem * 1000;

                    if (total - scorePrice <= 0)
                    {
                        if ((total - scorePrice) % 1000 > 0)
                        {
                            decimal roundedUp = Math.Sign(total - scorePrice) * (decimal)(Math.Ceiling(Math.Abs(total - scorePrice) / 1000) * 1000) + 1000;
                            diemConLai = Convert.ToInt32(-1 * roundedUp / 1000);
                        } else
                        {
                            diemConLai = Convert.ToInt32(-1 * (total - scorePrice) / 1000);
                        }
                        
                        scoreTxt.Text = diemConLai + " điểm";
                        this.totalPriceTxt.Text = "0";
                    }
                    else
                    {
                        this.totalPriceTxt.Text = (total - scorePrice) + "";
                        diemConLai = 0;
                        scoreTxt.Text = diemConLai + " điểm";
                    }
                }
                else
                {
                    this.totalPriceTxt.Text = total + "";
                    diemConLai = 0;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void getTotalPriceWhenChangeSaleAndCustomer()
        {
            decimal total = 0;
            foreach (CustomerBillDetailDTO customerBillDetail in customerBillDetailList)
            {
                total += customerBillDetail.SoLuong * customerBillDetail.DonGia;
            }

            calculateTotal(total);
        }

        private void loadCustomerBillDetailList()
        {
            try
            {
                this.bookList.Controls.Clear();

                decimal total = 0;

                foreach (CustomerBillDetailDTO customerBillDetail in customerBillDetailList)
                {
                    BookBill bookBill = new BookBill();

                    total += customerBillDetail.SoLuong * customerBillDetail.DonGia;

                    bookBill.addData(customerBillDetail.MaSach, customerBillDetail.SoLuong, customerBillDetail.DonGia);

                    int remain = BookBUS.Instance.getById(customerBillDetail.MaSach.ToString()).SoLuongConLai;

                    bookBill.plus.Enabled = remain != customerBillDetail.SoLuong;
                    bookBill.minus.Enabled = 1 != customerBillDetail.SoLuong;

                    bookBill.close.MouseClick += (object sender, MouseEventArgs e) =>
                    {
                        this.bookList.Controls.Remove(bookBill);

                        this.customerBillDetailList.Remove(customerBillDetail);

                        this.loadCustomerBillDetailList();
                    };

                    bookBill.plus.MouseClick += (object sender, MouseEventArgs e) =>
                    {
                        bookBill.minus.Enabled = true;

                        int amount = Convert.ToInt32(bookBill.amountInput.Text.ToString());

                        if (amount < remain)
                        {
                            bookBill.plus.Enabled = true;
                            bookBill.amountInput.Text = (amount + 1).ToString();

                            int idx = this.customerBillDetailList.FindIndex(
                                book => book.MaSach == customerBillDetail.MaSach
                            );

                            this.customerBillDetailList[idx].SoLuong = amount + 1;

                            total += customerBillDetail.DonGia;

                            calculateTotal(total);

                            if (amount == remain) bookBill.plus.Enabled = false;
                        }
                        else
                        {
                            bookBill.plus.Enabled = false;
                        }
                    };

                    bookBill.minus.MouseClick += (object sender, MouseEventArgs e) =>
                    {
                        bookBill.plus.Enabled = true;

                        int amount = Convert.ToInt32(bookBill.amountInput.Text.ToString());

                        int idx = this.customerBillDetailList.FindIndex(
                            book => book.MaSach == customerBillDetail.MaSach
                        );

                        if (amount <= 2)
                        {
                            bookBill.minus.Enabled = false;
                        }
                        else
                        {
                            bookBill.minus.Enabled = true;
                        }

                        bookBill.amountInput.Text = (amount - 1).ToString();

                        this.customerBillDetailList[idx].SoLuong = amount - 1;

                        total -= customerBillDetail.DonGia;

                        calculateTotal(total);
                    };

                    bookBill.amountInput.MouseLeave += (object sender, EventArgs e) =>
                    {
                        try
                        {
                            this.ActiveControl = null;

                            Regex isNum = new Regex(@"^\d+$");

                            int idx = this.customerBillDetailList.FindIndex(
                                book => book.MaSach == customerBillDetail.MaSach
                            );

                            if (!isNum.IsMatch(bookBill.amountInput.Text))
                            {
                                bookBill.amountInput.Text = this.customerBillDetailList[idx].SoLuong.ToString();
                                MessageBox.Show("Số lượng là một số");
                                return;
                            }

                            int amount = Convert.ToInt32(bookBill.amountInput.Text.ToString());

                            if (amount < 1 || amount > remain || this.customerBillDetailList[idx].SoLuong == amount)
                            {
                                bookBill.amountInput.Text = this.customerBillDetailList[idx].SoLuong.ToString();
                                return;
                            }

                            if (amount == 1) bookBill.minus.Enabled = false;
                            else bookBill.minus.Enabled = true;

                            if (amount == remain) bookBill.plus.Enabled = false;
                            else bookBill.minus.Enabled = true;

                            total -= this.customerBillDetailList[idx].SoLuong * customerBillDetail.DonGia;

                            this.customerBillDetailList[idx].SoLuong = amount;

                            total += this.customerBillDetailList[idx].SoLuong * customerBillDetail.DonGia;

                            calculateTotal(total);
                        }
                        catch
                        {
                            MessageBox.Show("Số lượng là một số");
                        }
                    };

                    bookBill.amountInput.KeyPress += (object sender, KeyPressEventArgs e) =>
                    {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                    };

                    this.bookList.Controls.Add(bookBill);
                }

                calculateTotal(total);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void CustomerBillModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.loadCustomerCbx();
                this.loadSaleCbx();
                this.loadCustomerBillDetailList();

                this.saleCbx.SelectedIndexChanged += this.saleCbx_SelectedIndexChanged;
                this.customerCbx.SelectedIndexChanged += this.customerCbx_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDetailDTO> copiedList = new List<CustomerBillDetailDTO>();
                copiedList.AddRange(customerBillDetailList);
                using (AddBookToCustomerBillModal addBookToBillModal = new AddBookToCustomerBillModal(copiedList))
                {
                    addBookToBillModal.ShowDialog();

                    if (addBookToBillModal.isSaved)
                    {
                        customerBillDetailList = new List<CustomerBillDetailDTO>(addBookToBillModal.selectedCustomerBillDetailList);

                    } else
                    {
                        customerBillDetailList = new List<CustomerBillDetailDTO>(addBookToBillModal.prevSelectedCustomerBillDetailList);
                    }
                    this.loadCustomerBillDetailList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private bool validate()
        {
            try
            {
                bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                        this.customerCbx,
                        this.errorCustomerMsg,
                        new string[] { "required" }
                    );

                bool isCheckCbx2 = CustomValidation.Instance.checkCombobox(
                    this.saleCbx,
                    this.errorSaleMsg,
                    new string[] { "required" }
                );

                if (this.customerBillDetailList.Count <= 0)
                {
                    this.errorBookListMsg.Text = "Danh sách sản phẩm không được để trống";
                    return false;
                }
                else
                {
                    this.errorBookListMsg.Text = "";
                }

                return isCheckCbx1 && isCheckCbx2;
            }
            catch (Exception ex)
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

                CustomerBillDTO customerBill = new CustomerBillDTO();
                CustomerDTO customer = CustomerBUS.Instance.getById(this.customerCbx.SelectedValue.ToString());

                customerBill.TongTien = Convert.ToDecimal(this.totalPriceTxt.Text);
                customerBill.TienKhachDua = Convert.ToDecimal(this.totalPriceTxt.Text);
                customerBill.PhanTramKhuyenMai = this.saleCbx.SelectedIndex != 1 ? SaleBUS.Instance.getById(this.saleCbx.SelectedValue.ToString()).PhanTram : 0;
                customerBill.MaNhanVien = this.staffId;
                customerBill.MaKhachHang = Convert.ToInt32(this.customerCbx.SelectedValue);
                customerBill.MaKhuyenMai = Convert.ToInt32(this.saleCbx.SelectedValue);
                customerBill.NgayLap = DateTime.Now;
                customerBill.DoiDiem = 
                    this.customerCbx.SelectedIndex != 1 && this.customerCbx.SelectedIndex != 0 && this.PointToggleBtn.Checked
                    ? diemConLai > 0 ? customer.Diem - diemConLai : customer.Diem : 0;

                CustomerBillDTO newCustomerBill = CustomerBillBUS.Instance.insertReturnBill(customerBill);

                if (newCustomerBill == null)
                {

                    MessageBox.Show("Tạo đơn thất bại!");
                    this.isSubmitSuccess = false;
                }
                else
                {
                    if (customerBill.DoiDiem > 0)
                    {
                        customer.Diem = diemConLai;
                        customer.Diem += (int)(customerBill.TongTien / 50000);
                        CustomerBUS.Instance.update(customer);
                    }

                    foreach (CustomerBillDetailDTO customerBillDetail in this.customerBillDetailList)
                    {
                        CustomerBillDetailDTO newCustomerBillDetail = new CustomerBillDetailDTO(
                            newCustomerBill.MaDonKhachHang,
                            customerBillDetail.MaSach,
                            customerBillDetail.SoLuong,
                            customerBillDetail.DonGia
                        );

                        CustomerBillBUS.Instance.createCustomerBillDetail(newCustomerBillDetail);
                    }

                    MessageBox.Show("Tạo đơn thành công!");

                    this.isSubmitSuccess = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saleCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCheckCbx2 = CustomValidation.Instance.checkCombobox(
                this.saleCbx,
                this.errorSaleMsg,
                new string[] { "required" }
            );

            getTotalPriceWhenChangeSaleAndCustomer();
        }

        private void customerCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkCombobox(
                this.customerCbx,
                this.errorCustomerMsg,
                new string[] { "required" }
            );

            PointToggleBtn.Enabled = this.customerCbx.SelectedIndex != 1 && this.customerCbx.SelectedIndex != 0;

            getTotalPriceWhenChangeSaleAndCustomer();
        }

        private void PointToggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(totalPriceTxt.Text.Split('.')[0]) > 0 || !PointToggleBtn.Checked)
                {
                    getTotalPriceWhenChangeSaleAndCustomer();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
