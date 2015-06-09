using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbApplication1
{
    class dbcontext : DbContext
    {
        public DbSet<Equipment> Equipment { get; set; }

    }
}
