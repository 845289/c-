using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace cus_pro
{
    class Product
    {
        [Key]
        public int productid { get; set; }
        public string productname { get; set; }
        public double pcost { get; set; }
    }
}
