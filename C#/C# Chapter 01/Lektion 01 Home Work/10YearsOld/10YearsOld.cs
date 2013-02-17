// * Write a program to read your age from the console and print how old you will be after 10 years

using System;

class _10YearsOld
{
    static void Main()
    {
        string userInput;
        int currYears;
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please, tell us how old you?");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(userInput, out currYears))
            {
                if (currYears > 0)
                {
                    if (currYears < 5)
                    {
                        Console.WriteLine("You're too young for computer!");
                    }
                    if (currYears > 89)
                    {
                        Console.WriteLine("Congratulations for your long life experience!");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Now is " + DateTime.Today.Year + " year. You are " + currYears + " years old...");
                    Console.WriteLine("But after 10 years, in " + (DateTime.Today.Year + 10) + " you'l be in " + (currYears + 10) + " years old!");
                    Console.WriteLine();
                    break;
                }
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
    }
}