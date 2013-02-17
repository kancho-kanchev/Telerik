using System;

class NextDate
{
	static void Main()
	{
		int inputDay = int.Parse(Console.ReadLine());
		int inputMonth = int.Parse(Console.ReadLine());
		int inputYear = int.Parse(Console.ReadLine());
		DateTime date1 = new DateTime(inputYear, inputMonth, inputDay);
		string dateStr = String.Format("{0}.{1}.{2}", date1.AddDays(1).Day, date1.AddDays(1).Month, date1.AddDays(1).Year);
		Console.WriteLine(dateStr);
    }
}