using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progrmas
{
    internal class Fibonacci_Number
    {
        public Fibonacci_Number()
        {
            IsFibonacciNumber();
        }
        static void IsFibonacciNumber()
        {
            Utility u = new Utility();
            
        int a = 0;
        int b = 1;
        int c;

        Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i< 5; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }

    Console.ReadLine();
                
        }
    }
}
