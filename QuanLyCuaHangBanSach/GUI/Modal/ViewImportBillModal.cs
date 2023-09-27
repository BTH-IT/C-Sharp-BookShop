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
    public partial class ViewImportBillModal : Form
    {
        private ImportBillDTO importBill = null;

        public ViewImportBillModal(ImportBillDTO importBill)
        {
            InitializeComponent();
            try
            {
                this.importBill = importBill;

                this.loadSupplierCbx();
                this.loadStaffCbx();

                this.supplierCbx.SelectedValue = importBill.MaNhaCungCap;
                this.staffCbx.SelectedValue = importBill.MaNhanVien;

                this.bookList.Controls.Clear();

                foreach (ImportBillDetailDTO importBillDetail in ImportBillBUS.Instance.getImportBillDetailList(importBill.MaDonNhapHang.ToString()))
                {
                    BookDTO book = BookBUS.Instance.getById(importBillDetail.MaSach.ToString());

                    ViewBookBill viewBook = new ViewBookBill(book.TenSach, importBillDetail.SoLuong, importBillDetail.DonGia, book.HinhAnh);

                    this.bookList.Controls.Add(viewBook);
                }

                this.totalPriceTxt.Text = this.importBill.TongTien.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadSupplierCbx()
        {
            try
            {
                List<SupplierDTO> supplierList = SupplierBUS.Instance.getAllData();

                supplierList.Insert(0, new SupplierDTO(0, "Chọn nhà cung cấp", "", ""));

                this.supplierCbx.ValueMember = "MaNhaCungCap";
                this.supplierCbx.DisplayMember = "TenNhaCungCap";
                this.supplierCbx.DataSource = supplierList;

                this.supplierCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadStaffCbx()
        {
            try
            {
                List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

                this.staffCbx.ValueMember = "Ma";
                this.staffCbx.DisplayMember = "Ten";
                this.staffCbx.DataSource = staffList;

                this.staffCbx.SelectedIndex = 0;
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
    }
}
