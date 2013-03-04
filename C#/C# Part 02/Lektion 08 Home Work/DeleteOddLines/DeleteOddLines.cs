using System.Collections.Generic;
using System.IO;
using System.Text;

//09. Write a program that deletes from given text file all odd lines. The result should be in the same file.

internal class DeleteOddLines
{
	private static void Main()
	{
		List<string> lines = new List<string>();
		StreamReader reader = new StreamReader("..\\..\\sample.txt", Encoding.GetEncoding("Windows-1251"));
		using (reader)
		{
			int lineNumber = 0;
			string line = reader.ReadLine();
			while (line != null)
			{
				lineNumber++;
				if (lineNumber % 2 == 0)
				{
					lines.Add(line);
				}
				line = reader.ReadLine();
			}
		}
		using (StreamWriter writer = new StreamWriter("..\\..\\sample.txt", false, Encoding.GetEncoding("Windows-1251")))
		{
			foreach (var item in lines)
			{
				writer.WriteLine(item);
			}
		}
	}
}