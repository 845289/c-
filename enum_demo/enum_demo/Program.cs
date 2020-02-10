using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_demo
{
    class Program
    {
        enum dep
        {
            p = 10,
            c = 13,
            m = 15,
            b = 18
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("department id of mathematics is {0}",(int)dep.m);
        }
    }
}
