using System;
//Sort 3 real values in descending order using nested if statements

class SortThreeReal
{
    static void Main()
    {
        string userInput = "";
        float firstNumber = 0.0F;
        float secondNumber = 0.0F;
        float thirdNumber = 0.0F;
        float vremNumber = 0.0F;
        while (true)
        {
            Console.Write("\nPlease, enter a first number: ");
            userInput = Console.ReadLine();
            if (float.TryParse(userInput, out firstNumber))
            {
                break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        while (true)
        {
            Console.Write("\nPlease, enter a second number: ");
            userInput = Console.ReadLine();
            if (float.TryParse(userInput, out secondNumber))
            {
                break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        while (true)
        {
            Console.Write("\nPlease, enter a third number: ");
            userInput = Console.ReadLine();
            if (float.TryParse(userInput, out thirdNumber))
            {
                if (thirdNumber >= 0) break;
            }
            Console.WriteLine("Not valid input! Please try again...");
        }
        Console.WriteLine();
        if (thirdNumber > secondNumber)
        {
            vremNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = vremNumber;
            //secondNumber = secondNumber + thirdNumber;
            //thirdNumber = secondNumber - thirdNumber;
            //secondNumber = secondNumber - thirdNumber;
        }
        if (secondNumber > firstNumber)
        {
            vremNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = vremNumber;
            //firstNumber = firstNumber + secondNumber;
            //secondNumber = firstNumber - secondNumber;
            //firstNumber = firstNumber - secondNumber;
        }
        if (thirdNumber > secondNumber)
        {
            vremNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = vremNumber;
            //secondNumber = secondNumber + thirdNumber;
            //thirdNumber = secondNumber - thirdNumber;
            //secondNumber = secondNumber - thirdNumber;
        }
        //if (secondNumber > firstNumber)
        //{
        //    if (firstNumber > thirdNumber)
        //    {
        //        //b>a>c
        //    }
        //    else
        //    {
        //        //b>c>a
        //    }
        //}
        //else
        //{
        //    if (thirdNumber > secondNumber)
        //    {
        //        //a>c>b
        //    }
        //    else
        //    {
        //        //a>b>c
        //    }
        //}
        //if (thirdNumber > secondNumber)
        //{
        //    if (secondNumber > firstNumber)
        //    {
        //        //c>b>a
        //    }
        //    else
        //    {
        //        //c>a>b
        //    }
        //}

        if ((firstNumber >= secondNumber) && (secondNumber >= thirdNumber))
        {
            Console.WriteLine("{0,1:F2}>{1,1:F2}>{2,1:F2}", firstNumber, secondNumber, thirdNumber);
        }
        else
        {
            Console.WriteLine("error");
        }
        Console.WriteLine();
    }
}