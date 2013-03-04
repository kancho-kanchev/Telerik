using System;

//06. Write a program to convert binary numbers to hexadecimal numbers (directly).

internal class BinToHex
{
	private static string BinaryToHex(string binary)
	{
		string hex = "";
		string digit = "";
		string[,] hexNumbers = {{"0000",
								"0001",
								"0010",
								"0011",
								"0100",
								"0101",
								"0110",
								"0111",
								"1000",
								"1001",
								"1010",
								"1011",
								"1100",
								"1101",
								"1110",
								"1111"},{"0","1","2","3","4","5","6","7","8","9","a","b","c","d","e","f"}};
		int i = binary.Length - 1;
		int step = 0;
		while (i >= 0)

		//for (int i = binary.Length-1; i >=0; i--)
		{
			for (int k = 0; k < 4; k++)
			{
				if (i - k >= 0)
				{
					digit = binary[i - k] + digit;
					step++;
				}
				else
				{
					digit = '0' + digit;
				}
			}
			for (int h = 0; h < 16; h++)
			{
				if (digit == hexNumbers[0, h])
				{
					hex = hexNumbers[1, h] + hex;
				}
			}
			digit = "";
			i -= step;
			step = 0;
		}

		return hex;
	}

	private static void Main()
	{
		string binary = "111110111";
		Console.WriteLine(BinaryToHex(binary));
	}
}