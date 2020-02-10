using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace link
{
    class arr
    {
        public void array(int[] a)
        {
            foreach(int i in a)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
