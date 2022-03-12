using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Progrmas
{
    internal class Coupon_Number
    {
        public Coupon_Number()
        {
            GenCoupan();
        }
        static void GenCoupan()
        {
            Utility u = new Utility();
            Console.Write("Enter the number of coupons you want: ");
            int num = u.ReadInt();
            Random rc = new Random();
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string[] array = new string[num];
            for (int i = 0; i < num; i++)
            {
                int rn1 = rc.Next(0, 100);
                int rn = rc.Next(26);
                char rn2 = alpha[rn];
                int rn3 = rc.Next(222, 444);
                int rn4 = rc.Next(26);
                char rn5 = alpha[rn4];
                int rn6 = rc.Next(26);
                char rn7 = alpha[rn6];
                string coupon = " " + rn1 + rn2 + rn5 + rn7 + rn3 + rn2 + rn6 + rn7 + rn;
                array[i] = coupon;
                int val = i;
                if (i != 0)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (coupon == array[j])
                        {
                            i--;
                        }
                    }
                }
            }
            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(" CoupanNumber : " + array[k]);
            }

        }
    }
}
