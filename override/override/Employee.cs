using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @override
{
    class Employee
{
        int id;
        string address;
        string name;
        public int Id { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
        public Department  dept { get; set; }
        public virtual string empsalary (double sal)
        {
            return string.Format("no salary  :(");
        }
}
}
