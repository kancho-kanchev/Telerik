using System;

//21. Write a program that reads two numbers N and K
//and generates all the combinations of K distinct elements from the set [1..N].
//Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
//
//Вариант 2  ---> задачата за вариация + една проверка за комбинация и брояч колко принта сме направили
//
internal class GeneratesAllTheCombinations_Var02
{
	private static int stepen(int p, int k)
	{
		int x = p;
		for (int i = 2; i <= k; i++)
		{
			x = x * p;
		}
		return x;
	}

	private static bool checkForCombination(int[] arrayK)
	{
		bool result = true;
		for (int i = 0; i < arrayK.Length - 1; i++)
		{
			for (int k = i + 1; k < arrayK.Length; k++)
			{
				if (arrayK[i] <= arrayK[k])
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
		int variations = 0;
		int countComb = 0;
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
		//variations = (number-1)*number^0+(number-1)*number^1...(number-1)*number^numberK

		variations = number - 1; // (number-1)*number^0
		for (int k = 1; k < numberK; k++)
		{
			variations += (number - 1) * stepen(number, k);
		}
		variations++;
		Console.WriteLine("Varations: {0}", variations);
		int currVarTemp = 0;
		for (int currVariation = 0; currVariation < variations; currVariation++)
		{
			for (int i = 0; i < arrayK.Length; i++) // нулираме масива (безмислено но за всеки случай)
			{
				arrayK[i] = 0;
			}
			currVarTemp = currVariation;
			for (int i = 0; i < arrayK.Length; i++) // преобразуваме по формула за бройна с-ма (десетична към N-чна)
			{
				arrayK[i] = currVarTemp % number;
				currVarTemp = currVarTemp / number;
			}
			if (checkForCombination(arrayK)) // ако е комбинация принт
			{
				if (countComb > 0) // форматиране на изхода и изход
				{
					Console.Write(", ");
				}
				Console.Write("{");
				for (int i = arrayK.Length - 1; i >= 0; i--)
				{
					if (i < arrayK.Length - 1)
					{
						Console.Write(",");
					}
					Console.Write(arrayK[i] + 1); // изключваме нулата от бройната с-ма
				}
				Console.Write("}");
				countComb++;
			}
		}
		Console.WriteLine("\nCombinations: {0}", countComb);
	}
}