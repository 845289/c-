using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread1
{
    class Program

    {
        
        static void Main(string[] args)
        {
            ThreadStart st = new ThreadStart(getnumbers);
            Thread t = new Thread(st);
            t.Start();
            ThreadStart ts = new ThreadStart(geteven);
            Thread s = new Thread(ts);
            s.Start();


        }
        public static void getnumbers()
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        public static void geteven()
        {
            for (int j = 0; j <= 10; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(j);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
