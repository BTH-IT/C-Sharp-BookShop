using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class PositionManageGUI : Form
    {
        private CheckBox headerCheckbox;

        public PositionManageGUI()
        {
            InitializeComponent();
        }

        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvPosition.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvPosition.Controls.Add(headerCheckbox);
        }

        private void loadPositionListToDataView(List<PositionDTO> positionList)
        {
            this.dgvPosition.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvPosition.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dgvPosition.Rows.Clear();

            foreach (PositionDTO position in positionList)
            {
                this.dgvPosition.Rows.Add(new object[] {
                    false,
                    position.MaChucVu,
                    position.TenChucVu,
                    position.MoTa,
                    position.TrangThai ? "Đang hoạt động" : "Ngưng hoạt động",
                });
            }

        }


        private void PositionManageGUI_Load(object sender, EventArgs e)
        {

            List<PositionDTO> positionList = PositionBUS.Instance.getAllData();
            this.loadPositionListToDataView(positionList);

            this.renderCheckBoxDgv();
            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvPosition.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
            }

            this.dgvPosition.RefreshEdit();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            this.searchInput.ForeColor = Color.Black;

            List<PositionDTO> positionList = PositionBUS.Instance.search(this.searchInput.Text);

            this.loadPositionListToDataView(positionList);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            List<PositionDTO> positionList = PositionBUS.Instance.search(this.searchInput.Text);

            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(positionList);

            string[] headerList = new string[] { "Mã chức vụ", "Tên chức vụ", "Mô tả", "Trạng thái"};

            CustomExcel.Instance.ExportFile(dataTable, "Position Manage", "Cửa hàng bán chức vụ", headerList);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvPosition.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            using (PositionModal positionModal = new PositionModal("Sửa chức vụ"))
            {
                DataGridViewRow row = this.dgvPosition.Rows[this.dgvPosition.CurrentCell.RowIndex];

                PositionDTO position = PositionBUS.Instance.getById(row.Cells[1].Value.ToString());

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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool isHaveSelect = false;

            foreach (DataGridViewRow row in this.dgvPosition.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    isHaveSelect = true;
                    break;
                }
            }

            if (!isHaveSelect)
            {
                MessageBox.Show("Bạn chưa chọn những chức vụ cần xóa");
                return;
            }

            DialogResult dlgResult = MessageBox.Show(
                "Bạn chắc chắn muốn xóa các chức vụ đã chọn chứ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (dlgResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in this.dgvPosition.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        PositionBUS.Instance.delete(row.Cells[1].Value.ToString());
                    }

                }
                List<PositionDTO> positionList = PositionBUS.Instance.search(this.searchInput.Text);
                this.loadPositionListToDataView(positionList);

                MessageBox.Show("Delete successful");
            }
        }

        private void dgvPosition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0)
            {
                return;
            }

            using (PositionModal positionModal = new PositionModal("Sửa chức vụ"))
            {
                DataGridViewRow row = this.dgvPosition.Rows[e.RowIndex];

                PositionDTO position = PositionBUS.Instance.getById(row.Cells[1].Value.ToString());

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
            this.searchInput.Clear();

            List<PositionDTO> positionList = PositionBUS.Instance.search("");
            this.loadPositionListToDataView(positionList);
        }

        private void authorizeBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvPosition.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            DataGridViewRow row = this.dgvPosition.Rows[this.dgvPosition.CurrentCell.RowIndex];

            using (AuthorizeModal authorizeModal = new AuthorizeModal(Convert.ToInt32(row.Cells[1].Value)))
            {
                authorizeModal.ShowDialog();
            }
        }
    }
}
