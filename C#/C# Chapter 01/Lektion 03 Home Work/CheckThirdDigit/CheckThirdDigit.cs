using System;
//Write an expression that checks for given integer
//if its third digit (right-to-left) is 7. E. g. 1732  true

class CheckThirdDigit
{
    static void Main()
    {
        string userInput = "";
        string stringForNumber = "";
        int number = 0;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out number)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        if (number>99)
        {
            userInput = Convert.ToString(number);
            stringForNumber = userInput.Substring((userInput.Length - 3), 3);
            Console.WriteLine((stringForNumber[0] == '7'));
        }
        else
        {
            Console.WriteLine("The number is low than 3 digit");
        }
    }
}