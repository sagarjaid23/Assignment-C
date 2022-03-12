using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progrmas
{
    internal class Perfect_Number
    {
        public Perfect_Number()
        {
            IsPerfectNumber();
        }
        static void IsPerfectNumber()
        {
            Utility u = new Utility();
            int sum = 0;
            int n = 0;
            Console.WriteLine("Please Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }

            }

            if (sum == n)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
            }
        }
    }
    
}
