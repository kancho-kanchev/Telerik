using System;

//Write a program that reads from the console a
//sequence of N integer numbers and returns
//the minimal and maximal of them.

class MinAndMaxOfSequence
{
    static void Main()
    {
        string userInput = "";
        int numberN = 0;
        int min = 0;
        int max = 0;
        int current;
        while (true)
        {
            Console.Write("\nEnter a number: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out numberN))
            {
                break;
            }
            Console.WriteLine("Invalid input! Please try again...");
        }
        for (int i = 0; i < numberN; i++)
        {
            while (true)
            {
                Console.Write("\nEnter a number {0} of {1}: ", i + 1, numberN);
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out current))
                {
                    break;
                }
                Console.WriteLine("Invalid input! Please try again...");
            }
            if (i == 0)
            {
                max = current;
                min = current;
            }
            if (current > max)
            {
                max = current;
            }
            if (current < min)
            {
                min = current;
            }
        }
        Console.WriteLine("sequence of {0} numbers have min = {1} and max = {2}", numberN, min, max);
    }
}