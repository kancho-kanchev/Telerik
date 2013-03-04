using System;

class FighterAttack
{
	static void Main()
	{
		//initialise data
		int result = 0;
		int plantX1 = int.Parse(Console.ReadLine());
		int plantY1 = int.Parse(Console.ReadLine());
		int plantX2 = int.Parse(Console.ReadLine());
		int plantY2 = int.Parse(Console.ReadLine());
		int fighterX = int.Parse(Console.ReadLine());
		int fighterY = int.Parse(Console.ReadLine());
		int distanceD = int.Parse(Console.ReadLine());
		int top = Math.Max(plantY1, plantY2);
		int bottom = Math.Min(plantY1, plantY2);
		int left = Math.Min(plantX1, plantX2);
		int right = Math.Max(plantX1, plantX2);
		fighterX = fighterX + distanceD;
		//calculating
		if ((fighterY <= top) && (fighterY >= bottom) && (fighterX >= left) && (fighterX <= right))
		{
			result = result + 100;
		}
		fighterX = fighterX + 1;
		if ((fighterY <= top) && (fighterY >= bottom) && (fighterX >= left) && (fighterX <= right))
		{
			result = result + 75;
		}
		fighterX = fighterX - 1;
		fighterY = fighterY + 1;
		if ((fighterY <= top) && (fighterY >= bottom) && (fighterX >= left) && (fighterX <= right))
		{
			result = result + 50;
		}
		fighterY = fighterY - 2;
		if ((fighterY <= top) && (fighterY >= bottom) && (fighterX >= left) && (fighterX <= right))
		{
			result = result + 50;
		}
		//write result
		Console.WriteLine("{0}%", result);
	}
}