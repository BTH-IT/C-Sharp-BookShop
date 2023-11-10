using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class SaleBUS : IBUS<SaleDTO>
    {
        private static SaleBUS instance;

        public static SaleBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SaleBUS();
                }

                return SaleBUS.instance;
            }
            private set { SaleBUS.instance = value; }
        }

        public bool checkDuplicateName(string value)
        {
            return SaleDAO.Instance.checkDuplicateName(value);
        }

        public bool checkDuplicateName(string value, int id)
        {
            return SaleDAO.Instance.checkDuplicateName(value, id);
        }

        public DataTable getAll()
        {
            return SaleDAO.Instance.getAll();
        }

        public List<SaleDTO> search(string value)
        {
            return SaleDAO.Instance.searchData(value);
        }

        public List<SaleDTO> getAllData()
        {
            List<SaleDTO> saleList = new List<SaleDTO>();
            DataTable dt = SaleDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                SaleDTO sale = new SaleDTO(row);
                saleList.Add(sale);
            }

            return saleList;
        }

        public List<SaleDTO> getAllNotExpired()
        {
            return SaleDAO.Instance.getAllNotExpired();
        }

        public SaleDTO getById(string id)
        {
            return SaleDAO.Instance.getById(id);
        }

        public bool insert(SaleDTO sale)
        {
            return SaleDAO.Instance.insert(sale);
        }

        public bool update(SaleDTO sale)
        {
            return SaleDAO.Instance.update(sale);
        }

        public bool delete(string id)
        {
            return SaleDAO.Instance.delete(id);
        }
    }
}
