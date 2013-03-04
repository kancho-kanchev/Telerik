using System;

class DancingBits
{
	static int numberK = 0;
	static string numberString = "";

	private static bool IsDancingBits(int position)
	{
		char currentDigit = '5';
		if (numberString.Length == numberK)
		{
			if (numberString[position] == '1')
			{
				currentDigit = '0';
			}
			else
			{
				currentDigit = '1';
			}
		}
		else
		{
			if (position == 0)
			{
				currentDigit = numberString[numberK];
			}
			else
			{
				currentDigit = numberString[position - 1];
			}
		}
		if ((position > 0) && (position + numberK < numberString.Length))
		{
			if (numberString[position - 1] != numberString[position + numberK])
			{
				return false;
			}
		}
		for (int i = position; i < position + numberK; i++)
		{
			if (numberString[i] == currentDigit)
			{
				return false;
			}
		}
		return true;
	}

	static void Main()
	{
		int result = 0;
		numberK = int.Parse(Console.ReadLine());
		int numberN = int.Parse(Console.ReadLine());
		int[] numbers = new int[numberN];
		for (int i = 0; i < numberN; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
			numberString = String.Format("{0}{1}", numberString, Convert.ToString(numbers[i], 2));
		}
		//solution
		if (numberString == "")
		{
			numberString = "0";
		}
		for (int i = 0; i <= numberString.Length - numberK; i++)
		{
			if (IsDancingBits(i))
			{
				result++;
			}
		}
		//write result
		//Console.WriteLine(numberString);
		Console.WriteLine(result);
	}
}