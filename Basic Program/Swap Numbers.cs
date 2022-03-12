using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Swap_Numbers
    {
        public Swap_Numbers()
        {
            IsSwapNumbers();
        }

        static void IsSwapNumbers()
        {
            Utility u = new Utility();
            int a;
            int b;
            int temp;
            Console.WriteLine("Please Enter a:");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping Value of a={0},b={1}", a, b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping Value of a={0},b={1}", a, b);
        }

        

    }
}
