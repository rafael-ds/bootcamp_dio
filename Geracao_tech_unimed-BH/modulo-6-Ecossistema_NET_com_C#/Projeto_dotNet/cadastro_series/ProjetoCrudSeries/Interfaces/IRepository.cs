using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCrudSeries.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();

        T ReturnId(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();
    }
}