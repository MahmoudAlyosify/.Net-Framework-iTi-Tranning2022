using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /*
     Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should 
provide two methods: Start and Stop. We call the start method first, and the stop method next. 
Then we ask the stopwatch about the duration between start and stop. Duration should be a 
value in TimeSpan. Display the duration on the console. 
We should also be able to use a stopwatch multiple times. So we may start and stop it and then 
start and stop it again. Make sure the duration value each time is calculated properly. 

     */
    internal class Program
    {
        static void Main(string[] args)
        {

			Stopwatch MystopWatch = new Stopwatch();
			Console.WriteLine("Type 'start' to begin ^__^");
			string userInput = Console.ReadLine();
			if (userInput.ToLower() == "start")
			{
				MystopWatch.Start();
				Console.WriteLine("You started at {0}", MystopWatch.TheStartTime.ToString("yyyy-MM-dd & HH:mm:ss"));
			}
			else
			{
				Console.WriteLine("Type 'start' to begin ^__^");
				while (Console.ReadLine().ToLower() != "start")
				{
					Console.WriteLine("Type 'start' to begin ^__^");
				}
			}
            Console.WriteLine("----------------------------------------------");
			Console.WriteLine("Type 'stop' to End ^__^");
			userInput = Console.ReadLine();
			if (userInput.ToLower() == "stop")
			{
				MystopWatch.Stop();
				Console.WriteLine("You Stopped at {0}", MystopWatch.TheStopTime.ToString("yyyy-MM-dd & HH:mm:ss"));
				Console.WriteLine($"The Duration is :({MystopWatch.Duration()})");

			}
			else
			{
				Console.WriteLine("Type 'stop' to End ^__^");
				while (Console.ReadLine().ToLower() != "stop")
				{
					Console.WriteLine("Type 'stop' to End ^__^");
				}
				MystopWatch.Stop();
				Console.WriteLine("You Stopped at {0}", MystopWatch.TheStopTime.ToString("yyyy-MM-dd & HH:mm:ss"));
				Console.WriteLine($"The Duration is :({MystopWatch.Duration()})");
			}
			Console.ReadKey();

		}
    }
}
