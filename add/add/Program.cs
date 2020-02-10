using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add
{
    class Program
    {
        public static void Sum(int num1, int num2)
        {
            int total;
            total = num1+num2;
            Console.WriteLine(total);
        }
        public static void mul(int s1, int s2)
        {
            int result;
            result = s1 * s2;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nFunction to calculate the sum of two numbers :\n");
            
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 1 for add 2 for mul");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("\nThe sum of {0} and {1}  is : ", a,b);
                Sum(a, b);
            }
            else
            {

                Console.WriteLine("\n The pro of {0} and {1} is :", a, b);
                mul(a, b);

            }
        }
    }
}
