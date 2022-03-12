using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Quationent_and_Remainder
    {
        public Quationent_and_Remainder()
        {
            IsQuationentandRemainder();
        }

        static void IsQuationentandRemainder()
        {
            Utility u = new Utility();
            int diviend;
            int divisor;
            int quotient;
            int remainder;
            Console.WriteLine("Please diviend:");
            diviend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter divisor");
            divisor = Convert.ToInt32(Console.ReadLine());


            quotient = (diviend/divisor);
            remainder = diviend % divisor;

            Console.WriteLine("Quotient=" + quotient);
            Console.WriteLine("Remainer=" + remainder);
        }
    }
}
