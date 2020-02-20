using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpp
{
    class Customer:Product
    {
        public List<Product> Product { get; set; }
        public string cutomer_name { get; set; }
        public string cid { get; set; }
        public double purchase { get; set; }
    }
}
