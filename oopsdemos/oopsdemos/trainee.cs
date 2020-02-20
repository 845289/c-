using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemos
{
    class trainee
    {
        //data fields
         public String name, id, address;
        public int age;
         public void getdata(String n,String id,String addr, int age)
        {
            name = n;
            this.id = id;
            address = addr;
            this.age = age;
        }
            public void Show()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(address);
            Console.WriteLine(age);
            Console.Write("\n");
        }


    }
}
