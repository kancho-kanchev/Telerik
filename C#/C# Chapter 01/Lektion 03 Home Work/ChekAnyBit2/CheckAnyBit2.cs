using System;
//Write an expression that extracts from a given
//integer i the value of a given bit number b. Example: i=5; b=2  value=1

class CheckAnyBit2
{
    static void Main()
    {
        string userInput = "";
        int numberI = 0;
        int position = 0;
        int mask = 1;
        //int numberAndMask = 0;
        //int bitForCheck = 0;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out numberI)) break;
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
        if ((numberI & mask) == 0) Console.WriteLine("The {0} bit is: 0", position);
        else Console.WriteLine("The {0} bit is: 1", position);
        //numberAndMask = numberI & mask;
        //bitForCheck = numberAndMask >> position;
        //Console.WriteLine("The {1} bit is: {0}", bitForCheck, position);
        //Console.WriteLine(Convert.ToString(numberI, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(bitForCheck, 2).PadLeft(32, '0'));
    }
}