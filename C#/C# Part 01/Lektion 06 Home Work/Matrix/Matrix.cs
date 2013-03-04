using System;

//Write a program that reads from the console
//a positive integer number N (N < 20) and outputs
//a matrix like the following:
//123
//234
//345

class Matrix
{
    static void Main()
    {
        string userInput = "";
        int numberN = 0;
        while (true)
        {
            Console.Write("\nEnter a number N: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out numberN))
            {
                if ((numberN > 0) && (numberN < 20))
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again...( 0 < N < 20 )");
        }
        for (int i = 1; i <= numberN; i++)
        {
            userInput = " ";
            for (int k = 0; k < numberN; k++)
            {
                userInput = String.Format("{0} {1,2}",userInput, k + i);
            }
            Console.WriteLine(userInput);
        }
    }
}