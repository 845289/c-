using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace dm
{
    class Context:DbContext
    {
        public Context() : base("Context") { }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<Product> products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
