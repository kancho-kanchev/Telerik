using System;
//Write a program that reads 3 integer numbers from the console and prints their sum

class SumTriInteger
{
    static void Main()
    {
        string userInput = "";
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number 1: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out number1)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number 2: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out number2)) break;
            Console.WriteLine("Not valid input! Try again please...");
        } while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number 3: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out number3)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        Console.WriteLine("Sum: {0}", number1 + number2 + number3);
    }
}