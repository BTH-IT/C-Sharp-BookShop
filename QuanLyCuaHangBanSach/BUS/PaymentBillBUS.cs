using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class PaymentBillBUS : IBUS<PaymentBillDTO>
    {
        private static PaymentBillBUS instance;

        public static PaymentBillBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaymentBillBUS();
                }

                return PaymentBillBUS.instance;
            }
            private set { PaymentBillBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return PaymentBillDAO.Instance.getAll();
        }

        public List<PaymentBillDTO> getAllData()
        {
            List<PaymentBillDTO> paymentBillList = new List<PaymentBillDTO>();
            DataTable dt = PaymentBillDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                PaymentBillDTO paymentBill = new PaymentBillDTO(row);
                paymentBillList.Add(paymentBill);
            }

            return paymentBillList;
        }

        public List<PaymentBillDTO> search(string value)
        {
            DataTable dataTable = PaymentBillDAO.Instance.searchData(value);

            List<PaymentBillDTO> paymentBillList = new List<PaymentBillDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                PaymentBillDTO paymentBill = new PaymentBillDTO(row);
                paymentBillList.Add(paymentBill);
            }

            return paymentBillList;
        }

        public bool insert(PaymentBillDTO paymentBill)
        {
            return PaymentBillDAO.Instance.insert(paymentBill);
        }

        public PaymentBillDTO insertReturnBill(PaymentBillDTO paymentBill)
        {
            return PaymentBillDAO.Instance.insertReturnBill(paymentBill);
        }

        public bool update(PaymentBillDTO paymentBill)
        {
            return PaymentBillDAO.Instance.update(paymentBill);
        }

        public bool delete(string id)
        {
            return PaymentBillDAO.Instance.delete(id);
        }

        public PaymentBillDTO getById(string id)
        {
            return PaymentBillDAO.Instance.getById(id);
        }
    }
}
