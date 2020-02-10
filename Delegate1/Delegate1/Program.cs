using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        static void Main(string[] args)
        {
            Mydel delg = new Mydel(subtract);
            Console.WriteLine(delg(20, 50));
            delg += new Mydel(Add);
            Console.WriteLine(delg(12, 25));
            delg -= new Mydel(Add);
            Console.WriteLine(delg(20, 50));
            Square 
            
        }
        static string Add(int x,int y)
        {
            int z = x + y;
            return string.Format("{0}+{1}={2}",x, y, z);
        }
        static string subtract(int x,int y)
        {
            int z = x - y;
            return string.Format("{0}-{1}={2}", x, y, z);
        }
       
    }
}
