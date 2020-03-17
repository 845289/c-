using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class A { public int i; public void display() { Console.WriteLine(i); } }
    class B : A { public int j; public void display() { Console.WriteLine(j); } }
    class Program { static void Main(string[] args) { B obj = new B(); obj.i = 1; obj.j = 2; obj.display(); Console.ReadLine(); } } 
}
