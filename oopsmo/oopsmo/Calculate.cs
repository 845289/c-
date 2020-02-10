using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsmo
{
    class Calculate
    {
        public string Area(int side)
        {
            int ar = side * side;
            return string.Format("square area = {0}",ar);
        }
        public string Area(int l,int b)
        {
            int ar = l * b;
            return string.Format("Rectangle area ={0}",ar);
        }
        public string Area(double r)
        {
            double ar = r * r;
            return String.Format("Area of circle {0}", ar);
        }
        public String Area(double b,int h)
        {
            double ar = 0.5 * b * h;
            return string.Format("Triangle area {0}", ar);
        }
    }
}
