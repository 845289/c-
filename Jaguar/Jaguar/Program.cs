using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaguar
{
    class Program
    {
        static void Main(string[] args)
        {
            get1();
            get2();
            get3();
            get4();
        }

        private static void get4()
        {
            Car m4 = new Car("98654");
            m4.showcar();
        }

        private static void get3()
        {
            Car m3 = new Car("79642","Hyundai");
            m3.showcar();
        }

        private static void get2()
        {
            Car m2 = new Car("86252","Jaguar","black");
            m2.showcar();
        }

        private static void get1()
        {
            Car m1 = new Car("76543","Lambo","red",2390090);
            m1.showcar();
        }
    }
}
