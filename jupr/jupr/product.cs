using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace jupr
{
    class product
    {
        [Key]
        public string name { get; set; }
        public int id { get; set; }
        public double price { get; set; }
        
    }
}
