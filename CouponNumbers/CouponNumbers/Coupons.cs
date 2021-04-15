using System;
using System.Collections.Generic;
using System.Text;

namespace CouponNumbers
{
    class Coupons
    {
        public static void ReadNumOfCoupons()
        {
            Console.WriteLine("Enter the num for distinct coupons");
            int couponNo = Convert.ToInt32(Console.ReadLine());
            FindOutRandomCount(couponNo);
        }
        private static void FindOutRandomCount(int CouponNo)
        {
            int distinct = 0, count = 0;
            bool[] iscollected = new bool[CouponNo];
            while (distinct < CouponNo)
            {
                Random random = new Random();
                int newRandom = (int)random.NextDouble() * CouponNo;
                count++;
                if (!iscollected[newRandom])
                {
                    distinct++;
                    iscollected[newRandom] = true;
                }
            }
            Console.WriteLine("total random number needed to have all distict coupons:" + count);
        }
    }
}
