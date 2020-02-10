using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nonstat
{
    class Sales
    {
        string proname;
        int quantity;
        double price;

        public static double totalsales = 0;

        public static double pro1()
        {
            totalsales = +totalsales;
            return totalsales;
        }
        public string Proname
        {
            get { return proname; }
            set { proname = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double Saleamt
        {
            get { return price * quantity; }
        }
        public double Totalsales
        {
            get { return totalsales += Saleamt; }
        }
    }
}
