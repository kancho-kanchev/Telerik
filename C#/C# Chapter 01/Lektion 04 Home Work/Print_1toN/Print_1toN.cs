using System;
//Write a program that reads an integer number n from the console
//and prints all the numbers in the interval [1..n], each on a single line
class Print_1toN
{
    static void Main()
    {
        string userInput = "";
        int numberN = 0;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a number: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out numberN))
            {
                if (numberN >= 0) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        for (int i = 1; i <= numberN; i++)
        {
            Console.WriteLine(i);
        }
    }
}