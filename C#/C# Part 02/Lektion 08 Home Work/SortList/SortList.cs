using System.Collections.Generic;
using System.IO;
using System.Text;

//06. Write a program that reads a text file containing
//a list of strings, sorts them and
//saves them to another text file. Example:
//Ivan			George
//Peter			Ivan
//Maria			Maria
//George		Peter

internal class SortList
{
	private static void Main()
	{
		List<string> lines = new List<string>();
		using (StreamReader reader = new StreamReader("..\\..\\Unsorted.txt", Encoding.GetEncoding("Windows-1251")))
		{
			string line = reader.ReadLine();
			while (line != null)
			{
				lines.Add(line);
				line = reader.ReadLine();
			}
		}
		lines.Sort();
		using (StreamWriter writer = new StreamWriter("..\\..\\result.txt", false, Encoding.GetEncoding("Windows-1251")))
		{
			foreach (var item in lines)
			{
				writer.WriteLine(item);
			}
		}
	}
}