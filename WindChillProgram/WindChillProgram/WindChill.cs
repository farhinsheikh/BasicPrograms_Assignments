using System;
using System.Collections.Generic;
using System.Text;

namespace WindChillProgram
{
    class WindChill
    {
        public static void WindChillCalculate()
        {
            try
            {
                ///enter input
                Console.WriteLine("Enter Temperature");
                /// accept input
                int temperature = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Speed");
                int speed = int.Parse(Console.ReadLine());
                ///check the condition
                if ((temperature < 50) && (speed > 3 && temperature < 120))
                {
                   // Console.WriteLine("Wind Chill is");
                    double windchill = 35.74 + (0.6215 + temperature) + ((0.4275 + temperature));
                    Console.WriteLine("Wind Chilll is  " + windchill);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input..");
                WindChillCalculate();
            }
            Console.ReadLine();
        }
    }
}
