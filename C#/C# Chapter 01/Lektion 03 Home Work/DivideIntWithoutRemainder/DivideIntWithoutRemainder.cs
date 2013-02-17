using System;
//Write a boolean expression that checks for given integer
//if it can be divided (without remainder) by 7 and 5 in the same time
class DivideIntWithoutRemainder
{
    static void Main()
    {
        string userInput = "";
        int integer = 0;
        float divider1 = 7.0f;
        float divider2 = 5.0f;
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please, enter integer number");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse (userInput, out integer))
            {
                if ((( integer % divider1 ) == 0 ) && (( integer % divider2 ) == 0 ))
                {
                    Console.WriteLine("This number is divided without remainder by 7 and 5 in the same time.");
                }
                else
                {
                    Console.WriteLine("This number is NOT divided without remainder by 7 and 5 in the same time.");
                }
                break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        
    }
}