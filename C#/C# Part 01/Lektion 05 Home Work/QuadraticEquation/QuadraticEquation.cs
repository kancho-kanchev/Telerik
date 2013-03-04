using System;
//Write a program that enters the coefficients a, b and c
//of a quadratic equation
//		a*x2 + b*x + c = 0
//		and calculates and prints its real roots.
//Note that quadratic equations may have 0, 1 or 2 real roots.

// ax*x + b*x + c=0
// a b c -> real
// a != 0
// solution -> 0, 1 or 2 real root
// x= (-b +/- sqrt(b*b - 4ac)) / 2a

class QuadraticEquation
{
    static void Main()
    {
        string userInput = "";
        double coeffA = 0.0D;
        double coeffB = 0.0D;
        double coeffC = 0.0D;
        double discrD = 0.0D;
        double? result1 = null;
        double? result2 = null;
        while (true)
        {
            Console.Write("Enter a coefficient A: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (double.TryParse(userInput, out coeffA))
            {
                if (coeffA != 0) break;
            }
            Console.WriteLine("Invalid input! Please try again... (A != 0)");
        }
        while (true)
        {
            Console.Write("Enter a coefficient B: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (double.TryParse(userInput, out coeffB))
            {
                break;
            }
            Console.WriteLine("Invalid input! Please try again...");
        }
        while (true)
        {
            Console.Write("Enter a coefficient C: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (double.TryParse(userInput, out coeffC))
            {
                break;
            }
            Console.WriteLine("Invalid input! Please try again...");
        }
        discrD = (coeffB * coeffB) - (4 * coeffA * coeffC);
        if (discrD >= 0)
        {
            if (discrD == 0)
            {
                result1 = (coeffB / (2 * coeffA)) * (-1);
            }
            else
            {
                result1 = (((-1) * coeffB) + Math.Sqrt(discrD)) / (2 * coeffA);
                result2 = (((-1) * coeffB) - Math.Sqrt(discrD)) / (2 * coeffA);
            }
            Console.WriteLine("Real root's are: {0,1:F2} {1,1:F2}", result1, result2);
        }
        else
        {
            Console.WriteLine("No real root's");
        }
    }
}