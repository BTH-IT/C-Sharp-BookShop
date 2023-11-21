using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class PositionManageGUI : Form
    {
        public PositionManageGUI()
        {
            InitializeComponent();
        }

        private void loadPositionListToDataView(List<PositionDTO> positionList)
        {
            try
            {
                this.dgvPosition.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
                this.dgvPosition.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                this.dgvPosition.Rows.Clear();

                foreach (PositionDTO position in positionList)
                {
                    this.dgvPosition.Rows.Add(new object[] {
                        position.MaChucVu,
                        position.TenChucVu,
                        position.MoTa,
                        position.TrangThai ? "Đang hoạt động" : "Ngưng hoạt động",
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private void PositionManageGUI_Load(object sender, EventArgs e)
        {

            try
            {
                List<PositionDTO> positionList = PositionBUS.Instance.getAllData();
                this.loadPositionListToDataView(positionList);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.ForeColor = Color.Black;

                List<PositionDTO> positionList = PositionBUS.Instance.search(this.searchInput.Text);

                this.loadPositionListToDataView(positionList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (dgvPosition.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
                return;

            }
            try
            {
                string[] headerList = new string[] { "Mã chức vụ", "Tên chức vụ", "Mô tả", "Trạng thái" };

                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvPosition);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPosition.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                    return;
                }

                DataGridViewRow row = this.dgvPosition.Rows[this.dgvPosition.CurrentCell.RowIndex];

                if (row.Cells[0].Value.ToString() == "1")
                {
                    MessageBox.Show("Chức vụ này không thể thay đổi!!");
                    return;
                }

                using (PositionModal positionModal = new PositionModal("Sửa chức vụ"))
                {
                    PositionDTO position = PositionBUS.Instance.getById(row.Cells[0].Value.ToString());

                    positionModal.updatePosition = position;

                    if (positionModal.updatePosition == null)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                        return;
                    }

                    positionModal.ShowDialog();

                    if (positionModal.isSubmitSuccess)
                    {
                        List<PositionDTO> positionList = PositionBUS.Instance.search(this.searchInput.Text);

                        this.loadPositionListToDataView(positionList);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dgvPosition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                {
                    return;
                }

                DataGridViewRow row = this.dgvPosition.Rows[e.RowIndex];

                if (row.Cells[0].Value.ToString() == "1")
                {
                    MessageBox.Show("Chức vụ này không thể thay đổi!!");
                    return;
                }

                using (PositionModal positionModal = new PositionModal("Sửa chức vụ"))
                {
                    PositionDTO position = PositionBUS.Instance.getById(row.Cells[0].Value.ToString());

                    positionModal.updatePosition = position;

                    if (positionModal.updatePosition == null)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                        return;
                    }

                    positionModal.ShowDialog();

                    if (positionModal.isSubmitSuccess)
                    {
                        List<PositionDTO> positionList = PositionBUS.Instance.search(this.searchInput.Text);

                        this.loadPositionListToDataView(positionList);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (PositionModal positionModal = new PositionModal())
            {
                positionModal.ShowDialog();


                if (positionModal.isSubmitSuccess)
                {
                    List<PositionDTO> positionList = PositionBUS.Instance.search(this.searchInput.Text);

                    this.loadPositionListToDataView(positionList);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.Clear();

                List<PositionDTO> positionList = PositionBUS.Instance.search("");
                this.loadPositionListToDataView(positionList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void authorizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPosition.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                    return;
                }

                DataGridViewRow row = this.dgvPosition.Rows[this.dgvPosition.CurrentCell.RowIndex];

                using (AuthorizeModal authorizeModal = new AuthorizeModal(Convert.ToInt32(row.Cells[0].Value)))
                {
                    authorizeModal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
