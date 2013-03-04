using System;

//07. Write a method that reverses the digits
//of given decimal number. Example: 256  652

internal class ReversesTheDigits
{
	private static void PrintReverseNumber(decimal number)
	{
		string numberStr = Convert.ToString(number);
		for (int i = numberStr.Length - 1; i >= 0; i--)
		{
			Console.Write(numberStr[i]);
		}
		Console.WriteLine();
	}

	private static void Main()
	{
		decimal number = 456.2565M;
		Console.WriteLine(number);
		PrintReverseNumber(number);
	}
}