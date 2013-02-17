using System;
//Write an expression that calculates rectangle’s area by given width and height
class RectanglesArea
{
    static void Main()
    {
        string userInput = "";
        float height = 0.0f;
        float width = 0.0f;
        float areaRectangle = 0.0f;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a height of rectangle: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (float.TryParse(userInput, out height)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a width of rectangle: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (float.TryParse(userInput, out width)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        areaRectangle = height * width;
        Console.WriteLine("Rectangle with height={0} and width={1} have area={2}", height, width, areaRectangle);
    }
}