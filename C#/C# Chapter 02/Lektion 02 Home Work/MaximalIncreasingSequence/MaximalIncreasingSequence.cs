using System;

//05. Write a program that finds the maximal increasing sequence
//in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

class MaximalIncreasingSequence
{
	static void Main()
	{
		// Declarations
		Random rand = new Random();
		int startIndex = 0;
		int lenghtSeq = 1;
		int currLenghtSeq = 1;
		int lenghtOfArray = rand.Next(1,20);
		// Initialize array
		int[] arrayOfInteger = new int[lenghtOfArray];
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = rand.Next(1, 40);
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();
		// For hardcore
		//arrayOfInteger = { 0, 1, 2, 3, 4, 2, 9, 14, 15, 16, 17, 18, 30, 32, 33 };
		//
		// Solution
		for (int i = 1; i < arrayOfInteger.Length; i++)
		{
			if (arrayOfInteger[i - 1] < arrayOfInteger[i])
			{
				currLenghtSeq++;
			}
			else
			{
				if (lenghtSeq < currLenghtSeq)
				{
					lenghtSeq = currLenghtSeq;
					startIndex = i - lenghtSeq;
				}
				currLenghtSeq = 1;
			}
		}
		if (lenghtSeq < currLenghtSeq)
		{
			lenghtSeq = currLenghtSeq;
			startIndex = arrayOfInteger.Length - lenghtSeq;
			currLenghtSeq = 1;
		}
		//output result
		Console.WriteLine("Lenght of sequence {0}, start index is {1} and is:", lenghtSeq, startIndex);
		for (int i = startIndex; i < startIndex + lenghtSeq; i++)
		{
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();
	}
}