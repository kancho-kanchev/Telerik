using System;

class Pillars
{
	static void Main()
	{
		//initialise data
		sbyte? resultCol = null;
		int leftSide = 0;
		int rightSide = 0;
		int mask = 1;
		byte[] row = new byte[8];
		//input data
		for (int i = 0; i < 8; i++)
		{
			row[i] = byte.Parse(Console.ReadLine());
		}
		//calculating
		for (sbyte currentCol = 7; currentCol >= 0; currentCol--)
		{
			//calc left and right side
			leftSide = 0;
			rightSide = 0;
			foreach (byte item in row)
			{
				for (sbyte position = 7; position > currentCol; position--)
				{
					mask = 1 << position;
					leftSide = leftSide + ((item >> position) & 1);
				}
				for (sbyte position = (sbyte)(currentCol - 1); position >= 0; position--)
				{
					mask = 1 << position;
					rightSide = rightSide + ((item >> position) & 1);
				}
			}
			if (leftSide == rightSide)
			{
				resultCol = currentCol;
				break;
			}
		}
		//write result
		if (resultCol != null)
		{
			Console.WriteLine(resultCol);
			Console.WriteLine(leftSide);
		}
		else
		{
			Console.WriteLine("No");
		}
	}
}