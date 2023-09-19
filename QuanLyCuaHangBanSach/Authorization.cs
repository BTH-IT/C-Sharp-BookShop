﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System.Collections.Generic;

namespace QuanLyCuaHangBanSach
{
    public class Authorization
    {
        public int MaChucVu {  get; private set; }
        private Dictionary<string, string> permissionObj = new Dictionary<string, string>();

        public Authorization(int maChucVu) {
            this.MaChucVu = maChucVu;

            List<PermissionDTO> permissions = PermissionBUS.Instance.getAllData();

            foreach (PermissionDTO permission in permissions)
            {
                permissionObj.Add(permission.MaQuyenHang.ToString(), permission.TenQuyenHang);
            }
        }

        public Dictionary<string, string> getPermissionObject()
        {
            return permissionObj;
        }

        public bool checkAuthorize(int maQuyenHang)
        {
            AuthDetailDTO authDetail = AuthDetailBUS.Instance.getById(this.MaChucVu.ToString(), maQuyenHang.ToString());

            if (authDetail == null || !authDetail.TrangThai) return false;
            
            return true;
        }
    }
}