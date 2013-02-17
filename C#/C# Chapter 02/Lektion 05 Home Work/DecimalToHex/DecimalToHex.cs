using System;

//03. Write a program to convert decimal numbers to their hexadecimal representation

internal class DecimalToHex
{
	private static string NumberToHex(int number)
	{
		string result = "";
		while (number > 0)
		{
			if ((number % 16) > 9)
			{
				result = (char)((number % 16) + 'a' - 10) + result;
			}
			else
			{
				result = (number % 16) + result;
			}
			number = number / 16;
		}
		return result;
	}

	private static void Main()
	{
		int number = 245;
		Console.WriteLine(Convert.ToString(number, 16).PadLeft(8, ' '));
		Console.WriteLine(Convert.ToString(number, 16));
		Console.WriteLine(NumberToHex(number));
	}
}