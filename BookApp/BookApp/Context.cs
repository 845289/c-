using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BookApp 
{
    class Context:DbContext
    {
        public Context() : base("Context") { }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Detail> details { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
