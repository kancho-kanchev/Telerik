using System;
using System.Numerics;

//Write a program that reads a number N and calculates the sum of the first N members
//of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class FibonacciSum
{
    static void Main()
    {
        string userInput = "";
        BigInteger sum = 1L;
        BigInteger aprior = 0L;
        BigInteger prior = 1L;
        BigInteger current = 1L;
        int numberN = 0;
        while (true)
        {
            Console.Write("\nEnter a number N: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out numberN))
            {
                if (numberN > 1)
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again...( N > 1 )");
        }
        for (int i = 2; i < numberN; i++)
        {
            current = aprior + prior;
            sum = sum + current;
            aprior = prior;
            prior = current;
        }
        Console.WriteLine("Sum(N!)    = {0}",sum);
        aprior = 0;
        prior = 1;
        for (int i = 2; i < numberN + 1; i++)
        {
            prior = aprior + prior;
            aprior = prior - aprior;
        }
        Console.WriteLine("(N+2)! - 1 = {0}", aprior + prior-1);
    }
}