//03. Write a method that returns the last digit of
//given integer as an English word.
//Examples: 512  "two", 1024  "four", 12309  "nine".

internal class DigitToWordMetod
{
	private static string DigitToWord(int number)
	{
		int digitOne = number % 10;
		string[] digit =
		{
			"zero",
			"one",
			"two",
			"three",
			"four",
			"five",
			"six",
			"seven",
			"eight",
			"nine"
		};
		return digit[digitOne];
	}

	private static void Main()
	{
		int number = 4654650; //число дадено по условие
		string result = DigitToWord(number);
		System.Console.WriteLine("{0} => {1}", number, result);
	}
}