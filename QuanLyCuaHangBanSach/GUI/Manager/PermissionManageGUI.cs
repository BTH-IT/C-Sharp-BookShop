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
    public partial class PermissionManageGUI : Form
    {
        private CheckBox headerCheckbox;

        public PermissionManageGUI()
        {
            InitializeComponent();
        }

        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvPermission.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvPermission.Controls.Add(headerCheckbox);
        }

        private void loadPermissionListToDataView(List<PermissionDTO> positionList)
        {
            this.dgvPermission.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvPermission.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dgvPermission.Rows.Clear();

            foreach (PermissionDTO position in positionList)
            {
                this.dgvPermission.Rows.Add(new object[] {
                    false,
                    position.MaQuyenHang,
                    position.TenQuyenHang,
                    position.TrangThai ? "Đang hoạt động" : "Ngưng hoạt động",
                });
            }

        }


        private void PermissionManageGUI_Load(object sender, EventArgs e)
        {

            List<PermissionDTO> positionList = PermissionBUS.Instance.getAllData();
            this.loadPermissionListToDataView(positionList);

            this.renderCheckBoxDgv();
            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvPermission.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
            }

            this.dgvPermission.RefreshEdit();
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            this.searchInput.ForeColor = Color.Black;

            List<PermissionDTO> positionList = PermissionBUS.Instance.search(this.searchInput.Text);

            this.loadPermissionListToDataView(positionList);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            List<PermissionDTO> positionList = PermissionBUS.Instance.search(this.searchInput.Text);

            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(positionList);

            string[] headerList = new string[] { "Mã quyền hạng", "Tên quyền hạng", "Trạng thái" };

            CustomExcel.Instance.ExportFile(dataTable, "Permission Manage", "Cửa hàng bán quyền hạng", headerList);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvPermission.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            using (PermissionModal positionModal = new PermissionModal("Sửa quyền hạng"))
            {
                DataGridViewRow row = this.dgvPermission.Rows[this.dgvPermission.CurrentCell.RowIndex];

                PermissionDTO position = PermissionBUS.Instance.getById(row.Cells[1].Value.ToString());

                positionModal.updatePermission = position;

                if (positionModal.updatePermission == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                    return;
                }

                positionModal.ShowDialog();

                if (positionModal.isSubmitSuccess)
                {
                    List<PermissionDTO> positionList = PermissionBUS.Instance.search(this.searchInput.Text);

                    this.loadPermissionListToDataView(positionList);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool isHaveSelect = false;

            foreach (DataGridViewRow row in this.dgvPermission.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    isHaveSelect = true;
                    break;
                }
            }

            if (!isHaveSelect)
            {
                MessageBox.Show("Bạn chưa chọn những quyền hạng cần xóa");
                return;
            }

            DialogResult dlgResult = MessageBox.Show(
                "Bạn chắc chắn muốn xóa các quyền hạng đã chọn chứ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (dlgResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in this.dgvPermission.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        PermissionBUS.Instance.delete(row.Cells[1].Value.ToString());
                    }

                }
                List<PermissionDTO> positionList = PermissionBUS.Instance.search(this.searchInput.Text);
                this.loadPermissionListToDataView(positionList);

                MessageBox.Show("Delete successful");
            }
        }

        private void dgvPermission_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0)
            {
                return;
            }

            using (PermissionModal positionModal = new PermissionModal("Sửa quyền hạng"))
            {
                DataGridViewRow row = this.dgvPermission.Rows[e.RowIndex];

                PermissionDTO position = PermissionBUS.Instance.getById(row.Cells[1].Value.ToString());

                positionModal.updatePermission = position;

                if (positionModal.updatePermission == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                    return;
                }

                positionModal.ShowDialog();

                if (positionModal.isSubmitSuccess)
                {
                    List<PermissionDTO> positionList = PermissionBUS.Instance.search(this.searchInput.Text);

                    this.loadPermissionListToDataView(positionList);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (PermissionModal positionModal = new PermissionModal())
            {
                positionModal.ShowDialog();


                if (positionModal.isSubmitSuccess)
                {
                    List<PermissionDTO> positionList = PermissionBUS.Instance.search(this.searchInput.Text);

                    this.loadPermissionListToDataView(positionList);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.searchInput.Clear();

            List<PermissionDTO> positionList = PermissionBUS.Instance.search("");
            this.loadPermissionListToDataView(positionList);
        }
    }
}
