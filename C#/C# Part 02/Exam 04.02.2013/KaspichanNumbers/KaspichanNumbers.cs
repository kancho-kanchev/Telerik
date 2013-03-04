using System;
using System.Numerics;

internal class KaspichanNumbers
{
	private static string DecToBase(string baseNumber, int baseX)
	{
		string result = "";
		BigInteger number = BigInteger.Parse(baseNumber);
		string vremResult = "";
		while (number > 0)
		{
			vremResult = ConvertKaspichanNumber((char)((number % baseX) + 'A'));
			result = vremResult + result;
			//Console.WriteLine(result);
			number = number / baseX;
		}
		return result;
	}
	private static string DecToBase2(string baseNumber, int baseX)
	{
		string result = "";
		BigInteger number = BigInteger.Parse(baseNumber);
		string vremResult = "";
		while (number > 0)
		{
			//vremResult = ConvertKaspichanNumber((char)((number % baseX) + 'a'));
			result = (char)((number % baseX) + 'a') + result;
			//Console.WriteLine(result);
			number = number / baseX;
		} 
		return result;
	}
	private static string ConvertKaspichanNumber(char p)
	{
		char r='Z';
		string x = "";
		if (p>'Z')
		{
			//Console.WriteLine((char)(p-26));
			//Console.WriteLine(DecToBase2((p-26).ToString(),256)+'a');
			x = string.Format("{0}{1}",(char)(p /25+'a'-3), (char)(p - 26));
			return x;//DecToBase2((p-r).ToString(), 26);
		}
		else
		{
			return p.ToString();
		}
	}

	private static void Main()
	{
		string number = Console.ReadLine();
		//for (int i = 1; i < 55; i++)
		//{


		//	//BigInteger number = 1000;
			string result = DecToBase(number, 256);
			Console.WriteLine(result);
		//}
		//string[] number = new string[256];
		//for (int i = 0; i < 256/26; i++)
		//{
		//	for (int k = 0; k < 26; k++)
		//	{
		//		number[i] = Convert.ToString('A' + k);
		//		Console.WriteLine(number[i]);
		//	}
		//}
		//Console.WriteLine(1000%256);
		//BigInteger number = 1000;
		//Console.WriteLine(234%26);
		//string[] patern = new string[256];
		//for (int i = 0; i < 256/26; i++)
		//{
		//	for (int k = 0; k < 256/26; k++)
		//	{
		//		patern[i] = Convert.ToString(i+1 + 'A');
		//	}

		//}
	}
}