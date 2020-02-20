using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelfirst
{
    class Program
    {
       static modelfContainer e = new modelfContainer();
        static void Main(string[] args)
        {
            insertcat();
            insertpro();
            


        }
        private static void proshow()
        {
            var products = e.products;
            foreach (var t in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", t.pid, t.title, t.price, t.category_cid);
            }
        }

        private static void catshow()
        {
            var categories = e.categories;
            foreach (var o in categories)
            {
                Console.WriteLine("{0}\t{1}", o.cid, o.cname);
            }
        }

        private static void insertpro()
        {
            Console.WriteLine("enter pid");
            int pid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter product title");
            string title = Console.ReadLine();
            Console.WriteLine("enter price");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter cid");
            int cid = int.Parse(Console.ReadLine());
            var products = new product
            {
                pid = pid,
                title = title,
                price = price,
                category_cid = cid

            };
            e.products.Add(products);
            e.SaveChanges();
        }

        private static void insertcat()
        {
            Console.WriteLine("enter cid");
            int cid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cname");
            string cname = Console.ReadLine();
            var categories = new category
            {
                cid = cid,
                cname = cname
            };
            e.categories.Add(categories);
            e.SaveChanges();
        }
    }
}
