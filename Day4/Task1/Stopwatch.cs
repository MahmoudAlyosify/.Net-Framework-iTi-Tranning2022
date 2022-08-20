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
					
		}

		public string Duration()
        {
			return (this.TheStopTime - this.TheStartTime).ToString();

		}
		public void Stop()
		{
				TheStopTime = DateTime.Now;
		}

	}
}
