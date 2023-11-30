using System.Collections.Generic;
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
		private List<int> authForStaffNhapHang = new List<int>() { 1, 3, 4, 5, 7, 9, 14, 16, 17 };
		private List<int> authForStaffBanHang = new List<int>() { 6, 8, 10, 13, 16 };
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
            }else if(positionId == 7) 
            {
                if(authForStaffNhapHang.Contains(permissionId))
                {
                    this.ckx.Enabled = false;
                }    
            }else if(positionId == 8)
            {
                if(authForStaffBanHang.Contains(permissionId))
                {
                    this.ckx.Enabled=false; 
                }    
            }    
        }

        public void ckx_CheckedChanged()
        {
            AuthDetailDTO authDetail = new AuthDetailDTO(positionId, permissionId, ckx.Checked);
            AuthDetailBUS.Instance.update(authDetail);
            onPermissionAuthorizeChange(ManagerGUI.currentStaff.Ma, "");
        }
    }
}
