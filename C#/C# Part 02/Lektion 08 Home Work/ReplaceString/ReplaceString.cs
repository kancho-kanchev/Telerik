using System.IO;
using System.Text;

//07. Write a program that replaces all occurrences of the substring "start"
//with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).

internal class ReplaceString
{
	private static void Main()
	{
		string wordFrom = "finish";
		string wordTo = "start";
		using (StreamReader reader = new StreamReader("..\\..\\original.txt", Encoding.GetEncoding("Windows-1251")))
		{
			using (StreamWriter writer = new StreamWriter("..\\..\\replaced.txt", false, Encoding.GetEncoding("Windows-1251")))
			{
				string line = reader.ReadLine();
				while (line != null)
				{
					line = line.Replace(wordFrom, wordTo);
					writer.WriteLine(line);
					line = reader.ReadLine();
				}
			}
		}
	}
}