using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrev
{
    class Cla
    {
        public string name;
        public string game;
        public string id;
        public string level;
        public void arrev(string n,string g,string i,string l)
        {
            name = n;
            game = g;
            id = i;
            level = l;
            Console.WriteLine("name :" + name + "game :" + game + " id " + id + " level  " + level );
        }
    }
}
