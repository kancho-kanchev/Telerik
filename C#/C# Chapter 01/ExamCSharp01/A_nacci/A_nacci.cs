using System;

class A_nacci
{
	static void Main()
	{
		//input
		int count = 0;
		string result = "";
		char letterOne = char.Parse(Console.ReadLine());
		char letterTwo = char.Parse(Console.ReadLine());
		char letterThree = 'A';
		int lines = int.Parse(Console.ReadLine());
		//solution


		//Console.WriteLine(Convert.ToChar(122));


		//print result
		Console.WriteLine(letterOne);
		for (int row = 2; row <= lines; row++)
		{
			if (((letterOne - 'A' + 1) + (letterTwo - 'A' + 1)) > 26)
			{
				letterThree = Convert.ToChar((((letterOne - 'A' + 1) + (letterTwo - 'A' + 1)) % 26) + 'A' - 1);
			}
			else
			{
				letterThree = Convert.ToChar((letterOne - 'A' + 1) + (letterTwo - 'A' + 1) + 'A' - 1);
			}
			letterOne = letterTwo;
			letterTwo = letterThree;
			result = Convert.ToString(letterOne);
			for (int col = 1; col <= count; col++)
			{
				result = result + String.Format(" ");
			}
			if (((letterOne - 'A' + 1) + (letterTwo - 'A' + 1)) > 26)
			{
				letterThree = Convert.ToChar((((letterOne - 'A' + 1) + (letterTwo - 'A' + 1)) % 26) + 'A' - 1);
			}
			else
			{
				letterThree = Convert.ToChar((letterOne - 'A' + 1) + (letterTwo - 'A' + 1) + 'A' - 1);
			}
			letterOne = letterTwo;
			letterTwo = letterThree;
			result = result + letterOne;
			Console.WriteLine(result);
			count++;
		}
	}
}