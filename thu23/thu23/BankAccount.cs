using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thu23
{
    class BankAccount
    {
        public Customer customer;
        int account_num;
        double account_bal;
         public double si;
        public int Ac
        {
            get; set;
        }
        public double acb
        {get; set;}
        public virtual double simplein()
        {
            int r = 3;
            int t = 3;

           si =(acb * t * r) / 100;
            return si;
        }
    }
}
