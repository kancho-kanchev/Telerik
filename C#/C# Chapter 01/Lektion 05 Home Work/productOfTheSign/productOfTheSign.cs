using System;
//Write a program that shows the sign (+ or -) of the product of
//three real numbers without calculating it. Use a sequence of if statements

class productOfTheSign
{
    static void Main()
    {
        bool boolFirst = false; //for if check
        bool boolSecond = false;//for if check
        bool boolThird = false; //for if check
        bool boolFirstTest = false; //for bit check
        bool boolSecondTest = false;//for bit check
        bool boolThirdTest = false; //for bit check
        double mask = 1;
        byte position = 63;
        string userInput = "";
        double realFirst = 0.0D;
        double realSecond = 0.0D;
        double realThird = 0.0D;
        while (true)
        {
            Console.Write("\nPlease, enter a first real number: ");
            userInput = Console.ReadLine();
            if (double.TryParse(userInput, out realFirst))
            {
                break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        while (true)
        {
            Console.Write("\nPlease, enter a second real number: ");
            userInput = Console.ReadLine();
            if (double.TryParse(userInput, out realSecond))
            {
                break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        while (true)
        {
            Console.Write("\nPlease, enter a third real number: ");
            userInput = Console.ReadLine();
            if (double.TryParse(userInput, out realThird))
            {
                break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        // if check for sign
        if (realFirst > 0)
        {
            boolFirst = true;
        }
        else
        {
            boolFirst = false;
        }
        if (realSecond > 0)
        {
            boolSecond = true;
        }
        else
        {
            boolSecond = false;
        }
        if (realThird > 0)
        {
            boolThird = true;
        }
        else
        {
            boolThird = false;
        }
        //bit check for sign
        mask = 1 << position;
        boolFirstTest = ((int)realFirst & (int)mask) == 0;
        boolSecondTest = ((int)realSecond & (int)mask) == 0;
        boolThirdTest = ((int)realThird & (int)mask) == 0;
        //if product of signs
        if (!(!(boolFirst ^ boolSecond) ^ boolThird)) //false = '-'
        {
            Console.WriteLine("\nIf check:  '+'");
        }
        else
        {
            Console.WriteLine("\nIf check:  '-'");
        }
        //bit product of signs
        if (!(!(boolFirstTest ^ boolSecondTest) ^ boolThirdTest))
        {
            Console.WriteLine("\nBit check: '+'");
        }
        else
        {
            Console.WriteLine("\nBit check: '-'");
        }
    }
}