using System;
//Write program that asks for a digit and depending on the input shows
//the name of that digit (in English) using a switch statement
class DigitInEnglish
{
    enum Digits
    {
        zero,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
    }
    static void Main()
    {
        Digits digitInEnglish = Digits.zero;
        string userInput = "";
        byte digit = 0;
        while (true)
        {
            Console.Write("\nEnter a number in the range [0..9]: ");
            userInput = Console.ReadLine();
            if (byte.TryParse(userInput, out digit))
            {
                if ((digitInEnglish >= 0) && (digit <= 9)) break;
            }
            Console.WriteLine("Invalid input! Please try again...");
        }
        switch (digit)
        {
            case 0:
                digitInEnglish = Digits.zero;
                break;
            case 1:
                digitInEnglish = Digits.one;
                break;
            case 2:
                digitInEnglish = Digits.two;
                break;
            case 3:
                digitInEnglish = Digits.three;
                break;
            case 4:
                digitInEnglish = Digits.four;
                break;
            case 5:
                digitInEnglish = Digits.five;
                break;
            case 6:
                digitInEnglish = Digits.six;
                break;
            case 7:
                digitInEnglish = Digits.seven;
                break;
            case 8:
                digitInEnglish = Digits.eight;
                break;
            case 9:
                digitInEnglish = Digits.nine;
                break;
            default:
                Console.WriteLine("Error!!! digit is ot of range");
                break;
        }
        Console.WriteLine(digitInEnglish);
    }
}