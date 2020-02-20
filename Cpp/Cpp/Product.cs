using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cpp
{
    class Product
    {
        [Key]
        public string productname { get; set; }
        public int productid { get; set; }
        public double productcost { get; set; }
        public Customer customer { get; set; }
    }
}
