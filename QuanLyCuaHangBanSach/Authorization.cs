using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;

namespace QuanLyCuaHangBanSach
{
    public class Authorization
    {
        public int MaChucVu { get; private set; }
        private Dictionary<string, string> permissionObj = new Dictionary<string, string>();

        public Authorization(int maChucVu)
        {
            this.MaChucVu = maChucVu;

            List<PermissionDTO> permissions = PermissionBUS.Instance.getAllData();

            foreach (PermissionDTO permission in permissions)
            {
                permissionObj.Add(permission.maQuyenHan.ToString(), permission.tenQuyenHan);
            }
        }

        public Dictionary<string, string> getPermissionObject()
        {
            return permissionObj;
        }

        public bool checkAuthorize(int maQuyenHan)
        {
            AuthDetailDTO authDetail = AuthDetailBUS.Instance.getById(this.MaChucVu.ToString(), maQuyenHan.ToString());

            if (authDetail == null || !authDetail.TrangThai) return false;

            return true;
        }
    }
}