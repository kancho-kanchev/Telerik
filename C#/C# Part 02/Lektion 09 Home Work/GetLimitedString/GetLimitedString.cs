using System;
using System.Text;

//06. Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should
//be filled with '*'. Print the result string into the console.

internal class GetLimitedString
{
	private static void Main()
	{
		int strLength = 20;
		StringBuilder str = new StringBuilder("", strLength);
		string userInput = "";
		while (true)
		{
			Console.Write("\nEnter a string of maximum {0} characters: ", strLength);
			userInput = Console.ReadLine();
			if (userInput.Length <= strLength)
			{
				break;
			}
			Console.WriteLine("Invalid input! Please try again...");
		}
		str.Append(userInput);
		for (int i = userInput.Length; i < strLength; i++)
		{
			str.Append("*");
		}
		userInput = str.ToString();
		Console.WriteLine(userInput);
	}
}