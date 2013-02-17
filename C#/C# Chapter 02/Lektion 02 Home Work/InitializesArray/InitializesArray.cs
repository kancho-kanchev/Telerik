using System;

//01. Write a program that allocates array of 20 integers
//and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

internal class InitializesArray
{
	private static void Main()
	{
		// Declarations
		int lenghtOfArray = 20;
		int[] arrayOfInteger = new int[lenghtOfArray];

		// Initialize and output
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = i * 5;
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();
	}
}