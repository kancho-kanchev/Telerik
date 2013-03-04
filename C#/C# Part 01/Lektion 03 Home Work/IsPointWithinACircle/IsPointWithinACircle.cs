using System;
//Write an expression that checks if given point (x,  y) is within a circle K(O, 5)
class IsPointWithinACircle
{
    static void Main()
    {
        int radius = 5;        
        string userInput = "";
        int numberX = 0;
        int numberY = 0;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number for X: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out numberX)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number for Y: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out numberY)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        if (((numberX * numberX) + (numberY * numberY)) <= radius * radius)
        {
            Console.WriteLine("The point is in circle");
        }
        else Console.WriteLine("The point is out of the circle");
    }
}