using System;

class SandGlass
{
	static void Main()
	{
		//Console.OutputEncoding = Encoding.Unicode;
		int heightOfTheHourglass = (int.Parse(Console.ReadLine())) - 1;
		int countInRow = heightOfTheHourglass + 1;
		int countRow = (heightOfTheHourglass + 1) / 2 + 1;
		char simbol = (char)0x2A;
		char simbolEmpty = (char)0x2E;
		//char simbol = '\u00A9';
		int writeSimbol = heightOfTheHourglass;
		string rowToWrite = "";
		writeSimbol = countInRow;
		for (int i = 1; i < countRow; i++)
		{
			for (int j = countInRow; j > 0; j--)
			{
				if ((j <= ((countInRow - writeSimbol) / 2)) || (j > ((countInRow - writeSimbol) / 2) + writeSimbol))
				{
					rowToWrite = rowToWrite + simbolEmpty;
				}
				else
				{
					rowToWrite = rowToWrite + simbol;
				}
			}
			writeSimbol = writeSimbol - 2;
			Console.WriteLine(rowToWrite);
			rowToWrite = "";
		}
		writeSimbol = 1;
		for (int i = 1; i <= countRow; i++)
		{
			for (int j = 1; j <= countInRow; j++)
			{
				if ((j <= ((countInRow - writeSimbol) / 2)) || (j > ((countInRow - writeSimbol) / 2) + writeSimbol))
				{
					rowToWrite = rowToWrite + simbolEmpty;
				}
				else
				{
					rowToWrite = rowToWrite + simbol;
				}
			}
			writeSimbol = writeSimbol + 2;
			Console.WriteLine(rowToWrite);
			rowToWrite = "";
		}
	}
}