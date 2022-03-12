using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progrmas
{
    internal class Prime_Number
    {
        public Prime_Number()
        {
            IsPrimeNumber();
        }
        static void IsPrimeNumber()
        {
            Utility u = new Utility();
            Console.WriteLine("Please Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;


            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
    
}
