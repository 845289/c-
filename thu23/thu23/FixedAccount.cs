using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thu23
{
    class FixedAccount:BankAccount
    {
        BankAccount v = new BankAccount();
        public override double simplein()
        {
            
            double newadd = v.acb *0.06;
            Console.WriteLine(newadd);
            return newadd;
        }

    }
}
