using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class BookTypeBUS : IBUS<BookTypeDTO>
    {
        private static BookTypeBUS instance;

        public static BookTypeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookTypeBUS();
                }

                return BookTypeBUS.instance;
            }
            private set { BookTypeBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return BookTypeDAO.Instance.getAll();
        }

        public List<BookTypeDTO> search(string value)
        {
            List<BookTypeDTO> bookList = new List<BookTypeDTO>();
            DataTable dt = BookTypeDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                BookTypeDTO book = new BookTypeDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public List<BookTypeDTO> getAllData()
        {
            List<BookTypeDTO> bookList = new List<BookTypeDTO>();
            DataTable dt = BookTypeDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                BookTypeDTO book = new BookTypeDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public BookTypeDTO getById(string id)
        {
            return BookTypeDAO.Instance.getById(id);
        }

        public bool insert(BookTypeDTO book)
        {
            return BookTypeDAO.Instance.insert(book);
        }

        public bool update(BookTypeDTO book)
        {
            return BookTypeDAO.Instance.update(book);
        }

        public bool delete(string id)
        {
            return BookTypeDAO.Instance.delete(id);
        }
    }
}
