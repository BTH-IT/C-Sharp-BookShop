using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public interface IBUS<T>
    {
        DataTable getAll();
        List<T> getAllData();
        T getById(string id);
        bool insert(T data);
        bool update(T data);
        bool delete(T data);
    }
}
