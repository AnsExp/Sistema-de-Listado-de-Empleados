using System.Collections.Generic;

namespace Model.DataAccessObject
{
    public interface IDataAccess<T>
    {
        T Select(T reg);
        void Insert(T reg);
        void Delete(T reg);
        void Update(T reg);
        List<T> SelectAll();
    }
}
