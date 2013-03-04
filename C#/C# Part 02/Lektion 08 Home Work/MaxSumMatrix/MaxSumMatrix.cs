using System;
using System.IO;
using System.Text;

//05. Write a program that reads a text file containing a square matrix of numbers
//and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2

internal class MaxSumMatrix
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
		int indexX = 0;
		int indexY = 0;
		int maxSum = 0;
		int tableX = 1; // 0,1,2 => 3 elements
		int tableY = 1; // 0,1,2 => 3 elements
		using (StreamReader reader = new StreamReader("..\\..\\matrix.txt", Encoding.GetEncoding("Windows-1251")))
		{
			string line = reader.ReadLine();
			int[,] matrix = new int[int.Parse(line), int.Parse(line)];
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				string[] numbers = reader.ReadLine().Split(' ');
				for (int k = 0; k < matrix.GetLength(1); k++)
				{
					matrix[i, k] = int.Parse(numbers[k]);
				}
			}
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
			printArray(matrix, "Result");
		}
		using (StreamWriter writer = new StreamWriter("..\\..\\result.txt", false, Encoding.GetEncoding("Windows-1251")))
		{
			writer.WriteLine(maxSum);
		}
		Console.WriteLine("Maximal sum: {0}, x: {1}, y: {2};", maxSum, indexY, indexX);
	}
}