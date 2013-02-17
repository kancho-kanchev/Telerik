using System;

//02. Write a method GetMax() with two parameters
//that returns the bigger of two integers.
//Write a program that reads 3 integers from the console
//and prints the biggest of them using the method GetMax().

internal class GetMaxMetod
{
	private static int GetMax(int number1, int number2)
	{
		if (number1 > number2)
		{
			return number1;
		}
		else
		{
			return number2;
		}
	}

	private static void Main()
	{
		int bigger = 0;
		int[] arrayOfInteger = new int[3];
		string userInput = "";
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			while (true)
			{
				Console.Write("\nEnter a number {0}: ", i);
				userInput = Console.ReadLine();
				if (int.TryParse(userInput, out arrayOfInteger[i]))
				{
					break;
				}
				Console.WriteLine("Invalid input! Please try again...");
			}
		}
		bigger = GetMax(GetMax(arrayOfInteger[0],arrayOfInteger[1]), arrayOfInteger[2]);
		Console.WriteLine("The bigger is: {0}", bigger);
	}
}