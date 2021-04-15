using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceStringProgram
{
    class ReplaceString
        {
        /// <summary>
        /// reading input from the user
        /// </summary>
        public static void ReadInput()
        {
            // giving string template
            string template = "Hello <<UserName>>, How are you?";
            // giving instruction/ message to the user
            Console.WriteLine("Please enter your name");
            // reading input from user
            string userInput = Console.ReadLine();
            // calling replace() method
            ReplaceWord(template, userInput);
        }
        // Created replace() method to perform replacement
        private static void ReplaceWord(string template, string userInput)
        {
            string result = template.Replace("<<UserName>>", userInput);
            Console.WriteLine("After done replace "+ result);

        }
    }
}
