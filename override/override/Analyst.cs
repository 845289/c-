using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @override
{
    class Analyst:Employee
{
        public override string empsalary(double sal)
        {
            double incentive = 10000000;
            double total =incentive +sal;
            return total.ToString();
        }
    }
}
