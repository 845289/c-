using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    class Calculator
    {
        int a, b;
        public Calculator() { }
        public Calculator(int a)
        {
            this.a = a;
        }
        public Calculator(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Add()
        {
            return a + b;
        }
        public int Diff()
        {
            return a - b;
        }
        public int Mul()
        {
            return a * b;

        }
        public int Div()
        {
            return a / b;
        }

    }
}
