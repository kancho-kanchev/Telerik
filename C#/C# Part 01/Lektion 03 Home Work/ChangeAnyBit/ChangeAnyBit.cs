using System;
//We are given integer number n, value v (v=0 or 1) and a position p.
//Write a sequence of operators that modifies n to hold the value v
//at the position p from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//	n = 5 (00000101), p=2, v=0  1 (00000001)

class ChangeAnyBit
{
    static void Main()
    {
        string userInput = "";
        int numberN = 0;
        bool valueV = false;
        ushort positionP = 0;
        int mask = 1;
        int result = 0;
        //int numberAndMask = 0;
        //int bitForCheck = 0;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if ( int.TryParse(userInput, out numberN)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter 0 or 1: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (ushort.TryParse(userInput, out positionP))
            {
                if ((positionP >= 0) && (positionP <= 1))
                {
                    valueV = Convert.ToBoolean(positionP);
                    positionP = 0;
                    break;
                }
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a position to change: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (ushort.TryParse(userInput, out positionP))
            {
                if (positionP >= 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        if (valueV)
        {
            mask = 1 << positionP;
            result = numberN | mask;
        }
        else
        {
            mask = ~(1 << positionP);
            result = numberN & mask;
        }
        Console.WriteLine("The result is: {0}", result);
        //Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}