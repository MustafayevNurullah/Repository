using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Entity;

namespace Book.Data_Access.SqlServer
{
    class SqlWorkerRepository : IRepository<WorkerEntity>
    {
        public void Add(WorkerEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<WorkerEntity> Get()
        {
            throw new NotImplementedException();
        }

        public WorkerEntity Get(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(WorkerEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
