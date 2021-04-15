using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquation
{
    class Quadratic
    {
        public static void QuadraticToFindRoots()
        {
            try
            {
                //enter input
                Console.WriteLine("Enter number1");
                ///accept input
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number2");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number3");
                int c = int.Parse(Console.ReadLine());
                double delta, root1, root2;
                ///to calculate result of given 3 numbers
                delta = (b * b) - (4 * a * c);
                Console.WriteLine("" + delta);
                ///calculate roots of given equation
                root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Roots of the Equation" + root1);
                Console.WriteLine("Roots of the Equation" + root2);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter Valid Number");
                QuadraticToFindRoots();
            }
            //Console.ReadLine();
        }
    }
}
