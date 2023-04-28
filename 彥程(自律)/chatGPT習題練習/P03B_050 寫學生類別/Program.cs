namespace P03B_050_寫學生類別
{
	/// <summary>
	/// 設計一個類別來表示一個學生，擁有姓名、年齡、成績三個屬性，以及計算是否及格的方法。
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			Student Annie = new Student("Annie", 20, 60, 50, 65);
			Console.WriteLine(Annie.IsPass());
		}
	}

	class Student
	{
        private string Name { get; set; }
		private int Age { get; set; }
        private double Grade_lang { get; set; }
		private double Grade_eng { get; set; }
		private double Grade_math { get; set; }


		public Student(string name,int age,double lang,double eng,double math)
		{
			Name = name;
			Age = age;
			Grade_lang = lang;
			Grade_eng = eng;
			Grade_math = math;
		}

		public bool IsPass()
			=> (Grade_lang + Grade_eng + Grade_math) / 3 >= 60 ? true : false;

		
    }
}