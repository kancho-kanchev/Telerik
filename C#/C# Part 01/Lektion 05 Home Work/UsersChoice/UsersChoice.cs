using System;
//Write a program that, depending on the user's choice inputs
//int, double or string variable.
//If the variable is integer or double, increases it with 1.
//If the variable is string, appends "*" at its end.
//The program must show the value of that variable as a console output.
//Use switch statement

class UsersChoice
{
    static void Main()
    {
        string userInput = "";
        int number = 0;
        double real = 0.0D;
        byte choice = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Integer");
            Console.WriteLine("2. Real");
            Console.WriteLine("3. String");
            Console.Write("\nPlease, enter your choice: ");
            userInput = Console.ReadLine();
            if (byte.TryParse(userInput, out choice))
            {
                if ((choice >= 1) && (choice <= 3)) break;
            }
        }
        switch (choice)
        {
            case 1:
                {
                    while (true)
                    {
                        Console.Write("\nEnter a integer number: ");
                        userInput = Console.ReadLine();
                        if (int.TryParse(userInput, out number))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input! Please try again...");
                    }
                    number = number - 1;
                    Console.WriteLine("\n{0}\n", number);
                    break;
                }
            case 2:
                {
                    while (true)
                    {
                        Console.Write("\nEnter a real number: ");
                        userInput = Console.ReadLine();
                        if (double.TryParse(userInput, out real))
                        {
                            break;
                        }
                        Console.WriteLine("Invalid input! Please try again...");
                    }
                    real = real - 1;
                    Console.WriteLine("\n{0,1:F2}\n", real);
                    break;
                }
            case 3:
                {
                    Console.Write("\nEnter a string: ");
                    userInput = Console.ReadLine();
                    userInput = userInput + "*";
                    Console.WriteLine("\n{0}\n",userInput);
                    break;
                }
            default:
                Console.WriteLine("Error!!! digit is out of range");
                break;
        }
    }
}