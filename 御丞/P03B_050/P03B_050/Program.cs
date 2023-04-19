using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace P03B_050
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/// 050 設計一個類別來表示一個學生，擁有姓名、年齡、成績三個屬性，以及計算是否及格的方法。
			/// 
			Student K7 = new Student("K7",26);
			K7.AddStudentScored("國文", 79);
			K7.AddStudentScored("英文", 11);
			K7.AddStudentScored("數學", 30);
			Console.WriteLine(K7.PassesQualification());
			Console.ReadKey();
		}
	}
	class Score
	{
		private Dictionary<string, int> myList;
		public Score()
		{
			myList = new Dictionary<string, int>();
		}
		public void AddScored(string subject, int score)
		{
			myList.Add(subject, score);
		}
		public Dictionary<string, int> GetScore()
		{
			return myList;
		}
	}
	class Student
	{
        public string Name { get; set; }
        public int Age { get; set; }
		
		public Score SubjectScore { get; set; }

		public Student(string name, int age)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(nameof(name),"Name can not be Null or Empty.");
			}
			else if (age < 0 || age > 150)
			{
				throw new ArgumentOutOfRangeException(nameof(age),"Age can not be less than 0 or larger than 150.");
			}

			Name = name;
			Age = age;
		}
		
		public void AddStudentScored(string subject, int score)
		{
			if (string.IsNullOrEmpty(subject))
			{
				throw new ArgumentNullException(nameof(subject), "Subject can not be Null or Empty.");
			}
			else if (score < 0 || score > 100)
			{
				throw new ArgumentOutOfRangeException(nameof(score), "Score can not be less than 0 or larger than 100.");
			}
			SubjectScore.AddScored(subject, score);
		}

		public bool PassesQualification()
		{
			Dictionary<string, int> newScore = new Dictionary<string, int>();
			newScore = SubjectScore.GetScore();
			int sumScore = 0;
			foreach (var item in newScore.Values)
			{
				sumScore += item;
			}
			if (sumScore / newScore.Count >= 60) 
			{ 
				return true;
			}
			else 
			{ 
				return false; 
			}
		}

	}
}
