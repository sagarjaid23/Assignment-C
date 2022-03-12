using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Max_Number
    {
        public Max_Number()
        {
            IsMaxNumber();
        }

        static void IsMaxNumber()
        {
            Utility.u = new Utility();
            int num1, num2, num3;
            string result;
            Console.WriteLine("First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num2)
            {
                result = "The First Number is Greatest Number \n" +num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                result = "The Second Number is Greatest Number \n" + num2;
            }
            else
            {
                result = "The Third Number is Greatest Number \n" + num3;
            }
            Console.WriteLine(result);
        }
    }
}