using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Odd_Even_Number
    {
        public Odd_Even_Number()
        {
            IsoddEvenNumber();
        }

        static void IsoddEvenNumber()
        {
            Utility.u = new Utility();
            Console.WriteLine("Please Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Numer is Even Number");
            }
            else
            {
                Console.WriteLine("Number is Odd Number");
            }
        }
    }
}
