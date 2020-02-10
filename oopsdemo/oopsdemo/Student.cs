using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class Student
    {
        String fname;
        String Lname;
        int id_no;
        String course;
        DateTime joindate;
       public Student(String fname,String lname)
        {
            this.fname = fname;
            Lname = lname;
        }
        public String Fname
        {
            get { return fname; }
            
        }
        public String lname
        {
            get { return Lname; }
        }

        public int idno
        {
            get { return id_no; }
            set { id_no = value; }
        }
        public String Course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime Joindate
        {
            get { return joindate; }
            set { joindate = value; }
        }

        
        
    }
}
