using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jupr
{
    class Program
    {
        private static void insert()
        {
            Context c = new Context();
            Console.WriteLine("enter product name");
            string pname = Console.ReadLine();
            Console.WriteLine("enter product id");
            int pid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter productcost");
            double pcost = double.Parse(Console.ReadLine());
            Console.WriteLine("enter customer name");
            string cname = Console.ReadLine();
            Console.WriteLine("enter customer id");
            int cid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter quality");
            int qua = int.Parse(Console.ReadLine());
            c.customers.Add(new customer { name = cname, id = cid, quality = qua });
            c.products.Add(new product { name = pname, id = pid, price = pcost });
            c.SaveChanges();
        }
        private static void search()
        {
            Console.WriteLine("enter id");
            int i = int.Parse(Console.ReadLine());
            Context c = new Context();
              var d= from f in c.customers
                     where f.id== i
                     select f;
            var p = from t in c.products
                    where t.id == i
                    select t;
            foreach (var q in d)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t", q.id, q.name,q.quality);

            }
            foreach(var t in p)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t", t.id, t.name, t.price);
            }

        }
        static void Main(string[] args)
        {
            search();
          
        }
    }
}
