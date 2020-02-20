using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace cp
{
    class context:DbContext
    {
        public DbSet<Customer> customer { get; set; }
    }
}
