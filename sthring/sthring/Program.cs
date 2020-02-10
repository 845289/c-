using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sthring
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "hello world";
            Console.WriteLine(data);
            string a = data.Insert(6, "my ");
            string bn = "you are so nice.";
            Console.WriteLine(a);
            Console.WriteLine(string.Concat(a,bn));
            string up = data.ToUpper();
            string lc = up.ToLower();
            Console.WriteLine("substring {0} ",bn.Substring(4,4));
            Console.WriteLine("{0}\t{1}",up,lc);
            string[] names = new string[] { "jathin", "darshik", "thaman" };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",",names);
            Console.WriteLine(allnames);
            string st1 = "welcome to chennai";
            string[] words = st1.Split();
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            string nstr = string.Copy(st1);
            Console.WriteLine("Copied  string is {0}",nstr);
            int i = st1.IndexOf("to ");
            Console.WriteLine("index of is {0}", i);
            int l = st1.Length;
            Console.WriteLine("length of the string is {0}",l);
            words.Reverse();
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            int nx = string.Compare("hello","world");
            Console.WriteLine("Comparision is {0}",nx);

        }
    }
}
