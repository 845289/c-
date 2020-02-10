using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer1
{
    class Indx<T>
    {
        private T[] arr = new T[100];
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    class Student
    {
        public int ID;
        public string stname;
        public string course;

        public int id { get; set; }
        public string Sname { get; set; }
        public string Course { get; set; }
    }
    class program
    {

    
        static void Main(string[] args)
        {
            var stringcol = new Indx<string>();
            stringcol[0] = "this is a Indexer demo";
            Console.WriteLine(stringcol[0]);
            var stdetails = new Indx<Student>();
            stdetails[0] = new Student
            {
                ID = 985,
                stname = "ambica",
                course = "c#",
            };
            stdetails[1] = new Student
            {
                ID = 555,
                stname = "kalyani",
                course = "c",
            };
            Console.WriteLine("{0}\t{1}\t{2}\t", stdetails[0].ID, stdetails[0].stname, stdetails[0].course);
            Console.WriteLine("{0}\t{1}\t{2}\t", stdetails[1].ID, stdetails[1].stname, stdetails[1].course);
        }
    }
    
}
