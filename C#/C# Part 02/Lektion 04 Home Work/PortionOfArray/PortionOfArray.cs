using System;

//09. Write a method that return the maximal element
//in a portion of array of integers starting at given index.
//Using it write another method that sorts an array
//in ascending / descending order

internal class PortionOfArray
{
	private static int getMax(int[] arr, int index)
	{
		int max = arr[index];
		for (int i = index; i < arr.Length; i++)
		{
			if (max < arr[i])
			{
				max = arr[i];
			}
		}
		return max;
	}

	private static void PrintArr(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			if (i > 0)
			{
				Console.Write(" ");
			}
			Console.Write(arr[i]);
		}
		Console.WriteLine();
	}

	private static int[] SortArr(int[] arrayOfInteger, int index, string direction)
	{
		int[] newArr = new int[arrayOfInteger.Length - index];
		int tempIndex = 0;
		int tempValue = 0;
		for (int i = index; i < arrayOfInteger.Length; i++)
		{
			newArr[tempIndex] = arrayOfInteger[i];
			tempIndex++;
		}
		tempIndex = newArr.Length - 1;
		Array.Sort(newArr);
		if (direction == "Down")
		{
			for (int i = 0; i < newArr.Length / 2; i++)
			{
				tempValue = newArr[i];
				newArr[i] = newArr[tempIndex];
				newArr[tempIndex] = tempValue;
				tempIndex--;
			}
		}
		return newArr;
	}

	private static void Main()
	{
		// Deklarations
		int max = 0;
		Random rand = new Random();
		int lenghtOfArray = rand.Next(10, 20);
		int index = rand.Next(0, lenghtOfArray);
		int[] arrayOfInteger = new int[lenghtOfArray]; // Enter array here and comment down (line 42)
		int[] sortedUp = new int[arrayOfInteger.Length - index];
		int[] sortedDw = new int[arrayOfInteger.Length - index];

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
		max = getMax(arrayOfInteger, index);
		sortedUp = SortArr(arrayOfInteger, index, "up");
		sortedDw = SortArr(arrayOfInteger, index, "Down");

		// output
		PrintArr(sortedUp);
		PrintArr(sortedDw);
		Console.WriteLine("index = {0}", index);
		Console.WriteLine("max value: {0}", max);
	}
}