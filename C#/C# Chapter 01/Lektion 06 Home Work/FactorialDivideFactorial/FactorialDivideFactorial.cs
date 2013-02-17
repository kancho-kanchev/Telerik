using System;
using System.Numerics;

//Write a program that calculates N!/K! for given N and K (1<K<N).

class FactorialDivideFactorial
{
    static void Main()
    {
        string userInput = "";
        int numberN = 1;
        int numberK = 1;
        BigInteger result = 1;
        while (true)
        {
            Console.Write("\nEnter a number K: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out numberK))
            {
                if (numberK > 1)
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again... ( 1 < K < N )");
        }
        while (true)
        {
            Console.Write("\nEnter a number N: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out numberN))
            {
                if (numberN > numberK)
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again... ( 1 < K < N )");
        }
        for (int i = numberK + 1; i <= numberN; i++)
        {
            result = result * i;
        }
        Console.WriteLine("{0}", result);
    }
}