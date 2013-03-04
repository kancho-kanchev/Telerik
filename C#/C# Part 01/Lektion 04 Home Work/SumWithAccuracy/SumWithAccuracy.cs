using System;
//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

class SumWithAccuracy
{
    static void Main()
    {
        float currentSum = 1.0F;
        float oldSum = 0.0F;
        int i = 2;
        bool equal = false;
        //currentSum = 1.0F + (1.0F / 2);
        while (true)
        {
            oldSum = currentSum;
            if (i % 2 == 0)
            {
                currentSum = currentSum + (1.0F / i);
            }
            else
            {
                currentSum = currentSum - (1.0F / i);
            }
            equal = (Math.Abs(currentSum - oldSum) < 0.001f);
            if (equal) break;
            i++;
        }
        Console.WriteLine("Loops {1}; Sum with accuracy of 0.001 is: {0,3:F3}", oldSum, i);
        Console.WriteLine("The next sum is: {0,3:F3}", currentSum);
    }
}