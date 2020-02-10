using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nonstat
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales s1 = new Sales();
            s1.Proname = "Dairymilk";
            s1.Quantity = 5;
            s1.Price = 20;
            Console.WriteLine("{0}\n{1}\n{2}", s1.Proname, s1.Quantity, s1.Price);
            Console.WriteLine("{0}", s1.Saleamt);
            Console.WriteLine("{0}", s1.Totalsales);


            Sales s2 = new Sales();
            s2.Proname = "5 star";
            s2.Quantity = 5;
            s2.Price = 10;
            Console.WriteLine("{0}\n{1}\n{2}", s2.Proname, s2.Quantity, s2.Price);
            Console.WriteLine("{0}", s2.Saleamt);
            Console.WriteLine("{0}", s2.Totalsales);


        }
    }
}
