using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movie_MVC.Models;
using System.Data.Entity;

namespace Movie_MVC.DataLayer
{
    public class Context:DbContext
    {
        
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
    }
}