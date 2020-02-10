using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conv
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale s = new Scale();
            s.inch = 12;
            Console.WriteLine("inches {0}", s.inch);
            s.showscale();

        }
    }
}
