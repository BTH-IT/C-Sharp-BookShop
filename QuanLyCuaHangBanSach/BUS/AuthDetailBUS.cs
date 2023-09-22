using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class AuthDetailBUS
    {
        private static AuthDetailBUS instance;

        public static AuthDetailBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthDetailBUS();
                }

                return AuthDetailBUS.instance;
            }
            private set { AuthDetailBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return AuthDetailDAO.Instance.getAll();
        }

        public List<AuthDetailDTO> getAllData()
        {
            List<AuthDetailDTO> authDetailList = new List<AuthDetailDTO>();
            DataTable dt = AuthDetailDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                AuthDetailDTO authDetail = new AuthDetailDTO(row);
                authDetailList.Add(authDetail);
            }

            return authDetailList;
        }

        public AuthDetailDTO getById(string positionId, string permissionId)
        {
            return AuthDetailDAO.Instance.getById(positionId, permissionId);
        }

        public List<AuthDetailDTO> getByPositionId(string positionId)
        {
            return AuthDetailDAO.Instance.getByPositionId(positionId);
        }

        public bool insert(AuthDetailDTO authDetail)
        {
            return AuthDetailDAO.Instance.insert(authDetail);
        }

        public bool update(AuthDetailDTO authDetail)
        {
            return AuthDetailDAO.Instance.update(authDetail);
        }

        public bool delete(string positionId, string permissionId)
        {
            return AuthDetailDAO.Instance.delete(positionId, permissionId);
        }

        public bool deleteAllByPositionId(string positionId)
        {
            return AuthDetailDAO.Instance.deleteAllByPositionId(positionId);
        }
    }
}
