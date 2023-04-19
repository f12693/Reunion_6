using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03B_100
{
	internal class Program
	{
		static void Main(string[] args)
		{
			///100 設計一個類別來表示一個簡單的倒數計時器，擁有設定時間、開始計時、停止計時等方法。
			///
			var clock = new CountDownTimer(SetTime.SetTimeCount());
			// var clock2 = clock.SetCount(20);
			clock.Run();
			Console.ReadKey();
		}
	}
}
