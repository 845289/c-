using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrev
{
    class Program
    {
        public int[] rev(int[] a)
        {
            Array.Reverse(a);
            return a;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Program n = new Program();
            int[] i=n.rev(a);
            foreach(int j in i)
            {
                Console.WriteLine(j);
            }
            int[] z = { 1, 2, 3, 4, 5 };
            tot o = new tot();
            Console.WriteLine(o.total(z));
            Cla m = new Cla();
            m.arrev("vishnu", "dungean", "123ew", "12");
            Stru t;
            t.code = "#45421";
            t.damn="gd damn";
            t.hash = "$kmfcdjf";
            Console.WriteLine("code : " + t.code + " damn :" + t.damn + " hash :" + t.hash);


        }
    }
}
