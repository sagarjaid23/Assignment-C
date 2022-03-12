using System;

namespace Logical_Progrmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility u = new Utility();
            Console.Write("Enter the Class Number: ");
            int num = u.ReadInt();
            switch (num)
            {
                case 1: new Fibonacci_Number(); break;
                case 2: new Perfect_Number(); break;
                case 3: new Prime_Number(); break;
                case 4: new Reverse_Number(); break;
                case 5: new Coupon_Number(); break;
               
                default:
                    Console.WriteLine("No such Class Name: ");
                    break;
            }
        }
    }
}
