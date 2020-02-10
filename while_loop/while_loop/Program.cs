using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter a value less than 100");
            a = int.Parse(Console.ReadLine());
            while(a<100)
            {
                Console.WriteLine("{0} is less than 100",a);
                a++;
            }
        }
    }
}
