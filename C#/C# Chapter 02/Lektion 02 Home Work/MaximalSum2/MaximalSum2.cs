using System;

//08. Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?

internal class MaximalSum2
{
	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		int lenghtOfArray = rand.Next(3, 16);
		int[] arrayOfInteger = new int[lenghtOfArray];
		int maxSum = 0;
		int maxSumTemp = 0;
		int maxSumIndex = 0;
		int maxSumCount = 1;

		//arrayOfInteger = { 13, 14, 15, 16, 0, 1, 2, 3, 17, 18, 19, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
		//arrayOfInteger = {10, 8, -7, -10, -6, 1};
		//{ 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = rand.Next(-11, 11);
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();

		// Solution
		maxSum = arrayOfInteger[maxSumIndex];
		for (int startIndex = 0; startIndex < arrayOfInteger.Length; startIndex++)
		{
			for (int currIndex = startIndex; currIndex < arrayOfInteger.Length; currIndex++)
			{
				maxSumTemp = maxSumTemp + arrayOfInteger[currIndex];
				if (maxSum < maxSumTemp)
				{
					maxSum = maxSumTemp;
					maxSumIndex = startIndex;
					maxSumCount = currIndex - startIndex + 1;
				}
			}
			maxSumTemp = 0;
		}

		// output result
		for (int i = maxSumIndex; i < maxSumIndex + maxSumCount; i++)
		{
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine("\nmaxSum={0}; maxSumIndex={1}; maxSumCount={2};", maxSum, maxSumIndex, maxSumCount);
	}
}