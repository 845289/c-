using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datafirst
{
     class Program
    {
        static EmployeDBEntities e = new EmployeDBEntities();
        static void Main(string[] args)
        {
           // show();
            insert();
            insert1();

        }

        private static void insert()
        {
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter course name");
            string cname = Console.ReadLine();
            Console.WriteLine("enter date");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            var courses = new courses
            {
                Id = id,
                course = cname,
                startdate = date

            };
            e.courses.Add(courses);
            e.SaveChanges();

            
        }

        private static void insert1()
        {
            Console.WriteLine("enter student id");
            int sid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter student name");
            string sname = Console.ReadLine();
            Console.WriteLine("enter course");
            string course = Console.ReadLine();
            Console.WriteLine("enter course id");
            int c_id = int.Parse(Console.ReadLine());
            var students = new student
            {
                Id = sid,
                sname = sname,
                course = course,
                course_id = c_id
            };
            e.students.Add(students);
            e.SaveChanges();
        }

        private static void show()
        {
            Console.WriteLine("all courses ");
            var courses = e.courses;
            foreach (var t in courses)
            {
                Console.WriteLine("{0}\t{1}\t{2}", t.Id, t.course, t.startdate);
            }
            var students = e.students;
            foreach (var o in students)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", o.Id, o.sname, o.course, o.course_id);
            }
        }
    }
}
