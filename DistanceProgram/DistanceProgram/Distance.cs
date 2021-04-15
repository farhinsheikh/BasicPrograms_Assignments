using System;
using System.Collections.Generic;
using System.Text;

namespace DistanceProgram
{
    class Distance
    {
        public static void ReadInput()
        {
            Console.Write("Enter value of x : ");//get user input
            string firstinput = Console.ReadLine();//store input value in firstinput
            int x = Convert.ToInt32(firstinput);//convert from string value into int and stored in x

            Console.Write("Enter value of y : ");
            string secondtinput = Console.ReadLine();
            int y = Convert.ToInt32(secondtinput);
            FindDistance(x, y);
        }
        private static void FindDistance(int x, int y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine(distance);//print the value 
        }
    }
}
