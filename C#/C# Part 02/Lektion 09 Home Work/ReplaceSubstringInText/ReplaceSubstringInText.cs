using System;
using System.Text.RegularExpressions;

//05. You are given a text. Write a program that changes the text
//in all regions surrounded by the tags <upcase> and </upcase>
//to uppercase. The tags cannot be nested.
//Example:
//We are living in a <upcase>yellow submarine</upcase>.
//We don't have <upcase>anything</upcase> else.
//		The expected result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

internal class ReplaceSubstringInText
{
	private static void Main()
	{
		string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
		Console.WriteLine("Text:\n{0}\n\n", str);
		Console.WriteLine("Result:\n{0}", Regex.Replace(str, @"<upcase>(?:\s*([^<]+)\s*)+</upcase>", replStr => replStr.Groups[1].Value.ToUpper()));

		//<upcase>(?:\s*([^<]+)\s*)+</upcase>
	}
}