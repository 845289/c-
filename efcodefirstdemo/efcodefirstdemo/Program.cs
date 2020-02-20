using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcodefirstdemo
{
    class Program
    {
        private static void insertdata()
        {
            EmployeeContext ect = new EmployeeContext();
            Console.WriteLine("enter id");
            int eid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name");
            string name = Console.ReadLine();
            Console.WriteLine("enter designation");
            string designation = Console.ReadLine();
            Console.WriteLine("enter salary");
            double sal = Convert.ToDouble(Console.ReadLine());
            ect.Employes.Add(new Employee { Eid = eid, Ename = name, Designation = designation, Salary = sal });
           
            ect.SaveChanges();
            Console.WriteLine("data" +
                " inserted");
        }
        private static void showdata()
        {
            EmployeeContext empctx = new EmployeeContext();

            //var emp1 = from e in empctx.Employees;

            var employees = empctx.Employes;
            foreach (var emp in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);
            }
        }
        private static void search()
        {
            Console.WriteLine("enter id");
            int i = int.Parse(Console.ReadLine());
            EmployeeContext empctx = new EmployeeContext();
            if (empctx.Employes.Find(i) == null)
            {
                Console.WriteLine("no record found");
            }

            //var emp1 = from e in empctx.Employees;

            var employees = from d in empctx.Employes
                            where d.Eid ==i
                            select d;
            foreach(var res in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t",res.Eid, res.Ename, res.Designation, res.Salary);
            }
        }
        private static void update()
        {
            Console.WriteLine("enter id");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("enter new designation");
            string desg = Console.ReadLine();
            EmployeeContext e = new EmployeeContext();
            if (e.Employes.Find(i) == null)
            {
                Console.WriteLine("no record found");
            }
            var up = from data in e.Employes
                     where data.Eid == i
                     select data;
            foreach (var d in up)
            {
                d.Designation = desg;
            }
            e.SaveChanges();
            Console.WriteLine("record updated");

        }
        private static void delete()
        {
            Console.WriteLine("enter id");
            int i = int.Parse(Console.ReadLine());

            EmployeeContext u = new EmployeeContext();
            if(u.Employes.Find(i)==null)
            {
                Console.WriteLine("no record found");
            }
            var deld = u.Employes.Find(i);
            u.Employes.Remove(deld);
            u.SaveChanges();
            Console.WriteLine("record deleted");


        }





        static void Main(string[] args)
        {
           // insertdata();
            //showdata();
          // Console.WriteLine("enter id");
           // int i = int.Parse(Console.ReadLine());
            // search(i);

           // Console.WriteLine("enter new designation");
            //string desg = Console.ReadLine();
            //update(i, desg);
            //delete(i);
            Console.WriteLine("1->insert\n2->show\n3->search\n4->update\n5->delete");
            int inp = int.Parse(Console.ReadLine());
            switch(inp)
            {
                case 1:
                    insertdata();
                    break;
                case 2:
                    showdata();
                    break;
                case 3:
                    search();
                    break;
                case 4:
                    update();
                    break;
                case 5:
                    delete();
                    break;
            }
           

        }
    }
}