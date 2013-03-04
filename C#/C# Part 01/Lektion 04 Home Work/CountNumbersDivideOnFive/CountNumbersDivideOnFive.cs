using System;
//Write a program that reads two positive integer numbers and
//prints how many numbers p exist between them
//such that the reminder of the division by 5 is 0 (inclusive).
//Example: p(17,25) = 2

class CountNumbersDivideOnFive
{
    static void Main()
    {
        string userInput = "";
        uint numberA = 0;
        uint numberB = 0;
        uint numberAZeroProtection = 0;
        uint numberBZeroProtection = 0;
        uint count = 0;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a positive number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (uint.TryParse(userInput, out numberA))
            {
                if (numberA >= 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a positive number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (uint.TryParse(userInput, out numberB))
            {
                if (numberB >= 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        if (numberA > numberB)
        {
            numberA = numberA + numberB;
            numberB = numberA - numberB;
            numberA = numberA - numberB;
        }
        numberAZeroProtection = numberA;
        numberBZeroProtection = numberB;
        if (numberA == 0) numberAZeroProtection = numberA + 2;
        if (numberB == 0) numberBZeroProtection = numberB + 1;
        count = (numberBZeroProtection / 5) - ((numberAZeroProtection - 1) / 5);
        Console.WriteLine();
        Console.WriteLine("The count of numbers that can be divided into 5 with reminder 0");
        Console.WriteLine("between {0} and {1} is {2}", numberA, numberB, count);
    }
}