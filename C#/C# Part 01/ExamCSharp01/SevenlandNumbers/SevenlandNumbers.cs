using System;

class SevenlandNumbers
{
	static void Main()
	{
		//input
		string result = "";
		int? digitOne = null;
		int? digitTwo = null;
		int? digitThree = null;
		int? digitFour = null;
		int sevenBasedNumber = int.Parse(Console.ReadLine());
		//solution
		digitOne = sevenBasedNumber % 10;

		if (sevenBasedNumber > 99)
		{
			digitOne = sevenBasedNumber % 10;
			digitTwo = (sevenBasedNumber % 100) / 10;
			digitThree = sevenBasedNumber / 100;
			if (digitOne!=6)
			{
				digitOne++;
			}
			else
			{
				digitOne = 0;
				if (digitTwo!=6)
				{
					digitTwo++;
				}
				else
				{
					digitTwo = 0;
					if (digitThree!=6)
					{
						digitThree++;
					}
					else
					{
						digitThree = 0;
						digitFour = 1;
					}
				}
			}
		}
		else if (sevenBasedNumber > 9)
		{
			digitOne = sevenBasedNumber % 10;
			digitTwo = (sevenBasedNumber % 100) / 10;
			if (digitOne != 6)
			{
				digitOne++;
			}
			else
			{
				digitOne = 0;
				if (digitTwo != 6)
				{
					digitTwo++;
				}
				else
				{
					digitTwo = 0;
					digitThree = 1;
				}
			}
		}
		else
		{
			digitOne = sevenBasedNumber % 10;
			if (digitOne != 6)
			{
				digitOne++;
			}
			else
			{
				digitOne = 0;
				digitTwo = 1;
			}
		}
		result = String.Format("{0}{1}{2}{3}", digitFour, digitThree, digitTwo, digitOne);
		//print result
		Console.WriteLine(result);
		//Console.WriteLine(digitOne);
		//Console.WriteLine(digitTwo);
		//Console.WriteLine(digitThree);
		//Console.WriteLine(digitFour);
	}
}