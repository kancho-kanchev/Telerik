using System;
using System.Net;

//04. Write a program that downloads a file
//from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

internal class ExceptionDownloadFileFromInternet
{
	private static void Main()
	{
		try
		{
			WebClient downLoad = new WebClient();
			Console.WriteLine("This program will \"download Exception-Handling.pptx\".");
			Console.WriteLine();
			Console.WriteLine("Downloading please wait...");
			Console.WriteLine();
			downLoad.DownloadFile("http://downloads.academy.telerik.com/svn/csharppart2/Lectures/6.%20Exceptions%20Handling/Exception-Handling.pptx", "Exception-Handling.pptx");
			Console.WriteLine("Exception-Handling.pptx was download");
			Console.WriteLine();
			Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
			Console.WriteLine();
		}
		catch (ArgumentNullException)
		{
			Console.WriteLine(@"
						The address parameter is null.
						-or-
						The fileName parameter is null.");
		}
		catch (WebException)
		{
			Console.WriteLine(@"
						The URI formed by combining BaseAddress and address is invalid.
						-or-
						filename is null or Empty.
						-or-
						The file does not exist.
						-or-
						An error occurred while downloading data.");
		}
		catch (NotSupportedException)
		{
			Console.WriteLine("The method has been called simultaneously on multiple threads.");
		}
		catch (Exception exc)
		{
			Console.WriteLine("Do not worry, be happy and just try again... But the exception is: " + exc.GetType().Name + exc.Message);
		}
		finally
		{
			Console.WriteLine();
			Console.WriteLine("Goodbay");
			Console.WriteLine();
		}
	}
}