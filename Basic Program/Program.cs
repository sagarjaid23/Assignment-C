using System;

namespace Basic_Program
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

                case 1: new FlipCoin(); break;
                case 2: new Leap_Year(); break;
                case 3: new Power_of_2(); break;
                case 4: new Harmonic_Number(); break;
                case 5: new Factors(); break;
                case 6: new Quationent_and_Remainder(); break;
                case 7: new Swap_Numbers(); break;
                case 8: new Odd_Even_Number(); break;
                    case 9: new Vowel_or_Not();break;
                    case 10: new Max_Number();break;
                default:
                    Console.WriteLine("No such Class Name: ");
                    break;
            }
        }
    }
}
