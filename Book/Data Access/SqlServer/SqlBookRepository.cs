using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Entity;

namespace Book
{
    class SqlBookRepository : IRepository<BookEntity>
    {
        public void Add(BookEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<BookEntity> Get()
        {
            throw new NotImplementedException();
        }

        public BookEntity Get(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(BookEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
