using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace cus_pro
{
    class Customer:DbContext
    {
        public List<Product> product { get; set; }
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public double purchase { get; set; }
    }
}
