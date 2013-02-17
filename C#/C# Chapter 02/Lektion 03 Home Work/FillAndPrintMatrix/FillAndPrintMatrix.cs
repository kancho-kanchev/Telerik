using System;

//Write a program that fills and prints a matrix of size (n, n)
//as shown below: (examples for n = 4)

internal class FillAndPrintMatrix
{
	private static void printArray(int[,] arrayOfInteger, string task)
	{
		Console.WriteLine(task);
		for (int x = 0; x < arrayOfInteger.GetLength(0); x++)
		{
			for (int y = 0; y < arrayOfInteger.GetLength(1); y++)
			{
				Console.Write("{0,3}", arrayOfInteger[x, y]);
				if (y < arrayOfInteger.GetLength(1) - 1)
				{
					Console.Write(", ");
				}
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}

	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		int lenghtOfArray = rand.Next(2, 16);
		int[,] matrix = new int[lenghtOfArray, lenghtOfArray];
		int indexX = 0;
		int indexY = 0;
		int indexXend = 0;
		int indexYend = 0;
		int count = 1;
		int loops = 1;

		// Solution
		// A
		// Initialize
		for (int y = 0; y < matrix.GetLength(0); y++)
		{
			for (int x = 0; x < matrix.GetLength(1); x++)
			{
				matrix[x, y] = count++;
			}
		}

		//Print
		printArray(matrix, "a)");

		// B
		//Initialize
		count = 1;
		for (int y = 0; y < matrix.GetLength(0); y++)
		{
			if ((y % 2) != 0)
			{
				for (int x = matrix.GetLength(1) - 1; x >= 0; x--)
				{
					matrix[x, y] = count++;
				}
			}
			else
			{
				for (int x = 0; x < matrix.GetLength(1); x++)
				{
					matrix[x, y] = count++;
				}
			}
		}

		//Print
		printArray(matrix, "b)");

		// C
		//Initialize
		count = 1;
		for (int i = 0; i < matrix.GetLength(0) * 2 - 1; i++)
		{
			indexX = 0;
			indexY = matrix.GetLength(0) - i - 1;
			if (indexY < 0)
			{
				indexY = 0;
			}
			if (i >= matrix.GetLength(1))
			{
				indexX = i - matrix.GetLength(1) + 1;
			}
			while ((indexX < matrix.GetLength(0)) && (indexY < matrix.GetLength(1)))
			{
				matrix[indexY++, indexX++] = count++;
			}
		}

		//Print
		printArray(matrix, "c)");

		// D
		// Initialize
		indexX = 0;
		indexY = 0;
		count = 1;
		indexYend = matrix.GetLength(1) - 1;
		indexXend = matrix.GetLength(0) - 1;
		if (matrix.GetLength(0) % 2 == 0)
		{
			loops = matrix.GetLength(0) / 2;
		}
		else
		{
			loops = (matrix.GetLength(0) + 1) / 2;
		}
		for (int i = 1; i <= loops; i++)
		{
			for (int col = indexY; col <= indexYend; col++)
			{
				matrix[col, indexX] = count++;
			}
			indexX = indexX + 1;
			for (int row = indexX; row <= indexXend; row++)
			{
				matrix[indexYend, row] = count++;
			}
			indexYend = indexYend - 1;
			for (int col = indexYend; col >= indexY; col--)
			{
				matrix[col, indexXend] = count++;
			}
			indexXend = indexXend - 1;
			for (int row = indexXend; row >= indexX; row--)
			{
				matrix[indexY, row] = count++;
			}
			indexY++;
		}

		//Print
		printArray(matrix, "d)");
	}
}