using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numtoword
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            ntw s = new ntw();
            long n = long.Parse(Console.ReadLine());
           string d= s.numbertoword(n);
            Console.WriteLine(d);
        }
    }
}
