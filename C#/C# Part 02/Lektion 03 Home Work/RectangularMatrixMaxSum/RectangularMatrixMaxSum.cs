using System;

//Write a program that reads a rectangular matrix of size N x M
//and finds in it the square 3 x 3 that has maximal sum of its elements.

internal class RectangularMatrixMaxSum
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

	private static int getMaxSum(int[,] matrix, int indexBeginX, int indexBeginY, int indexEndX, int indexEndY)
	{
		int sum = 0;
		for (int x = indexBeginX; x <= indexEndX; x++)
		{
			for (int y = indexBeginY; y <= indexEndY; y++)
			{
				sum = sum + matrix[x, y];
			}
		}
		return sum;
	}

	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		int indexX = rand.Next(3, 16);
		int indexY = rand.Next(3, 16);
		int[,] matrix = new int[indexX, indexY];
		indexX = 0;
		indexY = 0;
		int maxSum = 0;
		int tableX = 2; // 0,1,2 => 3 elements
		int tableY = 2; // 0,1,2 => 3 elements

		//generate random array
		for (int x = 0; x < matrix.GetLength(0); x++)
		{
			for (int y = 0; y < matrix.GetLength(1); y++)
			{
				matrix[x, y] = rand.Next(-11, 11);
			}
		}

		// Solution
		Console.WriteLine("{0}:{1}", matrix.GetLength(0), matrix.GetLength(1));
		maxSum = getMaxSum(matrix, indexX, indexY, tableX, tableY); // Приемаме първата плочка [0,0] за максимална сума
		for (int x = 0; x < matrix.GetLength(0) - tableX; x++)
		{
			for (int y = 0; y < matrix.GetLength(1) - tableY; y++)
			{
				if (maxSum < getMaxSum(matrix, x, y, x + tableX, y + tableY))
				{
					maxSum = getMaxSum(matrix, x, y, x + tableX, y + tableY);
					indexX = x;
					indexY = y;
				}
			}
		}

		//Print
		printArray(matrix, "Result");
		Console.WriteLine("Maximal sum: {0}, x: {1}, y: {2};", maxSum, indexX, indexY);
	}
}