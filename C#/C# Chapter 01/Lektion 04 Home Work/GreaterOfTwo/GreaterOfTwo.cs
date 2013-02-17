using System;
//Write a program that gets two numbers from the console and
//prints the greater of them. Don’t use if statements

class GreaterOfTwo
{
    static void Main()
    {
        string userInput = "";
        double numberA = 0.0D;
        double numberB = 0.0D;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (double.TryParse(userInput, out numberA)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (double.TryParse(userInput, out numberB)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        Console.WriteLine();
        Console.WriteLine("Greater is: {0}", Math.Max(numberA, numberB));
    }
}