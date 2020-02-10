using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopdem
{
    class Exam
    {
        String name, id, centre;
        int marks;
        public void get(String n,String id,String c,int m)
        {
            name = n;
            this.id = id;
            centre = c;
            marks = m;
        }
        public void show()
        {
            Console.WriteLine(name);
            Console.WriteLine(id + " " + centre);
            Console.WriteLine(marks);
            Console.WriteLine();
            
        }
    }
}
