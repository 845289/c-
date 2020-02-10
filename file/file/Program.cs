using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\DS\hello.txt";
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter you name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your city");
                    string city = Console.ReadLine();
                    Console.WriteLine("Enter your id");
                    string id = Console.ReadLine();
                    sw.WriteLine("name:" + name);
                    sw.WriteLine("City:" + city);
                    sw.WriteLine("Id: "+ id);
                }
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

            }
        }
    }
}
