using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter number");
            a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:
                    Console.WriteLine("hi");
                    break;
                case 2:
                    Console.WriteLine("hello");
                    break;
                case 3:
                    Console.WriteLine("bello");
                    break;
                default:
                    Console.WriteLine("ola amigo");
                    break;
            }
        }
    }
}
