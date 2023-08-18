using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DAO
{
    public interface IDAO<T>
    {
        DataTable getAll();
        T getById(string id);
        bool insert(T data);
        bool update(T data);
        bool delete(T data);
    }
}
