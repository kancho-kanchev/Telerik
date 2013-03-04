using System;

//We are given a matrix of strings of size N x M.
//Sequences in the matrix we define as sets of
//several neighbor elements located on
//the same line, column or diagonal.
//Write a program that finds the longest sequence
//of equal strings in the matrix.

internal class LongestSequenceInTheMatrix
{
	private static void printArray(string[,] matrix, string task)
	{
		Console.WriteLine(task);
		for (int y = 0; y < matrix.GetLength(1); y++)
		{
			for (int x = 0; x < matrix.GetLength(0); x++)
			{
				Console.Write("{0,5}", matrix[x, y]);
				if (x < matrix.GetLength(1) - 1)
				{
					Console.Write(", ");
				}
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}

	private static void checkMatrix(string[,] matrix, int[] result, int startX, int startY, int directionX, int directionY)
	{
		int count = 1;
		int y = startY;
		for (int x = startX; (x < matrix.GetLength(0)) && (y < matrix.GetLength(1)); x = x + directionX, y = y + directionY)
		{
			if ((x + directionX < matrix.GetLength(0)) && (y + directionY < matrix.GetLength(1)) && (x + directionX > -1) && (y + directionY > -1))
			{
				//Console.WriteLine("{2}:{3}-{0}=={1}-{4}:{5}     {6}", matrix[startX, startY], matrix[x + directionX, y + directionY], startX, startY, x + directionX, y + directionY, count);
				if (matrix[startX, startY] == matrix[x + directionX, y + directionY])
				{
					count++;
				}
				else
				{
					if (result[2] < count)
					{
						result[0] = startX;
						result[1] = startY;
						result[2] = count;
						if ((directionX == 1) && (directionY == 0))
						{
							result[3] = 1;
						}
						else if ((directionX == 0) && (directionY == 1))
						{
							result[3] = 2;
						}
						else if ((directionX == 1) && (directionY == -1))
						{
							result[3] = 3;
						}
						else if ((directionX == -1) && (directionY == 1))
						{
							result[3] = 4;
						}
					}
					startX = x + directionX;
					startY = y + directionY;
					count = 1;
				}
			}
			if (result[2] < count)
			{
				result[0] = startX;
				result[1] = startY;
				result[2] = count;
				if ((directionX == 1) && (directionY == 0))
				{
					result[3] = 1;
				}
				else if ((directionX == 0) && (directionY == 1))
				{
					result[3] = 2;
				}
				else if ((directionX == 1) && (directionY == 1))
				{
					result[3] = 3;
				}
				else if ((directionX == -1) && (directionY == 1))
				{
					result[3] = 4;
				}
			}
		}
	}

	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		string[,] matrix = new string[rand.Next(3, 10), rand.Next(3, 10)];
		int[] result = new int[4]; // startX, startY, count, direction (1=line,2=col, 3=diagonalRight, 4=diagonalLeft

		//generate random array
		string[] words = new string[Math.Min(matrix.GetLength(0), matrix.GetLength(1))];
		string word = "";
		for (int i = 0; i < words.Length; i++)
		{
			for (int k = 0; k < rand.Next(1, 6); k++)
			{
				word = word + Convert.ToChar(rand.Next(65, 65 + 26));
			}
			words[i] = word.ToLower();
			word = "";
		}
		for (int x = 0; x < matrix.GetLength(0); x++)
		{
			for (int y = 0; y < matrix.GetLength(1); y++)
			{
				matrix[x, y] = words[rand.Next(0, Math.Min(matrix.GetLength(0), matrix.GetLength(1)))];
			}
		}

		//print random array
		printArray(matrix, "");

		// Solution

		result[0] = 0;
		result[1] = 0;
		result[2] = 0;
		result[3] = 0;

		for (int i = 0; i < matrix.GetLength(1); i++) //for direction line
		{
			checkMatrix(matrix, result, 0, i, 1, 0);
		}
		for (int i = 0; i < matrix.GetLength(0); i++) // for direction col
		{
			checkMatrix(matrix, result, i, 0, 0, 1);
		}
		for (int i = 1; i < matrix.GetLength(1); i++) // for direction diaginal right
		{
			checkMatrix(matrix, result, 0, i, 1, 1);
		}
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			checkMatrix(matrix, result, i, 0, 1, 1);
		}
		for (int i = 1; i < matrix.GetLength(1); i++) // for direction diagonal left
		{
			checkMatrix(matrix, result, matrix.GetLength(0) - 1, i, -1, 1);
		}
		for (int i = 1; i < matrix.GetLength(0); i++)
		{
			checkMatrix(matrix, result, i, 0, -1, 1);
		}

		//Print
		switch (result[3])
		{
			case 1:
				word = "line - left";
				break;

			case 2:
				word = "column - down";
				break;

			case 3:
				word = "diagonal - right - down";
				break;

			case 4:
				word = "diagonal - left - down";
				break;
		}
		Console.WriteLine("word: {0}\nrow:       {1}\ncol:       {2}\ndirection: {4}\ncount:     {3}", matrix[result[0], result[1]], result[1] + 1, result[0] + 1, result[2], word);
	}
}