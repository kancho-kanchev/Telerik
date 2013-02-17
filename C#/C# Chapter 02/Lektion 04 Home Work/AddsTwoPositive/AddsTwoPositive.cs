using System;

//08. Write a method that adds two positive integer
//numbers represented as arrays of digits
//(each array element arr[i] contains a digit;
//the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

internal class AddsTwoPositive
{
	private static int[] SumTwoArrOfInt(int[] firstArr, int[] secondArr, int length)
	{
		int[] result = new int[length];
		int brain = 0;
		for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
		{
			if (result.Length - 2 > i)
			{
				result[i] = firstArr[i] + secondArr[i] + brain;
				brain = 0;
				result[result.Length - 1]++;
				if (result[i] - 9 > 0)
				{
					brain = result[i] / 10;
					result[i] = result[i] - 10;
				}
			}
			else
			{
				Console.WriteLine("overload in SumArrOfInt");
			}
		}
		for (int i = Math.Min(firstArr.Length, secondArr.Length); i < Math.Max(firstArr.Length, secondArr.Length); i++)
		{
			if (result.Length - 2 > i)
			{
				if (firstArr.Length > secondArr.Length)
				{
					result[i] = firstArr[i] + brain;
				}
				else
				{
					result[i] = secondArr[i] + brain;
				}
				brain = 0;
				result[result.Length - 1]++;
				if (result[i] - 9 > 0)
				{
					brain = result[i] / 10;
					result[i] = result[i] - 10;
				}
			}
			else
			{
				Console.WriteLine("overload in SumArrOfInt");
			}
		}
		if (brain > 0)
		{
			if (result.Length - 2 > result[result[length - 1]])
			{
				result[result[length - 1]] = brain;
				result[result.Length - 1]++;
			}
			else
			{
				Console.WriteLine("overload in SumArrOfInt");
			}
		}
		return result;
	}

	private static string PrintArr(int[] arr, int length)
	{
		string result = "";
		if (arr.Length >= length)
		{
			for (int i = length - 1; i >= 0; i--)
			{
				result += arr[i];
			}
		}
		else
		{
			result = "Overload in PrintArr";
		}
		return result;
	}

	private static void Main()
	{
		int[] firstArr = { 5, 5, 5, 2, 5 };
		int[] secondArr = { 5, 5, 5, 2, 5, 5, 5, 5, 2, 5 };
		int[] result = new int[10002];
		result = SumTwoArrOfInt(firstArr, secondArr, result.Length);
		Console.WriteLine("{0} + {1} = {2}",
			PrintArr(firstArr, firstArr.Length), PrintArr(secondArr, secondArr.Length), PrintArr(result, result[result.Length - 1]));
	}
}