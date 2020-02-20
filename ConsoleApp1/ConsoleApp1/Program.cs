using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sample {  public int i;  public int j;  public void fun(int i, int j) { this.i = i;  this.j = j; } }  class Program { static void Main(string[] args) {sample s = new sample(); s.i = 1;s.j = 2;s.fun(s.i, s.j); Console.WriteLine(s.i + " " + s.j);Console.ReadLine();} } 
}
