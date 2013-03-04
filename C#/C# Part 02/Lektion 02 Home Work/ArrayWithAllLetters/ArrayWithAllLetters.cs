using System;

//12. Write a program that creates an array containing
//all letters from the alphabet (A-Z).
//Read a word from the console and print the index
//of each of its letters in the array.

internal class ArrayWithAllLetters
{
	private static void Main()
	{
		// Deklarations
		int lenghtOfArray = 52;
		int letter_a = 0; // Ако искаме а=1  за прегледност тогава letter_a = 1;
		lenghtOfArray += letter_a;
		int[] arrayOfInteger = new int[lenghtOfArray];
		string userInput = "";

		//generate array
		for (int i = letter_a; i < arrayOfInteger.Length / 2 + letter_a; i++)
		{
			arrayOfInteger[i] = 'a' + i - letter_a;
			Console.Write(Convert.ToChar(arrayOfInteger[i]) + " ");
		}
		Console.WriteLine();
		for (int i = (arrayOfInteger.Length / 2 + letter_a); i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = 'A' + i - (arrayOfInteger.Length / 2) - letter_a;
			Console.Write(Convert.ToChar(arrayOfInteger[i]) + " ");
		}
		Console.Write("\nEnter a word: ");
		userInput = Console.ReadLine();

		// Solution
		foreach (var inpChar in userInput)
		{
			for (int indexchar = 0 + letter_a; indexchar < arrayOfInteger.Length; indexchar++)
			{
				if (inpChar == Convert.ToChar(arrayOfInteger[indexchar]))
				{
					Console.WriteLine(inpChar + " " + indexchar);
				}
			}
		}
		Console.WriteLine(userInput.Length);
	}
}