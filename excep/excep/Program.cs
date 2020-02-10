using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excep
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 56, b = 0;
            double result;
            mod m = new mod();
            try
            {
                result = m.div(a, b);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero {0}",e);
            }
        }
    }
}
