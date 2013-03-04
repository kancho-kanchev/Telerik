using System;
using System.Numerics;

class Tribonacci
{
	static void Main()
	{
		BigInteger result = 0;
		BigInteger element1 = int.Parse(Console.ReadLine());
		BigInteger element2 = int.Parse(Console.ReadLine());
		BigInteger element3 = int.Parse(Console.ReadLine());
		int count = int.Parse(Console.ReadLine());
		if (count == 1) Console.WriteLine(element1);
		else if (count == 2) Console.WriteLine(element2);
		else if (count == 3) Console.WriteLine(element3);
		else
		{
			for (int i = 3; i < count; i++)
			{
				result = element1 + element2 + element3;
				element1 = element2;
				element2 = element3;
				element3 = result;
			}
			Console.WriteLine(result);
		}
	}
}