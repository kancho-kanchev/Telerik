using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer

class ExchangeBits
{
    static void Main()
    {
        uint mask = 1U;
        ushort startPosition1 = 3;
        ushort startPosition2 = 24;
        ushort countBits = 3;
        //uint buffer = 0U;
        bool result1 = false;
        bool result2 = false;
        string userInput = "";
        uint number = 0U;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a positive number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (uint.TryParse(userInput, out number))
            {
                if (number >= 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        //buffer = number;
        for (int i = startPosition1; i < startPosition1+countBits; i++)
        {
            mask = 1U << i;
            result1 = (number & mask) != 0;
            mask = 1U << i + startPosition2 - startPosition1;
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
                mask = 1U << i + startPosition2 - startPosition1;
                number = number | mask;
            }
            else
            {
                mask = ~(1U << i + startPosition2 - startPosition1);
                number = number & mask;
            }
        }
        Console.WriteLine(number);
        //Console.WriteLine(Convert.ToString(buffer, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}