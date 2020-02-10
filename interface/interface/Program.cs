using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface

{
    public interface ihello
    {
        void getit();
    }
    public interface hhello
    {
        void shedit();
    }
    class Program
    {
        static void Main(string[] args)
        {
            
           Doit i = new Doit();
            i.getit();
            i.shedit();
            
        }
    }
}
