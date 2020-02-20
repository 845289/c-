using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace db
{
    class Program
    {
        static void Main(string[] args)
        {
            display2 d2 = new display2();
            display srt = d2.ShowbyId(3);
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\n", srt.Name, srt.Id, srt.Type, srt.Location);

            // Console.WriteLine("enter id");
            // int Id = Convert.ToInt32(Console.ReadLine());


        }

        private static void byquery()
        {
            insertbyquery iq = new insertbyquery();
            iq.show();
            iq.insert();
            iq.show();
        }

        private static void insertdynamically()
        {
            display rt = setdata();
            display2 d2 = new display2();
            d2.showmenu(rt);
            display r = new display();
            r.showrestaurent();
        }

        public static display setdata()
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter type");
            string type = Console.ReadLine();
            Console.WriteLine("enter location");
            string location = Console.ReadLine();
            display rts = new display();
            rts.Name = name;
            rts.Id = id;
            rts.Type = type;
            rts.Location = location;
            return rts;
        }
    }
    }
}
