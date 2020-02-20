using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Book
    {
        [Key]
       // [ForeignKey("StageId")]
        public int bid { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public int Aid { get; set; }
    }
}
