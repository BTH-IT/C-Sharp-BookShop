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

        public bool checkDuplicateName(string value)
        {
            return BookTypeDAO.Instance.checkDuplicateName(value);
        }

        public List<BookTypeDTO> search(string value)
        {
            List<BookTypeDTO> bookTypeList = new List<BookTypeDTO>();
            DataTable dt = BookTypeDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                BookTypeDTO bookType = new BookTypeDTO(row);
                bookTypeList.Add(bookType);
            }

            return bookTypeList;
        }

        public List<BookTypeDTO> getAllData()
        {
            List<BookTypeDTO> bookTypeList = new List<BookTypeDTO>();
            DataTable dt = BookTypeDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                BookTypeDTO bookType = new BookTypeDTO(row);
                bookTypeList.Add(bookType);
            }

            return bookTypeList;
        }

        public BookTypeDTO getById(string id)
        {
            return BookTypeDAO.Instance.getById(id);
        }

        public bool insert(BookTypeDTO bookType)
        {
            return BookTypeDAO.Instance.insert(bookType);
        }

        public bool update(BookTypeDTO bookType)
        {
            return BookTypeDAO.Instance.update(bookType);
        }

        public bool delete(string id)
        {
            return BookTypeDAO.Instance.delete(id);
        }
    }
}
