using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class Timeperiod
    {
        double seconds;
        public double hours
        {
            get { return seconds / 3600; }
            set
            {
                if (value < 0||value>24)
                {
                    throw new Exception("value must be between 0 and 24");
                }
                seconds = value * 3600;
            }
        }
        public void Showsecond()
        {
            Console.WriteLine("seconds {0}",seconds);
        }
        
    }
}
