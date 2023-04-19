using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03B_100
{
	public class SetTime
	{
		public static int SetTimeCount()
		{
			while (true)
			{
				if (int.TryParse(Console.ReadLine(), out var time)) return time;
			}
		}
	}
}
