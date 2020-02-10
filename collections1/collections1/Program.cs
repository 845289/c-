using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            //arraylist();
            Hashtable hst = new Hashtable();
            hst.Add("raju", 12345);
            hst.Add("karan", 5678);
            hst.Add("rjun", 6789);
            foreach (string k in hst.Values)
            {
                Console.WriteLine(k);
            }
            hst.Remove("karan");

            ArrayList al = new ArrayList() { "goku", "gohan", "gotan", "pikalu", "vigeta" };
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Sort();
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("freeza");
            al.Add("cell");
            al.Insert(4,"kick bu");
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Reverse();
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            string[] r = new string[] { "cat", "mat" };
            al.SetRange(4, r);
            foreach(string a in al)
            {
                Console.WriteLine(a);

            }
            al.RemoveRange(2, 2);
            Console.WriteLine();
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            

        }
    }
}
