using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not
{
    class Program
    {
        public delegate string Square(int side);
        static string square(int side)
        {
            int y = side * side;
            return string.Format("area of square {0}", y);
        }
        static void Main(string[] args)
        {
            Square s = new Square(square);
            Console.WriteLine("enter side");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine(square(q));

        }
    }
}
