using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm
{
    class Program
    {
      /*  public static List<Product> getAllProducts()
        {

            List<Product> plist = new List<Product>();
            int s = 0;
            do
            {
                Console.WriteLine("Enter Pname");
                string name = Console.ReadLine();
                Console.WriteLine("enter price");
                double prc = double.Parse(Console.ReadLine());
                plist.Add(new Product { pname = name, price = prc });
                Console.WriteLine("Do u want to continue 1.YES 2.NO");
                int n = int.Parse(Console.ReadLine());
            } while (s == 1);
                            return plist;
        }
        public static void insert()
        {
            Context c = new Context();
            Customer c1=new Customer(); 
            //Console.WriteLine("enter product name");
            //string pname = Console.ReadLine();
            //Console.WriteLine("enter product id");
            //int pid = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter productcost");
            //double pcost = double.Parse(Console.ReadLine());
            Console.WriteLine("enter customer name");
            c1.cname = Console.ReadLine();
            Console.WriteLine("enter phno");
            c1.phno = long.Parse(Console.ReadLine());
            c.customers.Add( c1);
                c1.products = getAllProducts();     
                    c.SaveChanges();
        }
        */

            public static void insertinitialdata()
        {
            Context c = new Context();
            var customers = new List<Customer>
                {
                    new Customer{cname="Anand",phno=1902882},
                    new Customer{cname="Anant",phno=1902552},
                    new Customer{cname="Abi",phno=1902662},
                    new Customer{cname="Arvind",phno=1902682},
                    new Customer{cname="Akhil",phno=1905882},
                    new Customer{cname="Ananda",phno=1602882}

                };
            customers.ForEach(s => c.customers.Add(s));
            c.SaveChanges();
           // Customer cn = new Customer();
            var products = new List<Product>
            {
                new Product{ pname="rice",price=99},
                new Product{ pname="dal",price=88},
                new Product{ pname="biscuit",price=9},
                new Product{ pname="choclate",price=91},
                new Product{ pname="wheat",price=300}

            };
            products.ForEach(p => c.products.Add(p));
            c.SaveChanges();
            var purchases = new List<Purchase>
                {
                new Purchase {OrderDate=Convert.ToDateTime("09-09-2020"),pid=1,cid=2 },
                new Purchase {OrderDate=Convert.ToDateTime("09-09-2020"),pid=2,cid=1 },
                new Purchase {OrderDate=Convert.ToDateTime("09-09-2020"),pid=3,cid=2 },
                new Purchase {OrderDate=Convert.ToDateTime("09-09-2020"),pid=3,cid=3 },
                new Purchase {OrderDate=Convert.ToDateTime("09-09-2020"),pid=4,cid=4 }

                
            };
            purchases.ForEach(pr => c.purchases.Add(pr));
            c.SaveChanges();

        }
        public static void show()
        {
            Context ct = new Context();
            var customers = ct.customers;
            Console.WriteLine("customer details ");
            foreach(var p in customers)
            {
                Console.WriteLine("{0}\t{1}\t{2}", p.cid, p.cname, p.phno);
            }
            var products = ct.products;
            Console.WriteLine("product details ");
            foreach (var p in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}", p.pid, p.pname, p.price);
                    }
            var purchases = ct.purchases;
            Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10}{5,8}{6,15}", "purch_ID", "OrderDate", "pid", "prd_name", "price", "cust_id", "Custname");
            Console.WriteLine("purchase details ");

            foreach (var p in purchases)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}Rs{4,10:N}{5,8}{6,15}",p.id,p.OrderDate.ToShortDateString(),p.pid,p.product.pname,p.product.price,p.cid,p.customer.cname);
               // Console.WriteLine("{0}\t{1}\t{2}", p.id, p.OrderDate, p.cid, p.pid);
            }
        }
            static void Main(string[] args)
            {
           insertinitialdata();
            show();

            }
        
    }
}