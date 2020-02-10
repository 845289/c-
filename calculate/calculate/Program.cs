using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator(10,2);
            Console.WriteLine("add - " + c.Add());
            Console.WriteLine("diff - " + c.Diff());
            Console.WriteLine("mul - " + c.Mul());
            Console.WriteLine("div - " + c.Div());


        }
    }
}
