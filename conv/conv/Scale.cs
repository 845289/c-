using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conv
{
    class Scale
    {
        double centimetre;
        public double inch
        {
            get { return centimetre/2.54; }
            set
            {
                centimetre = value * 2.54;
            }
        }
        public void showscale()
        {
            Console.WriteLine("centimetre {0}", centimetre);
        }
    }
}
