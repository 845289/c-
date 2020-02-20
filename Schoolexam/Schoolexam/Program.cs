using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolexam
{
    class Program
    {
        static ExammodContainer efc = new ExammodContainer();

        static void Main(string[] args)
        {
            {
                show();
                //insert();

            }
        }

        private static void insert()
        {
            insertschool();
            insertexam();
            insertinvijilator();
            insertcourse();
            insertsubject();
            insertstudent();
        }

        private static void show()
        {
            courseshow();
            examsshow();
            schoolshow();
            invigilatorshow();
            subjectshow();
            studentshow();
        }

        private static void insertstudent()
        {
            Console.WriteLine("enter student id");
            int stid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("enter course id");
            int cid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter school id");
            int scid = int.Parse(Console.ReadLine());
            var students = new Student { Stid = stid, Stname = name, CourseCid = cid, SchoolSid = scid };
            efc.Students.Add(students);
            efc.SaveChanges();
        }

        private static void insertsubject()
        {
            Console.WriteLine("enter subject id");
            int sid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter subject name");
            string name = Console.ReadLine();
            Console.WriteLine("enter course id");
            int cid = int.Parse(Console.ReadLine());
            var subjects = new Subject { Suid = sid, Suname = name, CourseCid = cid };
            efc.Subjects.Add(subjects);
            efc.SaveChanges();
        }

        private static void insertcourse()
        {
            Console.WriteLine("enter course id");
            int cid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter course name");
            string cname = Console.ReadLine();
            Console.WriteLine("enter school id");
            int scid = int.Parse(Console.ReadLine());
            var courses = new Course { Cid = cid, Cname = cname, SchoolSid = scid };
            efc.Courses.Add(courses);
            efc.SaveChanges();
        }

        private static void insertinvijilator()
        {
            Console.WriteLine("enter invigilator id");
            int iid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter invigilator name");
            string name = Console.ReadLine();
            Console.WriteLine("enter school id");
            int scid = int.Parse(Console.ReadLine());
            var invigilators = new Invigilator { Iid = iid, Iname = name, SchoolSid = scid };
            efc.Invigilators.Add(invigilators);
            efc.SaveChanges();
        }

        private static void insertexam()
        {
            Console.WriteLine("enter eid");
            int eid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter school id");
            int scid = int.Parse(Console.ReadLine());
            var exams = new Exam { Eid = eid, SchoolSid = scid };
            efc.Exams.Add(exams);
            efc.SaveChanges();
        }

        private static void insertschool()
        {
            Console.WriteLine("enter school id");
            int scid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter school name");
            string sc_name = Console.ReadLine();
            Console.WriteLine("enter location");
            string location = Console.ReadLine();
            var schools = new School { Sid = scid, Sname = sc_name, Slocation = location };
            efc.Schools.Add(schools);
            efc.SaveChanges();
        }

        private static void studentshow()
        {
            var students = efc.Students;
            foreach (var c in students)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", c.Stid, c.Stname, c.Course.Cname, c.School.Slocation, c.School.Sid);
            }
        }

        private static void subjectshow()
            {
                var subject = efc.Subjects;
                foreach (var c in subject)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", c.Suid, c.Suname, c.Course.Cid);
                }
            }

            private static void invigilatorshow()
            {
                var invigilator = efc.Invigilators;
                foreach (var c in invigilator)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", c.Iid, c.Iname, c.School.Slocation);
                }
            }

            private static void schoolshow()
            {
                var school = efc.Schools;
                foreach (var c in school)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", c.Sid, c.Sname, c.Slocation);
                }
            }

            private static void examsshow()
            {
                var exams = efc.Exams;
                foreach (var c in exams)
                {
                    Console.WriteLine("{0}\t{1}\t", c.Eid, c.School.Slocation);
                }
            }

            private static void courseshow()
            {
                var cources = efc.Courses;
                foreach (var c in cources)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", c.Cid, c.Cname, c.School.Sid);
                }
            }
        }
    }

