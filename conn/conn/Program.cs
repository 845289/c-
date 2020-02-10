using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Source = BLT1078\SQLEXPRESS2014; Initial Catalog = EmployeDB; Integrated Security = True
            Class1 c1 = new Class1();
            c1.show();
            c1.insert();
            c1.show();
        }
    }
}
