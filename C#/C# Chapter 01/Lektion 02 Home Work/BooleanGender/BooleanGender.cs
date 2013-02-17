using System;
//Declare a boolean variable called isFemale and
//assign an appropriate value corresponding to your gender.
class BooleanGender
{
    static void Main()
    {
        string answer = "";
        bool isFemale = false;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Are you a Man? (Y/N):");
            answer = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (!((answer.Equals("y")) || (answer.Equals("n")))) Console.WriteLine("Not valid input! Try again please...");
        } while (!((answer.Equals("y")) || (answer.Equals("n"))));
        if (answer.Equals("y")) isFemale = false;
        else isFemale = true;
        Console.WriteLine("You are a Female - {0}", isFemale);
    }
}