using System;

//07. Write a program to convert from
//any numeral system of given base s to
//any other numeral system of base d (2 ≤ s, d ≤  16).

internal class BaseToBase
{
	private static string DecToBase(string baseNumber, int baseX)
	{
		string result = "";
		int number = int.Parse(baseNumber);
		if (baseX == 10)
		{
			result = baseNumber;
		}
		else
		{
			while (number > 0)
			{
				if ((number % baseX) > 9)
				{
					result = (char)((number % baseX) + 'a' - 10) + result;
				}
				else
				{
					result = (number % baseX) + result;
				}
				number = number / baseX;
			}
		}
		return result;
	}

	private static string BaseToDec(string baseNumber, int baseX)
	{
		string result = "";
		int number = 0;
		int p = 1;
		if (baseX == 10)
		{
			result = baseNumber;
		}
		else
		{
			for (int i = baseNumber.Length - 1; i >= 0; i--)
			{
				if (baseNumber[i] >= 'a')
				{
					number += (baseNumber[i] - 'a' + 10) * p;
				}
				else
				{
					number += (baseNumber[i] - '0') * p;
				}
				p = p * baseX;
			}
			result = Convert.ToString(number);
		}
		return result;
	}

	private static void Main()
	{
		string base1number = "111110001";//>=2<36
		int base1 = 2;
		string base2number = "fa56";//<=16
		int base2 = 18;
		base1number = base1number.ToLower();
		base2number = base2number.ToLower();
		Console.WriteLine("base:{0}; number:{1}; to base:{2}; number:{3}", base1, base1number, 10, BaseToDec(base1number, base1));
		Console.WriteLine("base:{0}; number:{1}; to base:{2}; number:{3}", 10, BaseToDec(base1number, base1), base2, DecToBase(BaseToDec(base1number, base1), base2));
		Console.WriteLine("base:{0}; number:{1}; to base:{2}; number:{3}", base2, base2number, 10, BaseToDec(base2number, base2));
		Console.WriteLine("base:{0}; number:{1}; to base:{2}; number:{3}", 10, BaseToDec(base2number, base2), base1, DecToBase(BaseToDec(base2number, base2), base1));
	}
}