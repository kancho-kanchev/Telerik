using System;
using System.Numerics;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K)

class CalculatesFactorials
{
    static void Main()
    {
        string userInput = "";
        int numberN = 1;
        int numberK = 1;
        BigInteger result = 1;
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
            Console.WriteLine("Invalid input! Please try again... ( 1 < N < K )");
        }
        while (true)
        {
            Console.Write("\nEnter a number K: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out numberK))
            {
                if (numberK > numberN)
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again... ( 1 < N < K )");
        }
        for (int i = 1; i <= numberN; i++)
        {
            result = result * i;
        }
        Console.WriteLine(result);
        for (int i = (numberK - numberN + 1); i <= numberK; i++)
        {
            result = result * i;
        }
        Console.WriteLine("{0}", result);
    }
}