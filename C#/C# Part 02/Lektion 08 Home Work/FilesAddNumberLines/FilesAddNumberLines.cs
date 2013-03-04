using System.IO;
using System.Text;

//03. Write a program that reads a text file and
//inserts line numbers in front of each of its lines.
//The result should be written to another text file.

internal class FilesAddNumberLines
{
	private static void Main()
	{
		using (StreamReader reader = new StreamReader("..\\..\\FilesAddNumberLines.cs", Encoding.GetEncoding("Windows-1251")))
		{
			using (StreamWriter writer = new StreamWriter("..\\..\\ProgramWidthLines.txt", false, Encoding.GetEncoding("Windows-1251")))
			{
				int lineNumber = 0;
				string line = reader.ReadLine();
				while (line != null)
				{
					lineNumber++;
					writer.WriteLine("Line {0}: {1}", lineNumber, line);
					line = reader.ReadLine();
				}
			}
		}
	}
}