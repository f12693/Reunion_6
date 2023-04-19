using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 請假時數
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/// 計算一天總請假時數，每天上班時間是09~18點，12~13點為休息時間
			/// 
			var startTime = EnterNum.EnterNumber("請輸入請假時間( 0~23 hr)",0, 23);
			var endTime   = EnterNum.EnterNumber("請到什麼時候為止( 0~23 hr)", 0,23);

			var timeOff = new 請假();
			int timeOffInt = timeOff.GetTimeOff(startTime, endTime);
			var startDate = new DateTime(2023, 04, 15, 08, 00, 00);
			var endDate = new DateTime(2023, 04, 18, 19, 00, 00);
			int timeOffInt2 = timeOff.GetTimeOff(startDate, endDate, out int timeOffDays);
            Console.WriteLine($"請假{timeOffInt}小時");
            Console.WriteLine($"請假{timeOffDays}天{timeOffInt2}小時");
			Console.ReadKey();
        }
	}
}
