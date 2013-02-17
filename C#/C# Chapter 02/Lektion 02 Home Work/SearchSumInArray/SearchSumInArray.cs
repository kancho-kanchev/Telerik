using System;

//10 Write a program that finds in given array of integers
//a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

internal class SearchSumInArray
{
	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		int lenghtOfArray = rand.Next(3, 16);
		int[] arrayOfInteger = new int[lenghtOfArray]; // Enter array here
		int sum = 11; // Enter "S" here
		int sumTemp = 0;
		int sumIndex = 0;
		int sumCount = 1;

		//arrayOfInteger = { 13, 14, 15, 16, 0, 1, 2, 3, 17, 18, 19, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
		//arrayOfInteger = {10, 8, -7, -10, -6, 1};
		//{ 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
		//{4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = rand.Next(-11, 11);
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();

		// Solution
		for (int startIndex = 0; startIndex < arrayOfInteger.Length; startIndex++)
		{
			for (int currIndex = startIndex; currIndex < arrayOfInteger.Length; currIndex++)
			{
				sumTemp = sumTemp + arrayOfInteger[currIndex];
				if (sum == sumTemp)
				{
					sumIndex = startIndex;
					sumCount = currIndex - startIndex + 1;
				}
			}
			sumTemp = 0;
		}

		// output result
		for (int i = sumIndex; i < sumIndex + sumCount; i++)
		{
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine("\nSum={0}; SumIndex={1}; SumCount={2};", sum, sumIndex, sumCount);
	}
}