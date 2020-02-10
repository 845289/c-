using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avgmarks
{
    class Program
    {
        public static double getaveg(int[] m)
        {
            double sum = 0;
            double avg=0;
            foreach(int i in m)
            {
                 sum =sum+ i;
                 avg = sum / m.Length;
                
            }
            return avg;
        }
        static void Main(string[] args)
        {
            int[] marks = new int[] { 57, 65, 43, 84, 73, 93 };
            double avg = getaveg(marks);
            Console.WriteLine("average is {0}", avg);
        }
    }
}
