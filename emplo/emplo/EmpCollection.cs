using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace emplo
{
    class EmpCollection
    {
        List<Employee> lstEmp = new List<Employee>();
        public void add(int empid, string empname, string desg, double sal)
        {
            lstEmp.Add(new Employee {E_id=empid,E_name=empname,Designation=desg,salary=sal});
        }
        public void show()
        {
            foreach(Employee e in lstEmp)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",e.E_id,e.E_name,e.Designation,e.salary);
                
            }
            Console.WriteLine("\n");
        }
        public void remove(int n)
        {
            lstEmp.RemoveAt(n);
        }
       
    }
}
