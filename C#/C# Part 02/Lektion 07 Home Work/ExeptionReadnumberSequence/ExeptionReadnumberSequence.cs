using System;

//02. Write a method ReadNumber(int start, int end) that enters
//an integer number in given range [start…end].
//If an invalid number or non-number text is entered,
//the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100

internal class ExeptionReadnumberSequence
{
	private static void Main()
	{
		try
		{
			int end = 100;
			int[] arrayOfInteger = new int[10];
			arrayOfInteger[0] = ReadNumber(0, end);
			for (int i = 1; i < arrayOfInteger.Length; i++)
			{
				arrayOfInteger[i] = ReadNumber(arrayOfInteger[i - 1], end);
			}
		}
		catch (ArgumentException)
		{
			Console.WriteLine("Invalid number");
		}
		catch (FormatException)
		{
			Console.WriteLine("Format exception");
		}
		catch (OverflowException)
		{
			Console.WriteLine("Overflow number");
		}
		catch (Exception exc)
		{
			Console.WriteLine("Do not worry, be happy and just try again... But the exception is: " + exc.GetType().Name + exc.Message);
		}
		finally
		{
			Console.WriteLine("Goodbay");
		}
	}

	private static int ReadNumber(int start, int end)
	{
		Console.Write("\nEnter a number between {0}, {1}: ", start, end);
		int number = int.Parse(Console.ReadLine());
		if ((number <= start) || (number > end))
		{
			throw new ArgumentException();
		}
		return number;
	}
}