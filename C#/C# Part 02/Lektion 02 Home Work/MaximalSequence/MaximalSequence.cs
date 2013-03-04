using System;

//04. Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

class MaximalSequence
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
			arrayOfInteger[i] = rand.Next(1, 4);
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();
		// For hardcore
		//arrayOfInteger = { 2, 1, 1, 2, 3, 3, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
		//
		// Solution
		for (int i = 1; i < arrayOfInteger.Length; i++)
		{
			if (arrayOfInteger[i - 1] == arrayOfInteger[i])
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