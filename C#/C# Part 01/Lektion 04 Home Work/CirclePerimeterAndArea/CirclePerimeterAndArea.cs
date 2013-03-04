using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area

class CirclePerimeterAndArea
{
    static void Main()
    {
        string userInput = "";
        double radius = 0D;
        double pi = Math.PI;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a radius: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (double.TryParse(userInput, out radius))
            {
                if (radius > 0) break;
            }
            Console.WriteLine("Not valid input! Try again please... ( radius >= 0 )");
        }
        Console.WriteLine("Perimeter is: {0,9:F2}", 2 * pi * radius);
        Console.WriteLine("Area is: {0,14:F2}", pi * radius * radius);
    }
}