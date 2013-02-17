using System;
//Write a program that gets a number n and after that gets
//more n numbers and calculates and prints their sum

class SumNNumbers
{
    static void Main()
    {
        string userInput = "";
        uint numberN = 0U;
        double sumN = 0.0D;
        double currentNumber = 0.0D;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (uint.TryParse(userInput, out numberN))
            {
                if (numberN >= 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        for (int i = 0; i < numberN; i++)
        {
            while (true)
            {
                Console.Write("Please, enter a real number: ");
                userInput = Console.ReadLine();
                if (double.TryParse(userInput, out currentNumber))
                {
                    sumN = sumN + currentNumber;
                    break;
                }
                Console.WriteLine("Not valid input! Try again please...");
            }
        }
        Console.WriteLine("The sum is: {0,1:F2}", sumN);
        //code
    }
}