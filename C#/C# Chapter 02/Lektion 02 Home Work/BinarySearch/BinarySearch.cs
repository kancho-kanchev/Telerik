using System;

//11. Write a program that finds the index of given element
//in a sorted array of integers by using
//the binary search algorithm (find it in Wikipedia).

internal class BinarySearch
{
	private static int binarySearch(int[] arrayOfIntegerInMetod, int numberInMetod)
	{
		int midPoint = 0;
		int midPointMin = 0;
		int midPointMax = arrayOfIntegerInMetod.Length;
		while ((midPointMax - midPointMin) > 3)
		{
			midPoint = ((midPointMax - midPointMin) / 2) + midPointMin;
			if (arrayOfIntegerInMetod[midPoint] == numberInMetod)
			{
				return midPoint;
			}
			if (arrayOfIntegerInMetod[midPoint] < numberInMetod)
			{
				midPointMin = midPoint + 1;
			}
			else
			{
				midPointMax = midPoint - 1;
			}
		}
		for (int i = midPointMin; i < midPointMax; i++)
		{
			if (arrayOfIntegerInMetod[i] == numberInMetod)
			{
				return i;
			}
		}
		return (-1);
	}

	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		int lenghtOfArray = rand.Next(6, 25);
		int[] arrayOfInteger = new int[lenghtOfArray];//{ -6, -2, -1, -6, 5, 8, -3, -1, 1, 0, -4, 4, 5, 9, -9, -3, -11, -8, -4, 3, -5, -2, 4, 7 }; //
		string userInput = "";
		int number = 0;
		int numberIndex = -1;

		//generate random array
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = rand.Next(-11, 11);
		}

		//sorting array - Копирано от предишна задача
		int minValueIndex = 0;
		int minValue = 0;
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
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			Console.Write("{0,2} ", arrayOfInteger[i]);
		}
		Console.WriteLine();

		// get number from console
		while (true)
		{
			Console.Write("\nEnter a number: ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out number))
			{
				break;
			}
			Console.WriteLine("Invalid input! Please try again...");
		}

		// Solution
		numberIndex = binarySearch(arrayOfInteger, number);

		// Output result
		if (numberIndex == (-1))
		{
			Console.WriteLine("Number: {0} is not found", number);
		}
		else
		{
			if (numberIndex > 0)
			{
				while (arrayOfInteger[numberIndex - 1] == number)
				{
					if (numberIndex > 0)
					{
						numberIndex--;
					}
					else
					{
						break;
					}
				}
			}
			while (arrayOfInteger[numberIndex] == number)
			{
				Console.WriteLine("Number: {0} is on index: {1}", arrayOfInteger[numberIndex], numberIndex);
				numberIndex++;
			}
		}

		//Console.ReadKey();
	}
}