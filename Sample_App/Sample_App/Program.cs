using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            String ename;
            Console.WriteLine("enter your name");
            ename = Console.ReadLine();
            Console.WriteLine("enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Congratulations Mr/Ms {0} on your  Birthday {1} ",ename,age);
            Console.ReadKey();
        }
    }
}
