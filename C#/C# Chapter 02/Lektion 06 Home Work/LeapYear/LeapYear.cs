using System;

//01. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

internal class LeapYear
{
	private static void Main()
	{
		string userInput = "";
		int year = 0;
		while (true)
		{
			Console.Write("\nEnter a year: ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out year))
			{
				if (year >= 1)
				{
					break;
				}
			}
			Console.WriteLine("Invalid input! Please try again...");
		}
		if (DateTime.IsLeapYear(year))
		{
			Console.WriteLine("The year is leap");
		}
		else
		{
			Console.WriteLine("The year is not leap");
		}
	}
}