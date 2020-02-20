using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace jupr
{
    class customer
    {
        [Key]
        public string name { get; set; }
        public int id { get; set; }
        public int quality { get; set; }
        public List<product> Products { get; set; }
    }
}
