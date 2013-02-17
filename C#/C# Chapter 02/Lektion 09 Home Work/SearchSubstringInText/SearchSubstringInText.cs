using System;
using System.Text.RegularExpressions;

//04. Write a program that finds how many times a substring
//is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:
//"We are living in an yellow submarine. We don't have anything else.
//Inside the submarine is very tight. So we are drinking all the day.
//We will move out of it in 5 days."
//	The result is: 9

internal class SearchSubstringInText
{
	private static void Main()
	{
		string str = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
		string subStr = "in";
		Console.WriteLine("Text:\n{0}\n\nSubstring: {1}\n", str, subStr);
		Console.WriteLine("Matches: {0}", Regex.Matches(str, subStr, RegexOptions.IgnoreCase).Count);
	}
}