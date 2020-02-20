using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part
{
    class Program
    {
        public partial class Geeks
        {
            private string Author_name;
            private int Total_articles;

            public Geeks(string a, int t)
            {
                this.Author_name = a;
                this.Total_articles = t;
            }
        }
        public partial class Geeks
        {
            public void Display()
            {
                Console.WriteLine("Author's name is : " + Author_name);
                Console.WriteLine("Total number articles is : " + Total_articles);
            }
        }


        static void Main(string[] args)
        {
           
            Geeks s = new Geeks("niuefiujers",18);
            
            s.Display();
        }
    }
}
