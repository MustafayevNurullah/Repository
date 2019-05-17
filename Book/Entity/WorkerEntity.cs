using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entity
{
    class WorkerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FilialEntity filial { get; set; }
    }
}
