using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numtoword
{
    class ntw
    {

        public   string numbertoword(long n)
        {
           long reves= rev(n);
            //Console.WriteLine(reves);
           // int j = 0; 
            int b= n.ToString().Length;
            string[] words = { "zero ", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine " };
            //  string[] numtowords = { };
            string numword="";
            for (int i =0;i<b;i++)
            {
               // Console.WriteLine(i);
                long num = reves % 10;
                 reves = reves / 10;
               // Console.WriteLine(num);
                for(int j=0;j<words.Length;j++)
                {
                   //Console.WriteLine(v);
                    if (num ==j)
                    {

                        //Console.WriteLine(words[j]);
                        numword += words[j];
                        
                    }
                   // j++;
                }
            }
           return numword; 
        }
        public long rev(long n)

        {
            long rev = 0, remainder = 0;
            // printf("Enter an integer: ");
            //scanf("%d", &n);
            while (n != 0)
            {
                remainder = n % 10;
                rev = rev * 10 + remainder;
                n /= 10;
            }
            return rev;
        }
    }
}
