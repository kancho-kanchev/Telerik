using System;
using System.Numerics;

//In the combinatorial mathematics, the Catalan numbers
//are calculated by the following formula:
//Cn=(2n)!/(n+1)!n! gpr n>=0
//Write a program to calculate the Nth Catalan number by given N.

class CatalanNumbers
{
    static void Main()
    {
        BigInteger result = 1;
        BigInteger divisible = 1;
        BigInteger divisor = 1;
        string userInput = "";
        int numberN = 0;
        while (true)
        {
            Console.Write("\nEnter a number N: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out numberN))
            {
                if (numberN >= 0)
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again... ( n >= 0 )");
        }
        //http://en.wikipedia.org/wiki/Catalan_number
        //Cn = (k=2-->n)-->(n+k)/k
        if (numberN > 1)
        {
            for (int k = 2; k <= numberN; k++)
            {
                divisible = divisible * (numberN + k);
                divisor = divisor * k;
            }
        }
        result = divisible / divisor;
        Console.WriteLine("{0}", result);
    }
}