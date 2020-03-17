using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace movie_mvc1.Models
{
    public class Theatre
    {
        [Key]
        [Required]
        public int Tid { get; set; }
        [Required]
        public string Tname { get; set; }
        [Required]
        
        public ICollection< Movie> Movies { get; set; }
    }
}