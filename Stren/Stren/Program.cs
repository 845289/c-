using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stren
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder("helo");
            Console.WriteLine(stb);
            stb.Append(2345);
            Console.WriteLine("Append long values {0}",stb);
            int i = stb.Capacity;
            Console.WriteLine("Initial capacity of StringBuilder {0}", i);
            stb.Insert(6, "world");
            Console.WriteLine("Inserted at 6 id {0}", stb);
            stb.Remove(7, 3);
            Console.WriteLine("After removing {0}",stb);
            stb.Replace("lo", "arious");
            Console.WriteLine("After replaxing {0}",stb);
        }
    }
}
