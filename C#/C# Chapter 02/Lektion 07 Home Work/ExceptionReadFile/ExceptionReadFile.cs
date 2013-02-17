using System;
using System.IO;
using System.Security;

//03. Write a program that enters file name
//along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

internal class ExceptionReadFile
{
	private static string readFile(string fileName)
	{
		return File.ReadAllText(fileName);
	}

	private static void Main()
	{
		try
		{
			Console.Write("\nEnter a file name with full path (e.g. C:\\WINDOWS\\win.ini): ");
			string fileName = Console.ReadLine();

			//fileName = @"C:\WINDOWS\win.ini";
			string fileContent = readFile(fileName);
			Console.WriteLine("The content of the file is: ");
			Console.WriteLine(fileContent);
		}
		catch (DirectoryNotFoundException)
		{
			Console.WriteLine("Directory not found!");
		}
		catch (FileNotFoundException)
		{
			Console.WriteLine("File not found!");
		}
		catch (ArgumentNullException)
		{
			Console.WriteLine("File path is empty!");
		}
		catch (ArgumentException)
		{
			Console.WriteLine("File path is not correct!");
		}
		catch (PathTooLongException)
		{
			Console.WriteLine("Path is too long!");
		}
		catch (UnauthorizedAccessException uoae)
		{
			Console.WriteLine(uoae.Message);
		}
		catch (SecurityException)
		{
			Console.WriteLine("You don't have the required permission to access this file!");
		}
		catch (NotSupportedException)
		{
			Console.WriteLine("Invalid file path format!");
		}
		catch (IOException ioe)
		{
			Console.WriteLine(ioe.Message);
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