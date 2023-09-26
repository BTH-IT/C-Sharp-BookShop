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
        private ImportBillDTO supplierBill = null;

        public ViewImportBillModal(ImportBillDTO supplierBill)
        {
            InitializeComponent();
            try
            {
                this.supplierBill = supplierBill;

                this.loadSupplierCbx();

                this.supplierCbx.SelectedValue = 0;

                this.bookList.Controls.Clear();

                foreach (ImportBillDetailDTO importBillDetail in ImportBillBUS.Instance.getImportBillDetailList(supplierBill.MaDonNhapHang.ToString()))
                {
                    BookDTO book = BookBUS.Instance.getById(importBillDetail.MaSach.ToString());

                    ViewBookBill viewBook = new ViewBookBill(book.TenSach, importBillDetail.SoLuong, importBillDetail.DonGia, book.HinhAnh);

                    this.bookList.Controls.Add(viewBook);
                }

                this.totalPriceTxt.Text = this.supplierBill.TongTien.ToString();
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


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
