using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace jupr
{
    class Context:DbContext
    {
        public DbSet<customer> customers { get; set; }
        public DbSet<product> products { get; set; }
    }
}
