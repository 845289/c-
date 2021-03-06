﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using movie_mvc1.Models;
using System.Data.Entity;

namespace movie_mvc1.Models
{
    public class Context:DbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Theatre> Theatres { get; set; }
    }
}