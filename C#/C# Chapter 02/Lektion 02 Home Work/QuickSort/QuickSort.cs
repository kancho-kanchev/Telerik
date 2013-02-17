using System;

//14. Write a program that sorts an array of strings
//using the quick sort algorithm (find it in Wikipedia)

internal class QuickSort
{
	private static int partition(string[] array, int leftIndex, int rightIndex, int pivotIndex)
	{
		int storeIndex = 0;
		string pivotValue = array[pivotIndex];
		string valueTemp = "";

		//swap array[pivotIndex] and array[right]  // Move pivot to end
		valueTemp = array[rightIndex];
		array[rightIndex] = array[pivotIndex];
		array[pivotIndex] = valueTemp;
		storeIndex = leftIndex;
		for (int i = leftIndex; i < rightIndex; i++)
		{
			if (array[i].CompareTo(pivotValue) < 0) //array[i]<pivotValue)
			{
				// swap array[i] and array[storeIndex]
				valueTemp = array[i];
				array[i] = array[storeIndex];
				array[storeIndex] = valueTemp;
				storeIndex++;
			}
		}

		//swap array[storeIndex] and array[right]  // Move pivot to its final place
		valueTemp = array[storeIndex];
		array[storeIndex] = array[rightIndex];
		array[rightIndex] = valueTemp;
		return storeIndex;
	}

	private static void quickSort(string[] array, int leftIndex, int rightIndex)
	{
		// If the list has 2 or more items
		if (leftIndex < rightIndex)
		{
			Random rand = new Random();
			int pivotIndex = rand.Next(leftIndex, rightIndex + 1); // "Choice of pivot" random
			int pivotNewIndex = partition(array, leftIndex, rightIndex, pivotIndex); // Get lists of bigger and smaller items and final position of pivot

			// Recursively sort elements smaller than the pivot
			quickSort(array, leftIndex, pivotNewIndex - 1);

			// Recursively sort elements at least as big as the pivot
			quickSort(array, pivotNewIndex + 1, rightIndex);
		}
	}

	private static void Main()
	{
		// Deklarations
		string word = "";
		Random rand = new Random();
		int lenghtOfArray = rand.Next(6, 25);
		string[] arrayOfInteger = new string[lenghtOfArray];

		//generate random array
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			for (int k = 0; k < rand.Next(1, 10); k++)
			{
				word = word + Convert.ToChar(rand.Next(65, 65 + 26));
			}
			arrayOfInteger[i] = word.ToLower();
			word = "";
			Console.WriteLine("{0}", arrayOfInteger[i]);
		}
		Console.WriteLine();

		// Solution
		quickSort(arrayOfInteger, 0, arrayOfInteger.Length - 1);

		// Output
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			Console.WriteLine("{0} ", arrayOfInteger[i]);
		}
	}
}