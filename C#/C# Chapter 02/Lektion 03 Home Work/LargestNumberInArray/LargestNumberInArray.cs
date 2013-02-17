using System;

//Write a program, that reads from the console
//an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch()
//finds the largest number in the array which is ≤ K

internal class LargestNumberInArray
{
	private static void Main()
	{
		string userInput = "";
		int numberN = 10;
		int numberK = -6;
		int index = 0;
		while (true)
		{
			Console.Write("\nEnter a number N: ");
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
		int[] arrayOfInteger = new int[numberN];
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			while (true)
			{
				Console.Write("\nEnter a number: ");
				userInput = Console.ReadLine();
				if (int.TryParse(userInput, out arrayOfInteger[i]))
				{
					break;
				}
				Console.WriteLine("Invalid input! Please try again...");
			}
		}
		while (true)
		{
			Console.Write("\nEnter a number K: ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out numberK))
			{
				break;
			}
			Console.WriteLine("Invalid input! Please try again...");
		}

		// Solution
		Array.Sort(arrayOfInteger);
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			if (i > 0)
			{
				Console.Write(", ");
			}
			Console.Write(arrayOfInteger[i]);
		}
		Console.WriteLine();
		index = Array.BinarySearch(arrayOfInteger, numberK);
		if (index >= 0)
		{
			Console.WriteLine("K = X = {0}", arrayOfInteger[index]);
		}
		else if (~index == 0)
		{
			Console.WriteLine("K >= X = 'No'");
		}
		else
		{
			Console.WriteLine("K > X = {0}", arrayOfInteger[~index - 1]);
		}
	}
}