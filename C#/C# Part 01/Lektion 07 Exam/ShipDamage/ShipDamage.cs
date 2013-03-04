using System;

class ShipDamage
{
	static void Main()
	{
		int result = 0;
		int[,] catapult = new int[2, 3];
		int sx1 = int.Parse(Console.ReadLine());
		int sy1 = int.Parse(Console.ReadLine());
		int sx2 = int.Parse(Console.ReadLine());
		int sy2 = int.Parse(Console.ReadLine());
		int horisont = int.Parse(Console.ReadLine());
		sy1 = sy1 - horisont;
		sy2 = sy2 - horisont;
		for (int i = 0; i < 3; i++)
		{
			catapult[0, i] = int.Parse(Console.ReadLine());
			catapult[1, i] = -(int.Parse(Console.ReadLine()) - horisont);
		}
		int top = Math.Max(sy1, sy2);
		int bottom = Math.Min(sy1, sy2);
		int left = Math.Min(sx1, sx2);
		int right = Math.Max(sx1, sx2);
		for (int i = 0; i < 3; i++)
		{
			if ((catapult[1, i] < top) && (catapult[1, i] > bottom) && (catapult[0, i] > left) && (catapult[0, i] < right))
			{
				result = result + 100;
			}
			else if (((catapult[1, i] == top) && (catapult[0, i] == left)) ||
					 ((catapult[1, i] == top) && (catapult[0, i] == right)) ||
					 ((catapult[1, i] == bottom) && (catapult[0, i] == left)) ||
					 ((catapult[1, i] == bottom) && (catapult[0, i] == right)))
			{
				result = result + 25;
			}
			else if (((catapult[1, i] == top) && (catapult[0, i] > left) && (catapult[0, i] < right)) ||
					 ((catapult[1, i] == bottom) && (catapult[0, i] > left) && (catapult[0, i] < right)) ||
					 ((catapult[0, i] == left) && (catapult[1, i] > bottom) && (catapult[1, i] < top)) ||
					 ((catapult[0, i] == right) && (catapult[1, i] > bottom) && (catapult[1, i] < top)))
			{
				result = result + 50;
			}
		}
		Console.WriteLine("{0}%", result);
	}
}