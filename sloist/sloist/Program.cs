using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sloist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList slist = new SortedList();
            slist.Add("teja", 123);
            slist.Add("ambi", 124);
            slist.Add("vish", 125);
            slist.Add("siri", 126);
            foreach (string i in slist.Keys)
            {
                Console.WriteLine(i);
            }
            foreach (int v in slist.Values)
            {
                Console.WriteLine(v);
            }


        }
    }
}
