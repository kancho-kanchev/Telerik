using System;
using System.Collections.Generic;

//09. Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

internal class FrequentNumber
{
	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		int lenghtOfArray = rand.Next(6, 25);
		int[] arrayOfInteger = new int[lenghtOfArray];//{ 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 }
		List<int> listOfNumbers = new List<int>();
		int number = 0;
		int numberTemp = 0;
		int countTemp = 0;
		int count = 0;
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = rand.Next(-11, 11);
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();

		// Solution
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			numberTemp = arrayOfInteger[i];
			countTemp = 1;
			for (int k = i; k < arrayOfInteger.Length; k++)
			{
				if (numberTemp == number)
				{
					break;
				}
				if (numberTemp == arrayOfInteger[k])
				{
					countTemp++;
				}
			}
			if ((countTemp - 1) == count)
			{
				listOfNumbers.Add(numberTemp);
			}
			else if ((countTemp - 1) > count)
			{
				count = countTemp - 1;
				listOfNumbers.Clear();
				listOfNumbers.Add(numberTemp);
				number = numberTemp;
			}
		}

		// Output result
		Console.Write("Numbers: ");
		foreach (int listNumber in listOfNumbers)
		{
			Console.Write(listNumber + " ");
		}
		Console.WriteLine("\nTimes:  " + count);
	}
}