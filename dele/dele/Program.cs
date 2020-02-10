using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dele
{
    class Program
    {
       

         public static double mym(double b,double h)
         {
             return 0.5 * b * h;
         }
        public static void Main(string[] args)
        {
             Func<double, double,double> val= mym;
            double B = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            Console.WriteLine(val(B,H));
            

        }
    }
}
