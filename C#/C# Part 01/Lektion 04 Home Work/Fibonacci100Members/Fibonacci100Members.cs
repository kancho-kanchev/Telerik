using System;
using System.Numerics;
//Write a program to print the first 100 members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class Fibonacci100Members
{
    static void Main()
    {
        BigInteger buffer1 = 0;
        BigInteger buffer2 = 1;
        Console.WriteLine("{0,3} {1,6}", "1", buffer1);
        Console.WriteLine("{0,3} {1,6}", "2", buffer2);
        for (int i = 3; i <= 100; i++)
        {
            Console.WriteLine("{0,3} {1,6}",i,buffer1+buffer2);
            buffer2 = buffer1 + buffer2;
            buffer1 = buffer2 - buffer1;
        }
    }
}