using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lair
{
   public  interface lairborne
    {
        void fly();
    }
    class Program
    {
        static void Main(string[] args)
        {
            lairborne l;
            l = new Helicopter();
            l.fly();
            l = new Aeroplane();
            l.fly();
        }
    }
}
