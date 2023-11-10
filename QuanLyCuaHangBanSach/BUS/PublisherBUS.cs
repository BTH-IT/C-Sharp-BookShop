using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class PublisherBUS : IBUS<PublisherDTO>
    {
        private static PublisherBUS instance;

        public static PublisherBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PublisherBUS();
                }

                return PublisherBUS.instance;
            }
            private set { PublisherBUS.instance = value; }
        }

        public bool checkDuplicateName(string value)
        {
            return PublisherDAO.Instance.checkDuplicateName(value);
        }

        public bool checkDuplicateName(string value, int id)
        {
            return PublisherDAO.Instance.checkDuplicateName(value, id);
        }

        public DataTable getAll()
        {
            return PublisherDAO.Instance.getAll();
        }

        public List<PublisherDTO> search(string value)
        {
            List<PublisherDTO> bookList = new List<PublisherDTO>();
            DataTable dt = PublisherDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                PublisherDTO book = new PublisherDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public List<PublisherDTO> getAllData()
        {
            List<PublisherDTO> bookList = new List<PublisherDTO>();
            DataTable dt = PublisherDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                PublisherDTO book = new PublisherDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public PublisherDTO getById(string id)
        {
            return PublisherDAO.Instance.getById(id);
        }

        public bool insert(PublisherDTO book)
        {
            return PublisherDAO.Instance.insert(book);
        }

        public bool update(PublisherDTO book)
        {
            return PublisherDAO.Instance.update(book);
        }

        public bool delete(string id)
        {
            return PublisherDAO.Instance.delete(id);
        }
    }
}
