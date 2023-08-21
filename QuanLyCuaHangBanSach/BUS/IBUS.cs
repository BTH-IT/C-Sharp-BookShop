using System.Collections.Generic;
using System.Data;

namespace QuanLyCuaHangBanSach.BUS
{
    public interface IBUS<T>
    {
        DataTable getAll();
        List<T> getAllData();
        T getById(string id);
        bool insert(T data);
        bool update(T data);
        bool delete(string id);
    }
}
