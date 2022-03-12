using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progrmas
{
    internal class Reverse_Number
    {
        public Reverse_Number()
        {
            IsReverseNumber();
        }
        static void IsReverseNumber()
        {
            Utility u = new Utility();
            Console.WriteLine("Please Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int rem;

            while (num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number is:" + result);

        }
    }
    
}
