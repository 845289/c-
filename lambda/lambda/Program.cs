using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        delegate int Square(int num);
        static void Main(string[] args)
        {
            Square GetSquare = x => x * x;
            int j = GetSquare(5);
            Console.WriteLine("Square: " + j);
        }
    }
}
