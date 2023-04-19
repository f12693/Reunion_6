using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace P03B_100
{
	public class CountDownTimer
	{
		// Field
		private Timer timer;
		
		// Property
		public int Count { get; private set; }
		
		// Construct
        public CountDownTimer(int count) 
		{
			Count = count;
		}

		// Method
		public CountDownTimer SetCount(int count)
		{
			return new CountDownTimer(count);
		}
		public void Run()
		{
            Console.WriteLine("計時器開始");
			timer = new Timer(1000);
			timer.Elapsed += Timer_Elapsed;
			timer.AutoReset = true;
			timer.Enabled = true;
		}
		public void Stop()
		{
            Console.WriteLine("計時器停止");
            timer.Dispose();
		}

		private void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			if(Count > 0)
			{
				Count--;
                Console.WriteLine($"{Count}");
            }
			else
			{
				Stop();
			}
		}

	}
}
