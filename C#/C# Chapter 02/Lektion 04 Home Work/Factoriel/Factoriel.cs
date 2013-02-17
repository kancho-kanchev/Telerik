using System;

//10. Write a program to calculate n!
//for each n in the range [1..100].
//Hint: Implement first a method that
//multiplies a number represented as
//array of digits by given integer number.

internal class Factorial
{
	private static string ReverseArr(string arr)
	{
		int endIndex = arr.Length - 1;
		char[] newArr = new char[arr.Length];
		for (int i = 0; i <= newArr.Length / 2; i++)
		{
			newArr[i] = arr[endIndex];
			newArr[endIndex] = arr[i];
			endIndex--;
		}
		arr = "";
		for (int i = 0; i < newArr.Length; i++)
		{
			arr = arr + newArr[i];
		}
		return arr;
	}

	private static string ConvertArrayIntToStr(int[] arr)
	{
		string result = "";
		bool digit = false;
		for (int i = arr.Length - 1; i >= 0; i--)
		{
			if (arr[i] > 0) digit = true;
			if (digit)
			{
				result += arr[i];
			}
		}

		//Console.WriteLine(result);
		return result;
	}

	private static int[] ConvertArrayStrToInt(string str)
	{
		int[] arr = new int[str.Length];
		for (int i = 0; i < str.Length; i++)
		{
			arr[i] = int.Parse(Convert.ToString(str[i]));
		}
		return arr;
	}

	private static int[] SumTwoArrOfInt(int[] firstArr, int[] secondArr)
	{
		int[] result = new int[Math.Max(firstArr.Length, secondArr.Length) + 1];
		int brain = 0;
		for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
		{
			result[i] = firstArr[i] + secondArr[i] + brain;
			brain = 0;
			if (result[i] - 9 > 0)
			{
				brain = result[i] / 10;
				result[i] = result[i] - 10;
			}
		}
		for (int i = Math.Min(firstArr.Length, secondArr.Length); i < Math.Max(firstArr.Length, secondArr.Length); i++)
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
			if (result[i] - 9 > 0)
			{
				brain = result[i] / 10;
				result[i] = result[i] - 10;
			}
		}
		if (brain > 0)
		{
			result[result.Length - 1] = brain;
		}
		return result;
	}

	private static int[] MultiplyString(int[] multiplicand, int[] multiplier)
	{
		//за оптимизация: проверява кое е по-малко на дължина и се разменят при нужда така че tempRezult.Lenght = по-малкото
		int zero = 0;
		int brain = 0;
		int[] result = new int[multiplicand.Length + multiplier.Length];
		int[][] tempResults = new int[multiplier.Length][];
		for (int i = 0; i < multiplier.Length; i++)
		{
			for (int j = 0; j < multiplicand.Length; j++)
			{
				tempResults[i] = new int[result.Length];
			}
		}
		for (int i = 0; i < multiplier.Length; i++)
		{
			for (int j = 0; j < multiplicand.Length; j++)
			{
				tempResults[i][j + zero] = multiplicand[j] * multiplier[i] + brain;
				brain = 0;
				if (tempResults[i][j + zero] > 9)
				{
					brain = tempResults[i][j + zero] / 10;
					tempResults[i][j + zero] = tempResults[i][j + zero] % 10;
				}
			}
			tempResults[i][multiplicand.Length + zero] = brain;
			brain = 0;
			zero++;
		}
		for (int i = 0; i < tempResults.Length; i++)
		{
			result = SumTwoArrOfInt(tempResults[i], result);
		}
		return result;
	}

	private static string GetFactorial(int n)
	{
		string result = "1";
		for (int i = 2; i <= n; i++)
		{
			//Console.WriteLine("{0} * {1}", result, Convert.ToString(i));
			result = ConvertArrayIntToStr(MultiplyString(ConvertArrayStrToInt(ReverseArr(result)), ConvertArrayStrToInt(ReverseArr(Convert.ToString(i)))));
		}
		return result;
	}

	private static void Main()
	{
		string result = "";
		result = GetFactorial(21);

		//Console.WriteLine("{0}! = {1}", 21, result);
		//firstArr[i] = a[i] - '0';
		for (int n = 1; n <= 100; n++)
		{
			result = GetFactorial(n);
			Console.WriteLine("{0}! = {1}", n, result);
		}
	}
}