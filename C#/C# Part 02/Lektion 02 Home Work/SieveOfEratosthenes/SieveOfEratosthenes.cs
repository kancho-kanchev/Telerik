using System;
using System.IO;

//15. Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

internal class SieveOfEratosthenes
{
	private static void Main()
	{
		// Deklarations
		int count = 0;
		StreamWriter writer = null;
		string filename = "SieveOfEratosthenes.txt";
		int arrayLenght = 10000000;

		//array of Boolean values, indexed by integers 2 to n,
		bool[] array = new bool[arrayLenght];

		//initially all set to true.
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = true;
		}

		// Solution
		//for i = 2, 3, 4, ..., √n :
		for (int i = 2; i < Math.Sqrt(array.Length); i++)
		{
			if (array[i])
			{
				for (int j = i * i; j < array.Length; j = j + i)
				{
					array[j] = false;
				}
			}
		} //Now all i such that A[i] is true are prime.

		// output result
		count = 0;
		for (int i = 2; i < array.Length; i++)
		{
			if (array[i])
			{
				//Console.Write("{0} ", i); // Не пускай - много бавно печати!!!
				count++;
			}
		}
		Console.WriteLine("\nCount: {0}\nEnd", count);

		/*****************************************  Нека отпечатим във файл :) ***********************************************************/
		const string usageText = "Usage: File is in use 'SieveOfEratosthenes.txt'";
		try
		{
			// Attempt to open output file.
			writer = new StreamWriter(filename);

			// Redirect standard output from the console to the output file.
			Console.SetOut(writer);
		}
		catch (IOException e)
		{
			TextWriter errorWriter = Console.Error;

			//errorWriter.WriteLine(e.Message);
			errorWriter.WriteLine(usageText);
		}

		//begin write in file
		count = 0;
		for (int i = 2; i < array.Length; i++)
		{
			if (array[i])
			{
				Console.Write("{0} ", i);
				count++;
			}
		}
		Console.WriteLine("\nCount: {0}\nEnd", count);

		//end write in file
		writer.Close();

		// Recover the standard output stream so that a
		// completion message can be displayed.
		StreamWriter standardOutput = new StreamWriter(Console.OpenStandardOutput());
		standardOutput.AutoFlush = true;
		Console.SetOut(standardOutput);
		/******************* print file ********************/

		// Read the file as one string.
		string text = System.IO.File.ReadAllText(filename);

		// Display the file contents to the console. Variable text is a string.
		System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
		Console.WriteLine("The result is in {0}", filename);

		// Keep the console window open in debug mode.
		Console.WriteLine("Press any key to exit.");
		System.Console.ReadKey();
	}
}