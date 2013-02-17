using System;

//06. You are given a sequence of positive integer values written into a string,
//separated by spaces. Write a function that reads these values from given string
//and calculates their sum.
//Example:
//		string = "43 68 9 23 318"  result = 461

internal class SumOfSequence
{
	private static int GetSumFromString(string str)
	{
		int sum = 0;
		string[] array = str.Split(' ');
		for (int i = 0; i < array.Length; i++)
		{
			sum += int.Parse(array[i].Trim());
		}
		return sum;
	}

	private static void Main()
	{
		string str = "43 68 9 23 318";
		Console.WriteLine(str);
		Console.WriteLine(GetSumFromString(str));
	}
}