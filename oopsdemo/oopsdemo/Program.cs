using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Timeperiod t = new Timeperiod();
            t.hours = 15;
            Console.WriteLine("hours {0}", t.hours);
            t.Showsecond();
        }
    }
}
