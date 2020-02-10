using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtoo
{
    class Program
    {
        public string str(string[] x)
        {
            return string.Join(" ", x);

           
        }
        static void Main(string[] args)
        {
            string[] str;
            str = new string[] { "what", "the", "heck" };
            Program p = new Program();
            Console.WriteLine(p.str(str));
            fnln k = new fnln();
            Console.WriteLine( k.finlan("vishnu", " A"));
            slit h = new slit();
            
             string[] s = h.spli("catch me if you can");
            foreach(string j in s)
            {
                Console.WriteLine(j);
            }
        }
    }
}
