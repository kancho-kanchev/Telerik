using System;

//05. Write a program to convert hexadecimal numbers to binary numbers (directly).

internal class HexToBin
{
	private static string HexToBinary(string hex)
	{
		string binary = "";
		string[] hexNumbers = {"0000",
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
								"1111"};
		for (int i = hex.Length - 1; i >= 0; i--)
		{
			if (hex[i] >= 'a')
			{
				binary = (hexNumbers[hex[i] - 'a' + 10]) + binary;
			}
			else
			{
				binary = hexNumbers[hex[i] - '0'] + binary;
			}
		}
		return binary;
	}

	private static void Main()
	{
		string hex = "f1";
		hex = hex.ToLower();
		Console.WriteLine(HexToBinary(hex));
	}
}