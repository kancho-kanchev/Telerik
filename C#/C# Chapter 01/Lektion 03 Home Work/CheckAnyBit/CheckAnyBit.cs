using System;
//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1  false

class CheckAnyBit
{
    static void Main()
    {
        string userInput = "";
        int numberV = 0;
        int position = 0;
        int mask = 1;
        bool result = false;
        //int numberAndMask = 0;
        //int bitForCheck = 0;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out numberV)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a position to check: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out position))
            {
                if (position >= 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        mask = 1 << position;
        result = (numberV & mask) != 0;
        Console.WriteLine("The {0} bit is: {1}", position, result);
        //numberAndMask = numberV & mask;
        //bitForCheck = numberAndMask >> position;
        //Console.WriteLine("The {1} bit is: {0}", bitForCheck, position);
        //Console.WriteLine(Convert.ToString(numberV, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(bitForCheck, 2).PadLeft(32, '0'));
    }
}