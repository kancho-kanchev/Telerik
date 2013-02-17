using System;

//Write a program that prints all the numbers from 1 to N,
//that are not divisible by 3 and 7 at the same time.

class PrintsNumbersToN_NotDivisibleByThreeAndSeven
{
    static void Main()
    {
        string userInput = "";
        int number = 0;
        while (true)
        {
            Console.Write("\nEnter a number: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out number))
            {
                if (number >= 1)
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again...(number>=1)");
        }
        for (int i = 1; i <= number; i++)
        {
            if (!(((i % 3) == 0) && ((i % 7) == 0)))
            {
                Console.WriteLine("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}