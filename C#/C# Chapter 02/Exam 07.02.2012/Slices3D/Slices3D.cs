using System;

internal class Slices3D
{
	private static void Main()
	{
		string line = Console.ReadLine();
		string[] whd = line.Split(' ');
		int width = int.Parse(whd[0]);
		int height = int.Parse(whd[1]);
		int depth = int.Parse(whd[2]);
		int[, ,] cube3D = new int[width, height, depth];
		int count = 0;
		long sum = 0;
		long totalSum = 0;

		for (int h = 0; h < height; h++)
		{
			line = Console.ReadLine();
			string[] tokens = line.Split('|');
			for (int d = 0; d < depth; d++)
			{
				string[] numbers = tokens[d].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				for (int w = 0; w < width; w++)
				{
					int value = int.Parse(numbers[w]);
					cube3D[w, h, d] = value;
					totalSum += cube3D[w, h, d];
				}
			}
		}

		//Solution

		for (int w = 0; w < width - 1; w++)
		{
			for (int h = 0; h < height; h++)
			{
				for (int d = 0; d < depth; d++)
				{
					sum += cube3D[w, h, d];
				}
			}
			if ((sum * 2) == totalSum)
			{
				count++;
			}
		}

		sum = 0;
		for (int h = 0; h < height - 1; h++)
		{
			for (int w = 0; w < width; w++)
			{
				for (int d = 0; d < depth; d++)
				{
					sum += cube3D[w, h, d];
				}
			}
			if ((sum * 2) == totalSum)
			{
				count++;
			}
		}

		sum = 0;
		for (int d = 0; d < depth - 1; d++)
		{
			for (int w = 0; w < width; w++)
			{
				for (int h = 0; h < height; h++)
				{
					sum += cube3D[w, h, d];
				}
			}
			if ((sum * 2) == totalSum)
			{
				count++;
			}
		}
		Console.WriteLine(count);
	}
}

//for (int w = 0; w < width; w++)
//{
//	for (int h = 0; h < height; h++)
//	{
//		for (int d = 0; d < depth; d++)
//		{
//			Console.Write(cube3D[w, h, d]);
//		}
//		Console.Write(' ');
//	}
//	Console.WriteLine();
//}