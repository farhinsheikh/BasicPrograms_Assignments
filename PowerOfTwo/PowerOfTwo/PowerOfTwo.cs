using System;
using System.Collections.Generic;
using System.Text;

namespace PowerOfTwo
{
    class PowerOfTwo
    {
      public static void ReadInput()
      {
         //Reading input from user
         Console.WriteLine("Enter the Number:- "); 
         string Number = Console.ReadLine();
         int number = Convert.ToInt32(Number);
         int num = 1;
         int i = 1;
         int LimitPowerTwo = 31;
        //Cheack number is greater than Limit 31
         if (number > LimitPowerTwo)
         {
          Console.WriteLine($"You Enter {number}  of 2^ exceeds the value limit 31  ");
         }
         else
         {
           //to Check a number
          for (i = 1; i <= number; i++) 
          {
          // multiply number by 2
          num = (num * 2);
          //print Table values
          Console.WriteLine(num); 
          }
         }
      }
    }
}