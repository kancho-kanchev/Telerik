using System;
//Write a program that exchanges bits {p, p+1, …, p+k-1)
//with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer

class ExchangeBits2
{
    static void Main()
    {
        uint number = 0U;
        ushort startPositionP = 0;
        ushort startPositionQ = 0;
        ushort countBits = 0;
        uint buffer = 0U;
        uint mask = 1U;
        bool result1 = false;
        bool result2 = false;
        string userInput = "";
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a positive number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (uint.TryParse(userInput, out number))
            {
                if ((number >= 0)&&(number<=4294967295U)) break;
            }
            Console.WriteLine("Not valid input! Try again please... ( 0 <= number <= 4 294 967 295 )");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a start position P: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (ushort.TryParse(userInput, out startPositionP))
            {
                if ((startPositionP >= 0) && (startPositionP < 31)) break;
            }
            Console.WriteLine("Not valid input! Try again please... ( 0 >= P < 31 )");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a start position Q: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (ushort.TryParse(userInput, out startPositionQ))
            {
                if ((startPositionQ > startPositionP) && (startPositionQ <= 31)) break;
            }
            Console.WriteLine("Not valid input! Try again please... ( P < Q <=31 )");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a count bit for change: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (ushort.TryParse(userInput, out countBits))
            {
                if ((countBits + startPositionQ <= 31) && (countBits >= 0)) break;
            }
            Console.WriteLine("Not valid input! Try again please... ( K >= 0 and K+Q <= 31 )");
        }
        buffer = number;
        for (int i = startPositionP; i < startPositionP + countBits; i++)
        {
            mask = 1U << i;
            result1 = (number & mask) != 0;
            mask = 1U << i + startPositionQ - startPositionP;
            result2 = (number & mask) != 0;
            if (result2)
            {
                mask = 1U << i;
                number = number | mask;
            }
            else
            {
                mask = ~(1U << i);
                number = number & mask;
            }
            if (result1)
            {
                mask = 1U << i + startPositionQ - startPositionP;
                number = number | mask;
            }
            else
            {
                mask = ~(1U << i + startPositionQ - startPositionP);
                number = number & mask;
            }
        }
        Console.WriteLine(number);
        Console.WriteLine(Convert.ToString(buffer, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}