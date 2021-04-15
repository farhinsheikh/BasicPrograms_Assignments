using System;
using System.Collections.Generic;
using System.Text;

namespace LeapYearChecker
{
    //this is leap year class
    class LeapYear
    {
        //method to find leap year
        public static void Leap()
        {
            //take user input 
            Console.WriteLine("Enter the year");
            int Year = int.Parse(Console.ReadLine());
            // A leap year is exactly divisible by 4 except for century years
            // The century year is a leap year only if it is perfectly divisible by 400.
            // by using modulous(%) it checks if it is divisible or not.
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
               Console.WriteLine("This a Leap Year");
            else 
               Console.WriteLine("This is not a Leap Year");
               Console.ReadLine();
        }
    }
}

