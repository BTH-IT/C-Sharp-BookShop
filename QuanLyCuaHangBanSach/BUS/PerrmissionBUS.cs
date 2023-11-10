using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class PermissionBUS : IBUS<PermissionDTO>
    {
        private static PermissionBUS instance;

        public static PermissionBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PermissionBUS();
                }

                return PermissionBUS.instance;
            }
            private set { PermissionBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return PermissionDAO.Instance.getAll();
        }

        public bool checkDuplicateName(string value)
        {
            return PermissionDAO.Instance.checkDuplicateName(value);
        }

        public bool checkDuplicateName(string value, int id)
        {
            return PermissionDAO.Instance.checkDuplicateName(value, id);
        }

        public List<PermissionDTO> search(string value)
        {
            List<PermissionDTO> permissionList = new List<PermissionDTO>();
            DataTable dt = PermissionDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                PermissionDTO permission = new PermissionDTO(row);
                permissionList.Add(permission);
            }

            return permissionList;
        }

        public List<PermissionDTO> getAllData()
        {
            List<PermissionDTO> permissionList = new List<PermissionDTO>();
            DataTable dt = PermissionDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                PermissionDTO permission = new PermissionDTO(row);
                permissionList.Add(permission);
            }

            return permissionList;
        }

        public PermissionDTO getById(string id)
        {
            return PermissionDAO.Instance.getById(id);
        }

        public bool insert(PermissionDTO permission)
        {
            return PermissionDAO.Instance.insert(permission);
        }

        public bool update(PermissionDTO permission)
        {
            return PermissionDAO.Instance.update(permission);
        }

        public bool delete(string id)
        {
            return PermissionDAO.Instance.delete(id);
        }
    }
}
