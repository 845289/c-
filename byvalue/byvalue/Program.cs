using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byvalue
{
    class Program
    {   
        static void show(int a)
        {
            a = 10;
           
        }
        static void show(ref int b)
        {
            b = 10;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter a and b values");
            a = int.Parse(Console.ReadLine());
            
            b = int.Parse(Console.ReadLine());
            show(a);
            Console.WriteLine(a);
            show(ref b);
            Console.WriteLine(b);


        }
    }
}
