using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class PublisherGUI : Form
    {
        public PublisherGUI()
        {
            InitializeComponent();
        }
        private void loadPublisherListToDataView(List<PublisherDTO> PublisherList)
        {
            try
            {
                this.dgvPublisher.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
                this.dgvPublisher.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                this.dgvPublisher.Rows.Clear();

                foreach (PublisherDTO Publisher in PublisherList)
                {
                    this.dgvPublisher.Rows.Add(new object[] {
                        Publisher.MaNhaXuatBan,
                        Publisher.TenNhaXuatBan,
                        Publisher.DiaChi,
                        Publisher.SoDienThoai,
                    });
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }

        }


        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.ForeColor = Color.Black;
                List<PublisherDTO> PublisherList = PublisherBUS.Instance.search(this.searchInput.Text.Trim());
                this.loadPublisherListToDataView(PublisherList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (dgvPublisher.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
                return;

            }

            try
            {
                string[] headerList = new string[] { "Mã nhà xuất bản", "Tên nhà xuất bản", "Địa chỉ", "Số điện thoại" };
                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvPublisher);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPublisher.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                    return;
                }

                using (PublisherModal PublisherModal = new PublisherModal("Sửa nhà xuất bản"))
                {
                    DataGridViewRow row = this.dgvPublisher.Rows[this.dgvPublisher.CurrentCell.RowIndex];

                    PublisherDTO Publisher = PublisherBUS.Instance.getById(row.Cells[0].Value.ToString());

                    PublisherModal.updatePublisher = Publisher;

                    if (PublisherModal.updatePublisher == null)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                        return;
                    }

                    PublisherModal.ShowDialog();

                    if (PublisherModal.isSubmitSuccess)
                    {
                        List<PublisherDTO> PublisherList = PublisherBUS.Instance.search(this.searchInput.Text.Trim());

                        this.loadPublisherListToDataView(PublisherList);
                    }
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isHaveSelect = false;

                foreach (DataGridViewRow row in this.dgvPublisher.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        isHaveSelect = true;
                        break;
                    }
                }

                if (!isHaveSelect)
                {
                    MessageBox.Show("Bạn chưa chọn những nhà xuất bản cần xóa");
                    return;
                }

                DialogResult dlgResult = MessageBox.Show(
                    "Bạn chắc chắn muốn xóa các nhà xuất bản đã chọn chứ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (dlgResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in this.dgvPublisher.Rows)
                    {
                        if ((bool)row.Cells[0].Value == true)
                        {
                            PublisherBUS.Instance.delete(row.Cells[1].Value.ToString());
                        }

                    }
                    List<PublisherDTO> PublisherList = PublisherBUS.Instance.search(this.searchInput.Text.Trim());
                    this.loadPublisherListToDataView(PublisherList);

                    MessageBox.Show("Delete successful");
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void dgvPublisher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                {
                    return;
                }

                using (PublisherModal PublisherModal = new PublisherModal("Sửa nhà xuất bản"))
                {
                    DataGridViewRow row = this.dgvPublisher.Rows[e.RowIndex];

                    PublisherDTO Publisher = PublisherBUS.Instance.getById(row.Cells[0].Value.ToString());

                    PublisherModal.updatePublisher = Publisher;
                    if (PublisherModal.updatePublisher == null)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                        return;
                    }

                    PublisherModal.ShowDialog();

                    if (PublisherModal.isSubmitSuccess)
                    {
                        List<PublisherDTO> PublisherList = PublisherBUS.Instance.search(this.searchInput.Text.Trim());

                        this.loadPublisherListToDataView(PublisherList);
                    }
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.Clear();

                List<PublisherDTO> PublisherList = PublisherBUS.Instance.search("");
                this.loadPublisherListToDataView(PublisherList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (PublisherModal PublisherModal = new PublisherModal())
                {
                    PublisherModal.ShowDialog();


                    if (PublisherModal.isSubmitSuccess)
                    {
                        List<PublisherDTO> PublisherList = PublisherBUS.Instance.search(this.searchInput.Text.Trim());

                        this.loadPublisherListToDataView(PublisherList);
                    }
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void PublisherGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<PublisherDTO> PublisherList = PublisherBUS.Instance.getAllData();
                this.loadPublisherListToDataView(PublisherList);

            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }
    }
}
