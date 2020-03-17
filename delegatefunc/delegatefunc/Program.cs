using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatefunc
{
   // public delegate TResult Func<in a,in b,  out TResult>(a arg,b arg1);

class Program
    {
    static int rectangle(int a,int b)
    {
        return a * b;
    }
    static double triangle(int a,int b)
    {
        return 0.5 * a * b;
    }
    static void Main(string[] args)
    {
        Func<int, int, int> rec = rectangle;
        Func<int, int, double> tri = triangle;
            Console.WriteLine("enter a value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b value");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(rec(a,b));
        Console.WriteLine(tri(a,b));
    }
    
}
}
