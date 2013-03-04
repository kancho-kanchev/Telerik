using System;

class AstrologicalDigits
{
	static void Main()
	{
		string numberString = Console.ReadLine();
		int number = 0;
		int digit = 0;
		do
		{
			number = 0;
			foreach (char item in numberString)
			{
				if (int.TryParse(Convert.ToString(item), out digit))
				{
					number = number + digit;
				}
			}
			numberString = Convert.ToString(number);
		} while (number > 9);
		Console.WriteLine(number);
	}
}