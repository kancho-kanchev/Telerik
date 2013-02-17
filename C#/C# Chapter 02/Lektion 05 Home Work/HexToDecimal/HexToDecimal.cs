using System;

//04. Write a program to convert hexadecimal numbers to their decimal representation.

internal class HexToDecimal
{
	private static int HexToDec(string hex)
	{
		int number = 0;
		int p = 1;
		for (int i = hex.Length - 1; i >= 0; i--)
		{
			if (hex[i] >= 'a')
			{
				number += (hex[i] - 'a' + 10) * p;
			}
			else
			{
				number += (hex[i] - '0') * p;
			}
			p = p * 16;
		}
		return number;
	}

	private static void Main()
	{
		string hex = "f5";
		hex = hex.ToLower();
		Console.WriteLine(HexToDec(hex));
	}
}