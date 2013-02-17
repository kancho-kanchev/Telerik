using System.IO;
using System.Text;
using System.Text.RegularExpressions;

//08. Modify the solution of the previous problem to replace only whole words (not substrings).

//Previous problem: Write a program that replaces all occurrences of the substring "start"
//with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).

internal class ReplaceWord
{
	private static void Main()
	{
		using (StreamReader reader = new StreamReader("..\\..\\original.txt", Encoding.GetEncoding("Windows-1251")))
		{
			using (StreamWriter writer = new StreamWriter("..\\..\\replaced.txt", false, Encoding.GetEncoding("Windows-1251")))
			{
				string line = reader.ReadLine();
				while (line != null)
				{
					line = Regex.Replace(line, @"\bfinish\b", "start");
					writer.WriteLine(line);
					line = reader.ReadLine();
				}
			}
		}
	}
}