using System;
using System.Numerics;

//Write a program that, for a given two integer numbers N and X,
//calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/X^N

class CalculatesFactorials2
{
    static void Main()
    {
        BigInteger result = 1;
        BigInteger factorial = 1;
        BigInteger power = 1;
        string userInput = "";
        int numberN = 0;
        int numberX = 0;
        while (true)
        {
            Console.Write("\nEnter a number N: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out numberN))
            {
                if (numberN > 0)
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again...( N > 0 )");
        }
        while (true)
        {
            Console.Write("\nEnter a number X: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out numberX))
            {
                if (numberX != 0)
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again...( X <> 0 )");
        }
        for (int i = 1; i <= numberN; i++)
        {
            factorial = factorial * i;
            power = power * numberX;
            result = result + (factorial / power);
            //Console.WriteLine(factorial);
            //Console.WriteLine(power);
        }
        Console.WriteLine("{0}", result);
    }
}