using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoinProgram
{
    class FlipCoin
    {
        public static void ReadInput()
        {
            Console.WriteLine("Please enter number of times to flip coin");
            string input = Console.ReadLine();
            int numOfTimes = Convert.ToInt32(input);
            Flip(numOfTimes);
        }


        private static void Flip(int numOfTimes)
        {
            int tail = 0; int head = 0;
            Random random = new Random();
            for (int i = 1; i <= numOfTimes; i++)
            {
                if (random.NextDouble() < 0.5)
                    tail++;
                else
                    head++;
            }
            double tailPercentage = (double)tail / numOfTimes * 100;
            double headPercentage = (double)head / numOfTimes * 100;
            Console.WriteLine("Tail count" + " = " + tail + " percentage " + tailPercentage);
            Console.WriteLine("Head count" + " = " + head + " percentage " + headPercentage);



        }
    }
}
