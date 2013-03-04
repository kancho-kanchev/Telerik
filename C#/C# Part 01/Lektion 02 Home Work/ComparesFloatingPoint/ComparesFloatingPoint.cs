using System;
//Write a program that safely compares floating-point numbers
//with precision of 0.000001.
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
class ComparesFloatingPoint
{
    static void Main()
    {
        string strFirstFraction = "";
        string strSecondFraction = "";
        decimal firstFraction = 0.0m;
        decimal secondFraction = 0.0m;
        bool equal;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Please, enter the first number?");
            strFirstFraction = Console.ReadLine();
            Console.WriteLine();
            if (!(decimal.TryParse(strFirstFraction, out firstFraction))) Console.WriteLine("Not valid input! Try again please...");
        } while (!(decimal.TryParse(strFirstFraction, out firstFraction)));
        do
        {
            Console.WriteLine();
            Console.WriteLine("Please, enter the second number?");
            strSecondFraction = Console.ReadLine();
            Console.WriteLine();
            if (!(decimal.TryParse(strSecondFraction, out secondFraction))) Console.WriteLine("Not valid input! Try again please...");
        } while (!(decimal.TryParse(strSecondFraction, out secondFraction)));
        equal = (Math.Abs(firstFraction - secondFraction) < 0.000001m);
        if (equal) Console.WriteLine("true");
        else Console.WriteLine("false");
    }
}