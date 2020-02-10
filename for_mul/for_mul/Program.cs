using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_mul
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter a value");
            a = int.Parse(Console.ReadLine());
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }
        }
    }
}
