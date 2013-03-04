using System;
using System.Numerics;

//Write a program that calculates for given N
//how many trailing zeros present at the end
//of the number N!. Examples:
//N = 10  N! = 3628800  2
//N = 20  N! = 2432902008176640000  4
//Does your program work for N = 50 000?
//Hint: The trailing zeros in N! are equal to
//the number of its prime divisors of value 5. Think why!

class ZerosAtTheEndOfTheNFactorial
{
    static void Main()
    {
        BigInteger factorial = 1;
        int result = 0;
        string userInput = "";
        int numberN = 0;
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
        for (int divisor = 5; divisor <= numberN; divisor = divisor * 5)
        {
            result = result + (numberN / divisor);
        }
        Console.WriteLine("{0}", result);
        // test
        for (int i = 1; i <= numberN; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("{0}", factorial);
    }
}