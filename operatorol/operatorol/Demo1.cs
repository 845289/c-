using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorol
{
    struct Demo1
    {
        int no;
        int no1;
        public Demo1(int a, int b)
        {
            no = a;
            no1 = b;
        }
        public void showdata()
        {
            Console.WriteLine("{0}\t{1}", no, no1);
        }
        public static Demo1 operator +(Demo1 x, Demo1 y)
        {
            Demo1 t = new Demo1();
            t.no = x.no + y.no;
            t.no1 = x.no1 + y.no1;
            return t;
        }
        public static Demo1 operator -(Demo1 x, Demo1 y)
        {
            Demo1 t = new Demo1();
            t.no = x.no - y.no;
            t.no1 = x.no1 - y.no1;
            return t;
        }
    }
}