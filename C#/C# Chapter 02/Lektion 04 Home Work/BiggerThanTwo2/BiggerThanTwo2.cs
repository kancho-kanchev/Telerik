using System;

//06. Write a method that returns the index of
//the first element in array that is bigger
//than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

internal class BiggerThanTwo2
{
	private static int CheckNeighbors(int[] arr)
	{
		int index = -1;
		for (int currIndex = 0; currIndex < arr.Length; currIndex++)
		{
			if (currIndex == 0)
			{
				if (arr[currIndex] > arr[currIndex + 1])
				{
					index = currIndex;
					break;
				}
			}
			else if (currIndex == arr.Length - 1)
			{
				if (arr[currIndex] > arr[currIndex - 1])
				{
					index = currIndex;
					break;
				}
			}
			else
			{
				if ((arr[currIndex] > arr[currIndex + 1]) && (arr[currIndex] > arr[currIndex + 1]))
				{
					index = currIndex;
					break;
				}
			}
		}
		return index;
	}

	private static void Main()
	{
		// Deklarations
		int result = -1;
		Random rand = new Random();
		int lenghtOfArray = rand.Next(10, 20);
		int[] arrayOfInteger = new int[lenghtOfArray]; // Enter array here and comment down (line 42)

		//arrayOfInteger = { 13, 14, 15, 16, 0, 1, 2, 3, 17, 18, 19, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
		//arrayOfInteger = {10, 8, -7, -10, -6, 1};
		//{ 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
		//{4, 3, 1, 4, 2, 5, 8}{ -4, 6, -7, 8, 6, -10, -3, 0 };
		//{ 2, 1, 2, 4, 3, 5, 2, 6 };9 0 6 -10 4 2 10
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = rand.Next(-5, 5); // comment if enter hardcore array
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();

		// Solution
		result = CheckNeighbors(arrayOfInteger);
		if (result == -1)
		{
			Console.WriteLine("No bigger than its neighbors");
		}
		else
		{
			Console.WriteLine("{0} is bigger than its neighbors; index: {1}", arrayOfInteger[result], result);
		}
	}
}