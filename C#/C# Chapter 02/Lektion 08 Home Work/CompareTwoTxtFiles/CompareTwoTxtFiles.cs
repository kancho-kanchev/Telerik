using System;
using System.IO;
using System.Text;

//04. Write a program that compares two text files line by line and
//prints the number of lines that are the same and the number of
//lines that are different. Assume the files have equal number of lines.

internal class CompareTwoTxtFiles
{
	private static void Main()
	{
		int lineNumber = 0;
		int counter = 0;
		using (StreamReader readerTxt1 = new StreamReader("..\\..\\..\\FilesPtintOddLines\\FilesPrintOddLines.cs", Encoding.GetEncoding("Windows-1251")))
		{
			using (StreamReader readerTxt2 = new StreamReader("..\\..\\CompareTwoTxtFiles.cs", Encoding.GetEncoding("Windows-1251")))
			{
				lineNumber = 0;
				string lineTxt1 = readerTxt1.ReadLine();
				string lineTxt2 = readerTxt2.ReadLine();
				while ((lineTxt1 != null) || (lineTxt2 != null))
				{
					lineNumber++;
					lineTxt1 = readerTxt1.ReadLine();
					lineTxt2 = readerTxt2.ReadLine();
					if (lineTxt1 == lineTxt2)
					{
						counter++;
						Console.WriteLine("Lines {0} are equal", lineNumber);
					}
				}
			}
		}
		Console.WriteLine("{0} Lines are equal; {1} Lines are different", counter, lineNumber - counter);
	}
}