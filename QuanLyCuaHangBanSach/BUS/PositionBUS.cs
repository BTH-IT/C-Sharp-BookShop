using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class PositionBUS : IBUS<PositionDTO>
    {
        private static PositionBUS instance;

        public static PositionBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PositionBUS();
                }

                return PositionBUS.instance;
            }
            private set { PositionBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return PositionDAO.Instance.getAll();
        }

        public bool checkDuplicateName(string value)
        {
            return PositionDAO.Instance.checkDuplicateName(value);
        }

        public List<PositionDTO> search(string value)
        {
            List<PositionDTO> positionList = new List<PositionDTO>();
            DataTable dt = PositionDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                PositionDTO position = new PositionDTO(row);
                positionList.Add(position);
            }

            return positionList;
        }

        public List<PositionDTO> getAllData()
        {
            List<PositionDTO> positionList = new List<PositionDTO>();
            DataTable dt = PositionDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                PositionDTO position = new PositionDTO(row);
                positionList.Add(position);
            }

            return positionList;
        }

        public PositionDTO getById(string id)
        {
            return PositionDAO.Instance.getById(id);
        }

        public bool insert(PositionDTO position)
        {
            return PositionDAO.Instance.insert(position);
        }

        public bool update(PositionDTO position)
        {
            return PositionDAO.Instance.update(position);
        }

        public bool delete(string id)
        {
            return PositionDAO.Instance.delete(id);
        }
    }
}
