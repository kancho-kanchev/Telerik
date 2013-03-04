using System;
//Write a program that finds the biggest of three integers using nested if statements

class GreaterOfThree
{
    static void Main()
    {
        string userInput = "";
        int firstNumber = 0;
        int secondNumber = 0;
        int thirdNumber = 0;
        while (true)
        {
            Console.Write("\nPlease, enter a first number: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out firstNumber))
            {
                break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        while (true)
        {
            Console.Write("\nPlease, enter a second number: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out secondNumber))
            {
                break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        while (true)
        {
            Console.Write("\nPlease, enter a third number: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out thirdNumber))
            {
                break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        Console.WriteLine();
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("The first number is greater: {0}", firstNumber);
            }
            else
            {
                Console.WriteLine("The third number is greater: {0}", thirdNumber);
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The second number is greater: {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("The third number is greater: {0}", thirdNumber);
            }
        }
        Console.WriteLine();
    }
}