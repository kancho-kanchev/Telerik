using System;

//You are given an array of strings.
//Write a method that sorts the array by
//the length of its elements
//(the number of characters composing them).

//Копи паст на методите от задачата quickSort
//и смяна на условито за сравнение от CompareTo => array.lenght

internal class SortsStringArray
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
			if (array[i].Length < pivotValue.Length) //array[i].lenght < pivotValue.lenght
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

	private static void sortStringArray(string[] arrayOfStrings)
	{
		//solution
		quickSort(arrayOfStrings, 0, arrayOfStrings.Length - 1);
	}

	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		string[] arrayOfStrings = new string[rand.Next(3, 10)];
		int[] result = new int[4]; // startX, startY, count, direction (1=line,2=col, 3=diagonalRight, 4=diagonalLeft

		//generate random array
		string word = "";
		for (int i = 0; i < arrayOfStrings.Length; i++)
		{
			for (int k = 0; k < rand.Next(1, 6); k++)
			{
				word = word + Convert.ToChar(rand.Next(65, 65 + 26));
			}
			arrayOfStrings[i] = word.ToLower();
			Console.Write(arrayOfStrings[i] + ", ");
			word = "";
		}
		Console.WriteLine();

		// Solution
		sortStringArray(arrayOfStrings);

		// output result
		for (int i = 0; i < arrayOfStrings.Length; i++)
		{
			Console.WriteLine(arrayOfStrings[i]);
		}
	}
}