using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineProgram
{
    class VendingMachine
    {
        public static void ReadAmountToFindchange()
        {
            Console.WriteLine("Enter an amount to give change");
            int amount = Convert.ToInt32(Console.ReadLine());
            FindMinNotes(amount);
        }
        private static void FindMinNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

            int[] notesCounter = new int[notes.Length];

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    //25
                    notesCounter[i] = amount / notes[i];
                    amount = amount - (notesCounter[i] * notes[i]);
                    if (amount <= 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("currency count==>");
            for (int i = 0; i < notes.Length; i++)
            {
                if (notesCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + ":" + notesCounter[i]);
                }
            }
        }
    }
}

