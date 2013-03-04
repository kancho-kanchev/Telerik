using System;
//Write an expression that checks if given integer is odd or even
class OddOrEven
{
    static void Main()
    {
        string userInput;
        int integer;
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please, tell us integer to check for odd or even?");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out integer))
            {
                if (!((integer % 2) == 0))
                {
                    Console.WriteLine("This integer is odd");
                }
                else
                {
                    Console.WriteLine("This integer is even");
                }
                break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
    }
}