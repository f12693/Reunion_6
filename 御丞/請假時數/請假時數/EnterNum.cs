using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 請假時數
{
	public class EnterNum
	{
		public static int EnterNumber(string message = "請輸入整數", int min = int.MinValue, int max = int.MaxValue)
		{
			while (true)
			{
				Console.WriteLine(message);
				if (int.TryParse(Console.ReadLine(), out int result) && result >= min && result <= max)
					return result;
			}
		}
	}
}
