using System;

class Bits
{
	static int Mirror(int p)
	{
		int numberMirror = p;
		int bits = 0;
		while (numberMirror > 0)
		{
			numberMirror = numberMirror >> 1;
			bits++;
		}
		numberMirror = p;
		int startPositionP = 0;
		int startPositionQ = bits - 1;
		int countBits = 1;
		int buffer = 0;
		int mask = 1;
		bool result1 = false;
		bool result2 = false;
		buffer = numberMirror;
		while (startPositionP <= startPositionQ)
		{
			for (int i = startPositionP; i < startPositionP + countBits; i++)
			{
				mask = 1 << i;
				result1 = (numberMirror & mask) != 0;
				mask = 1 << i + startPositionQ - startPositionP;
				result2 = (numberMirror & mask) != 0;
				if (result2)
				{
					mask = 1 << i;
					numberMirror = numberMirror | mask;
				}
				else
				{
					mask = ~(1 << i);
					numberMirror = numberMirror & mask;
				}
				if (result1)
				{
					mask = 1 << i + startPositionQ - startPositionP;
					numberMirror = numberMirror | mask;
				}
				else
				{
					mask = ~(1 << i + startPositionQ - startPositionP);
					numberMirror = numberMirror & mask;
				}
			}
			startPositionP++;
			startPositionQ--;
		}
		return numberMirror;
	}

	private static void Main()
	{
		int numberN = int.Parse(Console.ReadLine()); //  0 < N < 801
		int[] numbers = new int[numberN];
		int[] result = new int[numberN];
		int numberMirror = 0; //..P
		for (int i = 0; i < numberN; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}

		//body Pnew = (P ^ P̃) & P̈.
		for (int i = 0; i < numberN; i++)
		{
			numberMirror = Mirror(numbers[i]);

			//Console.WriteLine("  N = {0}", Convert.ToString(numbers[i], 2).PadLeft(32, '0'));//Convert.ToString( numbers[i], 2).PadLeft(32, '0')
			//Console.WriteLine("..P = {0}", Convert.ToString(numberMirror, 2).PadLeft(32, '0'));
			result[i] = numberMirror;
		}

		//print
		for (int i = 0; i < numberN; i++)
		{
			Console.WriteLine(result[i]);
		}
	}
}