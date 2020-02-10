using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibCalculation
{
    public class Calculation
    {
        public int no1 { get; set; }
        public int no2 { get; set; }
        public string Add()
        {
            return string.Format("sum={0}", no1 + no2);
        }
        public string Sub()
        {
            return string.Format("sub={0}", no1 - no2);
        }
        public string Mul()
        {
            return string.Format("Mul={0}", no1 * no2);
        }
        public string Div()
        {
            return string.Format("Div={0}", no1 / no2);
        }
    }
}
