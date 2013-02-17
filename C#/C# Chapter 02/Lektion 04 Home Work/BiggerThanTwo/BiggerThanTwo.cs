using System;

//05. Write a method that checks if the element
//at given position in given array of integers
//is bigger than its two neighbors (when such exist).

internal class BiggerThanTwo
{
	private static bool CheckNeighbors(int[] arrayOfInteger, int index)
	{
		bool result = true;
		if (index == 0)
		{
			result = arrayOfInteger[index] > arrayOfInteger[index + 1];
		}
		else if (index == arrayOfInteger.Length - 1)
		{
			result = arrayOfInteger[index] > arrayOfInteger[index - 1];
		}
		else
		{
			result = (arrayOfInteger[index] > arrayOfInteger[index + 1]) && (arrayOfInteger[index] > arrayOfInteger[index + 1]);
		}
		return result;
	}

	private static void Main()
	{
		// Deklarations
		bool result = true;
		Random rand = new Random();
		int lenghtOfArray = rand.Next(10, 20);
		int index = rand.Next(0, lenghtOfArray);
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
		result = CheckNeighbors(arrayOfInteger, index);
		Console.WriteLine("{0} is bigger than its neighbors - {1}", arrayOfInteger[index], result);
	}
}