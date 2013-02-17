using System;
//Write a program that finds the greatest of given 5 variables

class GreatestOfFive
{
    enum Numbers
    {
        first,
        second,
        third,
        fourth,
        fifth,
    }
    static void Main()
    {
        string userInput = "";
        float[] number = { 0.0F, 0.0F, 0.0F, 0.0F, 0.0F };
        float greater = 0.0F;
        Numbers numberOfEnglish = Numbers.first;
        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write("\nEnter a {0} number: ", numberOfEnglish);
                userInput = Console.ReadLine();
                if (float.TryParse(userInput, out number[i]))
                {
                    break;
                }
                Console.WriteLine("Invalid input! Please try again...");
            }
            numberOfEnglish++;
        }
        greater = number[0];
        for (int i = 0; i < 5; i++)
        {
            if (number[i] > greater)
            {
                greater = number[i];
            }
        }
        Console.WriteLine("\nThe greatest number is: {0,1:F2}\n", greater);
    }
}