using System;

//02. Write a program to convert binary numbers to their decimal representation.

internal class BinToDecimal
{
	private static int BinaryToDecimal(string binary)
	{
		int number = 0;
		int p = 1;
		for (int i = binary.Length - 1; i >= 0; i--)
		{
			number += (binary[i] - '0') * p;
			p = p * 2;
		}
		return number;
	}

	private static void Main()
	{
		string binary = "11111110";
		Console.WriteLine(BinaryToDecimal(binary));
	}
}