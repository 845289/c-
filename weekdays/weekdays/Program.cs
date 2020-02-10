using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekdays
{
    class Program
    {
        enum week_days
        {
            sunday=1,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", (int)week_days.saturday);
        }
    }
}
