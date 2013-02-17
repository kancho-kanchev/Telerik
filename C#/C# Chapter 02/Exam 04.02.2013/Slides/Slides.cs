using System;

internal class Slides
{
	private static void Main()
	{
		string line = Console.ReadLine();
		string[] whd = line.Split(' ');
		int width = int.Parse(whd[0]);
		int height = int.Parse(whd[1]);
		int depth = int.Parse(whd[2]);
		string[, ,] cube3D = new string[width, height, depth];

		for (int h = 0; h < height; h++)
		{
			line = Console.ReadLine();
			string[] tokens = line.Split('|');
			for (int i = 0; i < tokens.Length; i++)
			{
				tokens[i] = tokens[i].Replace(" ", "");
				tokens[i] = tokens[i].Replace("(", "");

				//Console.WriteLine(tokens[i]);
			}
			for (int d = 0; d < depth; d++)
			{
				string[] move = tokens[d].Split(new char[] { ')' }, StringSplitOptions.RemoveEmptyEntries);
				for (int w = 0; w < width; w++)
				{
					cube3D[w, h, d] = move[w];

					//Console.WriteLine(cube3D[w, h, d]);
				}
			}
		}
		line = Console.ReadLine();
		string[] coordinates = line.Split(' ');
		int x = int.Parse(coordinates[0]);
		int y = 0;
		int z = int.Parse(coordinates[1]);

		//Solution
		bool exit = false;
		bool bracket = false;
		int vremX = x;
		int vremY = y;
		int vremZ = z;
		string control = "";
		do
		{
			vremX = x;
			vremY = y;
			vremZ = z;
			control = cube3D[x, y, z];

			//Console.WriteLine(cube3D[vremX, vremY, vremZ]);
			//Console.WriteLine("{4} {0} {1} {2} {3}", bracket, x, y, z, exit);
			//Console.WriteLine(control);
			if (cube3D[x, y, z][0] == 'E')
			{
				vremY++;
				if (vremY >= height)
				{
					vremY = height - 1;
					exit = true;
					break;
				}
			}
			else if (cube3D[x, y, z][0] == 'B')
			{
				bracket = true;
				exit = true;
				break;
			}
			else if (cube3D[x, y, z][0] == 'S')
			{
				for (int i = 1; i < cube3D[x, y, z].Length; i++)
				{
					if (cube3D[x, y, z][i] == 'L')
					{
						vremX--;
						if (vremX < 0)
						{
							vremX = 0;
							exit = true;
							break;
						}
					}
					else if (cube3D[x, y, z][i] == 'R')
					{
						vremX++;
						if (vremX >= width)
						{
							vremX = width - 1;
							exit = true;
							break;
						}
					}
					else if (cube3D[x, y, z][i] == 'B')
					{
						vremZ++;
						if (vremZ >= depth)
						{
							vremZ = depth - 1;
							exit = true;
							break;
						}
					}
					else if (cube3D[x, y, z][i] == 'F')
					{
						vremZ--;
						if (vremZ < 0)
						{
							vremZ = 0;
							exit = true;
							break;
						}
					}
				}
				vremY++;
				if (vremY >= height)
				{
					vremY = height - 1;
					exit = true;
					break;
				}
			}
			else if (cube3D[x, y, z][0] == 'T')
			{
				vremX = int.Parse(cube3D[x, y, z][1].ToString());
				vremZ = int.Parse(cube3D[x, y, z][2].ToString());
			}
			x = vremX;
			y = vremY;
			z = vremZ;
		} while (!exit);

		//output
		//Console.WriteLine("{4} {0} {1} {2} {3}", bracket, x, y, z, exit);
		//Console.WriteLine(control);

		if (bracket || (y < height - 1))
		{
			Console.WriteLine("No");
		}
		else
		{
			Console.WriteLine("Yes");
		}
		Console.WriteLine("{0} {1} {2}", x, y, z);
	}
}