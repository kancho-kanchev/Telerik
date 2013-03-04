using System;
//We are given 5 integer numbers.
//Write a program that checks
//if the sum of some subset of them is 0.

//Example: 3, -2, 1, 1, 8  1+1-2=0

class SumOfSomeSubsetIsZero
{
    static int length = 0;

    enum Numbers
    {
        first,
        second,
        third,
        fourth,
        fifth,
    }

    private static int[] DeleteTheZeros(int[] arrayNumber)
    {
        int[] arrayBuffer = { 0, 0, 0, 0, 0 };
        for (int i = 0; i < arrayNumber.Length; i++)
        {
            if (arrayNumber[i] != 0)
            {
                arrayBuffer[length] = arrayNumber[i];
                length++;
            }
        }
        return arrayBuffer;
    }

    static void Main()
    {
        string userInput = "";
        string sumString = "";
        int sum = 0;
        int[] number = { 0, 0, 0, 0, 0 };
        int mask = Convert.ToInt32(Math.Pow(2, 0));
        Numbers numberOfEnglish = Numbers.first;
        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                Console.Write("\nEnter a {0} number: ", numberOfEnglish);
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out number[i]))
                {
                    break;
                }
                Console.WriteLine("Invalid input! Please try again...");
            }
            numberOfEnglish++;
        }
        number = DeleteTheZeros(number);
        if (length > 0)
        {
            for (int i = 1; i <= (Math.Pow(2, length) - 1); i++)
            {
                for (int j = 0; j < length; j++)
                {
                    mask = 1 << j;

                    if ((i & mask) != 0)
                    {
                        sum = sum + number[j];
                        if (number[j] < 0)
                        {
                            if (sumString == "")
                            {
                                sumString = String.Format("({0})", Convert.ToString(number[j]));
                            }
                            else
                            {
                                sumString = String.Format("{0}{1}", sumString, Convert.ToString(number[j]));
                            }
                        }
                        else
                        {
                            if (sumString == "")
                            {
                                sumString = String.Format("{0}", Convert.ToString(number[j]));
                            }
                            else
                            {
                                sumString = String.Format("{0}+{1}", sumString, Convert.ToString(number[j]));
                            }
                        }
                    }
                }
                if (sum == 0)
                {
                    Console.WriteLine("0={0}", sumString);
                }
                sum = 0;
                sumString = "";
            }
        }
    }
}