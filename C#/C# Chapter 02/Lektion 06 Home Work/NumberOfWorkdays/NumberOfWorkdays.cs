using System;

//05. Write a method that calculates the number of workdays between today and given date,
//passed as parameter. Consider that workdays are all days from Monday to Friday
//except a fixed list of public holidays specified preliminary as array.

internal class NumberOfWorkdays
{
	private static int GetWorkdays(DateTime startData)
	{
		DateTime[] holidays =
        {
            new DateTime(2013, 1, 21),
            new DateTime(2013, 1, 22),
            new DateTime(2013, 1, 23),
            new DateTime(2013, 1, 24),
            new DateTime(2013, 1, 28)
        };
		bool checkHoliday = false;
		int result = 0;
		DateTime endtData = DateTime.Today;
		DateTime currDate = startData;
		for (int i = 0; i < (int)(endtData - startData).TotalDays + 1; i++)
		{
			for (int k = 0; k < holidays.Length; k++)
			{
				if (currDate == holidays[k])
				{
					checkHoliday = true;
				}
			}
			if (!((currDate.DayOfWeek == DayOfWeek.Saturday) || (currDate.DayOfWeek == DayOfWeek.Sunday) || (checkHoliday)))
			{
				result++;
			}
			checkHoliday = false;
			currDate = currDate.AddDays(1);

		}

		return result;
	}

	private static void Main()
	{
		string format = "dd.MMMM.yyyy";
		DateTime startData = new DateTime(2013, 01, 01);
		Console.WriteLine("{0} - {1}", startData.ToString(format), DateTime.Today.ToString(format));
		Console.WriteLine("{0} workdays",GetWorkdays(startData));
	}
}