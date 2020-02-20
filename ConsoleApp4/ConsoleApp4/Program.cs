using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0;
            int[] a = { 1, 3, 5, 7, 10 };
            int[] b = { 1, 2, 4, 10 };
            int[] c = new int[100];
           int len = a.Length + b.Length;
            for(i=0;i<a.Length;i++)
            {
                c[i] = a[i];
            }
            for(int j=i+1,int g=0;)
           /* c[0] = a[0];
            c[1] = a[1];
            c[2] = a[2];
            c[3] = a[3];
            c[4] = a[4];
            c[5] = b[0];
            c[6] = b[1];
            c[7] = b[2];
            c[8] = b[3];*/

            foreach (int k in c)
            {
                Console.WriteLine("{0}", k);
            }

        }
    }
}
