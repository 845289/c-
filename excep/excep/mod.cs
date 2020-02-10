using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excep
{
    class mod
    { 
        public double div(double a,double b)
        {
            if(b==0)
            {
                throw new System.DivideByZeroException();
            }
            return a % b;
        }
    }
}
