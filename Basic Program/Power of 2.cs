using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Power_of_2
    {
        public Power_of_2()
        {
            PrintPower();
        }
        static void PrintPower()
        {
            Utility u = new Utility();
            Console.Write("Enter the number: ");
            int num = u.ReadInt();
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}