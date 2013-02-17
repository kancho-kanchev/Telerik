using System;
//Write an expression that checks for given point (x, y)
//if it is within the circle K( (1,1), 3) and out of
//the rectangle R(top=1, left=-1, width=6, height=2).

class DotCircleRectangle
{
    static void Main()
    {
        short circleX = 1;
        short circleY = 1;
        short circleRadius = 3;
        short rectTop = 1;
        short rectLeft = -1;
        short rectWidth = 6;
        short rectHeight = 2;
        string userInput = "";
        float pointX = 0.0f;
        float pointY = 0.0f;
        float expression1 = 0.0f;
        bool isInCircle = false;
        bool isOutRectangle = false;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a point X: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (float.TryParse(userInput, out pointX)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a point Y: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (float.TryParse(userInput, out pointY)) break;
            Console.WriteLine("Not valid input! Try again please...");
        }
        expression1 = ((pointX-circleX) * (pointX-circleX)) + ((pointY-circleY) * (pointY-circleY));
        isInCircle = expression1 <= circleRadius * circleRadius;
        isOutRectangle = !((pointX > rectLeft) && (pointX < rectLeft + rectWidth)) || ((pointY > rectTop) && (pointY < rectTop - rectHeight));
        if (isInCircle && isOutRectangle)
        {
            Console.WriteLine("The point is within circle and out of rectangle");
        }
        else
        {
            Console.WriteLine("The point is NOT within circle and out of rectangle");
        }
    }
}