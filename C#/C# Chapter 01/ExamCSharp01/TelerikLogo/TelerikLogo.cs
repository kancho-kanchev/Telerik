using System;

class TelerikLogo
{
	static void Main()
	{
		int numberX = int.Parse(Console.ReadLine());

		int heightOfTheTree = (numberX+1)/2;
		int countInRow = 1;
		int countRow = 0;
		int charNumbers = heightOfTheTree * heightOfTheTree;
		char simbol = (char)0x2A;
		char simbolEmpty = (char)0x2E;
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
				if ((j == (((countInRow - writeSimbol) / 2))+1) || (j == ((countInRow - writeSimbol) / 2) + writeSimbol))
				{
					rowToWrite = rowToWrite + simbol;
				}
				else
				{
					rowToWrite = rowToWrite + simbolEmpty;
				}
			}
			for (int j = 1; j <= countInRow-2; j++)
			{
				rowToWrite = rowToWrite + simbolEmpty;
			}
			for (int j = 1; j <= countInRow; j++)
			{
				if ((j == (((countInRow - writeSimbol) / 2)) + 1) || (j == ((countInRow - writeSimbol) / 2) + writeSimbol))
				{
					rowToWrite = rowToWrite + simbol;
				}
				else
				{
					rowToWrite = rowToWrite + simbolEmpty;
				}
			}
			writeSimbol = writeSimbol + 2;
			Console.WriteLine(rowToWrite);
			rowToWrite = "";
		}
		heightOfTheTree = numberX * 3 - 2 - (numberX + 1) / 2;
		countRow = heightOfTheTree;
		for (int i = 1; i <= countRow - numberX+1; i++)
		{
			for (int j = 1; j <= numberX*3-2; j++)
			{
				if ((j == (((countInRow - writeSimbol) / 2) + numberX+1 + (numberX * 3 - 2 - numberX * 2))) || (j == ((countInRow - writeSimbol) / 2) + writeSimbol))
				{
					rowToWrite = rowToWrite + simbol;
				}
				else
				{
					rowToWrite = rowToWrite + simbolEmpty;
				}
			}
			writeSimbol = writeSimbol + 2;
			Console.WriteLine(rowToWrite);
			rowToWrite = "";
		}
		heightOfTheTree = numberX - 1;
		countRow = heightOfTheTree;
		writeSimbol =(3);
		for (int i = 1; i <= countRow; i++)
		{
			for (int j = 1; j <= numberX * 3 - 2; j++)
			{
				if ((j == (((countInRow - writeSimbol) / 2) + numberX + 1 + (numberX * 3 - 2 - numberX * 2))) || (j == ((countInRow - writeSimbol) / 2) + writeSimbol))
				{
					rowToWrite = rowToWrite + simbol;
				}
				else
				{
					rowToWrite = rowToWrite + simbolEmpty;
				}
			}
			writeSimbol = writeSimbol + 2;
			Console.WriteLine(rowToWrite);
			rowToWrite = "";
		}


	}
}