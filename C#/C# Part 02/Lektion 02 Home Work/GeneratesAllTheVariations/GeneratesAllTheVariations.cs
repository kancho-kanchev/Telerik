using System;

//20. Write a program that reads two numbers N and K
//and generates all the variations of K elements from the set [1..N].
//Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

internal class GeneratesAllTheVariations
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

	private static void Main()
	{
		//Declarations
		string userInput = "";
		int number = 0;
		int numberK = 0;
		int variations = 0;
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
				if (numberK > 0)
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
			if (currVariation > 0) // форматиране на изхода и изход
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
		}
		Console.WriteLine();
	}
}