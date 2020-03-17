using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace movie_mvc1.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Mid { get; set; }
        [Required]
        public string Mname { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double price { get; set; }
        [Required]
        public Theatre Theatre { get; set; }
    }
}