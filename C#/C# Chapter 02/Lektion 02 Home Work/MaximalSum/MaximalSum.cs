using System;

//06. Write a program that reads two integer numbers N and K
//and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

internal class MaximalSum
{
	private static void Main()
	{
		// Declarations and initialize
		int maxSum = 0;
		int currentSum = 0;
		int startSeq = 1;
		string userInput = "";
		int numberN = 0;
		int numberK = 0;
		while (true)
		{
			Console.Write("\nEnter a number 'N' of elements: ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out numberN))
			{
				if (numberN > 0)
				{
					break;
				}
			}
			Console.WriteLine("Invalid input! Please try again...");
		}
		while (true)
		{
			Console.Write("\nEnter a number 'K': ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out numberK))
			{
				if ((numberK > 0) && (numberK <= numberN))
				{
					break;
				}
			}
			Console.WriteLine("Invalid input! Please try again...");
		}
		int[] arrayOfInteger = new int[numberN];

		// Initialize
		Console.WriteLine("\nEnter a numbers separete with 'Enter': ");
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			while (true)
			{
				userInput = Console.ReadLine();
				if (int.TryParse(userInput, out arrayOfInteger[i]))
				{
					break;
				}
				Console.WriteLine("Invalid input! Please try again...");
			}
		}

		// For hardcore
		//arrayOfInteger = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17,18,19 };
		//
		// Solution
		for (int i = 0; i <= arrayOfInteger.Length - numberK; i++)
		{
			for (int k = 0; k < numberK; k++)
			{
				currentSum = currentSum + arrayOfInteger[i + k];
			}
			if (currentSum > maxSum)
			{
				maxSum = currentSum;
				startSeq = i;
			}
			currentSum = 0;
		}

		//output
		Console.WriteLine("Max Sum is {0} and begins from index {1}", maxSum, startSeq);
		for (int i = startSeq; i < startSeq + numberK; i++)
		{
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();
	}
}