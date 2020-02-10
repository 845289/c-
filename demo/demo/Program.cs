using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product {id=1,pname="product",price=9809 };
            Console.WriteLine("{0}\t{1}\t{2}",p.id,p.pname,p.price);
        }
    }
}
