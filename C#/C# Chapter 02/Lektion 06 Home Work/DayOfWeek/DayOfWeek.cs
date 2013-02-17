using System;

//03. Write a program that prints to the console which day of the week is today. Use System.DateTime

internal class DayOfWeek
{
	private static void Main()
	{
		Console.WriteLine("Today is {0}",DateTime.Now.DayOfWeek);
	}
}