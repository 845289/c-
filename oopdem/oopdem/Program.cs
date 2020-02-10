using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopdem
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam e1 = new Exam();
            e1.get("vishnu", "65614", "blr", 99);
            e1.show();
                
        }
    }
}
