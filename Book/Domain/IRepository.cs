using Book.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    interface IRepository<T>
    {
        void Add(T obj);
        void Remove(T obj);
        List<T> Get();
        T Get(int Id);
    }
}
