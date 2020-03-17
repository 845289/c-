using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Movie_Mvc2.Models
{
    public class Theatre
    {
        [Key]

        public int Tid { get; set; }
        public string theatre { get; set; }
        public Movie Movie { get; set; }
    }
}