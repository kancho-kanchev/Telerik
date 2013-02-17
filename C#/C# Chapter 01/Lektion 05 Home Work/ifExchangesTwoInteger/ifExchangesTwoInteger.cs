using System;
//Write an if statement that examines two integer variables and exchanges their values
//if the first one is greater than the second one

class ifExchangesTwoInteger
{
    static void Main()
    {
        string userInput = "";
        int firstInt = 0;
        int secondInt = 0;
        int vremInt = 0;
        while (true)
        {
            Console.Write("\nPlease, enter a first number: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out firstInt))
            {
                break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        while (true)
        {
            Console.Write("\nPlease, enter a second number: ");
            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out secondInt))
            {
                break;
            }
            Console.WriteLine("\nNot valid input! Please try again...");
        }
        if (firstInt != secondInt)
        {
            if (firstInt > secondInt)
            {
                vremInt= firstInt;
                firstInt = secondInt;
                secondInt = vremInt;
                //firstInt = firstInt + secondInt;
                //secondInt = firstInt - secondInt;
                //firstInt = firstInt - secondInt;
                Console.WriteLine("\nThe first number was bigger than second number but now is changed");
                Console.WriteLine("\nfirst number = {0}; second number = {1}\n", firstInt, secondInt);
            }
            else
            {
                Console.WriteLine("\nThe first number was smaller than second number and noting was changed\n");
            }
        }
        else
        {
            Console.WriteLine("\nThe first number and second number are equal\n");
        }
    }
}