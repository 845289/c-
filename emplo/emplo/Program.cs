using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpCollection k = new EmpCollection();
            k.add(0, "oleg", "god", 10000);
            k.add(1, "arthur", "stupid", 18990);
            k.add(2, "affleck", "vigilante", 9088);
            k.add(3, "wayne", "thebat", 90887);
            k.show();
            k.remove(2);
            k.show();
        
        }
    }
}
