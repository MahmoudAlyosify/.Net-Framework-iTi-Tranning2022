using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Stopwatch
    {
		public DateTime TheStartTime { get; set; }
		public DateTime TheStopTime { get; set; }

		public void Start()
		{		
				TheStartTime = DateTime.Now;
				Console.WriteLine("You started at {0}", TheStartTime.ToString("yyyy-MM-dd & HH:mm:ss"));	
		}

		public string Duration()
        {
			return (this.TheStopTime - this.TheStartTime).ToString();

		}
		public void Stop()
		{
				TheStopTime = DateTime.Now;
				Console.WriteLine("You Stopped at {0}", TheStopTime.ToString("yyyy-MM-dd & HH:mm:ss"));
				Console.WriteLine($"The Duration is :({Duration()})");
		}

	}
}
