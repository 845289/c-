using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //object of trainee class
            get1();
            get2();
            get3();
        }

        private static void get3()
        {
            trainee tr2 = new trainee();
            tr2.age = 12;
            Console.WriteLine(tr2.age);
        }

        private static void get2()
        {
            trainee tr1 = new trainee();
            tr1.getdata("christopher", "855077", "chittoor", 21);
            tr1.Show();
        }

        private static void get1()
        {
            trainee tr = new trainee();
            tr.getdata("vishnu", "855087", "chittoor", 21);
            tr.Show();
        }
    }
}
