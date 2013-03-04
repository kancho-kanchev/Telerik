using System;
using System.Numerics;

class ExcelColumns
{
	private static BigInteger naStepen(int b, int p)
	{
		BigInteger res = 1;
		for (int i = 0; i < p; i++)
		{
			res = res * b;
		}
		return res;
	}

	static void Main()
	{
		//input
		int count = 0;
		char[] identifier = { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };
		BigInteger result = 0;
		int colLength = int.Parse(Console.ReadLine());
		for (int i = 0; i < colLength; i++)
		{
			identifier[i] = char.Parse(Console.ReadLine());
		}
		//solution
		count = colLength - 1;
		for (int i = 0; i < colLength; i++)
		{
			result += (identifier[count] - 'A' + 1) * naStepen(26, i);
			count--;
		}
		//print result
		Console.WriteLine(result);
	}
}