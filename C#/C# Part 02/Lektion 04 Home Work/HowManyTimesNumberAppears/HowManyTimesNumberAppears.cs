using System;

//04. Write a method that counts how many times
//given number appears in given array.
//Write a test program to check
//if the method is working correctly

internal class HowManyTimesNumberAppears
{
	private static int CountNumberInArray(int[] arr, int number)
	{
		int count = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == number)
			{
				count++;
			}
		}
		return count;
	}

	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		int count = 0;
		int number = rand.Next(-5, 5);
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
		count = CountNumberInArray(arrayOfInteger, number);
		Console.WriteLine("number: {0}; count: {1};", number, count);
	}
}