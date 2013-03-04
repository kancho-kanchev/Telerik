using System;

//01. Write a method that asks the user for his name
//and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method

internal class MetodHelloName
{
	private static void HelloName()
	{
		string name = "";
		while (true)
		{
			Console.Write("\nEnter your first name: ");
			name = Console.ReadLine();
			if (ValidateName(name))
			{
				break;
			}
			Console.WriteLine("Invalid input! Please try again...");
		}
		Console.WriteLine("Hello, {0}!", name);
	}

	private static bool ValidateName(string name)
	{
		bool result = true;
		if (name != "")
		{
			if (Char.IsLower(name[0]))
			{
				result = false;
			}
			foreach (var simbol in name)
			{
				Console.WriteLine(simbol);
				if (!Char.IsLetter(simbol))
				{
					result = false;
				}
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	private static void Main()
	{
		HelloName();

		// test metod
	}
}