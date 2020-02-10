using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateevent
{
    class Program
    {
        public delegate void Deleventhandler();
        public static event Deleventhandler handler;
        static void Main(string[] args)
        {
            handler += new Deleventhandler(square);
            handler += new Deleventhandler(circle);
            handler.Invoke();
        }
        static void circle()
        {
            double r = 12.5;
            double ar = Math.PI * r * r;
            Console.WriteLine("Area of circle :{0}", ar);
        }
        static void square()
        {
            int s = 5;
            int a = 5 * 5;
            Console.WriteLine("square {0}", a);
        }
    }
}
