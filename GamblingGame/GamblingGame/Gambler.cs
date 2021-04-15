using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingGame
{
    class Gambler
    {
        public static void ReadStakeAmountAndGoal()
        {
            int wons = 0;
            int loose = 0;
            Console.WriteLine("Enter stake amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Goal amount");
            int goal = Convert.ToInt32(Console.ReadLine());


            Random random = new Random();


            for (int i = 1; i > 0; i++)
            {
                if (amount > 0)
                {
                    int randomvalue = random.Next(0, 2);

                    //won the game
                    if (randomvalue == 1)
                    {
                        amount = amount + 1;
                        wons++;

                        if (amount == goal)
                        {
                            Console.WriteLine("number of bets played in the game" + i);
                            Console.WriteLine("number of wons=" + wons);
                            Console.WriteLine("number of loose=" + loose);
                            break;
                        }
                    }
                    else
                    {
                        if (amount > 0)
                        {
                            amount = amount - 1;
                            loose++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("game broken that means is not sufficient");

                }
            }
            Console.WriteLine("final amount either it may reaches to goal or break the game" + amount);
        }
    }
}
