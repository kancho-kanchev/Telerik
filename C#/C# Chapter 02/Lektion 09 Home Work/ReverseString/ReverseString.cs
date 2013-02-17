using System;

//02. Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

//copy/paste от предишно домашно

internal class ReverseString
{
	private static string ReverseStr(string arr)
	{
		int endIndex = arr.Length - 1;
		char[] newArr = new char[arr.Length];
		for (int i = 0; i <= newArr.Length / 2; i++)
		{
			newArr[i] = arr[endIndex];
			newArr[endIndex] = arr[i];
			endIndex--;
		}
		arr = "";
		for (int i = 0; i < newArr.Length; i++)
		{
			arr = arr + newArr[i];
		}
		return arr;
	}

	private static void Main()
	{
		Console.Write("\nEnter a string: ");
		string userInput = Console.ReadLine();
		userInput = ReverseStr(userInput);
		Console.WriteLine(userInput);
	}
}