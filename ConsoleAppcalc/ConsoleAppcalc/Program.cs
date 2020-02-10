using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibCalculation;

namespace ConsoleAppcalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation a = new Calculation();
            a.no1 = 10;
            a.no2 = 5;
            Console.WriteLine(a.Add());
            Console.WriteLine(a.Sub());
            Console.WriteLine(a.Mul());
            Console.WriteLine(a.Div());
        }
    }
}
