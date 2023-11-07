using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class BookBUS : IBUS<BookDTO>
    {
        private static BookBUS instance;

        public static BookBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookBUS();
                }

                return BookBUS.instance;
            }
            private set { BookBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return BookDAO.Instance.getAll();
        }

        public List<BookDTO> search(string value)
        {
            List<BookDTO> bookList = new List<BookDTO>();
            DataTable dt = BookDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                BookDTO book = new BookDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public List<BookDTO> getAllData()
        {
            List<BookDTO> bookList = new List<BookDTO>();
            DataTable dt = BookDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                BookDTO book = new BookDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public BookDTO getById(string id)
        {
            return BookDAO.Instance.getById(id);
        }
        public List<BookDTO> getAllDataFiltered(int SortMode, string Type, string Author, string Publisher, bool Import)
        {
            List<BookDTO> bookList = new List<BookDTO>();
            DataTable dt = BookDAO.Instance.getAllDataFiltered(SortMode, Type, Author, Publisher, Import);

            foreach (DataRow row in dt.Rows)
            {
                BookDTO book = new BookDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public bool insert(BookDTO book)
        {
            return BookDAO.Instance.insert(book);
        }

        public bool update(BookDTO book)
        {
            return BookDAO.Instance.update(book);
        }

        public bool delete(string id)
        {
            return BookDAO.Instance.delete(id);
        }

        public bool deleteBookAmount(string id, int amount)
        {
            return BookDAO.Instance.deleteBookAmount(id, amount);
        }
        public bool createBookAmount(string id, int amount)
        {
            return BookDAO.Instance.createBookAmount(id, amount);
        }
        public List<BookDTO> getBookList(string id)
        {
            return BookDAO.Instance.getBookList(id);
        }
    }
}
