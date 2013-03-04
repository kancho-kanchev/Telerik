using System;

//01. Write a program that reads an integer number and calculates
//and prints its square root. If the number is invalid or negative,
//print "Invalid number". In all cases finally print "Good bye".
//Use try-catch-finally

internal class ExceptionSquareRoot
{
	private static void Main()
	{
		try
		{
			Console.Write("\nEnter a positive number: ");
			int number = int.Parse(Console.ReadLine());
			if (number < 0)
			{
				throw new ArgumentException();
			}
			else
			{
				Console.WriteLine("SQRT({0}) = {1}", number, Math.Sqrt(number));
			}
		}
		catch (ArgumentException)
		{
			Console.WriteLine("Number not in range");
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
}