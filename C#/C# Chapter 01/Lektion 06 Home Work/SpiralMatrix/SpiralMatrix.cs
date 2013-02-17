using System;

//Write a program that reads a positive integer
//number N (N < 20) from console and outputs in
//the console the numbers 1 ... N numbers arranged as a spiral.
//		Example for N = 4
// 1  2  3  4
//12 13 14  5
//11 16 15  6
//10  9  8  7

class SpiralMatrix
{
	static void Main()
	{
		int colBegin = 0;
		int colEnd = 0;
		int rowBegin = 0;
		int rowEnd = 0;
		int loops = 1;
		int counter = 1;
		int[,] matrix = new int[19, 19];
		string userInput = "";
		int numberN = 1;
		while (true)
		{
			Console.Write("\nEnter a number N: ");
			userInput = Console.ReadLine();
			if (int.TryParse(userInput, out numberN))
			{
				if ((numberN < 20) && (numberN > 0))
				{
					break;
				}
			}
			Console.WriteLine("Invalid input! Please try again...( 0 < N < 20)");
		}
		colEnd = numberN - 1;
		rowEnd = numberN - 1;
		if (numberN % 2 == 0)
		{
			loops = numberN / 2;
		}
		else
		{
			loops = (numberN + 1) / 2;
		}
		for (int i = 1; i <= loops; i++)
		{
			for (int col = colBegin; col <= colEnd; col++)
			{
				matrix[col, rowBegin] = counter;
				counter++;
			}
			rowBegin = rowBegin + 1;
			for (int row = rowBegin; row <= rowEnd; row++)
			{
				matrix[colEnd, row] = counter;
				counter++;
			}
			colEnd = colEnd - 1;
			for (int col = colEnd; col >= colBegin; col--)
			{
				matrix[col, rowEnd] = counter;
				counter++;
			}
			rowEnd = rowEnd - 1;
			for (int row = rowEnd; row >= rowBegin; row--)
			{
				matrix[colBegin, row] = counter;
				counter++;
			}
			colBegin = colBegin + 1;
		}
		//print
		for (int col = 0; col < numberN; col++)
		{
			for (int row = 0; row < numberN; row++)
			{
				Console.Write("{0,3} ", matrix[row, col]);
			}
			Console.WriteLine();
		}
	}
}