using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;
            short s = 359;
            int n = 99;
            uint ui = 99;
            long l= 937;
            ulong ul= 92237;
            float f = 1.99f;
            double d = 333333.34344;
            decimal de = 1000000000000;
            DateTime dt = DateTime.Now;
            Console.WriteLine("byte = {0} \n short s ={1} \n int n = {2} \n uint ui={3} \n long l ={4} \n ulong ul ={5} \n float f = {6} \n double d = {7} \n decimal de ={8} \n datetime = {9} ", b, s, n, ui, l, ul, f, d, de,dt);
        }
    }
}
