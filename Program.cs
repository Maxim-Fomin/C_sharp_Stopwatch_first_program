using System;
using System.Threading;

namespace MyStopwatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            for (int i = 0; i < 3; i++)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine("Duration: " + stopwatch.GetInterval());

                Console.WriteLine("Press Enter to run the stopwatch one more time.");

                Console.ReadLine();
            }
        }
    }
}
"# C_sharp_Stopwatch_first_program" 
