using System;

//21. Write a program that reads two numbers N and K
//and generates all the combinations of K distinct elements from the set [1..N].
//Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
//
//Вариант 1  ---> преобразуваме масив във nextCombination()
//
internal class GeneratesAllTheCombinations
{
	private static void nextCombination(int[] arrayK, int index, int number)
	{
		if (arrayK[index] == number - (arrayK.Length - index - 1))
		{
			if (index > 0)
			{
				nextCombination(arrayK, index - 1, number);
				arrayK[index] = arrayK[index - 1] + 1;
			}
		}
		else
		{
			arrayK[index]++;
		}
	}

	private static bool checkForCombination(int[] arrayK)
	{
		bool result = true;
		for (int i = 0; i < arrayK.Length - 1; i++)
		{
			for (int k = i + 1; k < arrayK.Length; k++)
			{
				if (arrayK[i] >= arrayK[k])
				{
					result = false;
				}
			}
		}
		return result;
	}

	private static void Main()
	{
		//Declarations
		string userInput = "";
		int number = 0;
		int numberK = 0;
		int combinations = 1;
		while (true)
		{
			Console.Write("\nEnter a number N: ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out number))
			{
				if (number > 0)
				{
					break;
				}
			}
			Console.WriteLine("Invalid input! Please try again...");
		}
		while (true)
		{
			Console.Write("\nEnter a element's count: ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out numberK))
			{
				if ((numberK <= number) && (numberK > 0))
				{
					break;
				}
			}
			Console.WriteLine("Invalid input! Please try again...");
		}
		int[] arrayK = new int[numberK];

		// Solution
		for (int i = 0; i < arrayK.Length; i++) // инициализираме масива
		{
			arrayK[i] = i;
		}
		arrayK[arrayK.Length - 1] = arrayK[arrayK.Length - 1] - 1;

		// find number of combinations
		for (int n = number; n >= number - numberK + 1; n--)
		{
			combinations = combinations * n;
		}
		for (int k = 1; k <= numberK; k++)
		{
			combinations = combinations / k;
		}
		Console.WriteLine("Combinations: {0}", combinations);
		int currCombTemp = 0;

		// find next k-combination
		for (int currCombination = 0; currCombination < combinations; currCombination++)
		{
			currCombTemp = currCombination;
			nextCombination(arrayK, arrayK.Length - 1, number - 1); // преобразуваме масива до следващата вариация
			if (checkForCombination(arrayK)) // ако е комбинация принт
			{
				if (currCombination > 0) // форматиране на изхода и изход
				{
					Console.Write(", ");
				}
				Console.Write("{");
				for (int i = 0; i < arrayK.Length; i++)
				{
					if (i > 0)
					{
						Console.Write(",");
					}
					Console.Write(arrayK[i] + 1); // изключваме нулата
				}
				Console.Write("}");
			}
			else
			{
				// ако не е комбинация връщаме цикъла с едно
				currCombination = currCombination - 1;
			}
		}
		Console.WriteLine();
	}
}