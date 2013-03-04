using System;

//16.* We are given an array of integers and a number S.
//Write a program to find if there exists a subset of
//the elements of the array that has a sum S.
//Example:
//	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

internal class SubsetSum
{
	private static int DeleteTheZeros(int[] arrayNumber, int length)
	{
		for (int i = 0; i < arrayNumber.Length; i++)
		{
			if (arrayNumber[i] != 0)
			{
				arrayNumber[length] = arrayNumber[i];
				length++;
			}
		}
		return length;
	}

	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		int lenghtOfArray = rand.Next(5, 10);
		int[] arrayOfInteger = new int[lenghtOfArray]; // Enter array here and comment down (line 42)
		int sum = 14; // Enter "S" here
		int mask = Convert.ToInt32(Math.Pow(2, 0));
		int length = 0;
		int sumTemp = 0;
		string sumString = "";

		//arrayOfInteger = { 13, 14, 15, 16, 0, 1, 2, 3, 17, 18, 19, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
		//arrayOfInteger = {10, 8, -7, -10, -6, 1};
		//{ 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
		//{4, 3, 1, 4, 2, 5, 8}{ -4, 6, -7, 8, 6, -10, -3, 0 };
		//{ 2, 1, 2, 4, 3, 5, 2, 6 };9 0 6 -10 4 2 10
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = rand.Next(-11, 11); // comment if enter hardcore array
			Console.Write(arrayOfInteger[i] + " ");
		}
		Console.WriteLine();

		// Solution
		length = DeleteTheZeros(arrayOfInteger, length);
		Console.WriteLine("Results:");
		if (length > 0)
		{
			for (int i = 1; i <= Math.Pow(2, length) - 1; i++)
			{
				for (int j = 0; j < length; j++)
				{
					mask = 1 << j;

					if ((i & mask) != 0)
					{
						sumTemp += arrayOfInteger[j];
						if (arrayOfInteger[j] < 0)
						{
							if (sumString == "")
							{
								sumString = String.Format("({0})", Convert.ToString(arrayOfInteger[j]));
							}
							else
							{
								sumString = String.Format("{0}{1}", sumString, Convert.ToString(arrayOfInteger[j]));
							}
						}
						else
						{
							if (sumString == "")
							{
								sumString = String.Format("{0}", Convert.ToString(arrayOfInteger[j]));
							}
							else
							{
								sumString = String.Format("{0}+{1}", sumString, Convert.ToString(arrayOfInteger[j]));
							}
						}
					}
				}
				if (sum == sumTemp)
				{
					Console.WriteLine("{1}={0}", sumString, sum);
				}
				sumTemp = 0;
				sumString = "";
			}
		}
	}
}