using System;
//Write an expression that checks if given positive integer number n
//(n ≤ 100) is prime. E.g. 37 is prime

//hint
//Числата нула и едно не са нито прости, нито съставни
//http://bg.wikipedia.org/wiki/%D0%9F%D1%80%D0%BE%D1%81%D1%82%D0%BE_%D1%87%D0%B8%D1%81%D0%BB%D0%BE
//Числото 1 не е просто число, въпреки че е било считано за такова в миналото.
//http://www.nauka.bg/a/%D0%BF%D1%80%D0%BE%D1%81%D1%82%D0%B8-%D1%87%D0%B8%D1%81%D0%BB%D0%B0
class IsNumberPrime
{
    static void Main()
    {
        string userInput = "";
        ushort number = 0;
        bool isPrime = true;
        while (true)
        {
            Console.WriteLine();
            Console.Write("Please, enter a positive number <= 100: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (ushort.TryParse(userInput, out number))
            {
                if ((number<=100)&&(number>=0)) break;
            }
            Console.WriteLine("Not valid input! Try again please...");
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) isPrime = false;
        }
        if (number < 2) isPrime = false; //look hint
        Console.WriteLine("The number {0} is prime - {1}", number, isPrime);
    }
}