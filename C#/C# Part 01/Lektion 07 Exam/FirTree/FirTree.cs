using System;

//using System.Text;

class FirTree
{
	static void Main()
	{
		//Console.OutputEncoding = Encoding.Unicode;
		int heightOfTheTree = (int.Parse(Console.ReadLine())) - 1;
		int countInRow = 1;
		int countRow = 0;
		int charNumbers = heightOfTheTree * heightOfTheTree;
		char simbol = (char)0x2A;
		char simbolEmpty = (char)0x2E;
		//char simbol = '\u00A9';
		int writeSimbol = 1;
		string rowToWrite = "";
		while (writeSimbol <= charNumbers)
		{
			for (int i = 1; i <= countInRow; i++)
			{
				if (writeSimbol <= charNumbers) writeSimbol++;
			}
			countInRow = countInRow + 2;
		}
		writeSimbol = 1;
		countRow = ((countInRow + 1) / 2) - 1;
		countInRow = countInRow - 2;
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
		writeSimbol = 1;
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
		Console.WriteLine(rowToWrite);
	}
}