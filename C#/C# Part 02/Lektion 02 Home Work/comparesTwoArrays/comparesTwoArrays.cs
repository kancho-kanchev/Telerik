using System;

//02. Write a program that reads two arrays
//from the console and compares them
//element by element
//
//Два масива са еднакви, когато имат еднаква дължина и
//стойностите на елементите в тях съответно съвпадат.
//Из книгата на Наков.

internal class comparesTwoArrays
{
	private static void Main()
	{
		// Initialize and input arrays lenght
		string userInput = "";
		string outputMessage = "";
		int lenghtOfArray = 0;
		while (true)
		{
			Console.Write("\nEnter a lenght of first array: ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out lenghtOfArray))
			{
				if (lenghtOfArray >= 0)
				{
					break;
				}
			}
			Console.WriteLine("Invalid input! Please try again...");
		}
		string[] arrayFirst = new string[lenghtOfArray]; // Declarations first array
		while (true)
		{
			Console.Write("\nEnter a lenght of second array: ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out lenghtOfArray))
			{
				if (lenghtOfArray >= 0)
				{
					break;
				}
			}
			Console.WriteLine("Invalid input! Please try again...");
		}
		string[] arraySecond = new string[lenghtOfArray]; // Declarations second array

		// Solution and output
		if (arrayFirst.Length == arraySecond.Length)
		{
			// Initialize first array
			Console.WriteLine("Input first array elements with \"Enter\":");
			for (int i = 0; i < arrayFirst.Length; i++)
			{
				arrayFirst[i] = Console.ReadLine();
			}

			// Initialize second array and compares to first array
			Console.WriteLine("Input second array elements with \"Enter\":");
			for (int i = 0; i < arraySecond.Length; i++)
			{
				arraySecond[i] = Console.ReadLine();
				if (arrayFirst[i] != arraySecond[i])
				{
					outputMessage = String.Format("The arrays are not equal!\nfirst array [{0}] = {1}\nsecond array [{0}] = {2}", i, arrayFirst[i], arraySecond[i]);
					break;
				}
				else
				{
					outputMessage = String.Format("The arrays are equal!");
				}
			}
		}
		else
		{
			outputMessage = String.Format("The arrays are not equal!\n(first array have lenght = {0}; second array have lenght = {1};)", arrayFirst.Length, arraySecond.Length);
		}
		Console.WriteLine(outputMessage);
	}
}