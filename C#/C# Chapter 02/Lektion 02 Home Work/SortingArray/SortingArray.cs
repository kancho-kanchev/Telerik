using System;

//07. Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array.
//Use the "selection sort" algorithm: Find the smallest element,
//move it at the first position, find the smallest from the rest,
//move it at the second position, etc

internal class SortingArray
{
	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		int lenghtOfArray = rand.Next(3, 21);
		int minValue = 0;
		int minValueIndex = 0;
		int[] arrayOfInteger = new int[lenghtOfArray];

		//arrayOfInteger = { 13, 14, 15, 16, 0, 1, 2, 3, 17, 18, 19, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = rand.Next(1, 101);
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();

		// Solution
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			minValueIndex = i;
			for (int index = i; index < arrayOfInteger.Length; index++)
			{
				if (arrayOfInteger[index] < arrayOfInteger[minValueIndex])
				{
					minValueIndex = index;
				}
			}
			minValue = arrayOfInteger[minValueIndex];
			arrayOfInteger[minValueIndex] = arrayOfInteger[i];
			arrayOfInteger[i] = minValue;
			minValueIndex = i;
		}

		// output
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();
	}
}