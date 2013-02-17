using System;

//03. Write a program that compares two char arrays lexicographically
//(letter by letter).
//
//При лексикографската наредба символите се сравняват един по един като
//се започва от най-левия. При несъвпадащи символи по-рано е масивът,
//чийто текущ символ е по-рано в азбуката. При съвпадение се продължава
//със следващия символ вдясно. Ако се стигне до края на единия масив,
//по-краткият е лексикографски по-рано. Ако всички съответни символи от
//двата масива съвпаднат, то масивите са еднакви и никой от тях не е
//по-рано в лексикографската наредба.
//Из книгата на Наков.
// П.С. Първо проверяваме лексикографски дали някой от двата не е по напред и
// ако са равни лексикографски проверяваме дължината.

internal class ComparesTwoArraysLexicographically
{
	private static void Main()
	{
		// Initialize and input arrays lenght
		string userInput = "";
		bool firstIsFirst = true;
		bool secondIsFirst = true;
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
		char[] arrayFirst = new char[lenghtOfArray]; // Declarations first array
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
		char[] arraySecond = new char[lenghtOfArray]; // Declarations second array

		// Initialize first array
		Console.WriteLine("Input first array elements with \"Enter\":");
		for (int i = 0; i < arrayFirst.Length; i++)
		{
			while (true)
			{
				userInput = Console.ReadLine();
				userInput = userInput.ToLower();
				if (char.TryParse(userInput, out arrayFirst[i]))
				{
					break;
				}
				Console.WriteLine("Invalid input! Please try again...");
			}
		}

		// Initialize second array
		Console.WriteLine("Input second array elements with \"Enter\":");
		for (int i = 0; i < arraySecond.Length; i++)
		{
			while (true)
			{
				userInput = Console.ReadLine();
				userInput = userInput.ToLower();
				if (char.TryParse(userInput, out arraySecond[i]))
				{
					break;
				}
				Console.WriteLine("Invalid input! Please try again...");
			}
		}

		// Solution
		for (int i = 0; i < Math.Min(arrayFirst.Length, arraySecond.Length); i++)
		{
			if (arrayFirst[i] > arraySecond[i])
			{
				firstIsFirst = false;
				break;
			}
			else if (arrayFirst[i] < arraySecond[i])
			{
				secondIsFirst = false;
				break;
			}
		}
		if (firstIsFirst && secondIsFirst)
		{
			if (arrayFirst.Length > arraySecond.Length)
			{
				firstIsFirst = false;
			}
			if (arrayFirst.Length < arraySecond.Length)
			{
				secondIsFirst = false;
			}
		}

		// Output
		if (firstIsFirst && secondIsFirst)
		{
			Console.WriteLine("The first array and second array are equal.");
		}
		else if (firstIsFirst && !secondIsFirst)
		{
			Console.WriteLine("The first array is first.");
		}
		else if (!firstIsFirst && secondIsFirst)
		{
			Console.WriteLine("The second array is first.");
		}
		else
		{
			Console.WriteLine("Programata ne raboti pravilno");
		}
	}
}