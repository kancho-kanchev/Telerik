using System;
using System.Numerics;

class TribonacciTriangle
{
	static void Main()
	{
		BigInteger result = 0;
		BigInteger element1 = int.Parse(Console.ReadLine());
		BigInteger element2 = int.Parse(Console.ReadLine());
		BigInteger element3 = int.Parse(Console.ReadLine());
		int lines = int.Parse(Console.ReadLine());
		Console.WriteLine(element1);
		Console.WriteLine("{0} {1}", element2, element3);
		for (int i = 3; i <= lines; i++)
		{
			for (int j = lines; j < lines + i; j++)
			{
				result = element1 + element2 + element3;
				element1 = element2;
				element2 = element3;
				element3 = result;
				Console.Write("{0}", element3);
				if (lines + i > j)
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}
}