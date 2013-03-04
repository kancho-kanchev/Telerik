using System;
//Declare two integer variables and assign them
//with 5 and 10 and after that exchange their values.
class ExchangeTwoInt
{
    static void Main()
    {
        int firstInt = 5;
        int secondInt = 10;
        Console.WriteLine("firstInt {0,2} secondInt {1,2}", firstInt, secondInt);
        firstInt = firstInt + secondInt;
        secondInt = firstInt - secondInt;
        firstInt = firstInt - secondInt;
        Console.WriteLine("firstInt {0,2} secondInt {1,2}", firstInt, secondInt);
    }
}