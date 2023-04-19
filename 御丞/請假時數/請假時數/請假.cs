using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 請假時數
{
	public class 請假
	{
		private const int WORK_START_TIME = 9;
		private const int WORK_END_TIME = 18;
		private const int Rest_START_TIME = 12;
		private const int Rest_END_TIME = 13;

		public int GetTimeOffInHours(int startTime, int endTime)
		{
			if (IsNotWorkTime(startTime, endTime))
				return 0;
			int beginTime = startTime < WORK_START_TIME ? WORK_START_TIME : startTime;
			int stopTime = endTime > WORK_END_TIME ? WORK_END_TIME : endTime;

			if (IncludeRestTime(startTime, endTime))
				return stopTime - beginTime - (Rest_END_TIME - Rest_START_TIME);
			else
				return stopTime - beginTime;
		}

		public int GetTimeOff(int startTime, int endTime)
			=> GetTimeOffInHours(startTime, endTime);

		public int GetTimeOff(DateTime startTime, DateTime endTime, out int timeOffDay)
		{
			timeOffDay = (endTime - startTime).Days;
			return GetTimeOffInHours(startTime.Hour, endTime.Hour);  // 傳回請假幾小時

		}

		public bool IncludeRestTime(int startTime, int endTime)
			=> startTime <= Rest_START_TIME && endTime >= Rest_END_TIME;

		public bool IsNotWorkTime(int startTime, int endTime)
			=> endTime <= WORK_START_TIME || startTime >= WORK_END_TIME;
	}
}
