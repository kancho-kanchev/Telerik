using System;

//03. Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

//добавена е допълнителна проверка ако има "=" да проверява скобите от двете му страни

internal class CheckBrackets
{
	private static bool checkExpressionBrackets(string str)
	{
		int bracket = 0;
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i].Equals('('))
			{
				bracket++;
			}
			else if (str[i].Equals(')'))
			{
				bracket--;
			}
			else if (str[i].Equals('='))
			{
				if (bracket!=0)
				{
					return false;
				}
			}
			if (bracket < 0)
			{
				return false;
			}
		}
		if (bracket != 0)
		{
			return false;
		}
		else
		{
			return true;
		}
	}

	private static void Main()
	{
		string str = "(((a+b)*2)/1)-4= (5)";
		bool result = true;
		result = checkExpressionBrackets(str);
		if (result)
		{
			Console.WriteLine("{0}\nThe expression is ok.", str);
		}
		else
		{
			Console.WriteLine("{0}\nThe expression isn't ok.", str);
		}
	}
}