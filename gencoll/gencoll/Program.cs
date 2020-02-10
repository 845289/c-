using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gencoll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cour> courlist = new List<cour>();
            courlist.Add(new cour { cid = 1, cname = "c#", startdate = DateTime.Today, fees = 6000 });
            courlist.Add(new cour { cid = 2, cname = "c", startdate = DateTime.Parse("05-02-2020"), fees = 5000 });
            courlist.Add(new cour { cid = 3, cname = "python", startdate = Convert.ToDateTime("06-05-2020"), fees = 6000 });

            foreach (cour cr in courlist)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", cr.cid, cr.cname, cr.startdate, cr.fees);
            }
        }
    }
}
