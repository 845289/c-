using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpp
{
    class Program
    {
        private static void insertdata()
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

        }
        static void Main(string[] args)
        {
        }
    }
}
