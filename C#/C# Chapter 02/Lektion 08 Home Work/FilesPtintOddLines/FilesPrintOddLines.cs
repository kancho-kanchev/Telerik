using System;
using System.IO;
using System.Text;

//01. Write a program that reads a text file
//and prints on the console its odd lines.

internal class FilesPtintOddLines
{
	private static void Main()
	{
		//new FileStream(0, FileAccess.Read);

		//StreamReader reader = new StreamReader("c:\\windows\\win.ini", Encoding.GetEncoding("Windows-1251"));
		StreamReader reader = new StreamReader
			("..\\..\\FilesPtintOddLines.cs", Encoding.GetEncoding("Windows-1251"));
		using (reader)
		{
			int lineNumber = 0;
			string line = reader.ReadLine();
			while (line != null)
			{
				lineNumber++;
				if (lineNumber % 2 != 0)
				{
					Console.WriteLine("Line {0}: {1}", lineNumber, line);
				}
				line = reader.ReadLine();
			}
		}
	}
}