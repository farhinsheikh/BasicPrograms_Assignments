using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
    class ToStopWatch
    {
        public static void ReadStopWatch()
        {
            Stopwatch time = new Stopwatch();
            Console.WriteLine("Press any key to start the stop watch");
            String userInput = Console.ReadLine();
            if (userInput != null)
            {
                time.Start();
            }
            Console.WriteLine("Press any key to stop the stop watch");
            userInput = Console.ReadLine();
            if (userInput != null)
            {
               time.Stop();
            }
            Console.WriteLine($"Time elapsed: {time.Elapsed}");

        }
    }
}

    

