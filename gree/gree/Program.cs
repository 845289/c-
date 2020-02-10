using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gree
{
    class Program
    {
        static String greeting(int age, String name)
        {

            return String.Format("Congratulations {0} on your {1} birthday", name, age);
        }
        static void Main(string[] args)
        {
            int a;
            String n, s;
            Console.WriteLine("enter name");
            n = Console.ReadLine();
            Console.WriteLine("enter age");
            a = int.Parse(Console.ReadLine());
            s = greeting(a, n);
            Console.WriteLine(s);
            Console.ReadKey();


        }
    }
}