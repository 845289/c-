using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp
{
    class Customer:Product
    {
        public List<Product> product { get; set; }
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public double purchase { get; set; }
    }
}
