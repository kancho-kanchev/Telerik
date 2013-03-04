using System;
//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0

class CheckThirtBit
{
    static void Main()
    {
        string userInput = "";
        int number = 0;
        int position = 3;
        int mask = 1;
        //int numberAndMask = 0;
        //int bitTri = 0;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out number)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        mask = 1 << position;
        if ((number & mask)==0) Console.WriteLine("The thirt bit is: 0");
        else Console.WriteLine("The thirt bit is: 1");
        //numberAndMask = number & mask;
        //bitTri = numberAndMask >> position;
        //Console.WriteLine("The thirt bit is: {0}", bitTri);
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(bitTri, 2).PadLeft(32, '0'));
    }
}