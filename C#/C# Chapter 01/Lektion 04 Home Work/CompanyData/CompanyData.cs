using System;
using System.Text.RegularExpressions;
//A company has 
//name, address, phone number, fax number, web site and manager.
//The manager has
//first name, last name, age and a phone number.
//Write a program that reads the information about a company and
//its manager and prints them on the console

class CompanyData
{
    static void Main()
    {
        string[,] company = new string[3, 6];
        string[,] manager = new string[3, 4];
        string userInput = "";
        //initializing
        company[0, 0] = "name";
        company[1, 0] = @"^([a-zA-Z ]){3,20}$";
        company[0, 1] = "address";
        company[1, 1] = @"^([a-zA-Z0-9\. ]){3,50}$";
        company[0, 2] = "phone";
        company[1, 2] = @"^(\+359 8|08)([6-9])([0-9]) ([0-9]{3}) ([0-9]{3})$";
        company[0, 3] = "fax";
        company[1, 3] = @"^(\+359 |0)([0-9]{1,5}) ([0-9]{3}) ([0-9]{2}) ([0-9]{2})$";
        company[0, 4] = "web";
        company[1, 4] = @"^(http:\\\\(.+)\.(.+)\.(.+))$";
        company[0, 5] = "manager";
        company[1, 5] = @"^([a-zA-Z ]){6,40}$";
        manager[0, 0] = "first name";
        manager[1, 0] = @"^([a-zA-Z]){3,20}$";
        manager[0, 1] = "last name";
        manager[1, 1] = @"^([a-zA-Z ]){3,20}$";
        manager[0, 2] = "age";
        manager[1, 2] = @"^([0-9]){1,2}$";
        manager[0, 3] = "phone";
        manager[1, 3] = @"^(\+359 8|08)([6-9])([0-9]) ([0-9]{3}) ([0-9]{3})$";
        for (int i = 0; i < company.GetLength(1); i++) company[2, i] = "";
        for (int i = 0; i < manager.GetLength(1); i++) manager[2, i] = "";
        //input valid data for company
        for (int i = 0; i < company.GetLength(1); i++)
        {
            while (true)
            {
                Console.Write("Please, enter a company {0}: ", company[0, i]);
                userInput = Console.ReadLine();
                if (Regex.IsMatch(userInput, company[1, i]))
                {
                    company[2, i] = userInput;
                    break;
                }
                Console.WriteLine("Not valid input! Try again please...");
                Console.WriteLine("Hint: company {0}: ", company[1, i]);
            }
        }
        //input valid data for manager
        Console.WriteLine();
        for (int i = 0; i < manager.GetLength(1); i++)
        {
            while (true)
            {
                Console.Write("Please, enter a manager {0}: ", manager[0, i]);
                userInput = Console.ReadLine();
                if (Regex.IsMatch(userInput, manager[1, i]))
                {
                    manager[2, i] = userInput;
                    break;
                }
                Console.WriteLine("Not valid input! Try again please...");
                Console.WriteLine("Hint: manager {0}: ", manager[1, i]);
            }
        }
        //Print data of company and manager
        Console.WriteLine();
        for (int i = 0; i < company.GetLength(1); i++)
        {
            Console.WriteLine("Company {0}: {1}",company[0,i],company[2,i]);
        }
        Console.WriteLine();
        for (int i = 0; i < manager.GetLength(1); i++)
        {
            Console.WriteLine("Manager {0}: {1}", manager[0, i], manager[2, i]);
        }
    }
}