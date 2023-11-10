using System.Collections.Generic;
using System.Data;
using BookShop_CNPM.DAO;
using BookShop_CNPM.DTO;

namespace BookShop_CNPM.BUS
{
    public class ImportRefundBillBUS : IBUS<ImportRefundBillDTO>
    {
        private static ImportRefundBillBUS instance;

        public static ImportRefundBillBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportRefundBillBUS();
                }

                return ImportRefundBillBUS.instance;
            }
            private set { ImportRefundBillBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return ImportRefundBillDAO.Instance.getAll();
        }

        public List<ImportRefundBillDTO> getAllData()
        {
            List<ImportRefundBillDTO> importRefundBillList = new List<ImportRefundBillDTO>();
            DataTable dt = ImportRefundBillDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                ImportRefundBillDTO importRefundBill = new ImportRefundBillDTO(row);
                importRefundBillList.Add(importRefundBill);
            }

            return importRefundBillList;
        }

        public List<ImportRefundBillDTO> search(string value)
        {
            DataTable dataTable = ImportRefundBillDAO.Instance.searchData(value);

            List<ImportRefundBillDTO> importRefundBillList = new List<ImportRefundBillDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                ImportRefundBillDTO importRefundBill = new ImportRefundBillDTO(row);
                importRefundBillList.Add(importRefundBill);
            }

            return importRefundBillList;
        }

        public List<ImportRefundBillDetailDTO> getImportRefundBillDetailList(string id)
        {
            return ImportRefundBillDAO.Instance.getImportRefundBillDetailList(id);
        }

        public bool createImportRefundBillDetail(ImportRefundBillDetailDTO importRefundBillDetail)
        {
            return ImportRefundBillDAO.Instance.createImportRefundBillDetail(importRefundBillDetail);
        }
        public bool insert(ImportRefundBillDTO importRefundBill)
        {
            return ImportRefundBillDAO.Instance.insert(importRefundBill);
        }

        public ImportRefundBillDTO insertReturnBill(ImportRefundBillDTO importRefundBill)
        {
            return ImportRefundBillDAO.Instance.insertReturnBill(importRefundBill);
        }

        public bool update(ImportRefundBillDTO importRefundBill)
        {
            return ImportRefundBillDAO.Instance.update(importRefundBill);
        }

        public bool delete(string id)
        {
            return ImportRefundBillDAO.Instance.delete(id);
        }

        public ImportRefundBillDTO getById(string id)
        {
            return ImportRefundBillDAO.Instance.getById(id);
        }
    }
}
