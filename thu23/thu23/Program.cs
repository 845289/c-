using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thu23
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer
            { cus = 123,
                n = "vis",
                add = "chennai",

        };



            BankAccount b = new BankAccount
            {
                Ac = 215646312,
                acb = 1000,

            };
            Console.WriteLine("customer id ={0}\nname ={1}\naddress={2}\naccount number ={3}\nbalance ={4}", c.cus, c.n, c.add, b.Ac, b.acb);
            Console.WriteLine("simple interest " + b.simplein());
            double totamb=b.acb + b.simplein();
            Console.WriteLine(totamb);
            FixedAccount f = new FixedAccount();
           
            Console.WriteLine("simple interest plus 3" + f.simplein());
            double q=f.simplein();
            double w = q + totamb;
            Console.WriteLine(w);

        }
    }
}
