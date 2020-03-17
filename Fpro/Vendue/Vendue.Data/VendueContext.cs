using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendue.Entities;

namespace Vendue.Data
{
    public class VendueContext : DbContext
    {
        public VendueContext() : base("VendueConnectionString")
        {
        }
        public DbSet<Auction> Auctions { get; set; }
    }
}
