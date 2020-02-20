using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aarraay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 45, 55, 89, 78, 45 };
            foreach (int i in marks)
            {
                Console.WriteLine(i);
            }
        }
    }
}
