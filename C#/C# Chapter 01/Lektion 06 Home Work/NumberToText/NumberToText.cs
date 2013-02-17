using System;

//* Write a program that converts a number in the range [0...999]
//to a text corresponding to its English pronunciation. Examples:
//  0  "Zero"
//  273  "Two hundred seventy three"
//  400  "Four hundred"
//  501  "Five hundred and one"
//  711  "Seven hundred and eleven"
class NumberToText
{
    static string[,] exceptionsNumber = {
                        { "0", "Zero"},
                        { "1", "One"},
                        { "2", "Two"},
                        { "3", "Three"},
                        { "4", "Four"},
                        { "5", "Five"},
                        { "6", "Six"},
                        { "7", "Seven"},
                        { "8", "Eight"},
                        { "9", "Nine"},
                        { "10", "Ten"},
                        { "11", "Eleven"},
                        { "12", "Twelve"},
                        { "13", "Thirteen"},
                        { "15", "Fifteen"},
                        { "18", "Eighteen"},
                        { "20", "Twenty"},
                        { "30", "Thirty"},
                        { "40", "Forty"},
                        { "50", "Fifty"},
                        { "60", "Sixty"},
                        { "70", "Seventy"},
                        { "80", "Eighty"},
                        { "90", "Ninety"}
                        //{ "100", "hundred"}
                        //{ "1000", "One thousand"}
                                        };

    private static string IsException(int exceptNumber)
    {
        string exceptionInText = "";
        for (int i = 0; i < exceptionsNumber.Length / 2; i++)
        {
            if (exceptionsNumber[i, 0] == Convert.ToString(exceptNumber))
            {
                exceptionInText = exceptionsNumber[i, 1];
            }
        }
        return exceptionInText;
    }

    private static string GetNumberInTextForTwoDigit(int getNumber)
    {
        string digitInText = "";
        int digitOne = 0;
        int digitTwo = 0;
        if ((getNumber >= 10) && (getNumber <= 19))
        {
            digitInText = IsException(getNumber);
            if (digitInText == "")
            {
                digitOne = getNumber % 10;
                digitInText = IsException(digitOne);
                digitInText = String.Format("{0}{1}", digitInText, "teen");
            }
        }
        else if ((getNumber >= 20) && (getNumber <= 99))
        {
            digitInText = IsException(getNumber);
            if (digitInText == "")
            {
                digitOne = getNumber % 10;
                digitTwo = (getNumber / 10) * 10;
                digitInText = IsException(digitOne);
                digitInText = digitInText.ToLower();
                digitInText = String.Format("{0} {1}", IsException(digitTwo), digitInText);
            }
        }
        return digitInText;
    }

    static void Main()
    {
        int number = 0;
        string numberInText = "";
        int digitOne = 0;
        int digitTwo = 0;
        int digitThree = 0;
        while (true)
        {
            Console.Write("\nEnter a number between 0 and 999 (including): ");
            numberInText = Console.ReadLine();
            if (int.TryParse(numberInText, out number))
            {
                if ((number >= 0) && (number <= 999))
                {
                    break;
                }
            }
            Console.WriteLine("Invalid input! Please try again...");
        }
        /****************************************************************************************************************************/
        //for (int test = 0; test < 1000; test++)
        //{//test
        //    number = test;
        /****************************************************************************************************************************/
        numberInText = "";
        if ((number >= 100) && (number <= 999))
        {
            numberInText = IsException(number);

            if (numberInText == "")
            {
                digitOne = number % 10;
                digitTwo = ((number % 100) / 10) * 10;
                digitThree = number / 100;
                numberInText = IsException(digitThree);
                numberInText = String.Format("{0} hundred", numberInText);
                if ((number % 100) != 0)
                {
                    numberInText = numberInText + " and ";
                    if (((number % 100) >= 0) && ((number % 100) <= 9))
                    {
                        numberInText = String.Format("{0}{1}", numberInText, IsException(number % 100).ToLower());
                    }
                    else
                    {
                        numberInText = String.Format("{0}{1}", numberInText, GetNumberInTextForTwoDigit((number % 100)).ToLower());
                    }
                }
            }
        }
        // end test digit 3 (100..999)
        else if ((number >= 10) && (number <= 99))
        {
            numberInText = GetNumberInTextForTwoDigit(number);
        }
        // end test digit 2 (10..99)
        else if ((number >= 0) && (number <= 9))
        {
            numberInText = IsException(number);
        }
        // end test digit 1 (0..9)
        Console.WriteLine(numberInText);
        /****************************************************************************************************************************/
        //}
        /****************************************************************************************************************************/
    }
}