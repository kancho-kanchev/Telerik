using System;

//01. Write a program to convert decimal numbers to their binary representation.

internal class DecimalToBin
{
	private static string NumberToBin(int number)
	{
		string result = "";
		while (number > 0)
		{
			result = number % 2 + result;
			number = number / 2;
		}
		return result;
	}

	private static void Main()
	{
		int number = 213;
		Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, ' '));
		Console.WriteLine(Convert.ToString(number, 2));
		Console.WriteLine(NumberToBin(number));
	}
}