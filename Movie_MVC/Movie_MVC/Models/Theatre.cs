using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Movie_MVC.Models
{
    public class Theatre
    {
        [Key]
        [Required]
        public int Tid { get; set; }
        [Required]
        public string Tname { get; set; }
        [Required]
        public Movie Movie { get; set; }

    }
}