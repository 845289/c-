using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbfirst
{
    class Program
    {
         static EmployeDBEntities3 e = new EmployeDBEntities3();
        static void Main(string[] args)
        {
            //allstudents();
            insert1();
            
        }
        private static void insert1()
        {
            Console.WriteLine("enter student id");
           int sid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter student name");
            string sname = Console.ReadLine();
            Console.WriteLine("enter course");
            string course = Console.ReadLine();
           // Console.WriteLine("enter course id");
            //int c_id = int.Parse(Console.ReadLine());
            var students = new student
            {
                id = sid,
                name = sname,
                course=course
               // course = course,
              //  course_id = c_id
            };
            e.students.Add(students);
            e.SaveChanges();
        }

        private static void allstudents()
        {
            var students = e.students;
            foreach (var o in students)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t", o.id, o.name, o.course);
            }
        }
    }
}
