using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klkl
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<course> st = new Stack<course>();
            st.Push(new course { cid = 1, cname = "c#", startdate = DateTime.Today, fees = 6000 });
            st.Push(new course { cid = 2, cname = "c2", startdate = DateTime.Parse("05-06-2020"), fees = 5000 });
            foreach (course s in st)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", s.cid, s.cname, s.startdate, s.fees);
            }
            Console.WriteLine("queue");

            Queue<course> qc = new Queue<course>();
            qc.Enqueue(new course { cid = 1, cname = "c#", startdate = DateTime.Today, fees = 6000 });
            qc.Enqueue(new course { cid = 2, cname = "c", startdate = DateTime.Parse("05-06-2020"), fees = 5000 });
            foreach (course c in qc)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", c.cid, c.cname, c.startdate, c.fees);
            }
        }
    }
}
