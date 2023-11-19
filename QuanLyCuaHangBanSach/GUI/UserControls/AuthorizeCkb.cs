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

namespace QuanLyCuaHangBanSach.GUI.UserControls
{
    public partial class AuthorizeCkb : UserControl
    {
        private int permissionId;
        private int positionId;
        public delegate void OnPermissionAuthorizeChange(int staffId, string screenName);
        public static event OnPermissionAuthorizeChange onPermissionAuthorizeChange;

        public AuthorizeCkb(string text, int positionId, int permissionId, bool isCheck)
        {
            InitializeComponent();
            this.permissionId = permissionId;
            this.positionId = positionId;
            this.ckx.Text = text;
            this.ckx.Checked = isCheck;
            if(positionId == 1)
            {
                this.ckx.Enabled = false;   
            }
        }

        private void ckx_CheckedChanged(object sender, EventArgs e)
        {
            AuthDetailDTO authDetail = new AuthDetailDTO(positionId, permissionId, ckx.Checked);
            AuthDetailBUS.Instance.update(authDetail);
            onPermissionAuthorizeChange(ManagerGUI.currentStaff.Ma, "");
        }
    }
}
