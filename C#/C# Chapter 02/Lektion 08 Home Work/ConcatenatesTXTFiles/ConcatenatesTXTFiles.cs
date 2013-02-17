using System.IO;
using System.Text;

//02. Write a program that concatenates two text files into another text file.

internal class ConcatenatesTXTFiles
{
	private static void Main()
	{
		using (StreamWriter writer = new StreamWriter("..\\..\\Task01AndTask02.txt", false, Encoding.GetEncoding("Windows-1251")))
		{
			using (StreamReader readerTxt1 = new StreamReader("..\\..\\..\\FilesPtintOddLines\\FilesPrintOddLines.cs", Encoding.GetEncoding("Windows-1251")))
			{
				string lineTxt1 = readerTxt1.ReadLine();
				while (lineTxt1 != null)
				{
					writer.WriteLine(lineTxt1);
					lineTxt1 = readerTxt1.ReadLine();
				}
			}
			using (StreamReader readerTxt2 = new StreamReader("..\\..\\ConcatenatesTXTFiles.cs", Encoding.GetEncoding("Windows-1251")))
			{
				string lineTxt2 = readerTxt2.ReadLine();
				while (lineTxt2 != null)
				{
					writer.WriteLine(lineTxt2);
					lineTxt2 = readerTxt2.ReadLine();
				}
			}
		}
	}
}