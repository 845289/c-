using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            Console.WriteLine(c.Area(12));
            Console.WriteLine(c.Area(5, 4));
            Console.WriteLine(c.Area(4.09));
            Console.WriteLine(c.Area(5.90, 8));
        }
    }
}
