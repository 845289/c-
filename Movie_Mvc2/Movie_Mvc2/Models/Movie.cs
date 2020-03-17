using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Movie_Mvc2.Models
{
    public class Movie
    {
        [Key]
        public int Mid { get; set; }
        public string Mname { get; set; }
        public double price { get; set; }
        public string location { get; set; }


    }
}