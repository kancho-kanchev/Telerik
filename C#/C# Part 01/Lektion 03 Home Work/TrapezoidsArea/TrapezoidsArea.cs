using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h
class TrapezoidsArea
{
    static void Main()
    {
        string userInput = "";
        int sideA = 0;
        int sideB = 0;
        int height = 0;
        float area = 0.0f;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number for side A: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out sideA))
            {
                if (sideA > 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number for side B: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out sideB))
            {
                if (sideB > 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number for height: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out height))
            {
                if (height > 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        area = ((sideA + sideB) / 2.0f) * height;
        Console.WriteLine("Trapezoid's area is: {0:0.00}", area);
    }
}